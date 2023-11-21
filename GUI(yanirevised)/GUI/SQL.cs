using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace GUI
{
    internal class SQL
    {
        private static SqlConnection sql_connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Yani\Documents\LMSDataBase.mdf;Integrated Security = True; Connect Timeout = 30");
        private static DataTable dataset;
        private static SqlCommand command;
        private static SqlDataAdapter adapter;

        public static DataTable RunCommand(string sql_command, DataGridView data_display = null, Dictionary<string, object> opt_sql_params = null)
        {
            sql_connection.Open();

            command = new SqlCommand(sql_command, sql_connection);

            if (opt_sql_params != null)
            {
                foreach(KeyValuePair<string, object> param in opt_sql_params)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            dataset = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataset);

            if (data_display != null)
            {
                data_display.ReadOnly = true;
                data_display.DataSource = dataset;
                data_display.AutoGenerateColumns = true;
            }

            sql_connection.Close();

            return dataset;
        }

        public static List<string> GetDataByColumnName(string column_name, string table_name)
        {
            string sql_command = "SELECT @column FROM @table";

            command = new SqlCommand(sql_command, sql_connection);
            command.Parameters.AddWithValue("@column", column_name);
            command.Parameters.AddWithValue("@table", table_name);

            dataset = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataset);

            return dataset.AsEnumerable().Select(x => x.Field<string>(column_name)).ToList();
        }
    }
}
