using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHSK
{
    public static class ValidateData
    {
        public static void kiemTraRong(TextBox txt, ErrorProvider error)
        {
            if (txt.Text == "")
                error.SetError(txt, "Không được để trống");
        }
        public static void kiemTraChuoi(TextBox txt, ErrorProvider error)
        {
            if (txt.Text == "")
                error.SetError(txt, "Không được để trống");

            else if (!Regex.IsMatch(txt.Text, @"^[a-zA-Z]+$"))
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
        }
    }
}
