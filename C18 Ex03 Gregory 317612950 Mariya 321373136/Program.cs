using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    //Main entry point
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
            Application.Run(new MainApplicationForm());
        }
    }
}
