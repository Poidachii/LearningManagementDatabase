using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public static class Session
    {
        private static string Acc_ID;
        private static string Acc_Role;
        private static string Acc_Name;

        public static void Logout()
        {
            AccID = null;
            AccRole = null;
            AccName = null;
        }

        public static bool Login(string username, string password)
        {
            Dictionary<string, object> sql_params = new Dictionary<string, object>()
            {
                { "@name", username },
                { "@pass", password }
            };

            DataTable dt = SQL_legit.RunCommand("SELECT * FROM AccountList WHERE (AccName = @name AND AccPass = @pass)", opt_sql_params: sql_params);

            if (dt?.Rows.Count <= 0) { return false; }

            DataRow dr = dt.Rows[0];

            AccID = dr["AccID"].ToString();
            AccName = dr["AccName"].ToString();
            AccRole = dr["AccRole"].ToString();

            return true;
        }

        public static string AccID
        {
            get { return Acc_ID; }
            set { Acc_ID = value; }
        }

        public static string AccName
        {
            get {  return Acc_Name; }
            set { Acc_Name = value; }
        }

        public static string AccRole
        {
            get { return Acc_Role; }
            set { Acc_Role = value; }
        }
    }
}
