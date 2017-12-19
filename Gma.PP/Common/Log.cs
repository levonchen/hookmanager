using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Gma.PP.Common
{
    public static class Log
    {
        public static void Info(string input)
        {
            var logger = LogManager.GetLogger(typeof(Program));

            logger.Info(input);
        }
    }
}
