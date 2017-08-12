namespace Shadowsocks.View
{
    partial class VPNPACForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gpPAC = new System.Windows.Forms.GroupBox();
            this.dgPAC = new System.Windows.Forms.DataGridView();
            this.gpPAC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPAC)).BeginInit();
            this.SuspendLayout();
            // 
            // gpPAC
            // 
            this.gpPAC.Controls.Add(this.dgPAC);
            this.gpPAC.Location = new System.Drawing.Point(5, 68);
            this.gpPAC.Name = "gpPAC";
            this.gpPAC.Size = new System.Drawing.Size(555, 382);
            this.gpPAC.TabIndex = 1;
            this.gpPAC.TabStop = false;
            this.gpPAC.Text = "VPN 代理列表";
            // 
            // dgPAC
            // 
            this.dgPAC.AllowUserToOrderColumns = true;
            this.dgPAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPAC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPAC.Location = new System.Drawing.Point(3, 17);
            this.dgPAC.Name = "dgPAC";
            this.dgPAC.RowTemplate.Height = 23;
            this.dgPAC.Size = new System.Drawing.Size(549, 362);
            this.dgPAC.TabIndex = 2;
            // 
            // VPNPACForm
            // 
            this.ClientSize = new System.Drawing.Size(572, 462);
            this.Controls.Add(this.gpPAC);
            this.Name = "VPNPACForm";
            this.Load += new System.EventHandler(this.VPNPACForm_Load);
            this.gpPAC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPAC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpPAC;
        private System.Windows.Forms.DataGridView dgPAC;
    }
}
