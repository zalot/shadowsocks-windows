using System;
using System.Collections.Generic;
using System.IO;

using Shadowsocks.Controller;
using Newtonsoft.Json;
using System.Windows.Forms;
using Shadowsocks.Util;

namespace Shadowsocks.Model
{
    [Serializable]
    public class NetServers
    {
        //{
        //  "servers": [
        //    {
        //      "server": "111.111.111.111",
        //      "server_port": 8388,
        //      "password": "1111111",
        //      "method": "aes-256-cfb",
        //      "remarks": "",
        //      "timeout": 5
        //    }
        //  ]
        //}
        public List<Server> servers;

        public static List<Server> Selected = new List<Server>();
    }

    [Serializable]
    public class Configuration
    {
        [NonSerialized]
        public List<Server> servers;

        // when strategy is set, index is ignored
        public string strategy;
        public int index;
        public bool global;
        public bool enabled;
        public bool shareOverLan;
        public bool isDefault;
        public int localPort;
        public string pacUrl;
        public bool useOnlinePac;
        public bool secureLocalPac = true;
        public bool availabilityStatistics;
        public bool autoCheckUpdate = false;
        public bool checkPreRelease;
        public bool isVerboseLogging;
        public LogViewerConfig logViewer;
        public ProxyConfig proxy;
        public HotkeyConfig hotkey;

        private static string CONFIG_FILE = "gui-config.json";

        public Server GetCurrentServer()
        {
            if (index >= 0 && index < servers.Count)
                return servers[index];
            else
                return GetDefaultServer();
        }

        public static void CheckServer(Server server)
        {
            CheckPort(server.server_port);
            CheckPassword(server.password);
            CheckServer(server.server);
            CheckTimeout(server.timeout, Server.MaxServerTimeoutSec);
        }

        public bool hasCanRunServers()
        {
            if(servers.Count > 0)
            {
                return true;
            }
            return false;
        }

        public static Configuration Load()
        {
            try
            {
                string configContent = File.ReadAllText(CONFIG_FILE);
                Configuration config = JsonConvert.DeserializeObject<Configuration>(configContent);
                config.isDefault = false;

                if (config.servers == null)
                    config.servers = NetServers.Selected;
                
                if (config.localPort == 0)
                    config.localPort = 1080;
                if (config.index == -1 && config.strategy == null)
                    config.index = 0;
                if (config.logViewer == null)
                    config.logViewer = new LogViewerConfig();
                if (config.proxy == null)
                    config.proxy = new ProxyConfig();
                if (config.hotkey == null)
                    config.hotkey = new HotkeyConfig();

                config.proxy.CheckConfig();

                return config;
            }
            catch (Exception e)
            {
                if (!(e is FileNotFoundException))
                    Logging.LogUsefulException(e);
                return new Configuration
                {
                    index = 0,
                    isDefault = true,
                    localPort = 1080,
                    servers = NetServers.Selected,
                    autoCheckUpdate = true,
                    logViewer = new LogViewerConfig(),
                    proxy = new ProxyConfig(),
                    hotkey = new HotkeyConfig()
                };
            }
        }

        public static void Save(Configuration config)
        {
            if (config.index >= config.servers.Count)
                config.index = config.servers.Count - 1;
            if (config.index < -1)
                config.index = -1;
            if (config.index == -1 && config.strategy == null)
                config.index = 0;
            config.isDefault = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(File.Open(CONFIG_FILE, FileMode.Create)))
                {
                    string jsonString = JsonConvert.SerializeObject(config, Formatting.Indented);
                    sw.Write(jsonString);
                    sw.Flush();
                }
            }
            catch (IOException e)
            {
                Logging.LogUsefulException(e);
            }
        }

        public static Server GetDefaultServer()
        {
            Server d = new Server();
            d.name = I18N.GetString("US");
            d.server = "198.74.54.60";
            d.server_port = 9607;
            d.password = "asdfgh78";
            d.method = "aes-256-cfb";
            d.remarks = "";
            d.timeout = 5;
            return d;
        }

        private static void Assert(bool condition)
        {
            if (!condition)
                throw new Exception(I18N.GetString("assertion failure"));
        }

        public static void CheckPort(int port)
        {
            if (port <= 0 || port > 65535)
                throw new ArgumentException(I18N.GetString("Port out of range"));
        }

        public static void CheckLocalPort(int port)
        {
            CheckPort(port);
            if (port == 8123)
                throw new ArgumentException(I18N.GetString("Port can't be 8123"));
        }

        private static void CheckPassword(string password)
        {
            if (password.IsNullOrEmpty())
                throw new ArgumentException(I18N.GetString("Password can not be blank"));
        }

        public static void CheckServer(string server)
        {
            if (server.IsNullOrEmpty())
                throw new ArgumentException(I18N.GetString("Server IP can not be blank"));
        }

        public static void CheckTimeout(int timeout, int maxTimeout)
        {
            if (timeout <= 0 || timeout > maxTimeout)
                throw new ArgumentException(string.Format(
                    I18N.GetString("Timeout is invalid, it should not exceed {0}"), maxTimeout));
        }
    }
}
