using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new StudentMainMenu());
=======
            Application.Run(new MainMenu());
>>>>>>> 9c69547b3250484f066d9bbd7aafce4f9386ade1
        }
    }
}
