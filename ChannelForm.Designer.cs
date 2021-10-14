namespace ChanForm {
  partial class frmChannelForm {
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
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tsslState = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslDCount = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslT = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslTicker = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.tsbtEnable = new System.Windows.Forms.ToolStripButton();
      this.tsbtClearMeta = new System.Windows.Forms.ToolStripButton();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tbxMax = new System.Windows.Forms.TextBox();
      this.tbxValue = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.tbxDLE = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tbxMin = new System.Windows.Forms.TextBox();
      this.tbxAvg = new System.Windows.Forms.TextBox();
      this.tbxDDT = new System.Windows.Forms.TextBox();
      this.gbxChannelBuffer = new System.Windows.Forms.GroupBox();
      this.rtbxChannelBuffer = new System.Windows.Forms.RichTextBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.statusStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.gbxChannelBuffer.SuspendLayout();
      this.SuspendLayout();
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslState,
            this.tsslDCount,
            this.tsslT,
            this.tsslTicker});
      this.statusStrip1.Location = new System.Drawing.Point(0, 292);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(341, 22);
      this.statusStrip1.TabIndex = 5;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tsslState
      // 
      this.tsslState.Image = global::MDIForm_1.Properties.Resources.Pause_grey_16x;
      this.tsslState.Name = "tsslState";
      this.tsslState.Size = new System.Drawing.Size(16, 17);
      this.tsslState.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.tsslState.ToolTipText = "Disabled";
      // 
      // tsslDCount
      // 
      this.tsslDCount.Name = "tsslDCount";
      this.tsslDCount.Size = new System.Drawing.Size(70, 17);
      this.tsslDCount.Text = "Data Count:";
      // 
      // tsslT
      // 
      this.tsslT.Name = "tsslT";
      this.tsslT.Size = new System.Drawing.Size(35, 17);
      this.tsslT.Text = "T: --x";
      // 
      // tsslTicker
      // 
      this.tsslTicker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsslTicker.Image = global::MDIForm_1.Properties.Resources.TaskCenterStatusBarAni_00_16x;
      this.tsslTicker.Name = "tsslTicker";
      this.tsslTicker.Size = new System.Drawing.Size(12, 17);
      this.tsslTicker.Text = "\\";
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtEnable,
            this.tsbtClearMeta});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(341, 25);
      this.toolStrip1.TabIndex = 8;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // tsbtEnable
      // 
      this.tsbtEnable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbtEnable.Image = global::MDIForm_1.Properties.Resources.Run_16x;
      this.tsbtEnable.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbtEnable.Name = "tsbtEnable";
      this.tsbtEnable.Size = new System.Drawing.Size(23, 22);
      this.tsbtEnable.Text = "toolStripButton2";
      this.tsbtEnable.Click += new System.EventHandler(this.tsbtEnable_Click);
      // 
      // tsbtClearMeta
      // 
      this.tsbtClearMeta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbtClearMeta.Image = global::MDIForm_1.Properties.Resources.ResetTimelineView_inverse_16x;
      this.tsbtClearMeta.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbtClearMeta.Name = "tsbtClearMeta";
      this.tsbtClearMeta.Size = new System.Drawing.Size(23, 22);
      this.tsbtClearMeta.Text = "toolStripButton1";
      this.tsbtClearMeta.Click += new System.EventHandler(this.tsbtClearMeta_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.AutoSize = true;
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
      this.tableLayoutPanel1.Controls.Add(this.tbxMax, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.tbxValue, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.tbxDLE, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.tbxMin, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.tbxAvg, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.tbxDDT, 1, 5);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 6;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 156);
      this.tableLayoutPanel1.TabIndex = 9;
      // 
      // tbxMax
      // 
      this.tbxMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.tbxMax.Location = new System.Drawing.Point(43, 55);
      this.tbxMax.Name = "tbxMax";
      this.tbxMax.ReadOnly = true;
      this.tbxMax.Size = new System.Drawing.Size(83, 20);
      this.tbxMax.TabIndex = 6;
      // 
      // tbxValue
      // 
      this.tbxValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.tbxValue.Location = new System.Drawing.Point(43, 29);
      this.tbxValue.Name = "tbxValue";
      this.tbxValue.ReadOnly = true;
      this.tbxValue.Size = new System.Drawing.Size(83, 20);
      this.tbxValue.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(28, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "DLE";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(34, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Value";
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 58);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(27, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Max";
      // 
      // tbxDLE
      // 
      this.tbxDLE.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.tbxDLE.Location = new System.Drawing.Point(43, 3);
      this.tbxDLE.Name = "tbxDLE";
      this.tbxDLE.ReadOnly = true;
      this.tbxDLE.Size = new System.Drawing.Size(83, 20);
      this.tbxDLE.TabIndex = 4;
      this.tbxDLE.Text = "T";
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 84);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(24, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Min";
      // 
      // label5
      // 
      this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 136);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(27, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "d/dt";
      // 
      // label6
      // 
      this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(3, 110);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(26, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Avg";
      // 
      // tbxMin
      // 
      this.tbxMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.tbxMin.Location = new System.Drawing.Point(43, 81);
      this.tbxMin.Name = "tbxMin";
      this.tbxMin.ReadOnly = true;
      this.tbxMin.Size = new System.Drawing.Size(83, 20);
      this.tbxMin.TabIndex = 12;
      // 
      // tbxAvg
      // 
      this.tbxAvg.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.tbxAvg.Location = new System.Drawing.Point(43, 107);
      this.tbxAvg.Name = "tbxAvg";
      this.tbxAvg.ReadOnly = true;
      this.tbxAvg.Size = new System.Drawing.Size(83, 20);
      this.tbxAvg.TabIndex = 13;
      // 
      // tbxDDT
      // 
      this.tbxDDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.tbxDDT.Location = new System.Drawing.Point(43, 133);
      this.tbxDDT.Name = "tbxDDT";
      this.tbxDDT.ReadOnly = true;
      this.tbxDDT.Size = new System.Drawing.Size(83, 20);
      this.tbxDDT.TabIndex = 14;
      // 
      // gbxChannelBuffer
      // 
      this.gbxChannelBuffer.Controls.Add(this.rtbxChannelBuffer);
      this.gbxChannelBuffer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gbxChannelBuffer.Location = new System.Drawing.Point(0, 181);
      this.gbxChannelBuffer.Name = "gbxChannelBuffer";
      this.gbxChannelBuffer.Size = new System.Drawing.Size(341, 111);
      this.gbxChannelBuffer.TabIndex = 10;
      this.gbxChannelBuffer.TabStop = false;
      this.gbxChannelBuffer.Text = "Channel Buffer";
      // 
      // rtbxChannelBuffer
      // 
      this.rtbxChannelBuffer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtbxChannelBuffer.Location = new System.Drawing.Point(3, 16);
      this.rtbxChannelBuffer.Name = "rtbxChannelBuffer";
      this.rtbxChannelBuffer.Size = new System.Drawing.Size(335, 92);
      this.rtbxChannelBuffer.TabIndex = 0;
      this.rtbxChannelBuffer.Text = "";
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // frmChannelForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(341, 314);
      this.Controls.Add(this.gbxChannelBuffer);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.statusStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "frmChannelForm";
      this.Text = "ChannelForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChannelForm_FormClosing);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.gbxChannelBuffer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbxDLE;
    private System.Windows.Forms.TextBox tbxMax;
    private System.Windows.Forms.TextBox tbxValue;
    private System.Windows.Forms.GroupBox gbxChannelBuffer;
    private System.Windows.Forms.RichTextBox rtbxChannelBuffer;
    private System.Windows.Forms.ToolStripButton tsbtEnable;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbxMin;
    private System.Windows.Forms.TextBox tbxAvg;
    private System.Windows.Forms.TextBox tbxDDT;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.ToolStripStatusLabel tsslState;
    private System.Windows.Forms.ToolStripButton tsbtClearMeta;
    private System.Windows.Forms.ToolStripStatusLabel tsslDCount;
    private System.Windows.Forms.ToolStripStatusLabel tsslT;
    private System.Windows.Forms.ToolStripStatusLabel tsslTicker;
  }
}