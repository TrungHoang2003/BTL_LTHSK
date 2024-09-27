using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace BTLHSK
{
    public partial class FormNhanVien : Form
    {
        string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

        public FormNhanVien()
        {
            InitializeComponent();
            dateNgaysinh.ShowUpDown = true;
            btnTimkiem.Enabled = false;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            DataAccess.loadDataGridView(dgvNhanVien, "select * from vNhanVien");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateData.checkKhoaChinh("@MaNV", txtMaNV.Text, "pr_CheckNV") == true)
                MessageBox.Show("Khóa chính đã tồn tại.");
            else
            {
                using (SqlConnection cnn = new SqlConnection(str))
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("pr_ThemNV", cnn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                            cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                            cmd.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dateNgaysinh.Text));
                            cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                            cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                            cmd.Parameters.AddWithValue("@Luong", Convert.ToSingle(txtLuong.Text));
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                DataAccess.loadDataGridView(dgvNhanVien, "select * from vNhanVien");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int cot = dgvNhanVien.CurrentCell.ColumnIndex;
            int hang = dgvNhanVien.CurrentCell.RowIndex;
            string ma = dgvNhanVien.Rows[hang].Cells[0].Value.ToString();

            if (cot != 1)
                MessageBox.Show("Vui lòng chọn tên nhân viên tương ứng.");
            else
            {
                if (ValidateData.checkKhoaNgoai("@sMaNV", txtMaNV.Text, "pr_ChecKhoaNgoaiNV") == true)
                    MessageBox.Show("Dữ liệu nhân viên đang tồn tại trong bảng hóa đơn.");
                else
                {
                    using (SqlConnection cnn = new SqlConnection(str))
                    {
                        using (SqlCommand cmd = new SqlCommand("pr_XoaNV", cnn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaNV", ma);
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            DataAccess.loadDataGridView(dgvNhanVien, "select * from vNhanVien");
                        }
                    }
                }

            }
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            ValidateData.kiemTraChuoi(txtTenNV, errorTenNV);
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            ValidateData.kiemTraRong(txtMaNV, errorMaNV);
        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {
            ValidateData.kiemTraRong(txtDiachi, errorDiachi);
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            ValidateData.kiemTraSo(txtSDT, errorSdt);
        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {
            ValidateData.kiemTraSo(txtLuong, errorLuong);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvNhanVien.CurrentCell.RowIndex;
            int cot = dgvNhanVien.CurrentCell.ColumnIndex;
            txtMaNV.Text = dgvNhanVien.Rows[hang].Cells[0].Value.ToString();
            txtDiachi.Text = dgvNhanVien.Rows[hang].Cells[3].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[hang].Cells[1].Value.ToString();
            dateNgaysinh.Text = dgvNhanVien.Rows[hang].Cells[2].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[hang].Cells[4].Value.ToString();
            txtLuong.Text = dgvNhanVien.Rows[hang].Cells[5].Value.ToString();
        }

        private bool suaDuLieuNV(DataGridView data)
        {
            int i = 0;
            using (SqlConnection cnn = new SqlConnection(str))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("pr_SuaNV", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", Convert.ToDateTime(dateNgaysinh.Value));
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@LuongCoBan", Convert.ToDouble(txtLuong.Text));
                        cnn.Open();
                        i = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            return i > 0;

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (suaDuLieuNV(dgvNhanVien))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                DataAccess.loadDataGridView(dgvNhanVien, "select*from vNhanVien");
            }
            else
                MessageBox.Show("Cập nhật dữ liệu không thành công");
        }

        private void cbMaNV_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMaNV.Checked)
            {
                cbSdt.Enabled = false;
                txtSDT_timkiem.Enabled = false;
                cbTenNV.Enabled = false;
                txtTenNV_timkiem.Enabled = false;
                btnTimkiem.Enabled = true;
            }
            else
            {
                cbSdt.Enabled = true;
                txtSDT_timkiem.Enabled = true;
                cbTenNV.Enabled = true;
                txtTenNV_timkiem.Enabled = true;
                btnTimkiem.Enabled = false;
            }
        }

        private void cbTenNV_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTenNV.Checked)
            {
                cbSdt.Enabled = false;
                txtSDT_timkiem.Enabled = false;
                cbMaNV.Enabled = false;
                txtMaNV_timkiem.Enabled = false;
                btnTimkiem.Enabled = true;
            }
            else
            {
                cbSdt.Enabled = true;
                txtSDT_timkiem.Enabled = true;
                cbMaNV.Enabled = true;
                txtMaNV_timkiem.Enabled = true;
                btnTimkiem.Enabled = false;
            }
        }

        private void cbSdt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSdt.Checked)
            {
                cbTenNV.Enabled = false;
                txtTenNV_timkiem.Enabled = false;
                cbMaNV.Enabled = false;
                txtMaNV_timkiem.Enabled = false;
                btnTimkiem.Enabled = true;
            }
            else
            {
                cbTenNV.Enabled = true;
                txtTenNV_timkiem.Enabled = true;
                cbMaNV.Enabled = true;
                txtMaNV_timkiem.Enabled = true;
                btnTimkiem.Enabled = false;
            }

        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataAccess.importDataTable(dt, "select* from vNhanVien");
            DataView view = new DataView(dt);

            if (cbMaNV.Checked)
            {
                String manv = txtMaNV_timkiem.Text;
                view.RowFilter = "[Mã nhân viên] like '%" + manv + "%'";
                if (view.Count == 0)
                    MessageBox.Show("Nhân viên không tồn tại");
                else
                {
                    dgvNhanVien.AutoGenerateColumns = true;
                    dgvNhanVien.DataSource = view;
                }
            }
            else if (cbTenNV.Checked)
            {
                String tennv = txtTenNV_timkiem.Text;
                view.RowFilter = "[Tên nhân viên] like '%" + tennv + "%'";
                if (view.Count == 0)
                    MessageBox.Show("Nhân viên không tồn tại");
                else
                {
                    dgvNhanVien.AutoGenerateColumns = true;
                    dgvNhanVien.DataSource = view;
                }
            }
            else if (cbSdt.Checked)
            {
                String sdt = txtSDT_timkiem.Text;
                view.RowFilter = "[Điện Thoại] like '%" + sdt + "%'";
                if (view.Count == 0)
                    MessageBox.Show("Nhân viên không tồn tại");
                else
                {
                    dgvNhanVien.AutoGenerateColumns = true;
                    dgvNhanVien.DataSource = view;
                }
            }

        }
    }
}
