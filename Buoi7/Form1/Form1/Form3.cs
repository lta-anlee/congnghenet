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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế toán" };
            foreach(string s in pb)
            {
                frTreeView.Nodes.Add(s);
                cb_phongban.Items.Add(s);
            }
            cb_phongban.SelectedIndex = 0;
        }
        public bool kiemtra(string s)
        {
            if (string.Compare(s, frTreeView.SelectedNode.Text, true) == 0)
                return true;
            return false;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (TreeNode node in frTreeView.Nodes)
                if (node.Text == cb_phongban.Text)
                {
                    index = node.Index;
                    break;
                }
            frTreeView.Nodes[index].Nodes.Add(txt_hoten.Text + "(" + txt_maso.Text + ")");
            frTreeView.ExpandAll();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tpb_Click(object sender, EventArgs e)
        {
            if (kiemtra(txt_phongban.Text) == false)
            {
                frTreeView.Nodes.Add(txt_phongban.Text);
                cb_phongban.Items.Add(txt_phongban.Text);
            }
            else
            {
                MessageBox.Show("Phòng ban đã tồn tại!");
            }
            txt_phongban.Text = "";
            txt_phongban.Focus();
        }

        private void btn_xpb_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                if(frTreeView.SelectedNode!=null)
                {
                    cb_phongban.Items.Remove(frTreeView.SelectedNode.Text);
                    frTreeView.Nodes.Remove(frTreeView.SelectedNode);
                }
        }

       
        }

      
    }

