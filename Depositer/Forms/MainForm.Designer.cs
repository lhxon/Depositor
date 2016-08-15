namespace Depositer.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reloginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debtSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DebtAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.投资分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.interestAgoLb = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.interestAfterLb = new System.Windows.Forms.Label();
            this.debtDgv2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.capAfterLb = new System.Windows.Forms.Label();
            this.capInterAfterLb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.debtDgv1 = new System.Windows.Forms.DataGridView();
            this.capAgoLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.capInterAgoLb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFilterDebt = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bigRepayAfterBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.bigRepayInterLb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bigRepayCapLb = new System.Windows.Forms.Label();
            this.bigRepayCapInterLb = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bigRepayDgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtDgv2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtDgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigRepayDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.设置ToolStripMenuItem,
            this.分析ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 24);
            this.toolStripMenuItem1.Text = "系统";
            // 
            // reloginToolStripMenuItem
            // 
            this.reloginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloginToolStripMenuItem.Image")));
            this.reloginToolStripMenuItem.Name = "reloginToolStripMenuItem";
            this.reloginToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.reloginToolStripMenuItem.Text = "重新登入";
            this.reloginToolStripMenuItem.Click += new System.EventHandler(this.reloginToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debtSettingToolStripMenuItem,
            this.incomeSettingToolStripMenuItem});
            this.设置ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("设置ToolStripMenuItem.Image")));
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // debtSettingToolStripMenuItem
            // 
            this.debtSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("debtSettingToolStripMenuItem.Image")));
            this.debtSettingToolStripMenuItem.Name = "debtSettingToolStripMenuItem";
            this.debtSettingToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.debtSettingToolStripMenuItem.Text = "贷款设置";
            this.debtSettingToolStripMenuItem.Click += new System.EventHandler(this.debtSettingToolStripMenuItem_Click);
            // 
            // incomeSettingToolStripMenuItem
            // 
            this.incomeSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("incomeSettingToolStripMenuItem.Image")));
            this.incomeSettingToolStripMenuItem.Name = "incomeSettingToolStripMenuItem";
            this.incomeSettingToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.incomeSettingToolStripMenuItem.Text = "投资设置";
            this.incomeSettingToolStripMenuItem.Click += new System.EventHandler(this.incomeSettingToolStripMenuItem_Click);
            // 
            // 分析ToolStripMenuItem
            // 
            this.分析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DebtAnalysisToolStripMenuItem,
            this.投资分析ToolStripMenuItem});
            this.分析ToolStripMenuItem.Name = "分析ToolStripMenuItem";
            this.分析ToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.分析ToolStripMenuItem.Text = "分析";
            // 
            // DebtAnalysisToolStripMenuItem
            // 
            this.DebtAnalysisToolStripMenuItem.Name = "DebtAnalysisToolStripMenuItem";
            this.DebtAnalysisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DebtAnalysisToolStripMenuItem.Text = "还贷分析";
            this.DebtAnalysisToolStripMenuItem.Click += new System.EventHandler(this.debtAnalysisToolStripMenuItem_Click);
            // 
            // 投资分析ToolStripMenuItem
            // 
            this.投资分析ToolStripMenuItem.Name = "投资分析ToolStripMenuItem";
            this.投资分析ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.投资分析ToolStripMenuItem.Text = "投资分析";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.interestAgoLb);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.capAgoLb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.capInterAgoLb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 380);
            this.panel1.TabIndex = 5;
            // 
            // interestAgoLb
            // 
            this.interestAgoLb.AutoSize = true;
            this.interestAgoLb.ForeColor = System.Drawing.Color.Blue;
            this.interestAgoLb.Location = new System.Drawing.Point(331, 170);
            this.interestAgoLb.Name = "interestAgoLb";
            this.interestAgoLb.Size = new System.Drawing.Size(32, 17);
            this.interestAgoLb.TabIndex = 10;
            this.interestAgoLb.Text = "利息";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.interestAfterLb);
            this.groupBox3.Controls.Add(this.debtDgv2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.capAfterLb);
            this.groupBox3.Controls.Add(this.capInterAfterLb);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 176);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "待还本息";
            // 
            // interestAfterLb
            // 
            this.interestAfterLb.AutoSize = true;
            this.interestAfterLb.ForeColor = System.Drawing.Color.Blue;
            this.interestAfterLb.Location = new System.Drawing.Point(340, 152);
            this.interestAfterLb.Name = "interestAfterLb";
            this.interestAfterLb.Size = new System.Drawing.Size(32, 17);
            this.interestAfterLb.TabIndex = 16;
            this.interestAfterLb.Text = "利息";
            // 
            // debtDgv2
            // 
            this.debtDgv2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.debtDgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debtDgv2.Dock = System.Windows.Forms.DockStyle.Top;
            this.debtDgv2.Location = new System.Drawing.Point(3, 19);
            this.debtDgv2.Name = "debtDgv2";
            this.debtDgv2.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            this.debtDgv2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.debtDgv2.RowTemplate.Height = 23;
            this.debtDgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.debtDgv2.ShowEditingIcon = false;
            this.debtDgv2.Size = new System.Drawing.Size(385, 130);
            this.debtDgv2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "待还利息：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "待还本息：";
            // 
            // capAfterLb
            // 
            this.capAfterLb.AutoSize = true;
            this.capAfterLb.ForeColor = System.Drawing.Color.Green;
            this.capAfterLb.Location = new System.Drawing.Point(221, 152);
            this.capAfterLb.Name = "capAfterLb";
            this.capAfterLb.Size = new System.Drawing.Size(32, 17);
            this.capAfterLb.TabIndex = 14;
            this.capAfterLb.Text = "本金";
            // 
            // capInterAfterLb
            // 
            this.capInterAfterLb.AutoSize = true;
            this.capInterAfterLb.ForeColor = System.Drawing.Color.Red;
            this.capInterAfterLb.Location = new System.Drawing.Point(83, 152);
            this.capInterAfterLb.Name = "capInterAfterLb";
            this.capInterAfterLb.Size = new System.Drawing.Size(32, 17);
            this.capInterAfterLb.TabIndex = 12;
            this.capInterAfterLb.Text = "本息";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "待还本金：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "共还利息：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.debtDgv1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 170);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已还本息";
            // 
            // debtDgv1
            // 
            this.debtDgv1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.debtDgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debtDgv1.Dock = System.Windows.Forms.DockStyle.Top;
            this.debtDgv1.Location = new System.Drawing.Point(3, 19);
            this.debtDgv1.Name = "debtDgv1";
            this.debtDgv1.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            this.debtDgv1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.debtDgv1.RowTemplate.Height = 23;
            this.debtDgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.debtDgv1.ShowEditingIcon = false;
            this.debtDgv1.Size = new System.Drawing.Size(385, 145);
            this.debtDgv1.TabIndex = 1;
            // 
            // capAgoLb
            // 
            this.capAgoLb.AutoSize = true;
            this.capAgoLb.ForeColor = System.Drawing.Color.Green;
            this.capAgoLb.Location = new System.Drawing.Point(212, 170);
            this.capAgoLb.Name = "capAgoLb";
            this.capAgoLb.Size = new System.Drawing.Size(32, 17);
            this.capAgoLb.TabIndex = 8;
            this.capAgoLb.Text = "本金";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "共还本息：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "共还本金：";
            // 
            // capInterAgoLb
            // 
            this.capInterAgoLb.AutoSize = true;
            this.capInterAgoLb.ForeColor = System.Drawing.Color.Red;
            this.capInterAgoLb.Location = new System.Drawing.Point(74, 170);
            this.capInterAgoLb.Name = "capInterAgoLb";
            this.capInterAgoLb.Size = new System.Drawing.Size(32, 17);
            this.capInterAgoLb.TabIndex = 6;
            this.capInterAgoLb.Text = "本息";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.checkBoxFilterDebt);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 435);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "贷款分析";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "~";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(187, 23);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(87, 23);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // checkBoxFilterDebt
            // 
            this.checkBoxFilterDebt.AutoSize = true;
            this.checkBoxFilterDebt.Location = new System.Drawing.Point(13, 23);
            this.checkBoxFilterDebt.Name = "checkBoxFilterDebt";
            this.checkBoxFilterDebt.Size = new System.Drawing.Size(51, 21);
            this.checkBoxFilterDebt.TabIndex = 6;
            this.checkBoxFilterDebt.Text = "筛选";
            this.checkBoxFilterDebt.UseVisualStyleBackColor = true;
            this.checkBoxFilterDebt.CheckedChanged += new System.EventHandler(this.checkBoxFilterDebt_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(493, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 222);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "大额还款前后对比";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightYellow;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 19);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(391, 200);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // bigRepayAfterBtn
            // 
            this.bigRepayAfterBtn.BackColor = System.Drawing.SystemColors.Control;
            this.bigRepayAfterBtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigRepayAfterBtn.Location = new System.Drawing.Point(405, 372);
            this.bigRepayAfterBtn.Name = "bigRepayAfterBtn";
            this.bigRepayAfterBtn.Size = new System.Drawing.Size(77, 23);
            this.bigRepayAfterBtn.TabIndex = 7;
            this.bigRepayAfterBtn.Text = "大额还款>>";
            this.bigRepayAfterBtn.UseVisualStyleBackColor = false;
            this.bigRepayAfterBtn.Click += new System.EventHandler(this.bigRepayAfterBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "一次性还清",
            "仅缩短期限",
            "仅减少月供",
            "缩期减月供",
            "本金不变缩期"});
            this.comboBox1.Location = new System.Drawing.Point(405, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "大额还款方式";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox10.Controls.Add(this.bigRepayInterLb);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.label10);
            this.groupBox10.Controls.Add(this.bigRepayCapLb);
            this.groupBox10.Controls.Add(this.bigRepayCapInterLb);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.bigRepayDgv);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(496, 286);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(391, 180);
            this.groupBox10.TabIndex = 12;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "大额还款后";
            // 
            // bigRepayInterLb
            // 
            this.bigRepayInterLb.AutoSize = true;
            this.bigRepayInterLb.ForeColor = System.Drawing.Color.Blue;
            this.bigRepayInterLb.Location = new System.Drawing.Point(340, 154);
            this.bigRepayInterLb.Name = "bigRepayInterLb";
            this.bigRepayInterLb.Size = new System.Drawing.Size(30, 16);
            this.bigRepayInterLb.TabIndex = 28;
            this.bigRepayInterLb.Text = "利息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "待还利息：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "待还本息：";
            // 
            // bigRepayCapLb
            // 
            this.bigRepayCapLb.AutoSize = true;
            this.bigRepayCapLb.ForeColor = System.Drawing.Color.Green;
            this.bigRepayCapLb.Location = new System.Drawing.Point(221, 154);
            this.bigRepayCapLb.Name = "bigRepayCapLb";
            this.bigRepayCapLb.Size = new System.Drawing.Size(30, 16);
            this.bigRepayCapLb.TabIndex = 26;
            this.bigRepayCapLb.Text = "本金";
            // 
            // bigRepayCapInterLb
            // 
            this.bigRepayCapInterLb.AutoSize = true;
            this.bigRepayCapInterLb.ForeColor = System.Drawing.Color.Red;
            this.bigRepayCapInterLb.Location = new System.Drawing.Point(83, 154);
            this.bigRepayCapInterLb.Name = "bigRepayCapInterLb";
            this.bigRepayCapInterLb.Size = new System.Drawing.Size(30, 16);
            this.bigRepayCapInterLb.TabIndex = 24;
            this.bigRepayCapInterLb.Text = "本息";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(152, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "待还本金：";
            // 
            // bigRepayDgv
            // 
            this.bigRepayDgv.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.bigRepayDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bigRepayDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.bigRepayDgv.Location = new System.Drawing.Point(3, 17);
            this.bigRepayDgv.Name = "bigRepayDgv";
            this.bigRepayDgv.RowHeadersVisible = false;
            this.bigRepayDgv.RowTemplate.Height = 23;
            this.bigRepayDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bigRepayDgv.ShowEditingIcon = false;
            this.bigRepayDgv.Size = new System.Drawing.Size(385, 129);
            this.bigRepayDgv.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(890, 471);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bigRepayAfterBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "还投决策器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtDgv2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.debtDgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigRepayDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reloginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debtSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomeSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DebtAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 投资分析ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxFilterDebt;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView debtDgv2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView debtDgv1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bigRepayAfterBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label capInterAgoLb;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DataGridView bigRepayDgv;
        private System.Windows.Forms.Label interestAgoLb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label capAgoLb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label interestAfterLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label capAfterLb;
        private System.Windows.Forms.Label capInterAfterLb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label bigRepayInterLb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label bigRepayCapLb;
        private System.Windows.Forms.Label bigRepayCapInterLb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

