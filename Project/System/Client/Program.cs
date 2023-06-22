using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Helper.PDF;
using Client.UI;
using Client.UI.Agreement;
using Client.UI.Contract;

namespace Client
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
            var loginForm = new LoginSystem();
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new Main());
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
