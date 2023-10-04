using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001207166_LeThanhAn
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void nhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();

        }

        private void BTS_phai_Click(object sender, EventArgs e)
        {
            lst_B.Items.Add(lst_A.SelectedItem);
            lst_A.Items.Remove(lst_A.SelectedItem);
        }

        private void BTS_trai_Click(object sender, EventArgs e)
        {
            lst_A.Items.Add(lst_B.SelectedItem);
            lst_B.Items.Remove(lst_B.SelectedItem);
        }

        
    }
}
