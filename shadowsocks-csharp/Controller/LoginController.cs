using Shadowsocks.Controller.Hotkeys;
using Shadowsocks.Model;
using Shadowsocks.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowsocks.Controller
{
    public class LoginController
    {
        public static VPNLoginForm loginForm;
        public static VPNListFirstForm ListFirst;

        public LoginController()
        {
        }
        
        public void ShowLogin()
        {
            if(loginForm == null)
            {
                loginForm = new VPNLoginForm(this);
            }

            loginForm.Show();
            loginForm.Activate();
        }

        public void CloseLogin()
        {
            if (loginForm != null)
            {
                loginForm.Close();
            }
           
        }

        internal void Start()
        {
            ShowLogin();
        }

        public bool Login(string username, string psw)
        {
            return true;
        }

       
        public NetServers getNetServers()
        {
            return Util.Utils.getNetServers();
        }

        public void ShowVPNList()
        {
            if(ListFirst == null)
            {
                ListFirst = new VPNListFirstForm(this);
            }
            this.CloseLogin();
            ListFirst.Show();
            ListFirst.Activate();
        }
    }
}
