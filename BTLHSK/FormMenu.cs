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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void menuNhanvien_Click(object sender, EventArgs e)
        {
            FormNhanVien formNV = new FormNhanVien();
            formNV.ShowDialog();
        }
    }
}
