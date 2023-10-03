using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;

namespace baiTapNhom
{
    public partial class dangKy : Form
    {
        
        public dangKy()
        {
            InitializeComponent();
        }
        public bool checkTK(string ch)
            {
                return Regex.IsMatch(ch, "^[a-z0-9]$");
            }
        public bool checkEmail(string em)
        {
         return Regex.IsMatch(em, @"^[\w]s@gmail.com$");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = txtTTK.Text;
            string mk = txtMK2.Text;
            string xnmk = txtXNMK.Text;
            string email = txtEMAIL.Text;
           
            //bool isTKValid = checkTK(tentk);
            //bool isEmailValid = checkEmail(email);
            if (!checkTK(tentk) && !checkEmail(email) && xnmk == mk)
            {
                SqlConnection cnt = new SqlConnection("Data Source=DESKTOP-ESLTI3R\\SQLEXPRESS;Initial Catalog=QUANLYKHOHANG;Integrated Security=True");
                cnt.Open();
                string sql  = "INSERT INTO taiKhoan VALUES('" + tentk + "','" + mk + "','" + email + "','" + xnmk + "') ";
                SqlCommand cmd = new SqlCommand(sql, cnt);
                cmd.ExecuteNonQuery();
                cnt.Close();
                MessageBox.Show("ĐĂNG KÝ THÀNH CÔNG!");
                this.Close();
                dangNhap dangNhap = new dangNhap();
                dangNhap.Show();
            }
            else
            {
                // Nếu có lỗi, hiển thị thông báo lỗi
                if (checkTK(tentk))
                {
                    MessageBox.Show("Tên tài khoản không hợp lệ!");
                }
                else if (checkEmail(email))
                {
                    MessageBox.Show("Email không hợp lệ!");
                }
                else if (xnmk != mk)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            dangNhap dangNhap = new dangNhap();
            dangNhap.Show();
        }
    }
}
