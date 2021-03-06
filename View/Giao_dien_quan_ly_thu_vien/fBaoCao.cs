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
    public partial class fBaoCao : Form
    {
        public fBaoCao()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
            txb_TextChanged();
        }

        private void listView1_SelectedIndexChanged()
        {
            string query = "Select CHITIETHOADON.MASACH, TENSACH, SUM(SOLUONG) AS [SỐ LƯỢNG BÁN RA], " +
                "GIAMUA, GIABIA From CHITIETHOADON RIGHT JOIN SACH ON CHITIETHOADON.MASACH = SACH.MASACH " +
                "Group By CHITIETHOADON.MASACH, SACH.TENSACH, GIAMUA, GIABIA";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listView1.Clear();
            this.listView1.Items.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("MÃ SÁCH", 150);
            this.listView1.Columns.Add("TÊN SÁCH", 250);
            this.listView1.Columns.Add("SỐ LƯỢNG BÁN RA", 200);
            this.listView1.Columns.Add("GIÁ MUA", 200);
            this.listView1.Columns.Add("GIÁ BÌA", 200);
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listView1.Items.Add(row["MASACH"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.listView1.Items[i].SubItems.Add(row["SỐ LƯỢNG BÁN RA"].ToString());
                this.listView1.Items[i].SubItems.Add(row["GIAMUA"].ToString());
                this.listView1.Items[i].SubItems.Add(row["GIABIA"].ToString());
                i++;
            }
        }

        private void txb_TextChanged()
        {
            int von = 0;
            int tong = 0;
            float loinhuan;
            foreach (ListViewItem item in this.listView1.Items)
            {
                von = von + (Convert.ToInt32(item.SubItems[2].Text) * Convert.ToInt32(item.SubItems[3].Text));
                tong = tong + (Convert.ToInt32(item.SubItems[2].Text) * Convert.ToInt32(item.SubItems[4].Text));
            }
            loinhuan = tong - von;
            txbTongDoanhThu.Text = tong.ToString() + " VND";
            txbLoiNhuan.Text = loinhuan.ToString() + " VND";
        }

        private void bThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
