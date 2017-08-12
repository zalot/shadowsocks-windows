using Shadowsocks.Controller;
using Shadowsocks.Controller.Hotkeys;
using Shadowsocks.Model;
using Shadowsocks.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Shadowsocks.View
{
    public partial class VPNListFirstForm : Form
    {
        static MenuViewController _menu;
        static ShadowsocksController _main;

        bool canExit = true;
        public VPNListFirstForm(LoginController loginController)
        {
            InitializeComponent();
        }

        private void VPNListFirstForm_Load(object sender, EventArgs e)
        {
            rdUS.Select();
        }

        private List<Server> getSelectedServers()
        {
            List<Server> ss = new List<Server>();
            if (dgVPN.SelectedRows.Count > 0)
            {
                int st = dgVPN.SelectedRows[0].Index;
                
            }
            //cdg.sele
            return ss;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            List<Server> ss = getSelectedServers();
            NetServers.Selected = ss;
            if(ss.Count > 0)
            {
                canExit = false;
                if (_main == null)
                {
                    _main = new ShadowsocksController();
                }
                if (_menu == null)
                {
                    _main.Load();
                    _menu = new MenuViewController(_main);
                    HotKeys.Init(_main);
                }
                this.Close();
                _main.Start();
            }
        }

        private void VPNListFirstForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(canExit)
                Environment.Exit(0);
        }


        private void rdChanged(string type)
        {
            dgVPN.Rows.Clear();
            int c = 0;
#if DEBUG
            for (int x = 0; x < 10; x++)
            {
#endif
                List<Server> ss = Utils.getNetServersByType(type);
                foreach (Server s in ss)
                {
                    dgVPN.Rows.Add(I18N.GetString(s.name) + " " + (c++), "0%", s.Identifier(), "");
                }
#if DEBUG
            }
#endif
        }

        private void rdUS_Enter(object sender, EventArgs e)
        {
            rdChanged("us");
        }

        private void rdEU_Enter(object sender, EventArgs e)
        {
            rdChanged("eu");
        }

        private void rdAS_Enter(object sender, EventArgs e)
        {
            rdChanged("as");
        }
    }
}
