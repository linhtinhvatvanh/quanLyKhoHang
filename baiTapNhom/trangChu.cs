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
    public partial class trangChu : Form
    {
        public trangChu()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            dangNhap dangNhap = new dangNhap();
            dangNhap.Show(); 
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            dangNhap dangNhap = new dangNhap();
            dangNhap.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            baoCao bao = new baoCao();
            bao.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            quaLyThongTin quanLy = new quaLyThongTin();
            quanLy.Show();
        }
        SqlConnection cnt = new SqlConnection("Data Source=DESKTOP-ESLTI3R\\SQLEXPRESS;Initial Catalog=QUANLYKHOHANG;Integrated Security=True");
        public void hienthi()
        {
            cnt.Open();
            string sql = "select*from [dbo].[tb_HANGHOA]";
            SqlCommand cmd= new SqlCommand(sql, cnt);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cnt.Close();
            dgvTrangChu.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            hienthi();
        }
       
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
