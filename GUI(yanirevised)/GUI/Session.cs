using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public static class Session
    {
        public static string AccID;
        public static string AccRole;
        public static string AccName;

        public static void LogOut()
        {
            AccID = null;
            AccRole = null;
            AccName = null;
        }

        public static void SetAccName() 
        {
            Dictionary<string, object> sql_params = new Dictionary<string, object>
            {
                { "@accid", AccID}
            };

            DataTable dt = SQL_legit.RunCommand("SELECT AccName FROM AccountList WHERE AccID=@accid", opt_sql_params: sql_params);

            AccName = dt.Rows[0]["AccName"].ToString();
        }
    }
}
