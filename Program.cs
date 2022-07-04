using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Line_Production
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
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            Application.Run(new Control());
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            //Common.UpdateState(StateLine.STOP, Control.CountProduct.ToString(), Control.ProductPlan.ToString());
        }
    }
}
