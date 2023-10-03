using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiTapNhom
{
    public partial class baoCao : Form
    {
        public baoCao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            trangChu trangChu = new trangChu();
            trangChu.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            trangChu trangChu = new trangChu();
            trangChu.Show();
        }
    }
}
