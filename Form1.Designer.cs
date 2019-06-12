namespace WindowsForms串口
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrCurrent = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstlblConnectionSTAT = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstlblSendCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstlblReceiveCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstlblReceivedCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstlblPortStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstlblCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHandShaking = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoStringReceived = new System.Windows.Forms.RadioButton();
            this.rdoHexReceived = new System.Windows.Forms.RadioButton();
            this.btnClearReceivedData = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSendRecycle = new System.Windows.Forms.TextBox();
            this.chkSendRecycle = new System.Windows.Forms.CheckBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.rdoSrtingSend = new System.Windows.Forms.RadioButton();
            this.rdoHexSend = new System.Windows.Forms.RadioButton();
            this.btnClearSendData = new System.Windows.Forms.Button();
            this.tmrSendRecycle = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendedDataToolStripMenuItem,
            this.receivedDataToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // sendedDataToolStripMenuItem
            // 
            this.sendedDataToolStripMenuItem.Name = "sendedDataToolStripMenuItem";
            this.sendedDataToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.sendedDataToolStripMenuItem.Text = "Sended data";
            // 
            // receivedDataToolStripMenuItem
            // 
            this.receivedDataToolStripMenuItem.Name = "receivedDataToolStripMenuItem";
            this.receivedDataToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.receivedDataToolStripMenuItem.Text = "Received data";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tmrCurrent
            // 
            this.tmrCurrent.Enabled = true;
            this.tmrCurrent.Interval = 1000;
            this.tmrCurrent.Tick += new System.EventHandler(this.TmrCurrent_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstlblConnectionSTAT,
            this.tstlblSendCounter,
            this.tstlblReceiveCounter,
            this.tstlblReceivedCounter,
            this.tstlblPortStatus,
            this.tstlblCurrentTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstlblConnectionSTAT
            // 
            this.tstlblConnectionSTAT.Name = "tstlblConnectionSTAT";
            this.tstlblConnectionSTAT.Size = new System.Drawing.Size(88, 19);
            this.tstlblConnectionSTAT.Text = "Not Connected";
            // 
            // tstlblSendCounter
            // 
            this.tstlblSendCounter.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tstlblSendCounter.Name = "tstlblSendCounter";
            this.tstlblSendCounter.Size = new System.Drawing.Size(208, 19);
            this.tstlblSendCounter.Spring = true;
            this.tstlblSendCounter.Text = "S: 0";
            this.tstlblSendCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstlblReceiveCounter
            // 
            this.tstlblReceiveCounter.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tstlblReceiveCounter.Name = "tstlblReceiveCounter";
            this.tstlblReceiveCounter.Size = new System.Drawing.Size(208, 19);
            this.tstlblReceiveCounter.Spring = true;
            this.tstlblReceiveCounter.Text = "R:0";
            this.tstlblReceiveCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstlblReceivedCounter
            // 
            this.tstlblReceivedCounter.Name = "tstlblReceivedCounter";
            this.tstlblReceivedCounter.Size = new System.Drawing.Size(0, 19);
            // 
            // tstlblPortStatus
            // 
            this.tstlblPortStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tstlblPortStatus.Name = "tstlblPortStatus";
            this.tstlblPortStatus.Size = new System.Drawing.Size(208, 19);
            this.tstlblPortStatus.Spring = true;
            this.tstlblPortStatus.Text = " ";
            // 
            // tstlblCurrentTime
            // 
            this.tstlblCurrentTime.Name = "tstlblCurrentTime";
            this.tstlblCurrentTime.Size = new System.Drawing.Size(73, 19);
            this.tstlblCurrentTime.Text = "CurrentTime";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(800, 440);
            this.splitContainer1.SplitterDistance = 96;
            this.splitContainer1.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOpen);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbHandShaking);
            this.groupBox3.Controls.Add(this.cmbParity);
            this.groupBox3.Controls.Add(this.cmbStopBits);
            this.groupBox3.Controls.Add(this.cmbDataBits);
            this.groupBox3.Controls.Add(this.cmbBaudRate);
            this.groupBox3.Controls.Add(this.cmbPortName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(96, 440);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Setting";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 351);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(89, 39);
            this.btnOpen.TabIndex = 13;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 306);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 39);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Handshaking:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stop Bits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Bits:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baud Rate:";
            // 
            // cmbHandShaking
            // 
            this.cmbHandShaking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHandShaking.FormattingEnabled = true;
            this.cmbHandShaking.Location = new System.Drawing.Point(6, 277);
            this.cmbHandShaking.Name = "cmbHandShaking";
            this.cmbHandShaking.Size = new System.Drawing.Size(89, 21);
            this.cmbHandShaking.TabIndex = 6;
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(6, 230);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(89, 21);
            this.cmbParity.TabIndex = 5;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Location = new System.Drawing.Point(6, 182);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(89, 21);
            this.cmbStopBits.TabIndex = 4;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Location = new System.Drawing.Point(6, 134);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(89, 21);
            this.cmbDataBits.TabIndex = 3;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(6, 87);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(89, 21);
            this.cmbBaudRate.TabIndex = 2;
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(6, 39);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(89, 21);
            this.cmbPortName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port Name:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtReceived);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtSend);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(700, 440);
            this.splitContainer2.SplitterDistance = 316;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 7;
            // 
            // txtReceived
            // 
            this.txtReceived.AcceptsReturn = true;
            this.txtReceived.BackColor = System.Drawing.Color.Black;
            this.txtReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceived.ForeColor = System.Drawing.Color.Gold;
            this.txtReceived.Location = new System.Drawing.Point(0, 53);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.ReadOnly = true;
            this.txtReceived.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReceived.Size = new System.Drawing.Size(700, 263);
            this.txtReceived.TabIndex = 6;
            this.txtReceived.TextChanged += new System.EventHandler(this.TxtReceived_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoStringReceived);
            this.groupBox1.Controls.Add(this.rdoHexReceived);
            this.groupBox1.Controls.Add(this.btnClearReceivedData);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received";
            // 
            // rdoStringReceived
            // 
            this.rdoStringReceived.AutoSize = true;
            this.rdoStringReceived.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoStringReceived.Location = new System.Drawing.Point(124, 17);
            this.rdoStringReceived.Name = "rdoStringReceived";
            this.rdoStringReceived.Size = new System.Drawing.Size(67, 33);
            this.rdoStringReceived.TabIndex = 5;
            this.rdoStringReceived.TabStop = true;
            this.rdoStringReceived.Text = "String";
            this.rdoStringReceived.UseVisualStyleBackColor = true;
            // 
            // rdoHexReceived
            // 
            this.rdoHexReceived.AutoSize = true;
            this.rdoHexReceived.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoHexReceived.Location = new System.Drawing.Point(78, 17);
            this.rdoHexReceived.Name = "rdoHexReceived";
            this.rdoHexReceived.Size = new System.Drawing.Size(46, 33);
            this.rdoHexReceived.TabIndex = 4;
            this.rdoHexReceived.TabStop = true;
            this.rdoHexReceived.Text = "Hex";
            this.rdoHexReceived.UseVisualStyleBackColor = true;
            this.rdoHexReceived.CheckedChanged += new System.EventHandler(this.RdoHexReceived_CheckedChanged);
            // 
            // btnClearReceivedData
            // 
            this.btnClearReceivedData.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClearReceivedData.Location = new System.Drawing.Point(3, 17);
            this.btnClearReceivedData.Name = "btnClearReceivedData";
            this.btnClearReceivedData.Size = new System.Drawing.Size(75, 33);
            this.btnClearReceivedData.TabIndex = 3;
            this.btnClearReceivedData.Text = "Clear";
            this.btnClearReceivedData.UseVisualStyleBackColor = true;
            this.btnClearReceivedData.Click += new System.EventHandler(this.BtnClearReceivedData_Click);
            // 
            // txtSend
            // 
            this.txtSend.AcceptsReturn = true;
            this.txtSend.BackColor = System.Drawing.Color.Black;
            this.txtSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSend.ForeColor = System.Drawing.Color.Orange;
            this.txtSend.Location = new System.Drawing.Point(0, 0);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSend.Size = new System.Drawing.Size(700, 35);
            this.txtSend.TabIndex = 10;
            this.txtSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSend_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSendRecycle);
            this.groupBox2.Controls.Add(this.chkSendRecycle);
            this.groupBox2.Controls.Add(this.btnSendData);
            this.groupBox2.Controls.Add(this.rdoSrtingSend);
            this.groupBox2.Controls.Add(this.rdoHexSend);
            this.groupBox2.Controls.Add(this.btnClearSendData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 88);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Interval";
            // 
            // txtSendRecycle
            // 
            this.txtSendRecycle.Location = new System.Drawing.Point(148, 61);
            this.txtSendRecycle.MaxLength = 5;
            this.txtSendRecycle.Name = "txtSendRecycle";
            this.txtSendRecycle.Size = new System.Drawing.Size(43, 21);
            this.txtSendRecycle.TabIndex = 7;
            // 
            // chkSendRecycle
            // 
            this.chkSendRecycle.AutoSize = true;
            this.chkSendRecycle.Location = new System.Drawing.Point(89, 37);
            this.chkSendRecycle.Name = "chkSendRecycle";
            this.chkSendRecycle.Size = new System.Drawing.Size(110, 19);
            this.chkSendRecycle.TabIndex = 6;
            this.chkSendRecycle.Text = "Send Recycle";
            this.chkSendRecycle.UseVisualStyleBackColor = true;
            this.chkSendRecycle.CheckedChanged += new System.EventHandler(this.ChkSendRecycle_CheckedChanged);
            // 
            // btnSendData
            // 
            this.btnSendData.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendData.Location = new System.Drawing.Point(622, 17);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 68);
            this.btnSendData.TabIndex = 1;
            this.btnSendData.Text = "Send";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.BtnSendData_Click);
            // 
            // rdoSrtingSend
            // 
            this.rdoSrtingSend.AutoSize = true;
            this.rdoSrtingSend.Location = new System.Drawing.Point(136, 16);
            this.rdoSrtingSend.Name = "rdoSrtingSend";
            this.rdoSrtingSend.Size = new System.Drawing.Size(67, 19);
            this.rdoSrtingSend.TabIndex = 5;
            this.rdoSrtingSend.TabStop = true;
            this.rdoSrtingSend.Text = "String";
            this.rdoSrtingSend.UseVisualStyleBackColor = true;
            // 
            // rdoHexSend
            // 
            this.rdoHexSend.AutoSize = true;
            this.rdoHexSend.Location = new System.Drawing.Point(89, 16);
            this.rdoHexSend.Name = "rdoHexSend";
            this.rdoHexSend.Size = new System.Drawing.Size(46, 19);
            this.rdoHexSend.TabIndex = 4;
            this.rdoHexSend.TabStop = true;
            this.rdoHexSend.Text = "Hex";
            this.rdoHexSend.UseVisualStyleBackColor = true;
            this.rdoHexSend.CheckedChanged += new System.EventHandler(this.RdoHexSend_CheckedChanged);
            // 
            // btnClearSendData
            // 
            this.btnClearSendData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClearSendData.Location = new System.Drawing.Point(3, 33);
            this.btnClearSendData.Name = "btnClearSendData";
            this.btnClearSendData.Size = new System.Drawing.Size(75, 31);
            this.btnClearSendData.TabIndex = 3;
            this.btnClearSendData.Text = "Clear";
            this.btnClearSendData.UseVisualStyleBackColor = true;
            this.btnClearSendData.Click += new System.EventHandler(this.BtnClearSendData_Click);
            // 
            // tmrSendRecycle
            // 
            this.tmrSendRecycle.Tick += new System.EventHandler(this.TmrSendRecycle_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendedDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivedDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Timer tmrCurrent;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tstlblConnectionSTAT;
        private System.Windows.Forms.ToolStripStatusLabel tstlblSendCounter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoStringReceived;
        private System.Windows.Forms.RadioButton rdoHexReceived;
        private System.Windows.Forms.Button btnClearReceivedData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.RadioButton rdoHexSend;
        private System.Windows.Forms.Button btnClearSendData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHandShaking;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel tstlblReceiveCounter;
        private System.Windows.Forms.ToolStripStatusLabel tstlblReceivedCounter;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.ToolStripStatusLabel tstlblPortStatus;
        private System.Windows.Forms.ToolStripStatusLabel tstlblCurrentTime;
        private System.Windows.Forms.RadioButton rdoSrtingSend;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSendRecycle;
        private System.Windows.Forms.CheckBox chkSendRecycle;
        private System.Windows.Forms.Timer tmrSendRecycle;
    }
}

