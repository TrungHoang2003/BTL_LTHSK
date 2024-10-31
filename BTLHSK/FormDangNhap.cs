using System;
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
            if (txtDangNhap.Text == "trung" && txtMatKhau.Text == "12345")
            {
                FormMenu formMenu = new FormMenu(txtDangNhap.Text);
                formMenu.ShowDialog();
            }

        }
    }
}   
