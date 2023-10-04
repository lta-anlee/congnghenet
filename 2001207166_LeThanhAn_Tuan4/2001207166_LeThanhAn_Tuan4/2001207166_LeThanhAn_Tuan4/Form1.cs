using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace _2001207166_LeThanhAn_Tuan4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Thoát", "Bạn có muốn thoát chương trình?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txt_a_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "bạn chưa nhập giá trị a");
            else
                this.errorProvider1.Clear();
        }

        private void txt_b_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "bạn chưa nhập giá trị a");
            else
                this.errorProvider1.Clear();
        }

        private void btn_cong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            string s = "kết quả là:\n";
            float a = float.Parse(txt_a.Text);
            float b = float.Parse(txt_b.Text);
            Tinh t = new Tinh();
            if (rdo_cong.Checked)
                MessageBox.Show(s + a + "+" + b + "=");
            else if (rdo_tru.Checked)
                MessageBox.Show(s + a + "-" + b + "=");
            else if (rdo_nhan.Checked)
                MessageBox.Show(s + a + "*" + b + "=");
            else if (b!=0)
                MessageBox.Show(s + a + "/" + b + "=");
            else
                MessageBox.Show("Phép chia bị lỗi!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

       
    }
}
