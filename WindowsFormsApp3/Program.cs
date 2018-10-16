using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String jsonFilename = "accounts.json";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ATM atm = new ATM(jsonFilename);
            Application.Run(new Login(atm));
        }
    }
}
