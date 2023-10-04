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
    public partial class Mananhr : Form
    {
        public Mananhr()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Button btn_1 = (Button)sender;
            if (btn_1.BackColor != Color.Yellow)
                if (btn_1.BackColor == Color.White)
                {
                    btn_1.BackColor = Color.Blue;
                }
                else
                {
                    btn_1.BackColor = Color.White;
                }
            else
                MessageBox.Show("ghế đã hết !!!");
        }

        private void Mananhr_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Thoát chương trình", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult)
                e.Cancel = true;
        }


      
    }
}
