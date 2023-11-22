using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public static class Session
    {
        public static string AccID;
        public static string AccRole;

        public static void LogOut()
        {
            AccID = "0";
            AccRole = null;
        }
    }
}
