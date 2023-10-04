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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string[] dt ={"Kinh","Hoa","K'Me","H'Mong","Khác"};  
            foreach(string s in dt)
            {
                cb_dulieu.Items.Add(s);
            }
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            string s = "Dân tộc được chọn:";
            if (cb_dulieu.SelectedIndex >= 0)
            {
                lbl_kq.Text = s + cb_dulieu.SelectedItem.ToString();
            }
            else
            {
                lbl_kq.Text = "Bạn chưa chọn dân tộc.";
            }
        }

        private void cb_dulieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Dân tộc được chọn:" + cb_dulieu.SelectedItem.ToString());
        }
    }
}
  