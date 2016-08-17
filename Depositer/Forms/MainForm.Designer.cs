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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.reloginToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.exitToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.debtSettingToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.investToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.DebtAnalysisToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.EarlyBigPayToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Honeydew;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloginToolStripBtn,
            this.exitToolStripBtn,
            this.toolStripSeparator1,
            this.debtSettingToolStripBtn,
            this.investToolStripBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(325, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // reloginToolStripBtn
            // 
            this.reloginToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("reloginToolStripBtn.Image")));
            this.reloginToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloginToolStripBtn.Name = "reloginToolStripBtn";
            this.reloginToolStripBtn.Size = new System.Drawing.Size(76, 22);
            this.reloginToolStripBtn.Text = "重新登入";
            this.reloginToolStripBtn.Click += new System.EventHandler(this.reloginToolStripBtn_Click);
            // 
            // exitToolStripBtn
            // 
            this.exitToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripBtn.Image")));
            this.exitToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitToolStripBtn.Name = "exitToolStripBtn";
            this.exitToolStripBtn.Size = new System.Drawing.Size(52, 22);
            this.exitToolStripBtn.Text = "退出";
            this.exitToolStripBtn.Click += new System.EventHandler(this.exitToolStripBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // debtSettingToolStripBtn
            // 
            this.debtSettingToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("debtSettingToolStripBtn.Image")));
            this.debtSettingToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.debtSettingToolStripBtn.Name = "debtSettingToolStripBtn";
            this.debtSettingToolStripBtn.Size = new System.Drawing.Size(76, 22);
            this.debtSettingToolStripBtn.Text = "贷款设置";
            this.debtSettingToolStripBtn.Click += new System.EventHandler(this.debtSettingToolStripBtn_Click);
            // 
            // investToolStripBtn
            // 
            this.investToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("investToolStripBtn.Image")));
            this.investToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.investToolStripBtn.Name = "investToolStripBtn";
            this.investToolStripBtn.Size = new System.Drawing.Size(76, 22);
            this.investToolStripBtn.Text = "投资设置";
            this.investToolStripBtn.Click += new System.EventHandler(this.investToolStripBtn_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.PapayaWhip;
            this.toolStrip2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DebtAnalysisToolStripBtn,
            this.EarlyBigPayToolStripBtn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(325, 27);
            this.toolStrip2.TabIndex = 14;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // DebtAnalysisToolStripBtn
            // 
            this.DebtAnalysisToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("DebtAnalysisToolStripBtn.Image")));
            this.DebtAnalysisToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DebtAnalysisToolStripBtn.Name = "DebtAnalysisToolStripBtn";
            this.DebtAnalysisToolStripBtn.Size = new System.Drawing.Size(85, 24);
            this.DebtAnalysisToolStripBtn.Text = "贷款分析";
            this.DebtAnalysisToolStripBtn.Click += new System.EventHandler(this.DebtAnalysisToolStripBtn_Click);
            // 
            // EarlyBigPayToolStripBtn
            // 
            this.EarlyBigPayToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("EarlyBigPayToolStripBtn.Image")));
            this.EarlyBigPayToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EarlyBigPayToolStripBtn.Name = "EarlyBigPayToolStripBtn";
            this.EarlyBigPayToolStripBtn.Size = new System.Drawing.Size(85, 24);
            this.EarlyBigPayToolStripBtn.Text = "提前还贷";
            this.EarlyBigPayToolStripBtn.Click += new System.EventHandler(this.EarlyBigPayToolStripBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(325, 607);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "贷款分析";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.closeBtn, 0);
            this.Controls.SetChildIndex(this.toolStrip2, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton reloginToolStripBtn;
        private System.Windows.Forms.ToolStripButton exitToolStripBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton debtSettingToolStripBtn;
        private System.Windows.Forms.ToolStripButton investToolStripBtn;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton DebtAnalysisToolStripBtn;
        private System.Windows.Forms.ToolStripButton EarlyBigPayToolStripBtn;
    }
}

