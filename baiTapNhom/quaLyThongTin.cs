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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baiTapNhom
{
    public partial class quaLyThongTin : Form
    {
        public quaLyThongTin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            trangChu trangChu = new trangChu();
            trangChu.Show();
        }
        SqlConnection cnt = new SqlConnection("Data Source=DESKTOP-ESLTI3R\\SQLEXPRESS;Initial Catalog=QUANLYKHOHANG;Integrated Security=True");
        public void hienthi()
        {
            cnt.Open();
            string sql  = "SELECT*FROM [dbo].[tb_HANGHOA]";
            SqlCommand cmd = new SqlCommand(sql,cnt);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cnt.Close();
            dataGridView1.DataSource = dt;
        }
        private void quaLyThongTin_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dataGridView1.CurrentCell.RowIndex;
            txtMA.Text = dataGridView1.Rows[t].Cells[0].Value.ToString();
            txtTEN.Text = dataGridView1.Rows[t].Cells[1].Value.ToString();
            txtGIA.Text = dataGridView1.Rows[t].Cells[2].Value.ToString();
            txtXUATXU.Text = dataGridView1.Rows[t].Cells[3].Value.ToString();
            datetimeNNHAP.Text = dataGridView1.Rows[t].Cells[4].Value.ToString();
            txtSL.Text = dataGridView1.Rows[t].Cells[5].Value.ToString();

        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {

            cnt.Open();
            string sql = "INSERT INTO [dbo].[tb_HANGHOA] ([ID], [TENHH], [DONGIA], [NGAYNHAP], [XUATXU], [SOLUONG]) VALUES('" + txtMA.Text + "','" + txtTEN.Text + "','" + txtGIA.Text + "','" + datetimeNNHAP.Value.ToString("yyy-MM-dd") + "','" + txtXUATXU.Text + "','" + txtSL.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, cnt);
            cmd.ExecuteNonQuery();
            cnt.Close();
            hienthi();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            cnt.Open();
            string sql = "UPDATE [dbo].[tb_HANGHOA] SET TENHH='" + txtTEN.Text + "', DONGIA='" + txtGIA.Text + "',XUATXU='" + txtXUATXU.Text + "', NGAYNHAP= '" + datetimeNNHAP.Value.ToString("yyy-MM-dd") + "', SOLUONG='" + txtSL.Text + "'WHERE ID='" + txtMA.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnt);
            cmd.ExecuteNonQuery();
            cnt.Close();
            hienthi();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            cnt.Open();
            string sql = "DELETE [dbo].[tb_HANGHOA] WHERE ID ='" + txtMA.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, cnt);
            cmd.ExecuteNonQuery();
            cnt.Close();
            hienthi();
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            cnt.Open();
            string sql = "SELECT* FROM [dbo].[tb_HANGHOA] WHERE ID ='" + txtMA.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, cnt);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cnt.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
