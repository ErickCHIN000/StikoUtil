using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;

namespace Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Install_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile("https://github.com/ErickCHIN000/StikoUtil/blob/main/BepInEx_x64_5.4.15.0.zip?raw=true", @"BepinEx.zip");
                wc.DownloadFile("https://github.com/ErickCHIN000/StikoUtil/blob/main/STIKOSEKUTILITIES.dll?raw=true", @"Util.dll");
            }
            ZipFile.ExtractToDirectory(@".\BepinEx.zip", @".\");
            File.Delete(@".\BepinEx.zip");
            Directory.CreateDirectory(@".\BepInEx\plugins");
            File.Move(@".\Util.dll", @".\BepInEx\plugins\STIKOSEKUTILITIES.dll");
        }
    

        private void Uninstall_Click(object sender, EventArgs e)
        {
            Directory.Delete(@".\BepInEx",true);
            File.Delete(@".\changelog.txt");
            File.Delete(@".\doorstop_config.ini");
            File.Delete(@".\winhttp.dll");
        }
    }
}
