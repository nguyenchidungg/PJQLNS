﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Giao_dien_quan_ly_thu_vien
{
    public partial class fTacGia : Form
    {
        public fTacGia()
        {
            InitializeComponent();
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bThem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fThemTacGia
            fThemTacGia f = new fThemTacGia();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void bXoa_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fXoaTacGia
            fXoaTacGia f = new fXoaTacGia();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void bSua_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fSuaTacGia
            fSuaTacGia f = new fSuaTacGia();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }
    }
}
