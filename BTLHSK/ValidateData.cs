using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHSK
{
    public static class ValidateData
    {
        static string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        public static void kiemTraRong(TextBox txt, ErrorProvider error)
        {
            if (txt.Text == "")
                error.SetError(txt, "Không được để trống");
            else
                error.SetError(txt, "");
        }
        public static void kiemTraChuoi(TextBox txt, ErrorProvider error)
        {
            if (txt.Text == "")
                error.SetError(txt, "Không được để trống");

            else if (!Regex.IsMatch(txt.Text, @"^[\p{L}\s]+$"))
            {
                // Nếu không hợp lệ, hiển thị thông báo lỗi
                error.SetError(txt, "Chỉ được nhập chữ cái.");
            }
            else
            {
                // Nếu hợp lệ, xóa thông báo lỗi
                error.SetError(txt, "");
            }
        }

        public static void kiemTraSo(TextBox txt, ErrorProvider error)
        {
            if (txt.Text == "")
                error.SetError(txt, "Không được để trống");
            if (!float.TryParse(txt.Text, out float n))
                error.SetError(txt, "Kí tự nhập phải là số.");
            else
                error.SetError(txt, "");
        }

        public static bool checkKhoaChinh(string parameter, string value, string query)
        {
            bool check = true;
            using (SqlConnection cnn = new SqlConnection(str))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(parameter, value);
                        cnn.Open();
                        using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            ad.Fill(dt);
                            if (dt.Rows.Count > 0)
                                check = true;
                            else
                                check = false;
                        }

                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            return check;
        }
        public static bool checkKhoaNgoai(string parameter, string value, string query)
        {
            bool check = true;
            using (SqlConnection cnn = new SqlConnection(str))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(parameter, value);
                        using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            ad.Fill(dt);
                            if (dt.Rows.Count > 0) check = true; else check = false;
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            return check;

        }
    }
}
