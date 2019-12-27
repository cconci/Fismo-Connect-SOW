namespace Fismo_Connect_SOW
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_version = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_author = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxRX = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxTX = new System.Windows.Forms.RichTextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorkerDevice = new System.ComponentModel.BackgroundWorker();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.richTextBoxManualInput = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonManualSend = new System.Windows.Forms.Button();
            this.checkBoxApplyTigerProtocol = new System.Windows.Forms.CheckBox();
            this.labelClearMonitor = new System.Windows.Forms.Label();
            this.labelRawCommsRxClear = new System.Windows.Forms.Label();
            this.labelRawCommsTxClear = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_version,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_author,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "Version:";
            // 
            // toolStripStatusLabel_version
            // 
            this.toolStripStatusLabel_version.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolStripStatusLabel_version.Name = "toolStripStatusLabel_version";
            this.toolStripStatusLabel_version.Size = new System.Drawing.Size(24, 17);
            this.toolStripStatusLabel_version.Text = "NA";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(867, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "---";
            // 
            // toolStripStatusLabel_author
            // 
            this.toolStripStatusLabel_author.Name = "toolStripStatusLabel_author";
            this.toolStripStatusLabel_author.Size = new System.Drawing.Size(24, 17);
            this.toolStripStatusLabel_author.Text = "NA";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Enabled = false;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(984, 506);
            this.splitContainer1.SplitterDistance = 510;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelClearMonitor);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.richTextBoxStatus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(497, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Status:";
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxStatus.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxStatus.HideSelection = false;
            this.richTextBoxStatus.Location = new System.Drawing.Point(8, 29);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.ReadOnly = true;
            this.richTextBoxStatus.Size = new System.Drawing.Size(480, 431);
            this.richTextBoxStatus.TabIndex = 1;
            this.richTextBoxStatus.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(497, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RAW Comms";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(6, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.labelRawCommsRxClear);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.richTextBoxRX);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.labelRawCommsTxClear);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.richTextBoxTX);
            this.splitContainer2.Size = new System.Drawing.Size(486, 465);
            this.splitContainer2.SplitterDistance = 231;
            this.splitContainer2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RX";
            // 
            // richTextBoxRX
            // 
            this.richTextBoxRX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxRX.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxRX.HideSelection = false;
            this.richTextBoxRX.Location = new System.Drawing.Point(3, 29);
            this.richTextBoxRX.Name = "richTextBoxRX";
            this.richTextBoxRX.ReadOnly = true;
            this.richTextBoxRX.Size = new System.Drawing.Size(480, 199);
            this.richTextBoxRX.TabIndex = 0;
            this.richTextBoxRX.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TX";
            // 
            // richTextBoxTX
            // 
            this.richTextBoxTX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTX.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTX.HideSelection = false;
            this.richTextBoxTX.Location = new System.Drawing.Point(3, 32);
            this.richTextBoxTX.Name = "richTextBoxTX";
            this.richTextBoxTX.ReadOnly = true;
            this.richTextBoxTX.Size = new System.Drawing.Size(480, 194);
            this.richTextBoxTX.TabIndex = 0;
            this.richTextBoxTX.Text = "";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(469, 500);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.numericUpDown2);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(461, 474);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Runtime";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Command";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(309, 34);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Runtime Commands we are Requesting,";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.listBox1.Location = new System.Drawing.Point(23, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 95);
            this.listBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Runtime Commands Request Rate(Hz)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(309, 152);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(461, 474);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // backgroundWorkerDevice
            // 
            this.backgroundWorkerDevice.WorkerReportsProgress = true;
            this.backgroundWorkerDevice.WorkerSupportsCancellation = true;
            this.backgroundWorkerDevice.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDevice_DoWork);
            this.backgroundWorkerDevice.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerDevice_ProgressChanged);
            this.backgroundWorkerDevice.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDevice_RunWorkerCompleted);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.checkBoxApplyTigerProtocol);
            this.tabPage5.Controls.Add(this.buttonManualSend);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.richTextBoxManualInput);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(461, 474);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Manual";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // richTextBoxManualInput
            // 
            this.richTextBoxManualInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxManualInput.Location = new System.Drawing.Point(22, 28);
            this.richTextBoxManualInput.Name = "richTextBoxManualInput";
            this.richTextBoxManualInput.Size = new System.Drawing.Size(411, 65);
            this.richTextBoxManualInput.TabIndex = 0;
            this.richTextBoxManualInput.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Input Data (HEX)";
            // 
            // buttonManualSend
            // 
            this.buttonManualSend.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonManualSend.Location = new System.Drawing.Point(22, 122);
            this.buttonManualSend.Name = "buttonManualSend";
            this.buttonManualSend.Size = new System.Drawing.Size(411, 23);
            this.buttonManualSend.TabIndex = 2;
            this.buttonManualSend.Text = "Send";
            this.buttonManualSend.UseVisualStyleBackColor = true;
            this.buttonManualSend.Click += new System.EventHandler(this.buttonManualSend_Click);
            // 
            // checkBoxApplyTigerProtocol
            // 
            this.checkBoxApplyTigerProtocol.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBoxApplyTigerProtocol.AutoSize = true;
            this.checkBoxApplyTigerProtocol.Checked = true;
            this.checkBoxApplyTigerProtocol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxApplyTigerProtocol.Location = new System.Drawing.Point(22, 99);
            this.checkBoxApplyTigerProtocol.Name = "checkBoxApplyTigerProtocol";
            this.checkBoxApplyTigerProtocol.Size = new System.Drawing.Size(121, 17);
            this.checkBoxApplyTigerProtocol.TabIndex = 3;
            this.checkBoxApplyTigerProtocol.Text = "Apply Tiger Protocol";
            this.checkBoxApplyTigerProtocol.UseVisualStyleBackColor = true;
            // 
            // labelClearMonitor
            // 
            this.labelClearMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClearMonitor.AutoSize = true;
            this.labelClearMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClearMonitor.ForeColor = System.Drawing.Color.Blue;
            this.labelClearMonitor.Location = new System.Drawing.Point(457, 13);
            this.labelClearMonitor.Name = "labelClearMonitor";
            this.labelClearMonitor.Size = new System.Drawing.Size(31, 13);
            this.labelClearMonitor.TabIndex = 3;
            this.labelClearMonitor.Text = "Clear";
            this.labelClearMonitor.Click += new System.EventHandler(this.labelClearMonitor_Click);
            // 
            // labelRawCommsRxClear
            // 
            this.labelRawCommsRxClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRawCommsRxClear.AutoSize = true;
            this.labelRawCommsRxClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawCommsRxClear.ForeColor = System.Drawing.Color.Blue;
            this.labelRawCommsRxClear.Location = new System.Drawing.Point(452, 10);
            this.labelRawCommsRxClear.Name = "labelRawCommsRxClear";
            this.labelRawCommsRxClear.Size = new System.Drawing.Size(31, 13);
            this.labelRawCommsRxClear.TabIndex = 4;
            this.labelRawCommsRxClear.Text = "Clear";
            this.labelRawCommsRxClear.Click += new System.EventHandler(this.labelRawCommsRxClear_Click);
            // 
            // labelRawCommsTxClear
            // 
            this.labelRawCommsTxClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRawCommsTxClear.AutoSize = true;
            this.labelRawCommsTxClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawCommsTxClear.ForeColor = System.Drawing.Color.Blue;
            this.labelRawCommsTxClear.Location = new System.Drawing.Point(452, 15);
            this.labelRawCommsTxClear.Name = "labelRawCommsTxClear";
            this.labelRawCommsTxClear.Size = new System.Drawing.Size(31, 13);
            this.labelRawCommsTxClear.TabIndex = 5;
            this.labelRawCommsTxClear.Text = "Clear";
            this.labelRawCommsTxClear.Click += new System.EventHandler(this.labelRawCommsTxClear_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "MainApp";
            this.Text = "Fismo Connect SOW";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.Shown += new System.EventHandler(this.MainApp_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_version;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_author;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxRX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxTX;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDevice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonManualSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxManualInput;
        private System.Windows.Forms.CheckBox checkBoxApplyTigerProtocol;
        private System.Windows.Forms.Label labelClearMonitor;
        private System.Windows.Forms.Label labelRawCommsRxClear;
        private System.Windows.Forms.Label labelRawCommsTxClear;
    }
}

