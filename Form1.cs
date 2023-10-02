using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranDucPhi_16_ThiCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = ("Họ Và Tên: Trần Đức Phi" + "\nMSSV: 1223360070" + "\nNgày Thi" + DateTime.Now + "\nMôn Thi: Lập Trình Windows 2 - C#");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương Trình Tiện Ích", "Thông Tin");
        }

        private void giảiPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgiaiptbac2 frmgiaiptbac2 = new frmgiaiptbac2();
            frmgiaiptbac2.Show();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDinhDang frmDinhDang = new frmDinhDang();
            frmDinhDang.Show();
        }
    }
}
