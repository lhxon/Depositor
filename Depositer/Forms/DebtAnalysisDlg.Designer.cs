namespace Depositer.Forms
{
    partial class DebtAnalysisDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtAnalysisDlg));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paidDetailBtn = new System.Windows.Forms.Button();
            this.interTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.capTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.capInterTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.unPaidDetailBtn = new System.Windows.Forms.Button();
            this.unPaidInterTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unPaidCapTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.unPaidCapInterTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paidDetailBtn);
            this.groupBox1.Controls.Add(this.interTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.capTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.capInterTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已还";
            // 
            // paidDetailBtn
            // 
            this.paidDetailBtn.BackColor = System.Drawing.SystemColors.Info;
            this.paidDetailBtn.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.paidDetailBtn.FlatAppearance.BorderSize = 2;
            this.paidDetailBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paidDetailBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paidDetailBtn.Image = ((System.Drawing.Image)(resources.GetObject("paidDetailBtn.Image")));
            this.paidDetailBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.paidDetailBtn.Location = new System.Drawing.Point(262, 63);
            this.paidDetailBtn.Name = "paidDetailBtn";
            this.paidDetailBtn.Size = new System.Drawing.Size(37, 81);
            this.paidDetailBtn.TabIndex = 6;
            this.paidDetailBtn.Text = "  明细";
            this.paidDetailBtn.UseVisualStyleBackColor = false;
            this.paidDetailBtn.Click += new System.EventHandler(this.paidDetailBtn_Click);
            // 
            // interTxt
            // 
            this.interTxt.BackColor = System.Drawing.SystemColors.Info;
            this.interTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interTxt.Enabled = false;
            this.interTxt.Location = new System.Drawing.Point(108, 145);
            this.interTxt.Name = "interTxt";
            this.interTxt.Size = new System.Drawing.Size(100, 24);
            this.interTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "利息";
            // 
            // capTxt
            // 
            this.capTxt.BackColor = System.Drawing.SystemColors.Info;
            this.capTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capTxt.Enabled = false;
            this.capTxt.Location = new System.Drawing.Point(108, 93);
            this.capTxt.Name = "capTxt";
            this.capTxt.Size = new System.Drawing.Size(100, 24);
            this.capTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "本金";
            // 
            // capInterTxt
            // 
            this.capInterTxt.BackColor = System.Drawing.SystemColors.Info;
            this.capInterTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capInterTxt.Enabled = false;
            this.capInterTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.capInterTxt.Location = new System.Drawing.Point(108, 39);
            this.capInterTxt.Name = "capInterTxt";
            this.capInterTxt.Size = new System.Drawing.Size(100, 24);
            this.capInterTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "本息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.unPaidDetailBtn);
            this.groupBox2.Controls.Add(this.unPaidInterTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.unPaidCapTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.unPaidCapInterTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gold;
            this.groupBox2.Location = new System.Drawing.Point(2, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 182);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "未还";
            // 
            // unPaidDetailBtn
            // 
            this.unPaidDetailBtn.BackColor = System.Drawing.SystemColors.Info;
            this.unPaidDetailBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.unPaidDetailBtn.ForeColor = System.Drawing.Color.Gold;
            this.unPaidDetailBtn.Image = ((System.Drawing.Image)(resources.GetObject("unPaidDetailBtn.Image")));
            this.unPaidDetailBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.unPaidDetailBtn.Location = new System.Drawing.Point(260, 81);
            this.unPaidDetailBtn.Name = "unPaidDetailBtn";
            this.unPaidDetailBtn.Size = new System.Drawing.Size(37, 81);
            this.unPaidDetailBtn.TabIndex = 6;
            this.unPaidDetailBtn.Text = "   明细";
            this.unPaidDetailBtn.UseVisualStyleBackColor = false;
            this.unPaidDetailBtn.Click += new System.EventHandler(this.unPaidDetailBtn_Click);
            // 
            // unPaidInterTxt
            // 
            this.unPaidInterTxt.BackColor = System.Drawing.SystemColors.Info;
            this.unPaidInterTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unPaidInterTxt.Enabled = false;
            this.unPaidInterTxt.Location = new System.Drawing.Point(108, 145);
            this.unPaidInterTxt.Name = "unPaidInterTxt";
            this.unPaidInterTxt.Size = new System.Drawing.Size(100, 24);
            this.unPaidInterTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "利息";
            // 
            // unPaidCapTxt
            // 
            this.unPaidCapTxt.BackColor = System.Drawing.SystemColors.Info;
            this.unPaidCapTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unPaidCapTxt.Enabled = false;
            this.unPaidCapTxt.Location = new System.Drawing.Point(108, 93);
            this.unPaidCapTxt.Name = "unPaidCapTxt";
            this.unPaidCapTxt.Size = new System.Drawing.Size(100, 24);
            this.unPaidCapTxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "本金";
            // 
            // unPaidCapInterTxt
            // 
            this.unPaidCapInterTxt.BackColor = System.Drawing.SystemColors.Info;
            this.unPaidCapInterTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unPaidCapInterTxt.Enabled = false;
            this.unPaidCapInterTxt.ForeColor = System.Drawing.SystemColors.Info;
            this.unPaidCapInterTxt.Location = new System.Drawing.Point(108, 39);
            this.unPaidCapInterTxt.Name = "unPaidCapInterTxt";
            this.unPaidCapInterTxt.Size = new System.Drawing.Size(100, 24);
            this.unPaidCapInterTxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "本息";
            // 
            // DebtAnalysisDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(325, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DebtAnalysisDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DebtAnalysisDlg_Load);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.closeBtn, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button paidDetailBtn;
        private System.Windows.Forms.TextBox interTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox capTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox capInterTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button unPaidDetailBtn;
        private System.Windows.Forms.TextBox unPaidInterTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unPaidCapTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox unPaidCapInterTxt;
        private System.Windows.Forms.Label label6;
    }
}