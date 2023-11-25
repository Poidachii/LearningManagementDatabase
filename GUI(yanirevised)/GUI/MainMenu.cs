using GUI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainMenu : Form
    {
        private StudentMain student_form = new StudentMain();
        private AdminMain admin_form = new AdminMain();
        private ProfessorMain professor_form = new ProfessorMain();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            bool login_success = Session.Login(UsernameLoginField.Text, PasswordLoginField.Text);

            if (login_success)
            {
                this.Hide();

                switch (Session.AccRole)
                {
                    case "student":
                        student_form.ShowDialog();
                        break;

                    case "professor":
                        professor_form.ShowDialog();
                        break;

                    case "admin":
                        admin_form.SetGreeting();
                        admin_form.ShowDialog();
                        break;

                    default:
                        break;
                }

                this.Show();
            }

            else if (!login_success)
            {
                MessageBox.Show("Invalid login credentials. Please try again.");
            }
        }

        private void OneMCLButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://one.mcl.edu.ph");
        }

        private void BlackboardAppButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://mcl.edu.ph");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mcl.blackboard.com/ultra/catalog");
        }
    }
}
