namespace Shadowsocks.View
{
    partial class VPNLoginForm
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.labUser = new System.Windows.Forms.Label();
            this.labPsw = new System.Windows.Forms.Label();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(63, 23);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 21);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(13, 26);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(41, 12);
            this.labUser.TabIndex = 1;
            this.labUser.Text = "用户名";
            // 
            // labPsw
            // 
            this.labPsw.AutoSize = true;
            this.labPsw.Location = new System.Drawing.Point(13, 71);
            this.labPsw.Name = "labPsw";
            this.labPsw.Size = new System.Drawing.Size(29, 12);
            this.labPsw.TabIndex = 2;
            this.labPsw.Text = "密码";
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(63, 68);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(200, 21);
            this.txtPsw.TabIndex = 3;
            this.txtPsw.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(193, 118);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(70, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // VPNLoginForm
            // 
            this.ClientSize = new System.Drawing.Size(289, 164);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.labPsw);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VPNLoginForm";
            this.Text = "游学VPN登录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VPNLoginForm_FormClosed);
            this.Load += new System.EventHandler(this.VPNLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labPsw;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Button btnLogin;
    }
}
