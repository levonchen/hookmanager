using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Gma.PP.Common
{
    public static class Http
    {
        public static string Get(string url)
        {
            var webClient = new WebClient();

            return webClient.DownloadString(url);
        }

        public static string Post(string url, Dictionary<string, string> pars)
        {
            var webClient = new WebClient();
            webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

            return webClient.UploadString(url, "POST", "");
        }

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            //直接确认，否则打不开
            return true;
        }

        public static DateTime GetServerTime()
        {
            var url = AppConfig.PaipaiUrl;

            HttpWebRequest req = null;

            if (url.Contains("https"))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);

                req = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
            }
            else
            {
                req = (HttpWebRequest)WebRequest.Create(url);
            }

            req.Method = "GET";
            req.KeepAlive = true;

            var rsp = (HttpWebResponse)req.GetResponse();


            return DateTime.Parse(rsp.Headers["Date"]);
        }
    }
}
