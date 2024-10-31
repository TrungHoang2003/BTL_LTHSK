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
    public partial class FormChiTietHD : Form
    {
        public FormChiTietHD(string a)
        {
            InitializeComponent();
            txtSohd.Text = a;
        }


        private void FormChiTietHD_Load(object sender, EventArgs e)
        {
            DataAccess.loadDataGridView(dgvChitietHD,
                "select * from tblChiTietHoaDon where sSoHD = " + "'" + txtSohd.Text + "'");
        }

    }
}
