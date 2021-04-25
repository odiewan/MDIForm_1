using MDIForm_1;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.IO.Ports;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MDIForm_1.Properties;
using System.CodeDom.Compiler;

namespace ChanForm {
  public partial class MainForm :Form {

    private int chanCnt;
    public static string dataBuff;
    private DataCollector dc01;
    public static List<String> dleList;
    public static List<frmChannelForm> channels;
    public List<Series> seriesList;
    Series tmpSeries;
    private string portStr = Settings.Default.sAttrPort;
    private static bool foundDLEs;
    private bool foundDLEsShadow;

    int frmSelMode;
    Point frmMousePnt0;
    Point frmMousePnt1;
    public int masterT; //---Master timer in secs from reciept of first data from port (time since first call of DistData())
    int dcStartDelay; //--- ms between enableing the data collector and first callback invokation---


    private readonly Bitmap bmpConnected = MDIForm_1.Properties.Resources.ConnectPlugged_16x;
    private readonly Bitmap bmpNotConnected = MDIForm_1.Properties.Resources.ConnectUnplugged_16x;

    //=============================================================================================
    public MainForm() {
      chanCnt = 0;
      dataBuff = "";
      masterT = 0;

      frmSelMode = 0;
      frmMousePnt0 = new Point();
      frmMousePnt1 = new Point();

      dc01 = new DataCollector(Settings.Default.sAttrPort, Settings.Default.sAttrBaud, DistData);
      channels = new List<frmChannelForm>();
      dleList = new List<String>();
      foundDLEs = false;
      foundDLEsShadow = false;

      InitializeComponent();
      seriesList = new List<Series>();
      this.chart1.Series.Clear();
      this.chart1.Titles.Clear();
      this.chart1.Titles.Add("Serial Data");
      tsbtOpenPort.Text = "Port:Open";
      scanPorts();
      updateGUI();
    }

    //=============================================================================================
    public static void getDLEs() {
      string[] tmpStrAry = { };
      bool eol = false;


      eol = nStr.IndexOf('>') != -1;
      dleList.Clear();
      if( !eol ) {
        Console.WriteLine("haven't found EOL");
        dataBuff += nStr;
      } //  if( tmpStr.IndexOf('>') == -1 )
      else {
        tmpStrAry = dataBuff.Split();
        foreach( string str in tmpStrAry ) {
          if( str.IndexOf('&') != -1 ) {
            dleList.Add(str.Substring(1));
            foundDLEs = true;
          }

        }
        Console.WriteLine("DLE count:" + dleList.Count.ToString());
        dataBuff = "";

        Console.WriteLine("found EOL");
      } //   found EOL
    }
      

    //=============================================================================================
    public static void DistData(List<byte> bytes) {
      string cntStr = bytes.Count().ToString();
      byte[] byteAry = bytes.ToArray();
      string[] tmpStrAry = { };
      string tmpStr = "";
      bool eol = false;
      bool eolShadow = false;

      foreach( byte b in byteAry ) {
        tmpStr += Convert.ToChar(b);
      }

      eol = tmpStr.IndexOf('>') != -1;

      if( eol )
        Console.WriteLine("Found EOL");

      if( !eol && eol != eolShadow )
        dataBuff = "";


      dataBuff += tmpStr;

      Console.WriteLine("dataBuff:" + dataBuff);

      Console.WriteLine("new data:" + cntStr + " bytes:" + tmpStr);
      try {
        foreach( frmChannelForm fcf in channels ) {
          fcf.cfoParseStr(tmpStr);
        }
      }
      catch {
        Console.WriteLine("cfoParseStr threw exception");
      }

      eolShadow = eol;
    }

    //=============================================================================================
    private void newToolStripMenuItem_Click(object sender, EventArgs e) {
      addChannel();
    }

    //=============================================================================================
    private void tsbtAddChannel_Click(object sender, EventArgs e) {
      addChannel();
    }

    //=============================================================================================
    private void addChannel() {

      string tmpChanName;
      tmpChanName = "Chan" + chanCnt;
      string tmpDLE = tscbAvailableSigs.Text;
      frmChannelForm tmpChanForm = new frmChannelForm(tmpChanName, tmpDLE, tvwChannels, addSeries(tmpChanName));

      chanCnt++;
      tmpChanForm.Show();
      channels.Add(tmpChanForm);
    }

    //=============================================================================================
    private void tsbtOpenPort_Click(object sender, EventArgs e) {
      if( dc01.portState == true ) {
        dc01.closePort();
      }
      else {
        masterTimer.Interval = 10;
        masterTimer.Enabled = true;
        dc01.openPort();
      }

      foundDLEs = false;


      foreach( frmChannelForm fcf in channels ) {
        if( fcf != null )
          fcf.frmEnable(dc01.portState);
        else
          channels.Remove(fcf);
      }
      updateGUI();
    }

    //=============================================================================================
    public void updateGUI() {
      tsbtAddChannel.Enabled = foundDLEs;

      getDLEs();

      if( !foundDLEs && dleList.Count > 0 ) {
        tscbAvailableSigs.Items.Clear();
        foreach( string d in dleList ) {
          tscbAvailableSigs.Items.Add(d);
        }
      }

      updateStatusStrip();
      updateComPortGUI();
    }

