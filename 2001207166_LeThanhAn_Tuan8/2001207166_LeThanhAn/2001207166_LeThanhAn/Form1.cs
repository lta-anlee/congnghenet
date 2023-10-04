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

namespace _2001207166_LeThanhAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DBConnect con = new DBConnect();
        bool KT_MaKhoa(string ma)
        {
            string strSQL = "SELECT count(*) FROM Khoa WHERE MaKhoa='" + txt_mk + "'";
            int count = con.getCount_ExecuteScalar(strSQL);
            if (count >= 1)
                return false;
            return true;
        }

        private void btn_them_Click(object sender, EventArgs e) 
        {
            try
            {
                if (KT_MaKhoa(txt_mk.Text))
                {
                    string sql_insert = "insert into Khoa values('" + txt_mk.Text + "','" + txt_tk.Text + "')";
                    int r = con.executeNonQuery(sql_insert);
                    if (r > 0)
                        MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Ma khoa đã tồn tại!!!");
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
        }

        
       
    }
}
