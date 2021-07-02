﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Giao_dien_quan_ly_thu_vien
{
    public partial class fKho : Form
    {
        public fKho()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fXoaKho
            fXoaKho f = new fXoaKho();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bThem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fThemKho
            fThemKho f = new fThemKho();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }

        private void bSua_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fSuaKho
            fSuaKho f = new fSuaKho();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }
    }
}
