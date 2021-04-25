namespace ChanForm {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if( disposing && (components != null) ) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
      System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 2D);
      System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 1D);
      System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 2D);
      System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 1D);
      System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 2D);
      System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 1D);
      System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.wInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.tsbtOpenPort = new System.Windows.Forms.ToolStripButton();
      this.tscbPort = new System.Windows.Forms.ToolStripComboBox();
      this.tscbBaud = new System.Windows.Forms.ToolStripComboBox();
      this.tsbtScan = new System.Windows.Forms.ToolStripButton();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.gbxChannels = new System.Windows.Forms.GroupBox();
      this.tvwChannels = new System.Windows.Forms.TreeView();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.tsChannels = new System.Windows.Forms.ToolStrip();
      this.tsbtAddChannel = new System.Windows.Forms.ToolStripButton();
      this.tscbAvailableSigs = new System.Windows.Forms.ToolStripComboBox();
      this.gbxGraph = new System.Windows.Forms.GroupBox();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.toolStrip2 = new System.Windows.Forms.ToolStrip();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tsslPortStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslComPort = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslBaud = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslStartDelay = new System.Windows.Forms.ToolStripStatusLabel();
      this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
      this.masterTimer = new System.Windows.Forms.Timer(this.components);
      this.tsbRefreshDLEs = new System.Windows.Forms.ToolStripButton();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.gbxChannels.SuspendLayout();
      this.tsChannels.SuspendLayout();
      this.gbxGraph.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(910, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.wInToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
      this.newToolStripMenuItem.Text = "New";
      this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
      // 
      // wInToolStripMenuItem
      // 
      this.wInToolStripMenuItem.Name = "wInToolStripMenuItem";
      this.wInToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
      this.wInToolStripMenuItem.Text = "Window";
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtOpenPort,
            this.tscbPort,
            this.tscbBaud,
            this.tsbtScan});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(910, 25);
      this.toolStrip1.TabIndex = 3;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // tsbtOpenPort
      // 
      this.tsbtOpenPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbtOpenPort.Image = global::MDIForm_1.Properties.Resources.ConnectUnplugged_16x;
      this.tsbtOpenPort.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbtOpenPort.Name = "tsbtOpenPort";
      this.tsbtOpenPort.Size = new System.Drawing.Size(23, 22);
      this.tsbtOpenPort.Text = "toolStripButton1";
      this.tsbtOpenPort.Click += new System.EventHandler(this.tsbtOpenPort_Click);
      // 
      // tscbPort
      // 
      this.tscbPort.Items.AddRange(new object[] {
            "Select Port"});
      this.tscbPort.Name = "tscbPort";
      this.tscbPort.Size = new System.Drawing.Size(75, 25);
      this.tscbPort.Text = "COM1";
      this.tscbPort.SelectedIndexChanged += new System.EventHandler(this.tsddPort_SelectedIndexChanged);
      // 
      // tscbBaud
      // 
      this.tscbBaud.AutoSize = false;
      this.tscbBaud.Items.AddRange(new object[] {
            "2400",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "250000"});
      this.tscbBaud.Name = "tscbBaud";
      this.tscbBaud.Size = new System.Drawing.Size(75, 23);
      this.tscbBaud.Text = "Baud Rate";
      this.tscbBaud.SelectedIndexChanged += new System.EventHandler(this.tscbBaud_SelectedIndexChanged);
      // 
      // tsbtScan
      // 
      this.tsbtScan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbtScan.Image = global::MDIForm_1.Properties.Resources.Search_16x;
      this.tsbtScan.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbtScan.Name = "tsbtScan";
      this.tsbtScan.Size = new System.Drawing.Size(23, 22);
      this.tsbtScan.Text = "Scan Ports";
      this.tsbtScan.Click += new System.EventHandler(this.tsbtScan_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 49);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.gbxChannels);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.gbxGraph);
      this.splitContainer1.Size = new System.Drawing.Size(910, 417);
      this.splitContainer1.SplitterDistance = 302;
      this.splitContainer1.TabIndex = 4;
      // 
      // gbxChannels
      // 
      this.gbxChannels.Controls.Add(this.tvwChannels);
      this.gbxChannels.Controls.Add(this.tsChannels);
      this.gbxChannels.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gbxChannels.Location = new System.Drawing.Point(0, 0);
      this.gbxChannels.Name = "gbxChannels";
      this.gbxChannels.Size = new System.Drawing.Size(302, 417);
      this.gbxChannels.TabIndex = 1;
      this.gbxChannels.TabStop = false;
      this.gbxChannels.Text = "Channels";
      // 
      // tvwChannels
      // 
      this.tvwChannels.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tvwChannels.ImageIndex = 4;
      this.tvwChannels.ImageList = this.imageList1;
      this.tvwChannels.Location = new System.Drawing.Point(3, 41);
      this.tvwChannels.Name = "tvwChannels";
      this.tvwChannels.SelectedImageIndex = 0;
      this.tvwChannels.Size = new System.Drawing.Size(296, 373);
      this.tvwChannels.TabIndex = 1;
      this.tvwChannels.UseWaitCursor = true;
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "ASX_Run_blue_16x.png");
      this.imageList1.Images.SetKeyName(1, "ASX_Run_grey_16x.png");
      this.imageList1.Images.SetKeyName(2, "ConnectPlugged_16x.png");
      this.imageList1.Images.SetKeyName(3, "ConnectUnplugged_16x.png");
      this.imageList1.Images.SetKeyName(4, "Pause_16x.png");
      this.imageList1.Images.SetKeyName(5, "Pause_grey_16x.png");
      this.imageList1.Images.SetKeyName(6, "ResetTimelineView_16x.png");
      this.imageList1.Images.SetKeyName(7, "ResetTimelineView_inverse_16x.png");
      this.imageList1.Images.SetKeyName(8, "ResetTimelineViewDisabled_16x.png");
      this.imageList1.Images.SetKeyName(9, "ResetTimelineViewDisabled_inverse_16x.png");
      this.imageList1.Images.SetKeyName(10, "ReverseRun_16x.png");
      this.imageList1.Images.SetKeyName(11, "Run_16x.png");
      this.imageList1.Images.SetKeyName(12, "Run_blue_16x.png");
      this.imageList1.Images.SetKeyName(13, "Run_grey_16x.png");
      this.imageList1.Images.SetKeyName(14, "RunOutline_blue_16x.png");
      this.imageList1.Images.SetKeyName(15, "RunOutline_gray_16x.png");
      this.imageList1.Images.SetKeyName(16, "Search_16x.png");
      this.imageList1.Images.SetKeyName(17, "SerialPort_16x.png");
      // 
      // tsChannels
      // 
      this.tsChannels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtAddChannel,
            this.tscbAvailableSigs,
            this.tsbRefreshDLEs});
      this.tsChannels.Location = new System.Drawing.Point(3, 16);
      this.tsChannels.Name = "tsChannels";
      this.tsChannels.Size = new System.Drawing.Size(296, 25);
      this.tsChannels.TabIndex = 0;
      this.tsChannels.Text = "toolStrip1";
      // 
      // tsbtAddChannel
      // 
      this.tsbtAddChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbtAddChannel.Enabled = false;
      this.tsbtAddChannel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtAddChannel.Image")));
      this.tsbtAddChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbtAddChannel.Name = "tsbtAddChannel";
      this.tsbtAddChannel.Size = new System.Drawing.Size(33, 22);
      this.tsbtAddChannel.Text = "Add";
      this.tsbtAddChannel.Click += new System.EventHandler(this.tsbtAddChannel_Click);
      // 
      // tscbAvailableSigs
      // 
      this.tscbAvailableSigs.Name = "tscbAvailableSigs";
      this.tscbAvailableSigs.Size = new System.Drawing.Size(108, 25);
      this.tscbAvailableSigs.Text = "Available Signals";
      this.tscbAvailableSigs.ToolTipText = "Available Signals";
      // 
      // gbxGraph
      // 
      this.gbxGraph.Controls.Add(this.chart1);
      this.gbxGraph.Controls.Add(this.toolStrip2);
      this.gbxGraph.Controls.Add(this.splitter1);
      this.gbxGraph.Controls.Add(this.textBox1);
      this.gbxGraph.Controls.Add(this.statusStrip1);
      this.gbxGraph.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gbxGraph.Location = new System.Drawing.Point(0, 0);
      this.gbxGraph.Name = "gbxGraph";
      this.gbxGraph.Size = new System.Drawing.Size(604, 417);
      this.gbxGraph.TabIndex = 1;
      this.gbxGraph.TabStop = false;
      this.gbxGraph.Text = "gbxGraph";
      // 
      // chart1
      // 
      chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(3, 41);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      dataPoint1.AxisLabel = "AxisLabel for Series1";
      dataPoint1.IsValueShownAsLabel = true;
      dataPoint1.Label = "Label for DataPoint #VALX";
      dataPoint1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
      dataPoint2.IsValueShownAsLabel = true;
      dataPoint2.Label = "Label for DataPoint #VALX";
      dataPoint2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
      dataPoint3.Label = "Label for DataPoint #VALX";
      dataPoint3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
      dataPoint4.Label = "Label for DataPoint #VALX";
      dataPoint4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
      dataPoint5.Label = "Label for DataPoint #VALX";
      dataPoint6.Label = "Label for DataPoint #VALX";
      dataPoint7.Label = "Label for DataPoint #VALX";
      series1.Points.Add(dataPoint1);
      series1.Points.Add(dataPoint2);
      series1.Points.Add(dataPoint3);
      series1.Points.Add(dataPoint4);
      series1.Points.Add(dataPoint5);
      series1.Points.Add(dataPoint6);
      series1.Points.Add(dataPoint7);
      series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(598, 242);
      this.chart1.TabIndex = 5;
      this.chart1.Text = "chart1";
      title1.Name = "Title1";
      title1.Text = "Title1";
      this.chart1.Titles.Add(title1);
      this.chart1.DoubleClick += new System.EventHandler(this.chart1_DoubleClick);
      this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
      // 
      // toolStrip2
      // 
      this.toolStrip2.Location = new System.Drawing.Point(3, 16);
      this.toolStrip2.Name = "toolStrip2";
      this.toolStrip2.Size = new System.Drawing.Size(598, 25);
      this.toolStrip2.TabIndex = 4;
      this.toolStrip2.Text = "toolStrip2";
      // 
      // splitter1
      // 
      this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.splitter1.Location = new System.Drawing.Point(3, 283);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(598, 19);
      this.splitter1.TabIndex = 2;
      this.splitter1.TabStop = false;
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.textBox1.Location = new System.Drawing.Point(3, 302);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(598, 90);
      this.textBox1.TabIndex = 1;
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslPortStatus,
            this.tsslComPort,
            this.tsslBaud,
            this.tsslTime,
            this.tsslStartDelay});
      this.statusStrip1.Location = new System.Drawing.Point(3, 392);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(598, 22);
      this.statusStrip1.TabIndex = 0;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tsslPortStatus
      // 
      this.tsslPortStatus.Name = "tsslPortStatus";
      this.tsslPortStatus.Size = new System.Drawing.Size(64, 17);
      this.tsslPortStatus.Text = "Port Status";
      // 
      // tsslComPort
      // 
      this.tsslComPort.Name = "tsslComPort";
      this.tsslComPort.Size = new System.Drawing.Size(42, 17);
      this.tsslComPort.Text = "Port:--";
      // 
      // tsslBaud
      // 
      this.tsslBaud.Name = "tsslBaud";
      this.tsslBaud.Size = new System.Drawing.Size(47, 17);
      this.tsslBaud.Text = "Baud:--";
      // 
      // tsslTime
      // 
      this.tsslTime.Name = "tsslTime";
      this.tsslTime.Size = new System.Drawing.Size(29, 17);
      this.tsslTime.Text = "T: --";
      // 
      // tsslStartDelay
      // 
      this.tsslStartDelay.Name = "tsslStartDelay";
      this.tsslStartDelay.Size = new System.Drawing.Size(101, 17);
      this.tsslStartDelay.Text = "Start Delay, ms: --";
      // 
      // serialPort1
      // 
      this.serialPort1.BaudRate = 250000;
      this.serialPort1.PortName = "COM3";
      // 
      // masterTimer
      // 
      this.masterTimer.Interval = 1;
      this.masterTimer.Tick += new System.EventHandler(this.masterTimer_Tick);
      // 
      // tsbRefreshDLEs
      // 
      this.tsbRefreshDLEs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbRefreshDLEs.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefreshDLEs.Image")));
      this.tsbRefreshDLEs.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbRefreshDLEs.Name = "tsbRefreshDLEs";
      this.tsbRefreshDLEs.Size = new System.Drawing.Size(78, 22);
      this.tsbRefreshDLEs.Text = "Refresh DLEs";
      this.tsbRefreshDLEs.Click += new System.EventHandler(this.tsbRefreshDLEs_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(910, 466);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.gbxChannels.ResumeLayout(false);
      this.gbxChannels.PerformLayout();
      this.tsChannels.ResumeLayout(false);
      this.tsChannels.PerformLayout();
      this.gbxGraph.ResumeLayout(false);
      this.gbxGraph.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem wInToolStripMenuItem;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.GroupBox gbxChannels;
    private System.Windows.Forms.TreeView tvwChannels;
    private System.Windows.Forms.ToolStrip tsChannels;
    private System.Windows.Forms.ToolStripButton tsbtAddChannel;
    private System.Windows.Forms.GroupBox gbxGraph;
    private System.Windows.Forms.ToolStripButton tsbtOpenPort;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel tsslPortStatus;
    private System.IO.Ports.SerialPort serialPort1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.ToolStrip toolStrip2;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.Timer masterTimer;
    private System.Windows.Forms.ToolStripButton tsbtScan;
    private System.Windows.Forms.ToolStripComboBox tscbPort;
    private System.Windows.Forms.ToolStripComboBox tscbBaud;
    private System.Windows.Forms.ToolStripStatusLabel tsslComPort;
    private System.Windows.Forms.ToolStripStatusLabel tsslBaud;
    private System.Windows.Forms.ToolStripStatusLabel tsslTime;
    private System.Windows.Forms.ToolStripComboBox tscbAvailableSigs;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.ToolStripStatusLabel tsslStartDelay;
    private System.Windows.Forms.ToolStripButton tsbRefreshDLEs;
  }
}

