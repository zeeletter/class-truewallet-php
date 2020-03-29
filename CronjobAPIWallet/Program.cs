using System;
using System.IO;
using System.Net;
using System.Threading;

namespace CronjobAPIWallet
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                string html = string.Empty;
                # string url = @"http://127.0.0.1/Wallet/access_token.php";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                    if (html.IndexOf("UPC-200") > -1)
                    {
                        count++;
                        Console.WriteLine("[" + count + "][Cronjob] -> Token success At " + DateTime.Now.ToString("dd/MM/yyyy HH:mm tt"));
                    }
                    else
                    {
                        Console.WriteLine("[" + count + "][Cronjob] -> Token fail");
                        Console.ReadLine();
                        break;
                    }
                }
                Thread.Sleep(60000);
            }
        }
    }
}
