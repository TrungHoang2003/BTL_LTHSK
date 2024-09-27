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
        static string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
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
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

        }
    }
}
