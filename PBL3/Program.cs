using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            /* Application.Run(new GUI.DangNhap());*/
            /*Application.Run(new GUI.ManHinhChinh());*/
            Application.Run(new GUI.CaLamViec());
=======
            Application.Run(new GUI.Form1());
>>>>>>> a1cbb0d0ec0856c887f2780725bd53cd1b6467f0
        }
    }
}
