using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btNhom
{
    public partial class trangChu : Form
    {
        public trangChu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            dangNhap dangNhap = new dangNhap();
            dangNhap.Show();
        }
    }
}
