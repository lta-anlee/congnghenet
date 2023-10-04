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

namespace _2001207120_maingockhang
{
    public partial class congtrunhanchia : Form
    {
        public congtrunhanchia()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Thoát chương trình", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult)
                e.Cancel = true;
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txt_a.Text);
            float b = float.Parse(txt_b.Text);

            TinhTien tt = new TinhTien();
            float kq = a + b;
            txt_kq.Text = kq.ToString();
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txt_a.Text);
            float b = float.Parse(txt_b.Text);

            TinhTien tt = new TinhTien();
            float kq = a - b;
            txt_kq.Text = kq.ToString();
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txt_a.Text);
            float b = float.Parse(txt_b.Text);

            TinhTien tt = new TinhTien();
            float kq = a / b;
            txt_kq.Text = kq.ToString();
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txt_a.Text);
            float b = float.Parse(txt_b.Text);

            TinhTien tt = new TinhTien();
            float kq = a * b;
            txt_kq.Text = kq.ToString();
        }

        private void txt_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btn_cong.PerformClick();
        }


    }
}
