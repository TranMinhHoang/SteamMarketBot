using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SteamBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetPage_Click(object sender, EventArgs e)
        {
            string result;
            HttpDownloader download;
            if (txtURL.Text != "")
            {
                download = new HttpDownloader(txtURL.Text, null, null);
                result = download.GetPage();
                StreamWriter res = new StreamWriter("result.txt");
                res.Write(result);
                res.Close();
                txtResult.Text = result;
            }
        }
    }
}
