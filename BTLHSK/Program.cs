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
        public static void hienSanPham(string constr)
        {
            SqlConnection cnn = new SqlConnection(constr);
            try
            {
                using (cnn)
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter("select *from tblSanPham", cnn))
                    {
                        using (DataTable tb = new DataTable("tblSanPham"))
                        {
                            ad.Fill(tb);
                            if (tb.Rows.Count == 0)
                            {
                                Console.WriteLine("Khong co ban khi nao.");
                            }
                            else
                                foreach (DataRow r in tb.Rows)
                                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", r["sMaSP"], r["sTenSP"], r["sMaNCC"],
                                    r["fSoluong"], r["fGiaBan"], r["fGiaNhap"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); Console.WriteLine(ex.StackTrace);
            }
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormNhanVien());
            Application.Run(new FormMenu());
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
