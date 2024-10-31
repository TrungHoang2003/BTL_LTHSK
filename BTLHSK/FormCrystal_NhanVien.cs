using BTLHSK.Reports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class FormCrystal_NhanVien : Form
    {
        string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        public FormCrystal_NhanVien()
        {
            InitializeComponent();


        }

        private void CRVnhanvien_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNam.Text, out int nam))
            {
                if (nam >= 1900 && nam <= 2024)
                {
                    using (SqlConnection cnn = new SqlConnection(str))
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand("pr_DSNVtheoNam", cnn))
                            {
                                cnn.Open();
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@nam", nam);

                                SqlDataAdapter da = new SqlDataAdapter(cmd);
                                DataTable dt = new DataTable();
                                da.Fill(dt);

                                NhanVienTheoNam objRpt = new NhanVienTheoNam();
                                objRpt.SetDataSource(dt);

                                objRpt.SetParameterValue("@nam", nam);
                                CRVnhanvien.ReportSource = objRpt;
                                CRVnhanvien.Refresh();
                            }

                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                else
                    MessageBox.Show("Nam nhap khong hop le.");
            }
            else
                MessageBox.Show("Error");
        }

        private void FormCrystal_NhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
