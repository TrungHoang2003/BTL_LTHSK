using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHSK
{
    public partial class FormHoaDon : Form
    {

        string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

        public FormHoaDon()
        {
            InitializeComponent();
            dateNgaymua.ShowUpDown = true;
            btnTimKiem.Enabled = false;
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            DataAccess.loadDataGridView(dgvHD, "select*from vHoaDon");
            loadComboBox();
        }

        private void loadComboBox()
        {
            using (SqlConnection cnn = new SqlConnection(str))
            {
                DataTable dt = new DataTable();
                DataAccess.importDataTable(dt, "select * from tblNhanVien");
                cmbMaNV.DataSource = dt;
                cmbMaNV.ValueMember = dt.Columns[0].ColumnName;
                cmbMaNV.DisplayMember = dt.Columns[1].ColumnName;
            }
        }


        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvHD.CurrentCell.RowIndex;
            int cot = dgvHD.CurrentCell.ColumnIndex;
            txtSohd.Text = dgvHD.Rows[hang].Cells[0].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateData.checkKhoaChinh("@MaHD", txtSohd.Text, "pr_CheckHD") == true)
                MessageBox.Show("khóa chính đã tồn tại");
            else
            {
                using (SqlConnection cnn = new SqlConnection(str))
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("pr_ThemNV", cnn))
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {

        }
    }
}
