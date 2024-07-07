namespace LUART
{
    partial class LUART
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Text.ASCIIEncoding asciiEncoding1 = new System.Text.ASCIIEncoding();
            System.Text.DecoderReplacementFallback decoderReplacementFallback1 = new System.Text.DecoderReplacementFallback();
            System.Text.EncoderReplacementFallback encoderReplacementFallback1 = new System.Text.EncoderReplacementFallback();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LUART));
            panel_Setting = new Panel();
            groupboxSendSetting = new GroupBox();
            txtAutoSendms = new TextBox();
            chkAutoCleanSend = new CheckBox();
            chkAutoSend = new CheckBox();
            chkfromFileSend = new CheckBox();
            chkAutoAddSend = new CheckBox();
            rbtnSendUnicode = new RadioButton();
            rbtnSendHex = new RadioButton();
            rbtnSendASCII = new RadioButton();
            rbtnSendUTF8 = new RadioButton();
            lkbReadSend = new LinkLabel();
            lkbClearSend = new LinkLabel();
            groupboxRecSetting = new GroupBox();
            chkRecSend = new CheckBox();
            lkbSaveRev = new LinkLabel();
            rbtnUnicode = new RadioButton();
            rbtnUTF8 = new RadioButton();
            rbtnASCII = new RadioButton();
            rbtnHex = new RadioButton();
            lkbClearRev = new LinkLabel();
            chkShowTime = new CheckBox();
            chkAutoLine = new CheckBox();
            groupBoxComSetting = new GroupBox();
            cbbParity = new ComboBox();
            cbbStopBits = new ComboBox();
            btnOpen = new Button();
            cbbDataBits = new ComboBox();
            cbbBaudRate = new ComboBox();
            cbbComList = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel_Rec = new Panel();
            groupBox2 = new GroupBox();
            txtShowData = new TextBox();
            panel_Send = new Panel();
            groupBox3 = new GroupBox();
            btnSend = new Button();
            txtSendData = new TextBox();
            panel_Log = new Panel();
            Log = new Label();
            btnCleanCount = new Button();
            lblRevCount = new Label();
            lblSendCount = new Label();
            ComDevice = new System.IO.Ports.SerialPort(components);
            timerAutoSend = new System.Windows.Forms.Timer(components);
            groupBox6 = new GroupBox();
            panel_ListSend = new Panel();
            ListSend_Send0 = new Button();
            ListSend_Text0 = new TextBox();
            ListSend_Hex0 = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            toolTip1 = new ToolTip(components);
            timerIcon = new System.Windows.Forms.Timer(components);
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            panel_Setting.SuspendLayout();
            groupboxSendSetting.SuspendLayout();
            groupboxRecSetting.SuspendLayout();
            groupBoxComSetting.SuspendLayout();
            panel_Rec.SuspendLayout();
            groupBox2.SuspendLayout();
            panel_Send.SuspendLayout();
            groupBox3.SuspendLayout();
            panel_Log.SuspendLayout();
            groupBox6.SuspendLayout();
            panel_ListSend.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Setting
            // 
            panel_Setting.BackColor = SystemColors.Control;
            panel_Setting.Controls.Add(groupboxSendSetting);
            panel_Setting.Controls.Add(groupboxRecSetting);
            panel_Setting.Controls.Add(groupBoxComSetting);
            panel_Setting.Dock = DockStyle.Left;
            panel_Setting.Location = new Point(0, 0);
            panel_Setting.Margin = new Padding(6);
            panel_Setting.Name = "panel_Setting";
            panel_Setting.Size = new Size(319, 1098);
            panel_Setting.TabIndex = 0;
            // 
            // groupboxSendSetting
            // 
            groupboxSendSetting.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupboxSendSetting.Controls.Add(txtAutoSendms);
            groupboxSendSetting.Controls.Add(chkAutoCleanSend);
            groupboxSendSetting.Controls.Add(chkAutoSend);
            groupboxSendSetting.Controls.Add(chkfromFileSend);
            groupboxSendSetting.Controls.Add(chkAutoAddSend);
            groupboxSendSetting.Controls.Add(rbtnSendUnicode);
            groupboxSendSetting.Controls.Add(rbtnSendHex);
            groupboxSendSetting.Controls.Add(rbtnSendASCII);
            groupboxSendSetting.Controls.Add(rbtnSendUTF8);
            groupboxSendSetting.Controls.Add(lkbReadSend);
            groupboxSendSetting.Controls.Add(lkbClearSend);
            groupboxSendSetting.Location = new Point(7, 724);
            groupboxSendSetting.Margin = new Padding(6);
            groupboxSendSetting.Name = "groupboxSendSetting";
            groupboxSendSetting.Padding = new Padding(6);
            groupboxSendSetting.Size = new Size(312, 354);
            groupboxSendSetting.TabIndex = 3;
            groupboxSendSetting.TabStop = false;
            groupboxSendSetting.Text = "发送设置";
            // 
            // txtAutoSendms
            // 
            txtAutoSendms.ImeMode = ImeMode.Disable;
            txtAutoSendms.Location = new Point(161, 170);
            txtAutoSendms.Margin = new Padding(6);
            txtAutoSendms.MaxLength = 5;
            txtAutoSendms.Name = "txtAutoSendms";
            txtAutoSendms.Size = new Size(55, 30);
            txtAutoSendms.TabIndex = 5;
            txtAutoSendms.Text = "500";
            txtAutoSendms.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(txtAutoSendms, "建议20-60000范围内");
            txtAutoSendms.KeyPress += txtAutoSendms_KeyPress;
            // 
            // chkAutoCleanSend
            // 
            chkAutoCleanSend.AutoSize = true;
            chkAutoCleanSend.Location = new Point(16, 128);
            chkAutoCleanSend.Margin = new Padding(6);
            chkAutoCleanSend.Name = "chkAutoCleanSend";
            chkAutoCleanSend.Size = new Size(162, 28);
            chkAutoCleanSend.TabIndex = 3;
            chkAutoCleanSend.Text = "发送完自动清空";
            chkAutoCleanSend.UseVisualStyleBackColor = true;
            // 
            // chkAutoSend
            // 
            chkAutoSend.AutoSize = true;
            chkAutoSend.Location = new Point(16, 172);
            chkAutoSend.Margin = new Padding(6);
            chkAutoSend.Name = "chkAutoSend";
            chkAutoSend.Size = new Size(145, 28);
            chkAutoSend.TabIndex = 4;
            chkAutoSend.Text = "发送周期(ms)";
            chkAutoSend.UseVisualStyleBackColor = true;
            // 
            // chkfromFileSend
            // 
            chkfromFileSend.AutoSize = true;
            chkfromFileSend.Enabled = false;
            chkfromFileSend.Location = new Point(16, 40);
            chkfromFileSend.Margin = new Padding(6);
            chkfromFileSend.Name = "chkfromFileSend";
            chkfromFileSend.Size = new Size(162, 28);
            chkfromFileSend.TabIndex = 1;
            chkfromFileSend.Text = "启用文件数据源";
            chkfromFileSend.UseVisualStyleBackColor = true;
            // 
            // chkAutoAddSend
            // 
            chkAutoAddSend.AutoSize = true;
            chkAutoAddSend.Enabled = false;
            chkAutoAddSend.Location = new Point(16, 84);
            chkAutoAddSend.Margin = new Padding(6);
            chkAutoAddSend.Name = "chkAutoAddSend";
            chkAutoAddSend.Size = new Size(162, 28);
            chkAutoAddSend.TabIndex = 2;
            chkAutoAddSend.Text = "自动发送附加位";
            chkAutoAddSend.UseVisualStyleBackColor = true;
            // 
            // rbtnSendUnicode
            // 
            rbtnSendUnicode.AutoSize = true;
            rbtnSendUnicode.Location = new Point(125, 260);
            rbtnSendUnicode.Margin = new Padding(6);
            rbtnSendUnicode.Name = "rbtnSendUnicode";
            rbtnSendUnicode.Size = new Size(106, 28);
            rbtnSendUnicode.TabIndex = 9;
            rbtnSendUnicode.Text = "Unicode";
            rbtnSendUnicode.UseVisualStyleBackColor = true;
            rbtnSendUnicode.Click += rbtnSend_Click;
            // 
            // rbtnSendHex
            // 
            rbtnSendHex.AutoSize = true;
            rbtnSendHex.Location = new Point(16, 216);
            rbtnSendHex.Margin = new Padding(6);
            rbtnSendHex.Name = "rbtnSendHex";
            rbtnSendHex.Size = new Size(68, 28);
            rbtnSendHex.TabIndex = 6;
            rbtnSendHex.Text = "Hex";
            rbtnSendHex.UseVisualStyleBackColor = true;
            rbtnSendHex.Click += rbtnSend_Click;
            // 
            // rbtnSendASCII
            // 
            rbtnSendASCII.AutoSize = true;
            rbtnSendASCII.Checked = true;
            rbtnSendASCII.Location = new Point(125, 218);
            rbtnSendASCII.Margin = new Padding(6);
            rbtnSendASCII.Name = "rbtnSendASCII";
            rbtnSendASCII.Size = new Size(70, 28);
            rbtnSendASCII.TabIndex = 7;
            rbtnSendASCII.TabStop = true;
            rbtnSendASCII.Text = "GBK";
            rbtnSendASCII.UseVisualStyleBackColor = true;
            rbtnSendASCII.Click += rbtnSend_Click;
            // 
            // rbtnSendUTF8
            // 
            rbtnSendUTF8.AutoSize = true;
            rbtnSendUTF8.Location = new Point(16, 260);
            rbtnSendUTF8.Margin = new Padding(6);
            rbtnSendUTF8.Name = "rbtnSendUTF8";
            rbtnSendUTF8.Size = new Size(87, 28);
            rbtnSendUTF8.TabIndex = 8;
            rbtnSendUTF8.Text = "UTF-8";
            rbtnSendUTF8.UseVisualStyleBackColor = true;
            rbtnSendUTF8.Click += rbtnSend_Click;
            // 
            // lkbReadSend
            // 
            lkbReadSend.AutoSize = true;
            lkbReadSend.Location = new Point(24, 309);
            lkbReadSend.Margin = new Padding(6, 0, 6, 0);
            lkbReadSend.Name = "lkbReadSend";
            lkbReadSend.Size = new Size(82, 24);
            lkbReadSend.TabIndex = 10;
            lkbReadSend.TabStop = true;
            lkbReadSend.Text = "文件载入";
            lkbReadSend.LinkClicked += lkbReadSend_LinkClicked;
            // 
            // lkbClearSend
            // 
            lkbClearSend.AutoSize = true;
            lkbClearSend.Location = new Point(152, 309);
            lkbClearSend.Margin = new Padding(6, 0, 6, 0);
            lkbClearSend.Name = "lkbClearSend";
            lkbClearSend.Size = new Size(82, 24);
            lkbClearSend.TabIndex = 11;
            lkbClearSend.TabStop = true;
            lkbClearSend.Text = "清除发送";
            lkbClearSend.LinkClicked += lkbClearSend_LinkClicked;
            // 
            // groupboxRecSetting
            // 
            groupboxRecSetting.Controls.Add(checkBox2);
            groupboxRecSetting.Controls.Add(checkBox1);
            groupboxRecSetting.Controls.Add(chkRecSend);
            groupboxRecSetting.Controls.Add(lkbSaveRev);
            groupboxRecSetting.Controls.Add(rbtnUnicode);
            groupboxRecSetting.Controls.Add(rbtnUTF8);
            groupboxRecSetting.Controls.Add(rbtnASCII);
            groupboxRecSetting.Controls.Add(rbtnHex);
            groupboxRecSetting.Controls.Add(lkbClearRev);
            groupboxRecSetting.Controls.Add(chkShowTime);
            groupboxRecSetting.Controls.Add(chkAutoLine);
            groupboxRecSetting.Location = new Point(7, 406);
            groupboxRecSetting.Margin = new Padding(6);
            groupboxRecSetting.Name = "groupboxRecSetting";
            groupboxRecSetting.Padding = new Padding(6);
            groupboxRecSetting.Size = new Size(312, 304);
            groupboxRecSetting.TabIndex = 2;
            groupboxRecSetting.TabStop = false;
            groupboxRecSetting.Text = "接收设置";
            // 
            // chkRecSend
            // 
            chkRecSend.AutoSize = true;
            chkRecSend.Location = new Point(24, 128);
            chkRecSend.Margin = new Padding(6);
            chkRecSend.Name = "chkRecSend";
            chkRecSend.Size = new Size(144, 28);
            chkRecSend.TabIndex = 9;
            chkRecSend.Text = "输入直接发送";
            chkRecSend.UseVisualStyleBackColor = true;
            // 
            // lkbSaveRev
            // 
            lkbSaveRev.AutoSize = true;
            lkbSaveRev.Location = new Point(24, 264);
            lkbSaveRev.Margin = new Padding(6, 0, 6, 0);
            lkbSaveRev.Name = "lkbSaveRev";
            lkbSaveRev.Size = new Size(82, 24);
            lkbSaveRev.TabIndex = 7;
            lkbSaveRev.TabStop = true;
            lkbSaveRev.Text = "保存数据";
            lkbSaveRev.LinkClicked += lkbSaveRev_LinkClicked;
            // 
            // rbtnUnicode
            // 
            rbtnUnicode.AutoSize = true;
            rbtnUnicode.Location = new Point(132, 220);
            rbtnUnicode.Margin = new Padding(6);
            rbtnUnicode.Name = "rbtnUnicode";
            rbtnUnicode.Size = new Size(106, 28);
            rbtnUnicode.TabIndex = 6;
            rbtnUnicode.Text = "Unicode";
            rbtnUnicode.UseVisualStyleBackColor = true;
            rbtnUnicode.Click += rbtn_Click;
            // 
            // rbtnUTF8
            // 
            rbtnUTF8.AutoSize = true;
            rbtnUTF8.Location = new Point(22, 220);
            rbtnUTF8.Margin = new Padding(6);
            rbtnUTF8.Name = "rbtnUTF8";
            rbtnUTF8.Size = new Size(87, 28);
            rbtnUTF8.TabIndex = 5;
            rbtnUTF8.Text = "UTF-8";
            rbtnUTF8.UseVisualStyleBackColor = true;
            rbtnUTF8.Click += rbtn_Click;
            // 
            // rbtnASCII
            // 
            rbtnASCII.AutoSize = true;
            rbtnASCII.Checked = true;
            rbtnASCII.Location = new Point(132, 176);
            rbtnASCII.Margin = new Padding(6);
            rbtnASCII.Name = "rbtnASCII";
            rbtnASCII.Size = new Size(70, 28);
            rbtnASCII.TabIndex = 4;
            rbtnASCII.TabStop = true;
            rbtnASCII.Text = "GBK";
            rbtnASCII.UseVisualStyleBackColor = true;
            rbtnASCII.Click += rbtn_Click;
            // 
            // rbtnHex
            // 
            rbtnHex.AutoSize = true;
            rbtnHex.Location = new Point(24, 176);
            rbtnHex.Margin = new Padding(6);
            rbtnHex.Name = "rbtnHex";
            rbtnHex.Size = new Size(68, 28);
            rbtnHex.TabIndex = 3;
            rbtnHex.Text = "Hex";
            rbtnHex.UseVisualStyleBackColor = true;
            rbtnHex.Click += rbtn_Click;
            // 
            // lkbClearRev
            // 
            lkbClearRev.AutoSize = true;
            lkbClearRev.Location = new Point(152, 264);
            lkbClearRev.Margin = new Padding(6, 0, 6, 0);
            lkbClearRev.Name = "lkbClearRev";
            lkbClearRev.Size = new Size(82, 24);
            lkbClearRev.TabIndex = 8;
            lkbClearRev.TabStop = true;
            lkbClearRev.Text = "清除接收";
            lkbClearRev.LinkClicked += lkbClearRev_LinkClicked;
            // 
            // chkShowTime
            // 
            chkShowTime.AutoSize = true;
            chkShowTime.Location = new Point(24, 84);
            chkShowTime.Margin = new Padding(6);
            chkShowTime.Name = "chkShowTime";
            chkShowTime.Size = new Size(144, 28);
            chkShowTime.TabIndex = 2;
            chkShowTime.Text = "显示接收时间";
            chkShowTime.UseVisualStyleBackColor = true;
            chkShowTime.CheckedChanged += chkShowTime_CheckedChanged;
            // 
            // chkAutoLine
            // 
            chkAutoLine.AutoSize = true;
            chkAutoLine.Location = new Point(24, 40);
            chkAutoLine.Margin = new Padding(6);
            chkAutoLine.Name = "chkAutoLine";
            chkAutoLine.Size = new Size(144, 28);
            chkAutoLine.TabIndex = 1;
            chkAutoLine.Text = "自动换行显示";
            chkAutoLine.UseVisualStyleBackColor = true;
            // 
            // groupBoxComSetting
            // 
            groupBoxComSetting.Controls.Add(cbbParity);
            groupBoxComSetting.Controls.Add(cbbStopBits);
            groupBoxComSetting.Controls.Add(btnOpen);
            groupBoxComSetting.Controls.Add(cbbDataBits);
            groupBoxComSetting.Controls.Add(cbbBaudRate);
            groupBoxComSetting.Controls.Add(cbbComList);
            groupBoxComSetting.Controls.Add(label2);
            groupBoxComSetting.Controls.Add(label5);
            groupBoxComSetting.Controls.Add(label1);
            groupBoxComSetting.Controls.Add(label4);
            groupBoxComSetting.Controls.Add(label3);
            groupBoxComSetting.Font = new Font("宋体", 10F);
            groupBoxComSetting.Location = new Point(6, 6);
            groupBoxComSetting.Margin = new Padding(6);
            groupBoxComSetting.Name = "groupBoxComSetting";
            groupBoxComSetting.Padding = new Padding(6);
            groupBoxComSetting.Size = new Size(312, 388);
            groupBoxComSetting.TabIndex = 1;
            groupBoxComSetting.TabStop = false;
            groupBoxComSetting.Text = "端口设置";
            // 
            // cbbParity
            // 
            cbbParity.FormattingEnabled = true;
            cbbParity.Items.AddRange(new object[] { "None", "Odd", "Even", "Mark", "Space" });
            cbbParity.Location = new Point(112, 260);
            cbbParity.Margin = new Padding(6);
            cbbParity.Name = "cbbParity";
            cbbParity.Size = new Size(176, 28);
            cbbParity.TabIndex = 5;
            cbbParity.TextChanged += cbbComSetChange;
            // 
            // cbbStopBits
            // 
            cbbStopBits.FormattingEnabled = true;
            cbbStopBits.Items.AddRange(new object[] { "1", "2", "3" });
            cbbStopBits.Location = new Point(112, 208);
            cbbStopBits.Margin = new Padding(6);
            cbbStopBits.Name = "cbbStopBits";
            cbbStopBits.Size = new Size(176, 28);
            cbbStopBits.TabIndex = 4;
            cbbStopBits.TextChanged += cbbComSetChange;
            // 
            // btnOpen
            // 
            btnOpen.DialogResult = DialogResult.Cancel;
            btnOpen.Font = new Font("宋体", 10F);
            btnOpen.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpen.Location = new Point(16, 314);
            btnOpen.Margin = new Padding(6);
            btnOpen.Name = "btnOpen";
            btnOpen.Padding = new Padding(15, 0, 46, 0);
            btnOpen.Size = new Size(275, 64);
            btnOpen.TabIndex = 6;
            btnOpen.Text = "打开串口";
            btnOpen.TextAlign = ContentAlignment.MiddleRight;
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // cbbDataBits
            // 
            cbbDataBits.FormattingEnabled = true;
            cbbDataBits.ImeMode = ImeMode.NoControl;
            cbbDataBits.Items.AddRange(new object[] { "8", "7", "6" });
            cbbDataBits.Location = new Point(112, 154);
            cbbDataBits.Margin = new Padding(6);
            cbbDataBits.Name = "cbbDataBits";
            cbbDataBits.Size = new Size(176, 28);
            cbbDataBits.TabIndex = 3;
            cbbDataBits.TextChanged += cbbComSetChange;
            // 
            // cbbBaudRate
            // 
            cbbBaudRate.DisplayMember = "1";
            cbbBaudRate.FormattingEnabled = true;
            cbbBaudRate.Items.AddRange(new object[] { "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "43000", "56000", "57600", "74880", "115200", "128000", "256000" });
            cbbBaudRate.Location = new Point(112, 96);
            cbbBaudRate.Margin = new Padding(6);
            cbbBaudRate.Name = "cbbBaudRate";
            cbbBaudRate.Size = new Size(176, 28);
            cbbBaudRate.TabIndex = 2;
            cbbBaudRate.Text = "115200";
            cbbBaudRate.ValueMember = "1";
            cbbBaudRate.TextChanged += cbbComSetChange;
            // 
            // cbbComList
            // 
            cbbComList.DisplayMember = "1";
            cbbComList.FormattingEnabled = true;
            cbbComList.Location = new Point(112, 44);
            cbbComList.Margin = new Padding(6);
            cbbComList.Name = "cbbComList";
            cbbComList.Size = new Size(176, 28);
            cbbComList.TabIndex = 1;
            cbbComList.DropDown += cbbComList_DropDown;
            cbbComList.TextChanged += cbbComSetChange;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 102);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "波特率";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 266);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "校验位";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 50);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "端口";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 214);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "停止位";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 160);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "数据位";
            // 
            // panel_Rec
            // 
            panel_Rec.Controls.Add(groupBox2);
            panel_Rec.Dock = DockStyle.Fill;
            panel_Rec.Location = new Point(319, 0);
            panel_Rec.Margin = new Padding(6);
            panel_Rec.Name = "panel_Rec";
            panel_Rec.Size = new Size(1184, 886);
            panel_Rec.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtShowData);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("宋体", 10F);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6);
            groupBox2.Size = new Size(1184, 886);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "数据接收区";
            // 
            // txtShowData
            // 
            txtShowData.Dock = DockStyle.Fill;
            txtShowData.ImeMode = ImeMode.Disable;
            txtShowData.Location = new Point(6, 29);
            txtShowData.Margin = new Padding(6);
            txtShowData.Multiline = true;
            txtShowData.Name = "txtShowData";
            txtShowData.ScrollBars = ScrollBars.Vertical;
            txtShowData.Size = new Size(1172, 851);
            txtShowData.TabIndex = 2;
            txtShowData.KeyPress += txtShowData_KeyPress;
            // 
            // panel_Send
            // 
            panel_Send.Controls.Add(groupBox3);
            panel_Send.Dock = DockStyle.Bottom;
            panel_Send.Location = new Point(319, 886);
            panel_Send.Margin = new Padding(6);
            panel_Send.Name = "panel_Send";
            panel_Send.Size = new Size(1184, 212);
            panel_Send.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSend);
            groupBox3.Controls.Add(txtSendData);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("宋体", 10F);
            groupBox3.Location = new Point(0, 0);
            groupBox3.Margin = new Padding(6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(6);
            groupBox3.Size = new Size(1184, 212);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "单条发送";
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.Font = new Font("宋体", 10F);
            btnSend.Location = new Point(1034, 44);
            btnSend.Margin = new Padding(6);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(143, 152);
            btnSend.TabIndex = 2;
            btnSend.Text = "发送";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtSendData
            // 
            txtSendData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSendData.Location = new Point(6, 44);
            txtSendData.Margin = new Padding(6);
            txtSendData.Multiline = true;
            txtSendData.Name = "txtSendData";
            txtSendData.ScrollBars = ScrollBars.Vertical;
            txtSendData.Size = new Size(1014, 148);
            txtSendData.TabIndex = 1;
            // 
            // panel_Log
            // 
            panel_Log.BorderStyle = BorderStyle.FixedSingle;
            panel_Log.Controls.Add(Log);
            panel_Log.Controls.Add(btnCleanCount);
            panel_Log.Controls.Add(lblRevCount);
            panel_Log.Controls.Add(lblSendCount);
            panel_Log.Dock = DockStyle.Bottom;
            panel_Log.Location = new Point(0, 1098);
            panel_Log.Margin = new Padding(6);
            panel_Log.Name = "panel_Log";
            panel_Log.Size = new Size(1842, 48);
            panel_Log.TabIndex = 3;
            // 
            // Log
            // 
            Log.AutoSize = true;
            Log.Location = new Point(11, 6);
            Log.Margin = new Padding(6, 0, 6, 0);
            Log.MinimumSize = new Size(183, 0);
            Log.Name = "Log";
            Log.Padding = new Padding(4);
            Log.Size = new Size(183, 32);
            Log.TabIndex = 15;
            Log.Text = "串口关闭";
            Log.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCleanCount
            // 
            btnCleanCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCleanCount.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnCleanCount.Location = new Point(1713, 3);
            btnCleanCount.Margin = new Padding(6);
            btnCleanCount.Name = "btnCleanCount";
            btnCleanCount.Size = new Size(121, 40);
            btnCleanCount.TabIndex = 14;
            btnCleanCount.Text = "复位计数";
            btnCleanCount.UseVisualStyleBackColor = true;
            btnCleanCount.Click += btnCleanCount_Click;
            // 
            // lblRevCount
            // 
            lblRevCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRevCount.AutoSize = true;
            lblRevCount.BorderStyle = BorderStyle.Fixed3D;
            lblRevCount.Location = new Point(1231, -150);
            lblRevCount.Margin = new Padding(6, 0, 6, 0);
            lblRevCount.MinimumSize = new Size(183, 0);
            lblRevCount.Name = "lblRevCount";
            lblRevCount.Padding = new Padding(4);
            lblRevCount.Size = new Size(183, 34);
            lblRevCount.TabIndex = 13;
            lblRevCount.Text = "接收:0";
            lblRevCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSendCount
            // 
            lblSendCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSendCount.AutoSize = true;
            lblSendCount.BorderStyle = BorderStyle.Fixed3D;
            lblSendCount.Location = new Point(1420, -150);
            lblSendCount.Margin = new Padding(6, 0, 6, 0);
            lblSendCount.MinimumSize = new Size(183, 0);
            lblSendCount.Name = "lblSendCount";
            lblSendCount.Padding = new Padding(4);
            lblSendCount.Size = new Size(183, 34);
            lblSendCount.TabIndex = 11;
            lblSendCount.Text = "发送:0";
            lblSendCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ComDevice
            // 
            ComDevice.BaudRate = 9600;
            ComDevice.DataBits = 8;
            ComDevice.DiscardNull = false;
            ComDevice.DtrEnable = false;
            ComDevice.Encoding = asciiEncoding1;
            ComDevice.Handshake = System.IO.Ports.Handshake.None;
            ComDevice.NewLine = "\n";
            ComDevice.Parity = System.IO.Ports.Parity.None;
            ComDevice.ParityReplace = 63;
            ComDevice.PortName = "COM1";
            ComDevice.ReadBufferSize = 4096;
            ComDevice.ReadTimeout = 1000;
            ComDevice.ReceivedBytesThreshold = 1;
            ComDevice.RtsEnable = false;
            ComDevice.StopBits = System.IO.Ports.StopBits.One;
            ComDevice.WriteBufferSize = 2048;
            ComDevice.WriteTimeout = 1000;
            ComDevice.DataReceived += Com_DataReceived;
            // 
            // timerAutoSend
            // 
            timerAutoSend.Interval = 1;
            timerAutoSend.Tick += timerAutoSend_Tick;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(panel_ListSend);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(label6);
            groupBox6.Dock = DockStyle.Right;
            groupBox6.Location = new Point(1503, 0);
            groupBox6.Margin = new Padding(6);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(6);
            groupBox6.Size = new Size(339, 1098);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "多字符串发送";
            // 
            // panel_ListSend
            // 
            panel_ListSend.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_ListSend.AutoScroll = true;
            panel_ListSend.BackColor = Color.Transparent;
            panel_ListSend.Controls.Add(ListSend_Send0);
            panel_ListSend.Controls.Add(ListSend_Text0);
            panel_ListSend.Controls.Add(ListSend_Hex0);
            panel_ListSend.Location = new Point(7, 64);
            panel_ListSend.Margin = new Padding(6);
            panel_ListSend.Name = "panel_ListSend";
            panel_ListSend.Size = new Size(304, 320);
            panel_ListSend.TabIndex = 6;
            // 
            // ListSend_Send0
            // 
            ListSend_Send0.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ListSend_Send0.Location = new Point(0, 0);
            ListSend_Send0.Margin = new Padding(6);
            ListSend_Send0.Name = "ListSend_Send0";
            ListSend_Send0.Size = new Size(46, 42);
            ListSend_Send0.TabIndex = 0;
            ListSend_Send0.TabStop = false;
            ListSend_Send0.Text = "1";
            ListSend_Send0.UseVisualStyleBackColor = true;
            ListSend_Send0.Click += ListSendButton_Click;
            // 
            // ListSend_Text0
            // 
            ListSend_Text0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ListSend_Text0.Location = new Point(50, 0);
            ListSend_Text0.Margin = new Padding(6);
            ListSend_Text0.Name = "ListSend_Text0";
            ListSend_Text0.Size = new Size(198, 30);
            ListSend_Text0.TabIndex = 4;
            ListSend_Text0.TabStop = false;
            // 
            // ListSend_Hex0
            // 
            ListSend_Hex0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ListSend_Hex0.AutoSize = true;
            ListSend_Hex0.Location = new Point(266, 8);
            ListSend_Hex0.Margin = new Padding(6);
            ListSend_Hex0.Name = "ListSend_Hex0";
            ListSend_Hex0.Size = new Size(22, 21);
            ListSend_Hex0.TabIndex = 3;
            ListSend_Hex0.TabStop = false;
            toolTip1.SetToolTip(ListSend_Hex0, "选择:以Hex发送\r\n不选:以文本发送");
            ListSend_Hex0.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(226, 32);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 24);
            label7.TabIndex = 4;
            label7.Text = "HEX";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 32);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 24);
            label6.TabIndex = 3;
            label6.Text = "发送";
            // 
            // timerIcon
            // 
            timerIcon.Interval = 300;
            timerIcon.Tick += timerIcon_Tick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(205, 40);
            checkBox1.Margin = new Padding(6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 28);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "DTR";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(205, 84);
            checkBox2.Margin = new Padding(6);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(68, 28);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "RTS";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // LUART
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOpen;
            ClientSize = new Size(1842, 1146);
            Controls.Add(panel_Rec);
            Controls.Add(panel_Send);
            Controls.Add(panel_Setting);
            Controls.Add(groupBox6);
            Controls.Add(panel_Log);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "LUART";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "串口调试助手";
            FormClosing += LUART_FormClosing;
            panel_Setting.ResumeLayout(false);
            groupboxSendSetting.ResumeLayout(false);
            groupboxSendSetting.PerformLayout();
            groupboxRecSetting.ResumeLayout(false);
            groupboxRecSetting.PerformLayout();
            groupBoxComSetting.ResumeLayout(false);
            groupBoxComSetting.PerformLayout();
            panel_Rec.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel_Send.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel_Log.ResumeLayout(false);
            panel_Log.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panel_ListSend.ResumeLayout(false);
            panel_ListSend.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel_Setting;
        private System.Windows.Forms.Panel panel_Rec;
        private System.Windows.Forms.Panel panel_Send;
        private System.Windows.Forms.GroupBox groupBoxComSetting;
        private System.Windows.Forms.ComboBox cbbParity;
        private System.Windows.Forms.ComboBox cbbStopBits;
        private System.Windows.Forms.ComboBox cbbDataBits;
        private System.Windows.Forms.ComboBox cbbBaudRate;
        private System.Windows.Forms.ComboBox cbbComList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupboxRecSetting;
        private System.Windows.Forms.CheckBox chkAutoLine;
        private System.Windows.Forms.Panel panel_Log;
        private System.Windows.Forms.Label lblRevCount;
        private System.Windows.Forms.Label lblSendCount;
        private System.Windows.Forms.CheckBox chkShowTime;
        private System.IO.Ports.SerialPort ComDevice;
        private System.Windows.Forms.LinkLabel lkbSaveRev;
        private System.Windows.Forms.RadioButton rbtnUnicode;
        private System.Windows.Forms.RadioButton rbtnUTF8;
        private System.Windows.Forms.RadioButton rbtnASCII;
        private System.Windows.Forms.RadioButton rbtnHex;
        private System.Windows.Forms.GroupBox groupboxSendSetting;
        private System.Windows.Forms.LinkLabel lkbClearSend;
        private System.Windows.Forms.LinkLabel lkbClearRev;
        private System.Windows.Forms.LinkLabel lkbReadSend;
        private System.Windows.Forms.Button btnCleanCount;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.TextBox txtShowData;
        private System.Windows.Forms.RadioButton rbtnSendUnicode;
        private System.Windows.Forms.RadioButton rbtnSendHex;
        private System.Windows.Forms.RadioButton rbtnSendASCII;
        private System.Windows.Forms.RadioButton rbtnSendUTF8;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox chkAutoCleanSend;
        private System.Windows.Forms.CheckBox chkAutoSend;
        private System.Windows.Forms.CheckBox chkfromFileSend;
        private System.Windows.Forms.CheckBox chkAutoAddSend;
        private System.Windows.Forms.TextBox txtAutoSendms;
        private System.Windows.Forms.Timer timerAutoSend;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel_ListSend;
        private System.Windows.Forms.Button ListSend_Send0;
        private System.Windows.Forms.TextBox ListSend_Text0;
        private System.Windows.Forms.CheckBox ListSend_Hex0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkRecSend;
        private System.Windows.Forms.Timer timerIcon;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}

