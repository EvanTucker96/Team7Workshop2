using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// Nelson - Products Add/Modify Form
        /// Steven - Main form / Login
        /// Evan - Packages Add/Modify Form
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
