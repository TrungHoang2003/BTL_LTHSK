using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHSK
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHoaDon());
           // Application.Run(new FormCrystal_NhanVien());
            //bool run = true;

            //while (run)
            //{
            //    string constr = @"Data Source = TRUNG; Initial Catalog = QuanLyCuaHangQuanAo; Integrated Security = True;";
            //    SqlConnection cnn = new SqlConnection(constr);
            //    Console.WriteLine("----MENU-----");
            //    Console.WriteLine("1. Nhap du lieu cho bang San Pham.");
            //    Console.WriteLine("2. Hien danh sach San Pham. ");
            //    Console.WriteLine("3. Them san pham.");
            //    Console.WriteLine("4. Xoa san pham.");
            //    Console.WriteLine("5. Tim kiem san pham theo ma.");
            //    Console.Write("Nhap lua chon cua ban: ");
            //    int choice = Convert.ToInt32(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            hienSanPham(constr);
            //            break;
            //        case 2:
            //            break;
            //        case 3:
            //        case 4:
            //            break;
            //        case 5:

            //            break;
            //    }
            //}
        }
    }
}
