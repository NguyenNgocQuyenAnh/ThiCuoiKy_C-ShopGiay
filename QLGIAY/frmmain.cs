using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGIAY
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmain f = new frmmain();
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.Show();
        }

        private void giàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiay f = new frmGiay();
            f.Show();
        }

        private void giàyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTimGiay f = new frmTimGiay();
            f.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTimHoadon f = new frmTimHoadon();
            f.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoadon f = new frmHoadon();
            f.Show();
        }
    }
}
