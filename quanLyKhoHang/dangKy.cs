﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanLyKhoHang
{
    public partial class dangKy : Form
    {
        public dangKy()
        {
            InitializeComponent();
        }
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dangKy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            trangChu  f = new trangChu();
            f.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
