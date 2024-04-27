using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.GUI;

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
            // Application.Run(new GUI.DangNhap());
            Application.Run(new GUI.ManHinhChinh());
            /*Application.Run(new GUI.CaLamViec());*/
            //Application.Run(new GUI.Admin.NhanVien());
=======

             // Application.Run(new GUI.ManHinhChinh());
            //  Application.Run(new GUI.Admin.ThongKe());
            //Application.Run(new GUI.Admin.ThongKeCa());
            //Application.Run(new GUI.Employee.XemThongTinBan(1));
            //Application.Run(new DTO.Form1());
             Application.Run(new GUI.DangNhap());
>>>>>>> ad2a925fee2710b2773f06a3c7b20b28a3fd18e4
        }
    }
}
