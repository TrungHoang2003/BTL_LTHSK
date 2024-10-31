using System;
using System.Windows.Forms;

namespace BTLHSK
{
    public partial class FormMenu : Form
    {
        public FormMenu(string a)
        {
            InitializeComponent();
            lblUser.Text = a;
        }

        private void menuNhanvien_Click(object sender, EventArgs e)
        {
            FormNhanVien formNV = new FormNhanVien();
            formNV.ShowDialog();
        }
    }
}
