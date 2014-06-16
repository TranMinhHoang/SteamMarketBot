using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SteamBot
{
    class HtmlParser
    {
        private string _html;
        private const string _dollar = "&#36;";
        
        public HtmlParser(string html)
        {
            _html = html;
        }
        public double parseHtml()
        {
            double lowestPrice = 0;
            double currentPrice = 0;
            string priceStr;
            int nextSpace;
            int index = _html.IndexOf(_dollar);
            int searchPos = index + _dollar.Length;
            StreamWriter ParserDebug = new StreamWriter("ParserDebugInfor.txt");
            while(index != -1)
            {
                index = _html.IndexOf(_dollar, searchPos);
                searchPos = index + _dollar.Length;
                nextSpace = _html.IndexOf('\t', searchPos);
                priceStr = _html.Substring(searchPos, nextSpace - searchPos);
                try
                {
                    currentPrice = Convert.ToDouble(priceStr);
                }
                catch (FormatException)
                {
                    ParserDebug.WriteLine("Unable to convert '{0}' to a Double.", priceStr);
                }
                catch (OverflowException)
                {
                    ParserDebug.WriteLine("'{0}' is outside the range of a Double.", priceStr);
                }
                // if the conversion failed
                if (currentPrice == 0) continue;
                // update the lowest price
                if (lowestPrice == 0) lowestPrice = currentPrice;
                else if (currentPrice < lowestPrice) lowestPrice = currentPrice;
            }

            ParserDebug.Close();
            return lowestPrice;
        }
    }
}
