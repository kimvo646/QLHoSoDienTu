using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHoSoDienTu
{
    internal static class Program
    {
        public static string Path = Application.StartupPath + @"\Data.txt";

        public static TreeDate treeDate;
        public static TreeName treeName;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTrangChu());
        }
    }
}
