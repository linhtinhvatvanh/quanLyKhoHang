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
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnt = new SqlConnection("Data Source=DESKTOP-ESLTI3R\\SQLEXPRESS;Initial Catalog=ttsv;Integrated Security=True");
        private void hienthi()
        {
            cnt.Open();
            SqlCommand cmd= new SqlCommand("select*from SV",cnt);
            DataTable dt=new DataTable();
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            da.Fill(dt);
            cnt.Close();
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            
            cnt.Open();
            string sql = "insert into SV values ('" + textBox1.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value.ToString("yyy-MM-dd") + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox6.Text + "')";
            SqlCommand cmd = new SqlCommand(sql,cnt);
            cmd.ExecuteNonQuery();
            cnt.Close();
            hienthi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t= dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[t].Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.Rows[t].Cells[1].Value.ToString(); 
            dateTimePicker1.Text = dataGridView1.Rows[t].Cells[2].Value.ToString();
            comboBox1.SelectedItem= dataGridView1.Rows[t].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[t].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.Rows[t].Cells[5].Value.ToString(); 
            textBox6.Text = dataGridView1.Rows[t].Cells[6].Value.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            cnt.Open();
            string sql = "update SV set id='" + textBox1.Text + "',name= '"+textBox5.Text+"',birth='"+ dateTimePicker1.Value.ToString("yyy-MM-dd") + "',sex'"+ comboBox1.SelectedItem.ToString() + "',address='"+textBox3+ "',phone='"+textBox2.Text+"',position='"+textBox6.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, cnt);
            cmd.ExecuteNonQuery();
            cnt.Close();
            hienthi();
        }

        private void button3_Click(object sender, EventArgs e)// tìm kiếm

        {
            cnt.Open();
            string sql = "select*from SV where id='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnt);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cnt.Close();
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnt.Open();
            string sql = "delete SV where id='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnt);
            cmd.ExecuteNonQuery();
            cnt.Close();
            hienthi();
        }
    }
}
