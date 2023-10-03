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
    public partial class quenMatKhau : Form
    {
        public quenMatKhau()
        {
            InitializeComponent();
        }
        private void quenMatKhau_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            dangNhap dangNhap = new dangNhap();
            dangNhap.Show();
        }

        private void txtEMAIL_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection cnt = new SqlConnection("Data Source=DESKTOP-ESLTI3R\\SQLEXPRESS;Initial Catalog=QUANLYKHOHANG;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEMAIL.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email đã đăng ký !");
                return;
            }

            using (SqlConnection cnt = new SqlConnection("Data Source=DESKTOP-ESLTI3R\\SQLEXPRESS;Initial Catalog=QUANLYKHOHANG;Integrated Security=True"))
            {
                cnt.Open();

                string sql = "SELECT * FROM taiKhoan WHERE email ='"+txtEMAIL.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, cnt);
                //cmd.Parameters.AddWithValue("@Email", email
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                cnt.Close();

                if (dt.Rows.Count > 0)
                {
                    label1.ForeColor = Color.Green;
                    label1.Text = dt.Rows[0]["MatKhau"].ToString();
                }
                else
                {
                    MessageBox.Show("Email không tồn tại trong hệ thống !");
                }
            }
        }
    }
}
