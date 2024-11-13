using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHSK
{
    public static class DataAccess
    {
        public static string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        static SqlConnection cnn = new SqlConnection();

        public static void loadCrystalReportViewer(CrystalReportViewer crv, string filepath)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(filepath);

            crv.ReportSource = cryRpt;
            crv.Refresh();
        }
        public static bool openConnection()
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                    cnn.ConnectionString = str;
                    cnn.Open();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
            return true;
        }

        public static void loadDataGridView(DataGridView dataGridView, string query)
        {
            using (SqlConnection cnn = new SqlConnection(str))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView.DataSource = dt;
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

        }

        public static DataTable importDataTable(DataTable dataTable, string query)
        {
            using (SqlConnection cnn = new SqlConnection(str))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                        {
                            ad.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            return dataTable;
        }

        public static void loadComboBox(SqlCommand cmd, ComboBox cbb)
        {
            DataTable dataTable = new DataTable();
            cbb.DataSource = dataTable;
            cbb.ValueMember = dataTable.Columns[0].ColumnName;
            cbb.DisplayMember = dataTable.Columns[1].ColumnName;
        }
    }
}
