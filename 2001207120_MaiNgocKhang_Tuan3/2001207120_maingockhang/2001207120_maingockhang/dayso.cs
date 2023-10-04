using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001207120_maingockhang
{
    public partial class dayso : Form
    {
        public dayso()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult  r;
            r = MessageBox.Show("Thoát chương trình", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult)
                e.Cancel = true;

        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            if(txt_nhap.Text !="")
            {
                float n = float.Parse(txt_nhap.Text);
                txt_dayvuanhap.Text += n.ToString();
            }
            else
            {
                this.errorProvider1.SetError(txt_nhap, "Bạn phải nhập");
            }
        }
    }
}
