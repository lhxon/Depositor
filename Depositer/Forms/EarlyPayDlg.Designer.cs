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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(98, 567);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(296, 567);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // shortTimeRB
            // 
            this.shortTimeRB.AutoSize = true;
            this.shortTimeRB.Checked = true;
            this.shortTimeRB.Location = new System.Drawing.Point(86, 31);
            this.shortTimeRB.Margin = new System.Windows.Forms.Padding(4);
            this.shortTimeRB.Name = "shortTimeRB";
            this.shortTimeRB.Size = new System.Drawing.Size(120, 24);
            this.shortTimeRB.TabIndex = 1;
            this.shortTimeRB.TabStop = true;
            this.shortTimeRB.Text = "缩短贷款时间";
            this.shortTimeRB.UseVisualStyleBackColor = true;
            this.shortTimeRB.CheckedChanged += new System.EventHandler(this.shortTimeRB_CheckedChanged);
            // 
            // shortMonthMoneyRB
            // 
            this.shortMonthMoneyRB.AutoSize = true;
            this.shortMonthMoneyRB.Location = new System.Drawing.Point(237, 25);
            this.shortMonthMoneyRB.Margin = new System.Windows.Forms.Padding(4);
            this.shortMonthMoneyRB.Name = "shortMonthMoneyRB";
            this.shortMonthMoneyRB.Size = new System.Drawing.Size(120, 24);
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
            this.groupBox1.Location = new System.Drawing.Point(1, 182);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(419, 346);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "提前还贷后";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Info;
            chartArea1.BackColor = System.Drawing.SystemColors.Info;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.Info;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 15F;
            legend1.Position.Width = 30F;
            legend1.Position.X = 69.5F;
            legend1.Position.Y = 3F;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 209);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(413, 145);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // savedInterestTxt
            // 
            this.savedInterestTxt.BackColor = System.Drawing.SystemColors.Info;
            this.savedInterestTxt.Enabled = false;
            this.savedInterestTxt.Location = new System.Drawing.Point(154, 154);
            this.savedInterestTxt.Margin = new System.Windows.Forms.Padding(4);
            this.savedInterestTxt.Name = "savedInterestTxt";
            this.savedInterestTxt.Size = new System.Drawing.Size(127, 27);
            this.savedInterestTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
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
            this.paidDetailBtn.Location = new System.Drawing.Point(332, 56);
            this.paidDetailBtn.Margin = new System.Windows.Forms.Padding(4);
            this.paidDetailBtn.Name = "paidDetailBtn";
            this.paidDetailBtn.Size = new System.Drawing.Size(48, 99);
            this.paidDetailBtn.TabIndex = 6;
            this.paidDetailBtn.Text = "   明 细";
            this.paidDetailBtn.UseVisualStyleBackColor = false;
            this.paidDetailBtn.Click += new System.EventHandler(this.paidDetailBtn_Click);
            // 
            // interTxt
            // 
            this.interTxt.BackColor = System.Drawing.SystemColors.Info;
            this.interTxt.Enabled = false;
            this.interTxt.Location = new System.Drawing.Point(154, 114);
            this.interTxt.Margin = new System.Windows.Forms.Padding(4);
            this.interTxt.Name = "interTxt";
            this.interTxt.Size = new System.Drawing.Size(127, 27);
            this.interTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "剩余利息";
            // 
            // capTxt
            // 
            this.capTxt.BackColor = System.Drawing.SystemColors.Info;
            this.capTxt.Enabled = false;
            this.capTxt.Location = new System.Drawing.Point(154, 73);
            this.capTxt.Margin = new System.Windows.Forms.Padding(4);
            this.capTxt.Name = "capTxt";
            this.capTxt.Size = new System.Drawing.Size(127, 27);
            this.capTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "剩余本金";
            // 
            // capInterTxt
            // 
            this.capInterTxt.BackColor = System.Drawing.SystemColors.Info;
            this.capInterTxt.Enabled = false;
            this.capInterTxt.Location = new System.Drawing.Point(154, 31);
            this.capInterTxt.Margin = new System.Windows.Forms.Padding(4);
            this.capInterTxt.Name = "capInterTxt";
            this.capInterTxt.Size = new System.Drawing.Size(127, 27);
            this.capInterTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "剩余本息";
            // 
            // calcuBtn
            // 
            this.calcuBtn.BackColor = System.Drawing.SystemColors.Info;
            this.calcuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcuBtn.ForeColor = System.Drawing.Color.Red;
            this.calcuBtn.Location = new System.Drawing.Point(13, 109);
            this.calcuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.calcuBtn.Name = "calcuBtn";
            this.calcuBtn.Size = new System.Drawing.Size(394, 31);
            this.calcuBtn.TabIndex = 4;
            this.calcuBtn.Text = "计             算";
            this.calcuBtn.UseVisualStyleBackColor = false;
            this.calcuBtn.Click += new System.EventHandler(this.calcuBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.shortTimeRB);
            this.groupBox2.Controls.Add(this.shortMonthMoneyRB);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 71);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "提前还贷方法";
            // 
            // EarlyPayDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(420, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.calcuBtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "EarlyPayDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BigPayForm";
            this.Load += new System.EventHandler(this.EarlyPayDlg_Load);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.closeBtn, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.calcuBtn, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
    }
}