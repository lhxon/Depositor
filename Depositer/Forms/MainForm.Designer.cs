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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.textBoxCapAfter = new System.Windows.Forms.TextBox();
            this.textBoxAgoScale = new System.Windows.Forms.TextBox();
            this.textBoxCapAgo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFilterDebt = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.debtDgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.debtDgv2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtDgv1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtDgv2)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(814, 28);
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
            this.DebtAnalysisToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.DebtAnalysisToolStripMenuItem.Text = "还贷分析";
            this.DebtAnalysisToolStripMenuItem.Click += new System.EventHandler(this.debtAnalysisToolStripMenuItem_Click);
            // 
            // 投资分析ToolStripMenuItem
            // 
            this.投资分析ToolStripMenuItem.Name = "投资分析ToolStripMenuItem";
            this.投资分析ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.投资分析ToolStripMenuItem.Text = "投资分析";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxCapAfter);
            this.panel1.Controls.Add(this.textBoxAgoScale);
            this.panel1.Controls.Add(this.textBoxCapAgo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 345);
            this.panel1.TabIndex = 5;
            // 
            // textBoxCapAfter
            // 
            this.textBoxCapAfter.Location = new System.Drawing.Point(323, 153);
            this.textBoxCapAfter.Multiline = true;
            this.textBoxCapAfter.Name = "textBoxCapAfter";
            this.textBoxCapAfter.Size = new System.Drawing.Size(65, 22);
            this.textBoxCapAfter.TabIndex = 4;
            // 
            // textBoxAgoScale
            // 
            this.textBoxAgoScale.Location = new System.Drawing.Point(211, 153);
            this.textBoxAgoScale.Multiline = true;
            this.textBoxAgoScale.Name = "textBoxAgoScale";
            this.textBoxAgoScale.Size = new System.Drawing.Size(44, 22);
            this.textBoxAgoScale.TabIndex = 3;
            // 
            // textBoxCapAgo
            // 
            this.textBoxCapAgo.Location = new System.Drawing.Point(68, 153);
            this.textBoxCapAgo.Multiline = true;
            this.textBoxCapAgo.Name = "textBoxCapAgo";
            this.textBoxCapAgo.Size = new System.Drawing.Size(59, 22);
            this.textBoxCapAgo.TabIndex = 2;
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
            this.groupBox1.Size = new System.Drawing.Size(397, 398);
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
            this.dateTimePicker2.Size = new System.Drawing.Size(87, 23);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "已还本息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "已还比例";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "待还本息";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.debtDgv1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 147);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已还本息";
            // 
            // debtDgv1
            // 
            this.debtDgv1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.debtDgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debtDgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debtDgv1.Location = new System.Drawing.Point(3, 19);
            this.debtDgv1.Name = "debtDgv1";
            this.debtDgv1.RowHeadersVisible = false;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LimeGreen;
            this.debtDgv1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.debtDgv1.RowTemplate.Height = 23;
            this.debtDgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.debtDgv1.ShowEditingIcon = false;
            this.debtDgv1.Size = new System.Drawing.Size(385, 125);
            this.debtDgv1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.debtDgv2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 167);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "待还本息";
            // 
            // debtDgv2
            // 
            this.debtDgv2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.debtDgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debtDgv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debtDgv2.Location = new System.Drawing.Point(3, 19);
            this.debtDgv2.Name = "debtDgv2";
            this.debtDgv2.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LimeGreen;
            this.debtDgv2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.debtDgv2.RowTemplate.Height = 23;
            this.debtDgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.debtDgv2.ShowEditingIcon = false;
            this.debtDgv2.Size = new System.Drawing.Size(385, 145);
            this.debtDgv2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(814, 434);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.debtDgv1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.debtDgv2)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxCapAgo;
        private System.Windows.Forms.TextBox textBoxCapAfter;
        private System.Windows.Forms.TextBox textBoxAgoScale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView debtDgv2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView debtDgv1;
    }
}

