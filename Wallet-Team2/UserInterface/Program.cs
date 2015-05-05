using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            TestController tc = new TestController();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Opens the login form
            //If username & password match open Mainform
            LoginForm lf = new LoginForm(tc, null);
            Application.Run(lf);
            while (tc.open)
            {
                if (lf.match)
                {
                    Application.Run(new MainForm(tc, lf.username));
                }
            }
        }
    }
}
