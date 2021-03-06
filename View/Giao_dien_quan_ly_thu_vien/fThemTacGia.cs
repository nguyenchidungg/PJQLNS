using Giao_dien_quan_ly_thu_vien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Giao_dien_quan_ly_thu_vien
{
    public partial class fThemTacGia : Form
    {
        public fThemTacGia()
        {
            InitializeComponent();
            txbMaTacGia_TextChanged();
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbMaTacGia_TextChanged()
        {
            Random rd = new Random();
            txbMaTacGia.Text = ("TG0" + rd.Next(99, 1000));
        }

        private void bThem_Click(object sender, EventArgs e)
        {
            if (txbTenTacGia.Text == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN TÊN TÁC GIẢ!", "THÔNG BÁO");
            }
            else
            {
                string query = "Insert into TACGIA VALUES ('" + txbMaTacGia.Text + "', '" + txbTenTacGia.Text + "', '" +
                       dateTimePicker_NgaySinh.Text + "', '" + dateTimePicker_NgayMat.Text + "', '" + txbQueQuan.Text + "')";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                txbMaTacGia_TextChanged();
                txbTenTacGia.Text = "";
                txbQueQuan.Text = "";
                checkBox_QueQuan.Checked = false;
                checkBox_NgaySinh.Checked = false;
                checkBox_NgayMat.Checked = false;
                dateTimePicker_NgaySinh.Text = DateTime.Now.ToString();
                dateTimePicker_NgayMat.Text = DateTime.Now.ToString();
            }
        }

        private void checkBox_NgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_NgaySinh.Checked)
            {
                dateTimePicker_NgaySinh.Text = DateTime.MinValue.ToString();
            }
            else
            {
                dateTimePicker_NgaySinh.Text = DateTime.Now.ToString();
            }
        }

        private void checkBox_NgayMat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_NgayMat.Checked)
            {
                dateTimePicker_NgayMat.Text = DateTime.MaxValue.ToString();
            }
            else
            {
                dateTimePicker_NgayMat.Text = DateTime.Now.ToString();
            }
        }

        private void checkBox_QueQuan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_QueQuan.Checked)
            {
                checkBox_QueQuan.Text = "(Không có thông tin)";
                txbQueQuan.Text = "(Không có thông tin)";
                txbQueQuan.ReadOnly = true;
            }
            else
            {
                checkBox_QueQuan.Text = "CHƯA RÕ";
                txbQueQuan.Text = "";
                txbQueQuan.ReadOnly = false;
            }
        }
    }
}
