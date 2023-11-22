using GUI.Admin;
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
    public partial class AdminForm : Form
    {
        // private Login DBMenu;
        private AccountHandling account_handling = new AccountHandling();
        private AdminCourseHandling course_handling = new AdminCourseHandling();
        
        public AdminForm()
        {
            InitializeComponent(); 
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            account_handling.ShowDialog();
            this.Show();
        }

        private void CourseHandling_Click(object sender, EventArgs e)
        {
            this.Hide();
            course_handling.ShowDialog();
            this.Show();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
