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
        }

        public void loadDataGridView()
        {
            using (SqlConnection cnn = new SqlConnection(str))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("select * from vNhanVien", cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cnn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvNhanVien.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private bool checkKhoaChinh()
        {
            bool check = true;
            using (SqlConnection cnn = new SqlConnection(str))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("pr_checkNV", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
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

        private bool checkKhoaNgoai(string ma)
        {
            bool check = true;
            using (SqlConnection cnn = new SqlConnection(str))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("pr_ChecKhoaNgoaiNV", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaNV", ma);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkKhoaChinh() == true)
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
                loadDataGridView();
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
                if (checkKhoaNgoai(ma) == true)
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
                            loadDataGridView();
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
    }
}
