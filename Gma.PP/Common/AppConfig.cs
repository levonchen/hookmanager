using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gma.PP.Common
{
    public static class AppConfig
    {
        public static int Width
        {
            get
            {
                return Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["width"] ?? "42");
            }
        }

        public static int Heigth
        {
            get
            {
                return Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["height"] ?? "12");
            }
        }

        public static int DemoWidth
        {
            get { return Convert.ToInt32(Math.Floor(Width / 5m)) * 2; }
        }

        public static string PaipaiUrl
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["paipaiurl"] ?? "https://test.alltobid.com"; }
        }

        public static TimeSpan BeginTime
        {
            get
            {
                var time = System.Configuration.ConfigurationManager.AppSettings["begintime"] ?? "11:29:47";

                var g=time.Split(':');

                return new TimeSpan(0, Convert.ToInt32(g[0]), Convert.ToInt32(g[1]), Convert.ToInt32(g[2]));
            }
        }
    }
}
