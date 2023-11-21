using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Calendar : Form
    {
        int month, year;
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName (month);
            datelab.Text = monthname + " " + year;
            //First day of month
            DateTime startingmonth = new DateTime(year,month,1);
            //count of days
            int days = DateTime.DaysInMonth(year, month);
            //convert startmonth to int
            int dayoftheweek = Convert.ToInt32(startingmonth.DayOfWeek.ToString("d"))+1;

            for(int i =1; i < dayoftheweek; i++)
            {
                UserControlCal calblank = new UserControlCal();
                flowLayoutPanel1.Controls.Add(calblank);
            }
            //for DAYZZ
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ButPrev_Click(object sender, EventArgs e)
        {
            //clearcontainer
            flowLayoutPanel1.Controls.Clear();
            //decrement month
            month--;
            DateTime startingmonth = new DateTime(year, month, 1);
            //count of days
            int days = DateTime.DaysInMonth(year, month);
            //convert startmonth to int
            int dayoftheweek = Convert.ToInt32(startingmonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlCal calblank = new UserControlCal();
                flowLayoutPanel1.Controls.Add(calblank);
            }
            //for DAYZZ
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            // clear container
            flowLayoutPanel1.Controls.Clear();

            // increment month
            month++;

            // Check if the month exceeds 12, and if so, reset to 1 and increment the year
            if (month > 12)
            {
                month = 1;
                year++;
            }

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            datelab.Text = monthName + " " + year;
            DateTime startingMonth = new DateTime(year, month, 1);

            // count of days
            int days = DateTime.DaysInMonth(year, month);

            // convert startingMonth to int
            int dayOfWeek = Convert.ToInt32(startingMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlCal calBlank = new UserControlCal();
                flowLayoutPanel1.Controls.Add(calBlank);
            }

            // for DAYS
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                flowLayoutPanel1.Controls.Add(ucDays);
            }
        }
    }
}
