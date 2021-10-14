
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChanForm {
  enum cfo_parse_state_type {
    spstInit,
    spstHdr,
    spstData,
    spstProc,
    spstErr
  }

  enum cfo_state_type {
    sstInit,
    sstHdr,
    sstFooter,
    sstData,
    sstDataOk,
    sstErr,
    sstErrNoHeader,
    sstErrNoFooter,
    sstErrBufferEmpty,
    sstErrNoValidPackets,
    sstErrDataInvalid
  }


  //=============================================================================================
  public partial class frmChannelForm :Form {
    const int DEF_Q_LEN = 10;
    cfo_state_type cfoState = cfo_state_type.sstInit;
    TreeNode cfoNode;
    TreeView cfoTreeView;
    Series cfoSeries;
    List<decimal> cfoDataRaw;

    public String cfoBuffer =  "";

    String cfoName;
    String cfoFormName;
    String cfoDLE; 
    String cfoHeader;
    String cfoFooter;
    String cfoValStr;
    String cfoMinStr;
    String cfoMaxStr;
    String cfoAvgStr;

    Decimal cfoValueRaw;
    Decimal cfoValueRawShadow;
    Decimal cfoMin;
    Decimal cfoMax;
    Decimal cfoAvg;
    Decimal cfoAvgShadow;
    Decimal cfoValDecimal;
    Decimal cfoDDT; //--- d/dt of cfoValDecimal
    int cfoT;  //---time, in millisecs that we have data for----



    int cfoDataCount;

    private int cfoTickerIdx;
    
    private bool cfoEnable;

    private Queue<Decimal> cfoAvgQ;
    private int cfoAvgQCapacity;


    private readonly Bitmap bmpDisabled =  MDIForm_1.Properties.Resources.Pause_grey_16x;
    private readonly Bitmap bmpEnabled= MDIForm_1.Properties.Resources.Run_16x;

    //=============================================================================================
    public frmChannelForm(string nName, string nDLE, TreeView nTV, Series nSeries) {
      cfoName = "";
      cfoDLE =  "T";
      cfoHeader =  "";
      cfoFooter =  "";
      cfoValStr =  "";
      cfoMinStr =  "";
      cfoMaxStr =  "";
      cfoAvgStr =  "";

      cfoValueRaw = 0;
      cfoValueRawShadow = 0;
      cfoMin = 65535;
      cfoMax = 0;
      cfoValDecimal = 0;

      cfoDataCount = 0;

      cfoEnable = false;

      cfoDLE = nDLE;
      cfoName = nName;
      cfoTreeView = nTV;
      cfoNode = nTV.Nodes.Add(nName);
      cfoFormName = cfoName + " - " + cfoDLE;
      cfoSeries = nSeries;

      cfoAvg = 0;
      cfoAvgShadow = 0;
      cfoAvgQ = new Queue<decimal>();
      cfoAvgQCapacity = DEF_Q_LEN;

      cfoTickerIdx = 0;

      InitializeComponent();
      frmGenHeaderFooter();
      this.Text = cfoFormName;
    }

    //=============================================================================================
    public void frmEnable(bool en) {
      cfoEnable = en;
      tsbtClearMeta.Enabled = cfoEnable;
      tsbtEnable.Enabled = cfoEnable;
      updateVals();
      updateGUI();

    }

    //=============================================================================================
    public void frmGenHeaderFooter() {
      cfoHeader =  cfoDLE;
      tbxDLE.Text = cfoDLE;
      cfoFooter =  String.Concat("&" + cfoDLE);
      rtbxChannelBuffer.AppendText("Header:" + cfoHeader + "\n");
      rtbxChannelBuffer.AppendText("Footer:" + cfoFooter + "\n");
    }



    //=============================================================================================
    public string cfoParseStr(string nString) {
    
      //---Look for header, in the form " X " where x is a short string (~2-3 chars) that map to 
      //---what kind of sensor we are looking at.
      if( cfoEnable ) {
        cfoBuffer += nString;
        if( cfoBuffer.Length > 45 ) {
          cfoParse();
          Console.WriteLine("Call cfoParse(" + cfoDLE + "):" + cfoBuffer);

        }
        return cfoValDecimal.ToString();
      }
      else
        return "";
    }

    //=============================================================================================
    void cfoParse() {
      String[] stringAry0;
      int dataIdx;

      cfoState = cfo_state_type.sstInit;

      if( cfoBuffer.Length < 6) {
        cfoState = cfo_state_type.sstErrBufferEmpty;
        Console.WriteLine("err:" + cfoState.ToString());
        cfoBuffer = "";
        return;
      } 

      if( cfoBuffer.IndexOf(cfoHeader) == -1) {
        cfoState = cfo_state_type.sstErrNoHeader;
        Console.WriteLine("err:" + cfoState.ToString());
        cfoBuffer = "";
        return;

      } 

      cfoState = cfo_state_type.sstHdr;
      stringAry0 = cfoBuffer.Split();

      if( stringAry0.Length < 3 ) {
        cfoState = cfo_state_type.sstErrNoHeader;
        Console.WriteLine("err:" + cfoState.ToString());
        cfoBuffer = "";
        return;

      } 

      //---Find the header in the data buffer
      int i = Array.IndexOf(stringAry0, cfoHeader);
      if( i == -1 ) {
        cfoState = cfo_state_type.sstErrNoHeader;
        Console.WriteLine("err:" + cfoState.ToString());
        cfoBuffer = "";
        return;
      }
      dataIdx = i + 1;

      if( Array.IndexOf(stringAry0, cfoFooter) == -1 ) {
        cfoState = cfo_state_type.sstErrNoFooter;
        Console.WriteLine("err:" + cfoState.ToString());
        cfoBuffer = "";
        return;
            
      }

      cfoState = cfo_state_type.sstData;

      if( Decimal.TryParse(stringAry0[dataIdx], out cfoValDecimal) == false ) {
        cfoState = cfo_state_type.sstErrDataInvalid;
        Console.WriteLine("err:" + cfoState.ToString());
        cfoBuffer = "";
        return;
      }

      cfoPush(cfoValDecimal);
      cfoState = cfo_state_type.sstDataOk;
      Console.WriteLine("non-err:" + cfoState.ToString());

      if( cfoBuffer.Length > 55 )
        cfoBuffer = "";

    } 

    //=============================================================================================
    public void cfoPush(Decimal nVal) {
      Decimal nValShadow;
      cfoValueRaw = nVal;
      cfoDataCount++;

      cfoCaclAvg(cfoValueRaw);

      Console.WriteLine("parsed datum:" + cfoValueRaw);
      Console.WriteLine("buffer len:" + cfoBuffer.Length);

      nValShadow = nVal;
    }


    //=============================================================================================
    public void cfoCaclAvg(Decimal nVal) {
      cfoAvgShadow = cfoAvg;
      cfoAvgQ.Enqueue(nVal);
      if( cfoAvgQ.Count >= cfoAvgQCapacity)
        cfoAvgQ.Dequeue();

      Console.WriteLine("QCnt:" + cfoAvgQ.Count() + " v:" + nVal);
      foreach( Decimal v in cfoAvgQ ) {
        cfoAvg += v;
      }
      cfoAvg /= cfoAvgQCapacity;



    }

    //=============================================================================================
    private void tsbtEnable_Click(object sender, EventArgs e) {
      cfoEnable = !cfoEnable;

      updateGUI();
    }

    //=============================================================================================
    private void frmChannelForm_FormClosing(object sender, FormClosingEventArgs e) {
      cfoTreeView.Nodes.Remove(cfoNode);
      cfoTreeView.Invalidate();
    }


    //=============================================================================================
    private void updateVals() {
      decimal denom = timer1.Interval/1000;
      if( cfoValueRaw > cfoMax )
        cfoMax = cfoValueRaw;

      if( cfoValueRaw < cfoMin )
        cfoMin = cfoValueRaw;

      cfoDDT = (cfoAvg - cfoAvgShadow) / denom;

      cfoValueRawShadow = cfoValueRaw;
    }


    //=============================================================================================
    private void updateGUI() {

      cfoValStr = cfoValueRaw.ToString();
      cfoMaxStr = cfoMax.ToString();
      cfoMinStr = cfoMin.ToString();
      cfoAvgStr = cfoAvg.ToString();

      tsbtEnable.Image = cfoEnable ? bmpDisabled : bmpEnabled;
      tsslState.Image = cfoEnable ? bmpEnabled : bmpDisabled;
      timer1.Enabled = cfoEnable;
      tsslT.Text = "T:" + cfoT;

      tbxMin.Text = cfoMinStr;
      tbxMax.Text = cfoMaxStr;
      tbxValue.Text = cfoValStr;
      tbxAvg.Text = cfoAvgStr;
      tbxDDT.Text = cfoDDT.ToString();
      try {
        rtbxChannelBuffer.AppendText("data:" + cfoValStr + " @ t:" + cfoT + "s\n");
        rtbxChannelBuffer.SelectionStart = rtbxChannelBuffer.Text.Length;
        rtbxChannelBuffer.ScrollToCaret();
        cfoNode.ImageIndex = cfoEnable ? 11 : 4;
        cfoNode.Text = cfoName + ":" + cfoDLE + ":" + cfoValStr;
        

        cfoSeries.Points.AddXY(cfoT, cfoValueRaw);

        tsslDCount.Text = "Data Count:" + cfoDataCount.ToString();
      }
      catch {

      }

      switch( cfoTickerIdx ) {
        default:
        case 0:
          tsslTicker.Text = "|";
          break;
        case 1:
          tsslTicker.Text = "/";
          break;
        case 2:
          tsslTicker.Text = "-";
          break;
        case 3:
          tsslTicker.Text = "\\";
          break;
      }

    }

    //=============================================================================================
    public void extTrigger(int nT) {
      if( cfoEnable ) {
        cfoT = nT;
        updateVals();
        updateGUI();
      }
    }

    //=============================================================================================
    private void timer1_Tick(object sender, EventArgs e) {

      updateVals();
      updateGUI();
    }

    //=============================================================================================
    private void tsbtClearMeta_Click(object sender, EventArgs e) {
      cfoAvg = 0;
      cfoMin = 65535;
      cfoMax = 0;
      cfoDDT = 0;

    }
  }

}
