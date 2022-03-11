using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpdaterNBB.Classes;

namespace UpdaterNBB
{
    public partial class UP : Form
    {
        public UP()
        {
            InitializeComponent();
        }

        private void UP_Load(object sender, EventArgs e)
        {
            var path = Environment.GetEnvironmentVariable("LocalAppData") + "\\NepaliBibleAndBhajan\\Installer\\" + "NBBInstallation.json";
            Dictionary<string, string> installation_info = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(path));
            UpdateInstaller updateInstaller = new UpdateInstaller();
            updateInstaller.InstallAppNow(installation_info.FirstOrDefault().Value, installation_info.LastOrDefault().Value);
        }
    }
}
