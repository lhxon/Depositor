﻿namespace Depositer.Forms
{
    partial class DetailDebtDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailDebtDlg));
            this.panel1 = new System.Windows.Forms.Panel();
            this.after12MonthBtn = new System.Windows.Forms.Button();
            this.before12MonthBtn = new System.Windows.Forms.Button();
            this.debtDgv1 = new System.Windows.Forms.DataGridView();
            this.pagenoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtDgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pagenoTxt);
            this.panel1.Controls.Add(this.after12MonthBtn);
            this.panel1.Controls.Add(this.before12MonthBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 53);
            this.panel1.TabIndex = 1;
            // 
            // after12MonthBtn
            // 
            this.after12MonthBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.after12MonthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.after12MonthBtn.Image = ((System.Drawing.Image)(resources.GetObject("after12MonthBtn.Image")));
            this.after12MonthBtn.Location = new System.Drawing.Point(234, 21);
            this.after12MonthBtn.Name = "after12MonthBtn";
            this.after12MonthBtn.Size = new System.Drawing.Size(58, 25);
            this.after12MonthBtn.TabIndex = 1;
            this.after12MonthBtn.UseVisualStyleBackColor = false;
            this.after12MonthBtn.Click += new System.EventHandler(this.after12MonthBtn_Click);
            // 
            // before12MonthBtn
            // 
            this.before12MonthBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.before12MonthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.before12MonthBtn.Image = ((System.Drawing.Image)(resources.GetObject("before12MonthBtn.Image")));
            this.before12MonthBtn.Location = new System.Drawing.Point(160, 21);
            this.before12MonthBtn.Name = "before12MonthBtn";
            this.before12MonthBtn.Size = new System.Drawing.Size(58, 25);
            this.before12MonthBtn.TabIndex = 0;
            this.before12MonthBtn.UseVisualStyleBackColor = false;
            this.before12MonthBtn.Click += new System.EventHandler(this.before12MonthBtn_Click);
            // 
            // debtDgv1
            // 
            this.debtDgv1.AllowUserToAddRows = false;
            this.debtDgv1.AllowUserToDeleteRows = false;
            this.debtDgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.debtDgv1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.debtDgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debtDgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.debtDgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debtDgv1.Location = new System.Drawing.Point(0, 59);
            this.debtDgv1.Name = "debtDgv1";
            this.debtDgv1.ReadOnly = true;
            this.debtDgv1.RowHeadersVisible = false;
            this.debtDgv1.RowTemplate.Height = 23;
            this.debtDgv1.Size = new System.Drawing.Size(325, 371);
            this.debtDgv1.TabIndex = 2;
            // 
            // pagenoTxt
            // 
            this.pagenoTxt.Location = new System.Drawing.Point(82, 25);
            this.pagenoTxt.Name = "pagenoTxt";
            this.pagenoTxt.Size = new System.Drawing.Size(51, 23);
            this.pagenoTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "当前页数：";
            // 
            // DetailDebtDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 500);
            this.ControlBox = true;
            this.Controls.Add(this.debtDgv1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailDebtDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "明细";
            this.Load += new System.EventHandler(this.PaidDetailDebtDlg_Load);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.closeBtn, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.debtDgv1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtDgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button before12MonthBtn;
        private System.Windows.Forms.Button after12MonthBtn;
        private System.Windows.Forms.DataGridView debtDgv1;
        private System.Windows.Forms.TextBox pagenoTxt;
        private System.Windows.Forms.Label label1;
    }
}