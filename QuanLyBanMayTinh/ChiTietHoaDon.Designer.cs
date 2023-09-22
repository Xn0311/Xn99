namespace QuanLyBanMayTinh
{
    partial class ChiTietHoaDon
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
            this.lbcthd = new System.Windows.Forms.Label();
            this.lbmahd = new System.Windows.Forms.Label();
            this.lbmasp = new System.Windows.Forms.Label();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.lbgia = new System.Windows.Forms.Label();
            this.ttbmahd = new System.Windows.Forms.TextBox();
            this.ttbmasp = new System.Windows.Forms.TextBox();
            this.ttbsoluong = new System.Windows.Forms.TextBox();
            this.ttbgia = new System.Windows.Forms.TextBox();
            this.dgvct = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ttbtongtien = new System.Windows.Forms.TextBox();
            this.lbtongtien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbcthd
            // 
            this.lbcthd.AutoSize = true;
            this.lbcthd.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbcthd.Location = new System.Drawing.Point(61, 57);
            this.lbcthd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcthd.Name = "lbcthd";
            this.lbcthd.Size = new System.Drawing.Size(251, 37);
            this.lbcthd.TabIndex = 0;
            this.lbcthd.Text = "Chi Tiết Hóa Đơn";
            // 
            // lbmahd
            // 
            this.lbmahd.AutoSize = true;
            this.lbmahd.Location = new System.Drawing.Point(11, 23);
            this.lbmahd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmahd.Name = "lbmahd";
            this.lbmahd.Size = new System.Drawing.Size(113, 22);
            this.lbmahd.TabIndex = 0;
            this.lbmahd.Text = "Mã Hóa Đơn";
            // 
            // lbmasp
            // 
            this.lbmasp.AutoSize = true;
            this.lbmasp.Location = new System.Drawing.Point(6, 59);
            this.lbmasp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmasp.Name = "lbmasp";
            this.lbmasp.Size = new System.Drawing.Size(118, 22);
            this.lbmasp.TabIndex = 0;
            this.lbmasp.Text = "Mã Sản Phẩm";
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Location = new System.Drawing.Point(37, 95);
            this.lbsoluong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(87, 22);
            this.lbsoluong.TabIndex = 0;
            this.lbsoluong.Text = "Số Lượng";
            // 
            // lbgia
            // 
            this.lbgia.AutoSize = true;
            this.lbgia.Location = new System.Drawing.Point(85, 131);
            this.lbgia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbgia.Name = "lbgia";
            this.lbgia.Size = new System.Drawing.Size(39, 22);
            this.lbgia.TabIndex = 0;
            this.lbgia.Text = "Giá";
            // 
            // ttbmahd
            // 
            this.ttbmahd.Location = new System.Drawing.Point(131, 20);
            this.ttbmahd.Name = "ttbmahd";
            this.ttbmahd.Size = new System.Drawing.Size(204, 30);
            this.ttbmahd.TabIndex = 1;
            // 
            // ttbmasp
            // 
            this.ttbmasp.Location = new System.Drawing.Point(131, 56);
            this.ttbmasp.Name = "ttbmasp";
            this.ttbmasp.Size = new System.Drawing.Size(203, 30);
            this.ttbmasp.TabIndex = 2;
            // 
            // ttbsoluong
            // 
            this.ttbsoluong.Location = new System.Drawing.Point(131, 92);
            this.ttbsoluong.Name = "ttbsoluong";
            this.ttbsoluong.Size = new System.Drawing.Size(79, 30);
            this.ttbsoluong.TabIndex = 3;
            // 
            // ttbgia
            // 
            this.ttbgia.Location = new System.Drawing.Point(131, 128);
            this.ttbgia.Name = "ttbgia";
            this.ttbgia.Size = new System.Drawing.Size(169, 30);
            this.ttbgia.TabIndex = 4;
            // 
            // dgvct
            // 
            this.dgvct.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvct.Location = new System.Drawing.Point(377, 12);
            this.dgvct.Name = "dgvct";
            this.dgvct.RowTemplate.Height = 24;
            this.dgvct.Size = new System.Drawing.Size(788, 539);
            this.dgvct.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ttbtongtien);
            this.panel1.Controls.Add(this.lbtongtien);
            this.panel1.Controls.Add(this.ttbgia);
            this.panel1.Controls.Add(this.ttbsoluong);
            this.panel1.Controls.Add(this.ttbmasp);
            this.panel1.Controls.Add(this.ttbmahd);
            this.panel1.Controls.Add(this.lbgia);
            this.panel1.Controls.Add(this.lbsoluong);
            this.panel1.Controls.Add(this.lbmasp);
            this.panel1.Controls.Add(this.lbmahd);
            this.panel1.Location = new System.Drawing.Point(12, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 214);
            this.panel1.TabIndex = 6;
            // 
            // ttbtongtien
            // 
            this.ttbtongtien.Location = new System.Drawing.Point(131, 164);
            this.ttbtongtien.Name = "ttbtongtien";
            this.ttbtongtien.Size = new System.Drawing.Size(169, 30);
            this.ttbtongtien.TabIndex = 6;
            // 
            // lbtongtien
            // 
            this.lbtongtien.AutoSize = true;
            this.lbtongtien.Location = new System.Drawing.Point(34, 167);
            this.lbtongtien.Name = "lbtongtien";
            this.lbtongtien.Size = new System.Drawing.Size(90, 22);
            this.lbtongtien.TabIndex = 5;
            this.lbtongtien.Text = "Tổng Tiền";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btntimkiem);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnquaylai);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Location = new System.Drawing.Point(12, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 155);
            this.panel2.TabIndex = 7;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(30, 99);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(93, 35);
            this.btntimkiem.TabIndex = 0;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(271, 3);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(78, 35);
            this.btnxoa.TabIndex = 0;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnquaylai
            // 
            this.btnquaylai.Location = new System.Drawing.Point(212, 99);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(110, 35);
            this.btnquaylai.TabIndex = 0;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(142, 3);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(78, 35);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(3, 3);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(78, 35);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.them_Click);
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 563);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvct);
            this.Controls.Add(this.lbcthd);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChiTietHoaDon";
            this.Text = "ChiTietHoaDon";
            this.Load += new System.EventHandler(this.ChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcthd;
        private System.Windows.Forms.Label lbmahd;
        private System.Windows.Forms.Label lbmasp;
        private System.Windows.Forms.Label lbsoluong;
        private System.Windows.Forms.Label lbgia;
        private System.Windows.Forms.TextBox ttbmahd;
        private System.Windows.Forms.TextBox ttbmasp;
        private System.Windows.Forms.TextBox ttbsoluong;
        private System.Windows.Forms.TextBox ttbgia;
        private System.Windows.Forms.DataGridView dgvct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox ttbtongtien;
        private System.Windows.Forms.Label lbtongtien;
    }
}