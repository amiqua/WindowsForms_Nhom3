using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCCK_Nhom3_LTWF
{
    public partial class TrangChinh : Form
    {
        public TrangChinh()
        {
            InitializeComponent();
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau2 f = new Cau2 ();
            f.ShowDialog();
        }

        private void câu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau3 f = new Cau3 ();
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Bây giờ là :" + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
