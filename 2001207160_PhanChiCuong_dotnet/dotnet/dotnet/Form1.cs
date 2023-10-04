using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string[] dt = { "Kinh", "K'me", "H'Mong", "Tầy", "Hoa", "KHÁC" };
            foreach(string s in dt)
            {
                cbo_hienthi.Items.Add(s);
            }
        }

        private void btn_ht(object sender, EventArgs e)
        {
            string s = "Dân Tộc Được Chọn:";
            if (cbo_hienthi.SelectedIndex >= 0)
                btn_kq.Text = s + cbo_hienthi.SelectedItem.ToString();
            else
                btn_kq.Text = "Bạn Chưa Chọn Dân Tộc";
                
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            string s = "Dân Tộc Được Chọn:";
            if (cbo_hienthi.SelectedIndex >= 0)
                btn_kq.Text = s + cbo_hienthi.SelectedItem.ToString();
            else
                btn_kq.Text = "Bạn Chưa Chọn Dân Tộc";
        }

        private void cbo_hienthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Dân Tộc Được Chọn:" + cbo_hienthi.SelectedItem.ToString());
        }

    }
}
