using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Admin
{
    public partial class AdminMain : Form
    {
        private AccountHandling account_handling = new AccountHandling();
        private AdminCourseHandling course_handling= new AdminCourseHandling();

        public AdminMain()
        {
            InitializeComponent();
        }

        private void AccountHandleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            account_handling.ShowDialog();
            this.Show();
        }

        private void CourseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            course_handling.ShowDialog();
            this.Show();
        }
    }
}
