namespace Depositer.Forms
{
    partial class InvestAnalysisDlg
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
            this.calInvestBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.capitalTxt = new System.Windows.Forms.TextBox();
            this.interestTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calInvestBtn
            // 
            this.calInvestBtn.BackColor = System.Drawing.Color.Transparent;
            this.calInvestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calInvestBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.calInvestBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.calInvestBtn.Location = new System.Drawing.Point(73, 31);
            this.calInvestBtn.Name = "calInvestBtn";
            this.calInvestBtn.Size = new System.Drawing.Size(258, 40);
            this.calInvestBtn.TabIndex = 18;
            this.calInvestBtn.Text = "分析盈利";
            this.calInvestBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.interestTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.capitalTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 129);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "收益分析";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "本金";
            // 
            // capitalTxt
            // 
            this.capitalTxt.Location = new System.Drawing.Point(120, 36);
            this.capitalTxt.Name = "capitalTxt";
            this.capitalTxt.Size = new System.Drawing.Size(156, 27);
            this.capitalTxt.TabIndex = 1;
            // 
            // interestTxt
            // 
            this.interestTxt.Location = new System.Drawing.Point(120, 88);
            this.interestTxt.Name = "interestTxt";
            this.interestTxt.Size = new System.Drawing.Size(156, 27);
            this.interestTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "收益";
            // 
            // InvestAnalysisDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calInvestBtn);
            this.Name = "InvestAnalysisDlg";
            this.Text = "InvestAnalysisForm";
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.closeBtn, 0);
            this.Controls.SetChildIndex(this.calInvestBtn, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calInvestBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox interestTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox capitalTxt;
        private System.Windows.Forms.Label label1;
    }
}