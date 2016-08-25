namespace Depositer.Forms
{
    partial class BaseSettingDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseSettingDlg));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeLengthTxt = new System.Windows.Forms.TextBox();
            this.dayRadioBtn = new System.Windows.Forms.RadioButton();
            this.monthRadioBtn = new System.Windows.Forms.RadioButton();
            this.yearRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TimeLengthTxt);
            this.groupBox2.Controls.Add(this.dayRadioBtn);
            this.groupBox2.Controls.Add(this.monthRadioBtn);
            this.groupBox2.Controls.Add(this.yearRadioBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(325, 120);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "时长设置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "时长";
            // 
            // TimeLengthTxt
            // 
            this.TimeLengthTxt.Location = new System.Drawing.Point(87, 74);
            this.TimeLengthTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimeLengthTxt.Name = "TimeLengthTxt";
            this.TimeLengthTxt.Size = new System.Drawing.Size(100, 23);
            this.TimeLengthTxt.TabIndex = 6;
            // 
            // dayRadioBtn
            // 
            this.dayRadioBtn.AutoSize = true;
            this.dayRadioBtn.Location = new System.Drawing.Point(238, 30);
            this.dayRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dayRadioBtn.Name = "dayRadioBtn";
            this.dayRadioBtn.Size = new System.Drawing.Size(38, 21);
            this.dayRadioBtn.TabIndex = 2;
            this.dayRadioBtn.TabStop = true;
            this.dayRadioBtn.Text = "日";
            this.dayRadioBtn.UseVisualStyleBackColor = true;
            this.dayRadioBtn.CheckedChanged += new System.EventHandler(this.dayRadioBtn_CheckedChanged);
            // 
            // monthRadioBtn
            // 
            this.monthRadioBtn.AutoSize = true;
            this.monthRadioBtn.Location = new System.Drawing.Point(131, 28);
            this.monthRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.monthRadioBtn.Name = "monthRadioBtn";
            this.monthRadioBtn.Size = new System.Drawing.Size(38, 21);
            this.monthRadioBtn.TabIndex = 1;
            this.monthRadioBtn.TabStop = true;
            this.monthRadioBtn.Text = "月";
            this.monthRadioBtn.UseVisualStyleBackColor = true;
            this.monthRadioBtn.CheckedChanged += new System.EventHandler(this.monthRadioBtn_CheckedChanged);
            // 
            // yearRadioBtn
            // 
            this.yearRadioBtn.AutoSize = true;
            this.yearRadioBtn.Location = new System.Drawing.Point(36, 28);
            this.yearRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yearRadioBtn.Name = "yearRadioBtn";
            this.yearRadioBtn.Size = new System.Drawing.Size(38, 21);
            this.yearRadioBtn.TabIndex = 0;
            this.yearRadioBtn.TabStop = true;
            this.yearRadioBtn.Text = "年";
            this.yearRadioBtn.UseVisualStyleBackColor = true;
            this.yearRadioBtn.CheckedChanged += new System.EventHandler(this.yearRadioBtn_CheckedChanged);
            // 
            // BaseSettingDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(325, 500);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BaseSettingDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.closeBtn, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox TimeLengthTxt;
        protected System.Windows.Forms.RadioButton dayRadioBtn;
        protected System.Windows.Forms.RadioButton monthRadioBtn;
        protected System.Windows.Forms.RadioButton yearRadioBtn;
    }
}