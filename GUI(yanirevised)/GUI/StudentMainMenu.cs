﻿using System;
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
    public partial class StudentMainMenu : Form
    {
        private StudentGradeMenu studentgrademenu;
        public StudentMainMenu()
        {
            InitializeComponent();
        }

        private void StudentHomeButton_Click(object sender, EventArgs e)
        {

        }

        private void StudentLogoutButton_Click(object sender, EventArgs e)
        {

        }

        private void StudentCalendarButton_Click(object sender, EventArgs e)
        {

        }

        private void StudentGradeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentgrademenu = new StudentGradeMenu();
            studentgrademenu.ShowDialog();
            this.Show();
        }

        private void StudentCourseDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
