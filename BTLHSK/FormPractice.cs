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

    public partial class FormPractice : Form
    {
        public FormPractice()
        {
            InitializeComponent();
        }
        public void load_combo()
        {
            string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //string str = @"Data Source=TRUNG;Initial Catalog=QuanLyCuaHangQuanAo;Integrated Security=True";
            try
            {
                using (SqlConnection cnn = new SqlConnection(str))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select *from tblNhaCC", cnn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "sTenNhaCC";
                        comboBox1.ValueMember = "sMaNCC";
                    }
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void FormPractice_Load(object sender, EventArgs e)
        {
            load_combo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(str))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("pr_ThemNCC", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text);
                        cmd.Parameters.AddWithValue("@TenNCC", txtTenNCC.Text);
                        cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                        cmd.Parameters.AddWithValue("@sdt", txtDienthoai.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();

                        if (i > 0)
                            MessageBox.Show("Thêm thành công");
                        else
                            MessageBox.Show("Thêm thất bại");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }
    }
}
