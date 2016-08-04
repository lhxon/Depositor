namespace Depositer.Forms
{
    partial class BaseDlg
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeLengthTxt = new System.Windows.Forms.TextBox();
            this.dayRadioBtn = new System.Windows.Forms.RadioButton();
            this.monthRadioBtn = new System.Windows.Forms.RadioButton();
            this.yearRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Cyan;
            this.saveButton.Location = new System.Drawing.Point(65, 320);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 31);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Cyan;
            this.cancelButton.Location = new System.Drawing.Point(222, 322);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 31);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 85);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "时长设置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "时长";
            // 
            // TimeLengthTxt
            // 
            this.TimeLengthTxt.Location = new System.Drawing.Point(75, 52);
            this.TimeLengthTxt.Name = "TimeLengthTxt";
            this.TimeLengthTxt.Size = new System.Drawing.Size(218, 21);
            this.TimeLengthTxt.TabIndex = 6;
            // 
            // dayRadioBtn
            // 
            this.dayRadioBtn.AutoSize = true;
            this.dayRadioBtn.Location = new System.Drawing.Point(248, 21);
            this.dayRadioBtn.Name = "dayRadioBtn";
            this.dayRadioBtn.Size = new System.Drawing.Size(35, 16);
            this.dayRadioBtn.TabIndex = 2;
            this.dayRadioBtn.TabStop = true;
            this.dayRadioBtn.Text = "日";
            this.dayRadioBtn.UseVisualStyleBackColor = true;
            this.dayRadioBtn.CheckedChanged += new System.EventHandler(this.dayRadioBtn_CheckedChanged);
            // 
            // monthRadioBtn
            // 
            this.monthRadioBtn.AutoSize = true;
            this.monthRadioBtn.Location = new System.Drawing.Point(156, 20);
            this.monthRadioBtn.Name = "monthRadioBtn";
            this.monthRadioBtn.Size = new System.Drawing.Size(35, 16);
            this.monthRadioBtn.TabIndex = 1;
            this.monthRadioBtn.TabStop = true;
            this.monthRadioBtn.Text = "月";
            this.monthRadioBtn.UseVisualStyleBackColor = true;
            this.monthRadioBtn.CheckedChanged += new System.EventHandler(this.monthRadioBtn_CheckedChanged);
            // 
            // yearRadioBtn
            // 
            this.yearRadioBtn.AutoSize = true;
            this.yearRadioBtn.Location = new System.Drawing.Point(75, 20);
            this.yearRadioBtn.Name = "yearRadioBtn";
            this.yearRadioBtn.Size = new System.Drawing.Size(35, 16);
            this.yearRadioBtn.TabIndex = 0;
            this.yearRadioBtn.TabStop = true;
            this.yearRadioBtn.Text = "年";
            this.yearRadioBtn.UseVisualStyleBackColor = true;
            this.yearRadioBtn.CheckedChanged += new System.EventHandler(this.yearRadioBtn_CheckedChanged);
            // 
            // BaseDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(385, 363);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.MaximizeBox = false;
            this.Name = "BaseDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox TimeLengthTxt;
        private System.Windows.Forms.RadioButton dayRadioBtn;
        private System.Windows.Forms.RadioButton monthRadioBtn;
        private System.Windows.Forms.RadioButton yearRadioBtn;
    }
}