using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AccountMainMenu : Form
    {
        private AccountCreation accountCreation;
        public AccountMainMenu()
        {
            InitializeComponent();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            accountCreation = new AccountCreation();
            accountCreation.ShowDialog();
            this.Show();
        }

        private void EditAccountBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
