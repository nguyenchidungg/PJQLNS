﻿
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fLoaiSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bThem = new System.Windows.Forms.Button();
            this.bXoa = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(410, 364);
            this.dataGridView1.TabIndex = 1;
            // 
            // bThem
            // 
            this.bThem.Location = new System.Drawing.Point(12, 397);
            this.bThem.Name = "bThem";
            this.bThem.Size = new System.Drawing.Size(121, 29);
            this.bThem.TabIndex = 14;
            this.bThem.Text = "THÊM";
            this.bThem.UseVisualStyleBackColor = true;
            this.bThem.Click += new System.EventHandler(this.bThem_Click);
            // 
            // bXoa
            // 
            this.bXoa.Location = new System.Drawing.Point(156, 397);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(121, 29);
            this.bXoa.TabIndex = 15;
            this.bXoa.Text = "XÓA";
            this.bXoa.UseVisualStyleBackColor = true;
            this.bXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(301, 397);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 16;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // fLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 436);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.bXoa);
            this.Controls.Add(this.bThem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOẠI SÁCH";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bThem;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.Button fThoat;
    }
}