using Shadowsocks.Controller;
using Shadowsocks.Controller.Hotkeys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shadowsocks.View
{
    public partial class VPNLoginForm : Form
    {
        LoginController logController;
        bool canExit = true;
        public VPNLoginForm(LoginController logController)
        {
            this.logController = logController;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (logController.Login(txtUser.Text, txtPsw.Text))
            {
                if(logController.getNetServers() == null)
                {

                }
                canExit = false;
                logController.CloseLogin();
                logController.ShowVPNList();
            }
            else
            {
                MessageBox.Show(I18N.GetString("login error"));
            }
        }

        private void VPNLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void VPNLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(canExit)
                Environment.Exit(0);
        }
    }
}
