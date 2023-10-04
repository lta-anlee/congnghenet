using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_p_Click(object sender, EventArgs e)
        {
            list_phai.Items.Add(list_trai.SelectedItem);
            list_trai.Items.Remove(list_trai.SelectedItem);
        }

        private void btn_hp_Click(object sender, EventArgs e)
        {
            list_phai.Items.AddRange(list_trai.Items);
            list_trai.Items.Clear();
        }

        private void btn_t_Click(object sender, EventArgs e)
        {
            list_trai.Items.Add(list_phai.SelectedItem);
            list_phai.Items.Remove(list_phai.SelectedItem);
        }

        private void btn_ht_Click(object sender, EventArgs e)
        {
            list_trai.Items.AddRange(list_phai.Items);
            list_phai.Items.Clear();
        }
    }
}
