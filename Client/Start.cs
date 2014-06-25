using System;
using System.Windows.Forms;
using Client.Forms;
using Client.Utils;

namespace Client
{
    static class Start
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LogConfig.Configure();
            Application.Run(new MSS());
        }
    }
}