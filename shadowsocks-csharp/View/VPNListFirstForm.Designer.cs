namespace Shadowsocks.View
{
    partial class VPNListFirstForm
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.dgVPN = new System.Windows.Forms.DataGridView();
            this.labInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAS = new System.Windows.Forms.RadioButton();
            this.rdEU = new System.Windows.Forms.RadioButton();
            this.rdUS = new System.Windows.Forms.RadioButton();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVPN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(438, 398);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(124, 31);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "连接所选VPN服务器";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // dgVPN
            // 
            this.dgVPN.AllowUserToAddRows = false;
            this.dgVPN.AllowUserToDeleteRows = false;
            this.dgVPN.AllowUserToOrderColumns = true;
            this.dgVPN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgVPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.country,
            this.fuhe,
            this.IP,
            this.stat});
            this.dgVPN.Location = new System.Drawing.Point(12, 63);
            this.dgVPN.MultiSelect = false;
            this.dgVPN.Name = "dgVPN";
            this.dgVPN.ReadOnly = true;
            this.dgVPN.RowTemplate.Height = 23;
            this.dgVPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVPN.Size = new System.Drawing.Size(550, 317);
            this.dgVPN.TabIndex = 11;
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Location = new System.Drawing.Point(12, 398);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(77, 12);
            this.labInfo.TabIndex = 13;
            this.labInfo.Text = "账户到期日：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdAS);
            this.groupBox1.Controls.Add(this.rdEU);
            this.groupBox1.Controls.Add(this.rdUS);
            this.groupBox1.Location = new System.Drawing.Point(14, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 53);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器列表";
            // 
            // rdAS
            // 
            this.rdAS.AutoSize = true;
            this.rdAS.Location = new System.Drawing.Point(314, 20);
            this.rdAS.Name = "rdAS";
            this.rdAS.Size = new System.Drawing.Size(107, 16);
            this.rdAS.TabIndex = 13;
            this.rdAS.TabStop = true;
            this.rdAS.Text = "亚太地区服务器";
            this.rdAS.UseVisualStyleBackColor = true;
            this.rdAS.Enter += new System.EventHandler(this.rdAS_Enter);
            // 
            // rdEU
            // 
            this.rdEU.AutoSize = true;
            this.rdEU.Location = new System.Drawing.Point(164, 20);
            this.rdEU.Name = "rdEU";
            this.rdEU.Size = new System.Drawing.Size(83, 16);
            this.rdEU.TabIndex = 14;
            this.rdEU.TabStop = true;
            this.rdEU.Text = "欧洲服务器";
            this.rdEU.UseVisualStyleBackColor = true;
            this.rdEU.Enter += new System.EventHandler(this.rdEU_Enter);
            // 
            // rdUS
            // 
            this.rdUS.AutoSize = true;
            this.rdUS.Location = new System.Drawing.Point(20, 20);
            this.rdUS.Name = "rdUS";
            this.rdUS.Size = new System.Drawing.Size(83, 16);
            this.rdUS.TabIndex = 15;
            this.rdUS.TabStop = true;
            this.rdUS.Text = "美国服务器";
            this.rdUS.UseVisualStyleBackColor = true;
            this.rdUS.Enter += new System.EventHandler(this.rdUS_Enter);
            // 
            // country
            // 
            this.country.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.country.HeaderText = "国家";
            this.country.Name = "country";
            this.country.ReadOnly = true;
            // 
            // fuhe
            // 
            this.fuhe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fuhe.HeaderText = "负载";
            this.fuhe.Name = "fuhe";
            this.fuhe.ReadOnly = true;
            // 
            // IP
            // 
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            this.IP.Visible = false;
            // 
            // stat
            // 
            this.stat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stat.HeaderText = "状态";
            this.stat.Name = "stat";
            this.stat.ReadOnly = true;
            // 
            // VPNListFirstForm
            // 
            this.ClientSize = new System.Drawing.Size(574, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labInfo);
            this.Controls.Add(this.dgVPN);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VPNListFirstForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VPNListFirstForm_FormClosed);
            this.Load += new System.EventHandler(this.VPNListFirstForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVPN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridView dgVPN;
        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdAS;
        private System.Windows.Forms.RadioButton rdEU;
        private System.Windows.Forms.RadioButton rdUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat;
    }
}
