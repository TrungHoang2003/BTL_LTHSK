using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHSK
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtDangNhap.Text;
            string password = txtMatKhau.Text;

            using (var context = new UserDbContext())
            {
                var taikhoan = context.DStaiKhoan.FirstOrDefault(u=>u.sTenTaiKhoan == username && u.sMatKhau == password);
                if (taikhoan != null)
                {
                    MessageBox.Show("Dang nhap thanh cong");
                }
            }

        }
    }
}   
