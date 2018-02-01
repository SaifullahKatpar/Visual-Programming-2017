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

namespace NetSpeed
{
    public partial class Form1 : Form
    {
        const string tempfile = "tefile.tmp";
        public Form1()
        {
            InitializeComponent();
            getSpeed();
        }

        public void getSpeed()
        {
            System.Net.WebClient webClient = new System.Net.WebClient();

            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
            webClient.DownloadFile("http://blog.caranddriver.com/wp-content/uploads/2015/11/BMW-2-series.jpg", tempfile);
            sw.Stop();

            FileInfo fileInfo = new FileInfo(tempfile);
            MessageBox.Show(sw.Elapsed.Seconds+"");
            long speed = fileInfo.Length / sw.Elapsed.Seconds;

            MessageBox.Show( speed.ToString("N0"));
        }
    }
}
