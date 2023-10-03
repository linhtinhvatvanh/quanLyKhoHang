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
namespace btNhom
{
  
    public partial class dangNhap : Form
    {
        string tentaikhoan = "admin";
        string matkhau = "admin";
        public dangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            trangChu f = new trangChu();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dangKy f1 = new dangKy();
            f1.Show();
            this.Hide();
        }
        Boolean checkDangNhap(string tentaikhoan, string matkhau)
        {
            return false;
        }
    }
}
