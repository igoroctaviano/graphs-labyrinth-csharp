//
// Algorithms in Graphs
// Author: Igor Octaviano R. R.
// ID: 501119
// 

using System;
using System.Windows.Forms;

namespace PathFinder_501119
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
            Application.Run(new Menu());
        }
    }
}
