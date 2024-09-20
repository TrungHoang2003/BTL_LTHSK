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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtTen_Validating(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
                errorProvider1.SetError(txtTen, "Bạn phải nhập họ tên!");
            else errorProvider1.SetError(txtTen, "");
        }
    }

}
