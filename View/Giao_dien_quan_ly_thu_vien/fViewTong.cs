using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Giao_dien_quan_ly_thu_vien
{
    public partial class fViewTong : Form
    {
        public fViewTong()
        {
            InitializeComponent();
        }

        private void DangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CapnhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fTaiKhoan
            fTaiKhoan f = new fTaiKhoan();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void ThemsachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fThemSach
            fThemSach f = new fThemSach();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void XoasachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fXoaSach
            fXoaSach f = new fXoaSach();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void SuasachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fSuaSach
            fSuaSach f = new fSuaSach();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void LinhvucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fLinhVuc
            fLinhVuc f = new fLinhVuc();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void LoaisachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fLoaiSach
            fLoaiSach f = new fLoaiSach();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void KhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fKho
            fKho f = new fKho();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void NhaxuatbanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fNhaXuatBan
            fNhaXuatBan f = new fNhaXuatBan();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void HoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fHoaDon
            fHoaDon f = new fHoaDon();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void ThongkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fThongKe
            fThongKe f = new fThongKe();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void XoaTGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXoaTacGia f = new fXoaTacGia();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void ThemTGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemTacGia f = new fThemTacGia();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void SuaTGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSuaTacGia f = new fSuaTacGia();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }
    }
}
