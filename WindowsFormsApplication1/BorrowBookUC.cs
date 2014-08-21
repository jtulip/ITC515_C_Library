using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;

using Library.Interfaces.Uis;
using Library.Interfaces.Controls;

namespace Library
{
    static class BorrowBookUC
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BorrowBookUI gui = new BorrowBookUI();
            gui.Initialise(null);
            Application.Run(gui);
        }
    }
}