    //=============================================================================================
    private void updateStatusStrip() {
      tsslPortStatus.Text = dc01.portState ? "Port:Open": "Port:Closed";
      tsslPortStatus.Image = MDIForm_1.Properties.Resources.ConnectPlugged_16x;
      tsslComPort.Text = "Port:" + dc01.port;
      tsslBaud.Text = "Baud:" + dc01.baud;
      tsslTime.Text = "T:" + masterT.ToString() + "s";
      tsslStartDelay.Text = "Start Delay:" + dcStartDelay.ToString() + "ms";

    }


    //=============================================================================================
    private void updateComPortGUI() {
      tscbPort.Enabled = !dc01.portState;
      tscbBaud.Enabled = !dc01.portState;
      tsbtScan.Enabled = !dc01.portState;
      tscbPort.Text = dc01.port;
      tscbBaud.Text = dc01.baud.ToString();
      tsbtOpenPort.Image = dc01.portState ? bmpConnected : bmpNotConnected;
      tsbtOpenPort.ToolTipText = dc01.portState ? "Port:Open" : "Port:Closed";
    }

    //=============================================================================================
    private void scanPorts() {

      string[] ports = SerialPort.GetPortNames();
      int port_count = ports.Length;


      tscbPort.Items.Clear();
      foreach( string prt in ports ) {
        tscbPort.Items.Add(prt);

      }

      if(port_count > 0) {
        tscbPort.Enabled = true;
        tsbtOpenPort.Enabled = true;
        tscbBaud.Enabled = true;
        tsbtScan.Enabled = true;
      }
      else {
        tscbPort.Enabled = false;
        tscbPort.Text = "No ports found";
        tsbtOpenPort.Enabled = false;
        tscbBaud.Enabled = false;
        tsbtScan.Enabled = false;
      }
    }

    //=============================================================================================
    private void tsbtScan_Click(object sender, EventArgs e) {
      scanPorts();
      updateGUI();
    }


    //=============================================================================================
    private void tsddPort_SelectedIndexChanged(object sender, EventArgs e) {
      dc01.port = tscbPort.Text;
      updateGUI();
    }

    //=============================================================================================
    private void tscbBaud_SelectedIndexChanged(object sender, EventArgs e) {
      int.TryParse(tscbBaud.Text, out int tmpInt);
      dc01.baud = tmpInt;
    }


    //=============================================================================================
    private Series addSeries(String nName) {
      Series tmpSeries01 = this.chart1.Series.Add(nName);
      tmpSeries01.ChartType = SeriesChartType.Line;
      seriesList.Add(tmpSeries01);
      return tmpSeries01;
    }

    //=============================================================================================
    private void tsbtClearSeries_Click(object sender, EventArgs e) {
      this.chart1.Series.Clear();
    }


    //=============================================================================================
    private void tsbtAddDatum_Click(object sender, EventArgs e) {
      tmpSeries.Points.AddXY("datum", 1.0);
    }

    //=============================================================================================
    private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
      Settings.Default.sAttrBaud = dc01.baud;
      Settings.Default.sAttrPort = dc01.port;
      Settings.Default.Save();
    }

    private void chart1_Click(object sender, EventArgs e) {

    }

    //=============================================================================================
    private void chart1_DoubleClick(object sender, EventArgs e) {
      frmSelMode = 1;
    }

    //=============================================================================================
    private void chart1_MouseClick(object sender, MouseEventArgs e) {
      if( frmSelMode == 1 ) {
        frmMousePnt0.X = e.X;
        frmMousePnt0.Y = e.Y;
        chart1.ChartAreas[0].CursorX.Interval = 0;
        chart1.ChartAreas[0].CursorY.Interval = 0;
        chart1.ChartAreas[0].CursorX.SetCursorPixelPosition(frmMousePnt0, true);
        chart1.ChartAreas[0].CursorY.SetCursorPixelPosition(frmMousePnt0, true);
        frmSelMode = 2;
        Console.WriteLine("X1 0: " + frmMousePnt0.X.ToString());
        Console.WriteLine("Y1 0: " + frmMousePnt0.Y.ToString());
        Console.WriteLine("X2 0: " + frmMousePnt1.X.ToString());
        Console.WriteLine("Y2 0: " + frmMousePnt1.Y.ToString());
      }
      else if( frmSelMode == 2 ) {
        frmMousePnt1.X = e.X;
        frmMousePnt1.Y = e.Y;
        Console.WriteLine("X1 1: " + frmMousePnt0.X.ToString());
        Console.WriteLine("Y1 1: " + frmMousePnt0.Y.ToString());
        Console.WriteLine("X2 1: " + frmMousePnt1.X.ToString());
        Console.WriteLine("Y2 1: " + frmMousePnt1.Y.ToString());
      }
    }

    //=============================================================================================
    private void masterTimer_Tick(object sender, EventArgs e) {
      if( foundDLEs) {
        if( foundDLEsShadow != foundDLEs ) {
          masterTimer.Enabled = false;
          masterTimer.Interval = 1000;
          masterTimer.Enabled = true;
        }
        else {
          masterT++;
          Console.WriteLine("masterT:" + masterT);
          foreach( frmChannelForm fcf in channels )
            fcf.extTrigger(masterT);
        }
      }
      else {

        dcStartDelay += 1;
      }
      
      updateGUI();
      foundDLEsShadow = foundDLEs;
    }

    //=============================================================================================
    private void tsbRefreshDLEs_Click(object sender, EventArgs e) {
      foundDLEs = false;
      updateGUI();
    }
  } //---class MainForm
} //---namespace ChanForm
