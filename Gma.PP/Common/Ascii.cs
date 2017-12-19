using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gma.PP.Common
{
    public static class Ascii
    {
        public static byte GetAscii(char ch)
        {
            var encoding = new System.Text.ASCIIEncoding();

            return encoding.GetBytes(new[] { ch })[0];
        }
    }
}
