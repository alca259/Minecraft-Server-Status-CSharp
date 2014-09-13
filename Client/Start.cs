using System;
using System.Windows.Forms;
using MSSClient.Forms;
using MSSUtils.Logger;

namespace MSSClient
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
            Application.Run(new WFM());
        }
    }
}