using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_System_2018
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login_Form());
            //Application.Run(new Admin());
            //Application.Run(new Quiz_config_teacher("GV001","TDTGv1"));
            //Application.Run(new newMon("GV001", "TDTGv1"));
            //Application.Run(new Answer("EA0001",4,"502042"));
            Application.Run(new Quiz_config_student("SV001"));
        }
    }
}
