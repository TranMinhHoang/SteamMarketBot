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
            double lowestPrice;
            HttpDownloader download;
            HtmlParser parser;
            if (txtURL.Text != "")
            {
                download = new HttpDownloader(txtURL.Text, null, null);
                result = download.GetPage();
                parser = new HtmlParser(result);
                StreamWriter res = new StreamWriter("result.txt");
                res.Write(result);
                res.Close();
                txtPage.Text = result;
                lowestPrice = parser.parseHtml();
                StreamWriter Form1Debug = new StreamWriter("Form1DebugInfor.txt");
                try
                {
                    txtLowestPrice.Text = Convert.ToString(lowestPrice);
                }
                catch (System.OverflowException)
                {
                    Form1Debug.WriteLine("Conversion from string-to-double overflowed.");
                }
                catch (System.FormatException)
                {
                    Form1Debug.WriteLine("The string was not formatted as a double.");
                }
                catch (System.ArgumentException)
                {
                    Form1Debug.WriteLine("The string pointed to null.");
                }
                Form1Debug.Close();
            }
        }
    }
}
