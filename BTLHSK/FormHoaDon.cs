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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            DataAccess.loadDataGridView(dgvHD, "select*from vHoaDon");
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvHD.CurrentCell.RowIndex;
            int cot = dgvHD.CurrentCell.ColumnIndex;
            txtSohd.Text = dgvHD.Rows[hang].Cells[0].Value.ToString();
        }
    }
}
