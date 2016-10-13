using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSYS
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
            Application.Exit();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMainMenu());
        }
    }
}
