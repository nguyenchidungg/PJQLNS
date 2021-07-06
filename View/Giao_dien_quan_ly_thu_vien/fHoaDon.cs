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
    public partial class fHoaDon : Form
    {
        int bChonHD = 0;
        string mahd;
        int tong = 0;
        public fHoaDon()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
            listView3_SelectedIndexChanged();
            txbMaHD_TextChanged();
        }

        private void listView1_SelectedIndexChanged()
        {
            string query = "Select MAHOADON, TENKHACHHANG, NGAYLAP, TONGTIEN From HOADON";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listView1.Clear();
            this.listView1.Items.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("MÃ HÓA ĐƠN", 110);
            this.listView1.Columns.Add("TÊN KHÁCH HÀNG", 190);
            this.listView1.Columns.Add("NGÀY LẬP", 200);
            this.listView1.Columns.Add("TỔNG TIỀN", 100);
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;
            this.listView1.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listView1.Items.Add(row["MAHOADON"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENKHACHHANG"].ToString());
                this.listView1.Items[i].SubItems.Add(row["NGAYLAP"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TONGTIEN"].ToString());
                i++;
            }
        }
        private void bChonSua_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in this.listView1.Items)
            {
                if (item.Checked)
                    count++;
            }

            if (count == 1)
            {
                bChonHD = 1;
                foreach (ListViewItem item in this.listView1.Items)
                {
                    if (item.Checked == true)
                    {
                        mahd = item.SubItems[0].Text;
                        txbTenKH_Sua.Text = item.SubItems[1].Text;
                        dateTimePicker_Sua.Text = item.SubItems[2].Text;
                    }

                }
            }
            else if (count == 0)
            {
                MessageBox.Show("CHƯA CHỌN HÓA ĐƠN NÀO!", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("KHÔNG THỂ SỬA CÙNG LÚC NHIỀU HÓA ĐƠN!", "THÔNG BÁO");
            }
        }

        private void bLuu_Click(object sender, EventArgs e)
        {
            if (bChonHD == 1)
            {
                string query = "UPDATE HOADON SET TENKHACHHANG = '" + txbTenKH_Sua.Text + "', NGAYLAP = '" + dateTimePicker_Sua.Text + "' Where MAHOADON = '" + mahd + "'";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                txbTenKH_Sua.Text = "";
                dateTimePicker_Sua.Text = DateTime.Now.ToString();
                listView1_SelectedIndexChanged();
                bChonHD = 0;
            }
            else
            {
                MessageBox.Show("CHƯA CHỌN HÓA ĐƠN!", "THÔNG BÁO");
            }
        }

        private void bCTHD_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in this.listView1.Items)
            {
                if (item.Checked)
                    count++;
            }

            if (count == 1)
            {
                bChonHD = 1;
                foreach (ListViewItem item in this.listView1.Items)
                {
                    if (item.Checked == true)
                    {
                        mahd = item.SubItems[0].Text;
                    }

                }

                listView2_SelectedIndexChanged();
            }
            else if (count == 0)
            {
                MessageBox.Show("CHƯA CHỌN HÓA ĐƠN NÀO!", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("KHÔNG THỂ XEM CHI TIẾT CÙNG LÚC NHIỀU HÓA ĐƠN!", "THÔNG BÁO");
            }

        }

        private void listView2_SelectedIndexChanged()
        {
            string query2 = "Select MAHOADON, CHITIETHOADON.MASACH, TENSACH, SOLUONG, GIATIEN, THANHTIEN " +
                "From CHITIETHOADON LEFT JOIN SACH ON CHITIETHOADON.MASACH = SACH. MASACH Where MAHOADON = '" + mahd + "'";
            DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);

            this.listView2.Clear();
            this.listView2.Items.Clear();
            this.listView2.View = View.Details;
            this.listView2.Columns.Add("MÃ HÓA ĐƠN", 110);
            this.listView2.Columns.Add("MÃ SÁCH", 110);
            this.listView2.Columns.Add("TÊN SÁCH", 190);
            this.listView2.Columns.Add("SỐ LƯỢNG", 110);
            this.listView2.Columns.Add("GIÁ TIỀN", 150);
            this.listView2.Columns.Add("THÀNH TIỀN", 190);
            this.listView2.GridLines = true;
            this.listView2.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data2.Rows)
            {
                this.listView2.Items.Add(row["MAHOADON"].ToString());
                this.listView2.Items[i].SubItems.Add(row["MASACH"].ToString());
                this.listView2.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.listView2.Items[i].SubItems.Add(row["SOLUONG"].ToString());
                this.listView2.Items[i].SubItems.Add(row["GIATIEN"].ToString());
                this.listView2.Items[i].SubItems.Add(row["THANHTIEN"].ToString());
                i++;
            }
        }

        private void bXoaHD_Click(object sender, EventArgs e)
        {
            int count0 = 0;
            foreach (ListViewItem item in this.listView1.Items)
            {
                if (item.Checked)
                    count0++;
            }
            if (count0 > 0)
            {
                DialogResult d;
                d = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    int count = 0;
                    foreach (ListViewItem item in this.listView1.Items)
                    {
                        if (item.Checked == true)
                        {
                            count++;
                            string Ma = item.Text;
                            string query = "Delete From HOADON Where MAHOADON = '" + Ma + "'";
                            DataTable data = DataProvider.Instance.ExecuteQuery(query);
                            item.Remove();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("KHÔNG CÓ GÌ ĐỂ XÓA!", "THÔNG BÁO");
            }
        }

        private void txbMaHD_TextChanged()
        {
            Random rd = new Random();
            txbMaHD.Text = ("HD0" + rd.Next(99, 1000));
        }



        private void bChonSach_Click(object sender, EventArgs e)
        {
            if (txbTenKH.Text == "")
            {
                MessageBox.Show("NHẬP TÊN KHÁCH HÀNG!", "THÔNG BÁO");
            }
            else
            {
                int tien = 0;
                foreach (ListViewItem item in this.listView3.Items)
                {
                    if (item.Checked)
                    {
                        tien = Convert.ToInt32(item.SubItems[2].Text);
                    }
                }

                try
                {
                    tong = tong + Convert.ToInt32(numericUpDownSoLuong.Text) * tien;
                    string query3 = "Insert Into HOADON Values ('" + txbMaHD.Text + "', '" + txbTenKH.Text + "', '" + dateTimePicker_NgayLap.Text +
                        "', " + tong + ")";
                    DataTable data3 = DataProvider.Instance.ExecuteQuery(query3);
                    listView1_SelectedIndexChanged();
                    listView3_SelectedIndexChanged();
                    numericUpDownSoLuong.Value = 1;
                }
                catch
                {
                    tong = tong + Convert.ToInt32(numericUpDownSoLuong.Text) * tien;
                    string query3b = "Update HOADON SET TONGTIEN = " + tong + " Where MAHOADON = '" + txbMaHD.Text + "'";
                    DataTable data3b = DataProvider.Instance.ExecuteQuery(query3b);
                    listView1_SelectedIndexChanged();
                    listView3_SelectedIndexChanged();
                    numericUpDownSoLuong.Value = 1;
                }
            }

            int count = 0;
            foreach (ListViewItem item in this.listView3.Items)
            {
                if (item.Checked)
                    count++;
            }

            if (count == 1)
            {
                foreach (ListViewItem item in this.listView3.Items)
                {
                    if (item.Checked == true)
                    { 
                        string query4 = "Insert Into CHITIETHOADON Values ('" + txbMaHD.Text + "', '" + item.SubItems[0].Text +
                        "', " + numericUpDownSoLuong.Text + ", " + item.SubItems[2].Text + ", " +
                        Convert.ToInt32(numericUpDownSoLuong.Text) * Convert.ToInt32(item.SubItems[2].Text) + ")";
                        DataTable data4 = DataProvider.Instance.ExecuteQuery(query4);
                        MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
                    }
                }
            }
            else if (count == 0)
            {
                MessageBox.Show("CHƯA CHỌN SÁCH NÀO!", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("CHỌN TỪNG SÁCH VÀ NHẬP SỐ LƯỢNG!", "THÔNG BÁO");
            }
        }

        private void listView3_SelectedIndexChanged()
        {
            string query3 = "Select MASACH, TENSACH, GIABIA, TACGIA.MATG, TENTG, TENLINHVUC, TENLOAISACH From SACH LEFT JOIN TACGIA " +
                "ON SACH.MATG = TACGIA.MATG";
            DataTable data3 = DataProvider.Instance.ExecuteQuery(query3);

            this.listView3.Items.Clear();
            this.listView3.View = View.Details;
            this.listView3.Columns.Add("MÃ SÁCH", 100);
            this.listView3.Columns.Add("TÊN SÁCH", 200);
            this.listView3.Columns.Add("GIÁ BÌA", 150);
            this.listView3.Columns.Add("MÃ TÁC GIẢ", 100);
            this.listView3.Columns.Add("TÊN TÁC GIẢ", 150);
            this.listView3.Columns.Add("TÊN LĨNH VỰC", 150);
            this.listView3.Columns.Add("TÊN LOẠI SÁCH", 150);
            this.listView3.GridLines = true;
            this.listView3.FullRowSelect = true;
            this.listView3.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data3.Rows)
            {
                this.listView3.Items.Add(row["MASACH"].ToString());
                this.listView3.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.listView3.Items[i].SubItems.Add(row["GIABIA"].ToString());
                this.listView3.Items[i].SubItems.Add(row["MATG"].ToString());
                this.listView3.Items[i].SubItems.Add(row["TENTG"].ToString());
                this.listView3.Items[i].SubItems.Add(row["TENLINHVUC"].ToString());
                this.listView3.Items[i].SubItems.Add(row["TENLOAISACH"].ToString());
                i++;
            }
        }

        private void bThemHD_Click(object sender, EventArgs e)
        {
            listView1_SelectedIndexChanged();
            listView3_SelectedIndexChanged();
            txbMaHD_TextChanged();
            txbTenKH.Text = "";
            dateTimePicker_NgayLap.Text = DateTime.Now.ToString();
            MessageBox.Show("HOÀN THÀNH HÓA ĐƠN!", "THÔNG BÁO");
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
