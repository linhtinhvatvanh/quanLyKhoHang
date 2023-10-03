using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace baiTapNhom
{
    public partial class dangNhap : Form
    {
        public dangNhap()
        {
            InitializeComponent();
        }

        private void dangNhap_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dangKy dangKy= new dangKy();
            dangKy.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
    
            SqlConnection cnt = new SqlConnection("Data Source=DESKTOP-ESLTI3R\\SQLEXPRESS;Initial Catalog=QUANLYKHOHANG;Integrated Security=True");
            try
            {
                cnt.Open();
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                string sql = "select * from taiKhoan where tenTaiKhoan='"+tk+"' and matKhau='"+mk+"' ";
                SqlCommand cmd = new SqlCommand(sql, cnt);
                SqlDataReader da= cmd.ExecuteReader();
                if(da.Read()==true) {
                    trangChu trangChu = new trangChu();
                    trangChu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("TÊN ĐĂNG NHẬP HOẶC MẬT KHẨU BỊ SAI !"); 
                }
            }
            catch(Exception ex) {  
                MessageBox.Show("LỖI KẾT NỐI !");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            quenMatKhau quenMatKhau= new quenMatKhau();
            quenMatKhau.Show();
            this.Hide();
        }
    }
}
