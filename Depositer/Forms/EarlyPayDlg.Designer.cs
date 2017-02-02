namespace Depositer.Forms
{
    partial class EarlyPayDlg
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EarlyPayDlg));
            this.shortTimeRB = new System.Windows.Forms.RadioButton();
            this.shortMonthMoneyRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.savedInterestTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paidDetailBtn = new System.Windows.Forms.Button();
            this.interTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.capTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.capInterTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calcuBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.planBigRepayTimeDTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.planBigPayAmountTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(76, 482);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(230, 482);
            // 
            // shortTimeRB
            // 
            this.shortTimeRB.AutoSize = true;
            this.shortTimeRB.Checked = true;
            this.shortTimeRB.Location = new System.Drawing.Point(35, 26);
            this.shortTimeRB.Name = "shortTimeRB";
            this.shortTimeRB.Size = new System.Drawing.Size(98, 21);
            this.shortTimeRB.TabIndex = 1;
            this.shortTimeRB.TabStop = true;
            this.shortTimeRB.Text = "缩短贷款时间";
            this.shortTimeRB.UseVisualStyleBackColor = true;
            this.shortTimeRB.CheckedChanged += new System.EventHandler(this.shortTimeRB_CheckedChanged);
            // 
            // shortMonthMoneyRB
            // 
            this.shortMonthMoneyRB.AutoSize = true;
            this.shortMonthMoneyRB.Location = new System.Drawing.Point(189, 26);
            this.shortMonthMoneyRB.Name = "shortMonthMoneyRB";
            this.shortMonthMoneyRB.Size = new System.Drawing.Size(98, 21);
            this.shortMonthMoneyRB.TabIndex = 2;
            this.shortMonthMoneyRB.Text = "减少月供金额";
            this.shortMonthMoneyRB.UseVisualStyleBackColor = true;
            this.shortMonthMoneyRB.Visible = false;
            this.shortMonthMoneyRB.CheckedChanged += new System.EventHandler(this.shortMonthMoneyRB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Controls.Add(this.savedInterestTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.paidDetailBtn);
            this.groupBox1.Controls.Add(this.interTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.capTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.capInterTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 294);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "提前还贷后";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Info;
            chartArea2.BackColor = System.Drawing.SystemColors.Info;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.SystemColors.Info;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 15F;
            legend2.Position.Width = 30F;
            legend2.Position.X = 69.5F;
            legend2.Position.Y = 3F;
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 178);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(321, 123);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // savedInterestTxt
            // 
            this.savedInterestTxt.BackColor = System.Drawing.SystemColors.Info;
            this.savedInterestTxt.Enabled = false;
            this.savedInterestTxt.Location = new System.Drawing.Point(120, 131);
            this.savedInterestTxt.Name = "savedInterestTxt";
            this.savedInterestTxt.Size = new System.Drawing.Size(100, 23);
            this.savedInterestTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "节省利息";
            // 
            // paidDetailBtn
            // 
            this.paidDetailBtn.BackColor = System.Drawing.SystemColors.Info;
            this.paidDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paidDetailBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paidDetailBtn.Image = ((System.Drawing.Image)(resources.GetObject("paidDetailBtn.Image")));
            this.paidDetailBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.paidDetailBtn.Location = new System.Drawing.Point(258, 48);
            this.paidDetailBtn.Name = "paidDetailBtn";
            this.paidDetailBtn.Size = new System.Drawing.Size(37, 84);
            this.paidDetailBtn.TabIndex = 6;
            this.paidDetailBtn.Text = "   明 细";
            this.paidDetailBtn.UseVisualStyleBackColor = false;
            this.paidDetailBtn.Click += new System.EventHandler(this.paidDetailBtn_Click);
            // 
            // interTxt
            // 
            this.interTxt.BackColor = System.Drawing.SystemColors.Info;
            this.interTxt.Enabled = false;
            this.interTxt.Location = new System.Drawing.Point(120, 97);
            this.interTxt.Name = "interTxt";
            this.interTxt.Size = new System.Drawing.Size(100, 23);
            this.interTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "剩余利息";
            // 
            // capTxt
            // 
            this.capTxt.BackColor = System.Drawing.SystemColors.Info;
            this.capTxt.Enabled = false;
            this.capTxt.Location = new System.Drawing.Point(120, 62);
            this.capTxt.Name = "capTxt";
            this.capTxt.Size = new System.Drawing.Size(100, 23);
            this.capTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "剩余本金";
            // 
            // capInterTxt
            // 
            this.capInterTxt.BackColor = System.Drawing.SystemColors.Info;
            this.capInterTxt.Enabled = false;
            this.capInterTxt.Location = new System.Drawing.Point(120, 26);
            this.capInterTxt.Name = "capInterTxt";
            this.capInterTxt.Size = new System.Drawing.Size(100, 23);
            this.capInterTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "剩余本息";
            // 
            // calcuBtn
            // 
            this.calcuBtn.BackColor = System.Drawing.SystemColors.Info;
            this.calcuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcuBtn.Location = new System.Drawing.Point(248, 131);
            this.calcuBtn.Name = "calcuBtn";
            this.calcuBtn.Size = new System.Drawing.Size(67, 28);
            this.calcuBtn.TabIndex = 4;
            this.calcuBtn.Text = "计  算";
            this.calcuBtn.UseVisualStyleBackColor = false;
            this.calcuBtn.Click += new System.EventHandler(this.calcuBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.shortTimeRB);
            this.groupBox2.Controls.Add(this.shortMonthMoneyRB);
            this.groupBox2.Location = new System.Drawing.Point(8, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(307, 51);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "提前还贷方法";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "预计还贷时间";
            // 
            // planBigRepayTimeDTP
            // 
            this.planBigRepayTimeDTP.CustomFormat = "yyyy-MM";
            this.planBigRepayTimeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.planBigRepayTimeDTP.Location = new System.Drawing.Point(104, 61);
            this.planBigRepayTimeDTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.planBigRepayTimeDTP.Name = "planBigRepayTimeDTP";
            this.planBigRepayTimeDTP.ShowUpDown = true;
            this.planBigRepayTimeDTP.Size = new System.Drawing.Size(121, 23);
            this.planBigRepayTimeDTP.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "预计还贷金额";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "（万）";
            // 
            // planBigPayAmountTxt
            // 
            this.planBigPayAmountTxt.Location = new System.Drawing.Point(104, 111);
            this.planBigPayAmountTxt.Name = "planBigPayAmountTxt";
            this.planBigPayAmountTxt.Size = new System.Drawing.Size(100, 23);
            this.planBigPayAmountTxt.TabIndex = 20;
            // 
            // EarlyPayDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(327, 588);
            this.Controls.Add(this.planBigPayAmountTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.planBigRepayTimeDTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calcuBtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EarlyPayDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BigPayForm";
            this.Load += new System.EventHandler(this.EarlyPayDlg_Load);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.closeBtn, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.calcuBtn, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.planBigRepayTimeDTP, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.planBigPayAmountTxt, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton shortTimeRB;
        private System.Windows.Forms.RadioButton shortMonthMoneyRB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button paidDetailBtn;
        private System.Windows.Forms.TextBox interTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox capTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox capInterTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcuBtn;
        private System.Windows.Forms.TextBox savedInterestTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker planBigRepayTimeDTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox planBigPayAmountTxt;
    }
}