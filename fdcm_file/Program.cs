using System;
using System.Windows.Forms;

namespace fdcm_file
{
    static class Program
    {
        #region Private Methods

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        #endregion Private Methods
    }
}
