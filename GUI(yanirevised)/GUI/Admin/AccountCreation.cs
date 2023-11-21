using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace GUI
{
    public partial class AccountCreation : Form
    {
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();
        private DataTable dataset;

        public AccountCreation()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            dataset = SQL.RunCommand("");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}