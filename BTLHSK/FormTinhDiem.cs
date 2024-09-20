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
    public partial class FormTinhDiem : Form
    {
        public FormTinhDiem()
        {
            InitializeComponent();
        }

        private void buttonTinhDiem_Click(object sender, EventArgs e)
        {
            float diem1, diem2, diem3, tongDiem;

            diem1 = Convert.ToSingle(text1.Text);
            diem2 = Convert.ToSingle(text2.Text);
            diem3 = Convert.ToSingle(text3.Text);

            tongDiem = diem1 + diem2 + diem3;
            lblKetQua.Text = lblKetQua.Text + tongDiem.ToString();
        }

        private void text1_Validating(object sender, EventArgs e)
        {
            float diem1;
            if (!float.TryParse(text1.Text, out diem1))
                errorProvider1.SetError(text1, "Du lieu ban nhap khong hop le.");
            else errorProvider1.SetError(text1, "");
        }

        private void text2_TextChanged(object sender, EventArgs e)
        {
            float diem1;
            if (!float.TryParse(text2.Text, out diem1))
                errorProvider1.SetError(text2, "Du lieu ban nhap khong hop le.");
            else errorProvider1.SetError(text2, "");

        }

        private void text3_TextChanged(object sender, EventArgs e)
        {
            float diem;
            if (!float.TryParse(text1.Text, out diem))
                errorProvider1.SetError(text3, "Du lieu ban nhap khong hop le.");
            else errorProvider1.SetError(text3, "");

        }
    }
}
