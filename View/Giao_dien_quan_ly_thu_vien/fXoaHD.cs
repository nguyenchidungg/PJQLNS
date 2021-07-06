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
    public partial class fXoaHD : Form
    {
        public fXoaHD()
        {
            InitializeComponent();
            cbMaHD_SelectedIndexChanged();
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaHD_SelectedIndexChanged()
        {
            string query = "Select MAHOADON from HOADON";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            this.cbMaHD.DataSource = data;
            this.cbMaHD.DisplayMember = "MAHOADON";
        }
    }
}
