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
    public partial class Admin : Form
    {
        //private Login DBMenu;
        private DataBaseDisplay DBMenu = new DataBaseDisplay();
        
        public Admin()
        {
            InitializeComponent(); 
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void AccHandleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountMainMenu AccountMainMenu = new AccountMainMenu();
            AccountMainMenu.ShowDialog();
            this.Show();
        }

        private void DBbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBMenu.ShowDialog();
            //creationMenu.ShowDialog();
            this.Show();
        }

        private void QuizManagementBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuestionMainMenu QuestionMainMenu = new QuestionMainMenu();
            QuestionMainMenu.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
