using System;
using System.Windows.Forms;

namespace XBMControl
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

            var mainForm = new MainForm();
            if (mainForm != null && !mainForm.IsDisposed)
                Application.Run(mainForm);
        }
    }
}
