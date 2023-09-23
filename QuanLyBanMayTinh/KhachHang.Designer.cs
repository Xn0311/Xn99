namespace QuanLyBanMayTinh
{
    partial class KHACHHANG
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
            this.btTHEM = new System.Windows.Forms.Button();
            this.lbMAKH = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.dgvkh = new System.Windows.Forms.DataGridView();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbTENKH = new System.Windows.Forms.Label();
            this.lbDIACHI = new System.Windows.Forms.Label();
            this.lbGIOITINH = new System.Windows.Forms.Label();
            this.lbNGAYSINH = new System.Windows.Forms.Label();
            this.lbKHACHHANG = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.btSUA = new System.Windows.Forms.Button();
            this.btXOA = new System.Windows.Forms.Button();
            this.btTIMKIEM = new System.Windows.Forms.Button();
            this.btQUAYLAI = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btTHEM
            // 
            this.btTHEM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTHEM.Location = new System.Drawing.Point(15, 485);
            this.btTHEM.Margin = new System.Windows.Forms.Padding(6);
            this.btTHEM.Name = "btTHEM";
            this.btTHEM.Size = new System.Drawing.Size(95, 45);
            this.btTHEM.TabIndex = 0;
            this.btTHEM.Text = "Thêm";
            this.btTHEM.UseVisualStyleBackColor = true;
            this.btTHEM.Click += new System.EventHandler(this.btTHEM_Click);
            // 
            // lbMAKH
            // 
            this.lbMAKH.AutoSize = true;
            this.lbMAKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMAKH.Location = new System.Drawing.Point(41, 35);
            this.lbMAKH.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbMAKH.Name = "lbMAKH";
            this.lbMAKH.Size = new System.Drawing.Size(142, 22);
            this.lbMAKH.TabIndex = 1;
            this.lbMAKH.Text = "Mã Khách Hàng ";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(195, 23);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaKhachHang.Multiline = true;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(262, 44);
            this.txtMaKhachHang.TabIndex = 2;
            // 
            // dgvkh
            // 
            this.dgvkh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvkh.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkh.Location = new System.Drawing.Point(499, 60);
            this.dgvkh.Margin = new System.Windows.Forms.Padding(6);
            this.dgvkh.Name = "dgvkh";
            this.dgvkh.RowHeadersWidth = 51;
            this.dgvkh.Size = new System.Drawing.Size(998, 527);
            this.dgvkh.TabIndex = 3;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinh.Location = new System.Drawing.Point(195, 224);
            this.dtpngaysinh.Margin = new System.Windows.Forms.Padding(6);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(262, 30);
            this.dtpngaysinh.TabIndex = 4;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSDT.Location = new System.Drawing.Point(60, 345);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(125, 22);
            this.lbSDT.TabIndex = 1;
            this.lbSDT.Text = "Số Điện Thoại";
            // 
            // lbTENKH
            // 
            this.lbTENKH.AutoSize = true;
            this.lbTENKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTENKH.Location = new System.Drawing.Point(42, 105);
            this.lbTENKH.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTENKH.Name = "lbTENKH";
            this.lbTENKH.Size = new System.Drawing.Size(141, 22);
            this.lbTENKH.TabIndex = 1;
            this.lbTENKH.Text = "Tên Khách Hàng";
            // 
            // lbDIACHI
            // 
            this.lbDIACHI.AutoSize = true;
            this.lbDIACHI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDIACHI.Location = new System.Drawing.Point(111, 280);
            this.lbDIACHI.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDIACHI.Name = "lbDIACHI";
            this.lbDIACHI.Size = new System.Drawing.Size(72, 22);
            this.lbDIACHI.TabIndex = 1;
            this.lbDIACHI.Text = "Địa Chỉ";
            // 
            // lbGIOITINH
            // 
            this.lbGIOITINH.AutoSize = true;
            this.lbGIOITINH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGIOITINH.Location = new System.Drawing.Point(95, 163);
            this.lbGIOITINH.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbGIOITINH.Name = "lbGIOITINH";
            this.lbGIOITINH.Size = new System.Drawing.Size(88, 22);
            this.lbGIOITINH.TabIndex = 1;
            this.lbGIOITINH.Text = "Giới Tính";
            // 
            // lbNGAYSINH
            // 
            this.lbNGAYSINH.AutoSize = true;
            this.lbNGAYSINH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNGAYSINH.Location = new System.Drawing.Point(92, 232);
            this.lbNGAYSINH.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNGAYSINH.Name = "lbNGAYSINH";
            this.lbNGAYSINH.Size = new System.Drawing.Size(91, 22);
            this.lbNGAYSINH.TabIndex = 1;
            this.lbNGAYSINH.Text = "Ngày Sinh";
            // 
            // lbKHACHHANG
            // 
            this.lbKHACHHANG.AutoSize = true;
            this.lbKHACHHANG.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKHACHHANG.Location = new System.Drawing.Point(732, 15);
            this.lbKHACHHANG.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbKHACHHANG.Name = "lbKHACHHANG";
            this.lbKHACHHANG.Size = new System.Drawing.Size(180, 37);
            this.lbKHACHHANG.TabIndex = 1;
            this.lbKHACHHANG.Text = "Khách Hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(195, 92);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(262, 44);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(195, 160);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(6);
            this.txtGioiTinh.Multiline = true;
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(262, 40);
            this.txtGioiTinh.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(195, 277);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(6);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(262, 42);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(197, 342);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(6);
            this.txtSdt.Multiline = true;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(260, 42);
            this.txtSdt.TabIndex = 2;
            // 
            // btSUA
            // 
            this.btSUA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSUA.Location = new System.Drawing.Point(199, 485);
            this.btSUA.Margin = new System.Windows.Forms.Padding(6);
            this.btSUA.Name = "btSUA";
            this.btSUA.Size = new System.Drawing.Size(90, 45);
            this.btSUA.TabIndex = 0;
            this.btSUA.Text = "Sửa ";
            this.btSUA.UseVisualStyleBackColor = true;
            this.btSUA.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btXOA
            // 
            this.btXOA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXOA.Location = new System.Drawing.Point(380, 485);
            this.btXOA.Margin = new System.Windows.Forms.Padding(6);
            this.btXOA.Name = "btXOA";
            this.btXOA.Size = new System.Drawing.Size(107, 45);
            this.btXOA.TabIndex = 0;
            this.btXOA.Text = "Xóa";
            this.btXOA.UseVisualStyleBackColor = true;
            // 
            // btTIMKIEM
            // 
            this.btTIMKIEM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTIMKIEM.Location = new System.Drawing.Point(100, 542);
            this.btTIMKIEM.Margin = new System.Windows.Forms.Padding(6);
            this.btTIMKIEM.Name = "btTIMKIEM";
            this.btTIMKIEM.Size = new System.Drawing.Size(110, 45);
            this.btTIMKIEM.TabIndex = 0;
            this.btTIMKIEM.Text = "Tìm Kiếm";
            this.btTIMKIEM.UseVisualStyleBackColor = true;
            // 
            // btQUAYLAI
            // 
            this.btQUAYLAI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQUAYLAI.Location = new System.Drawing.Point(281, 542);
            this.btQUAYLAI.Margin = new System.Windows.Forms.Padding(6);
            this.btQUAYLAI.Name = "btQUAYLAI";
            this.btQUAYLAI.Size = new System.Drawing.Size(100, 45);
            this.btQUAYLAI.TabIndex = 0;
            this.btQUAYLAI.Text = "Quay Lại";
            this.btQUAYLAI.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMAKH);
            this.panel1.Controls.Add(this.dtpngaysinh);
            this.panel1.Controls.Add(this.txtSdt);
            this.panel1.Controls.Add(this.lbTENKH);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.lbGIOITINH);
            this.panel1.Controls.Add(this.lbNGAYSINH);
            this.panel1.Controls.Add(this.lbDIACHI);
            this.panel1.Controls.Add(this.txtGioiTinh);
            this.panel1.Controls.Add(this.lbSDT);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.txtMaKhachHang);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(4, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 409);
            this.panel1.TabIndex = 5;
            // 
            // KHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvkh);
            this.Controls.Add(this.lbKHACHHANG);
            this.Controls.Add(this.btQUAYLAI);
            this.Controls.Add(this.btTIMKIEM);
            this.Controls.Add(this.btXOA);
            this.Controls.Add(this.btSUA);
            this.Controls.Add(this.btTHEM);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "KHACHHANG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHACHHANG";
            this.Load += new System.EventHandler(this.KHACHHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTHEM;
        private System.Windows.Forms.Label lbMAKH;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.DataGridView dgvkh;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbTENKH;
        private System.Windows.Forms.Label lbDIACHI;
        private System.Windows.Forms.Label lbGIOITINH;
        private System.Windows.Forms.Label lbNGAYSINH;
        private System.Windows.Forms.Label lbKHACHHANG;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Button btSUA;
        private System.Windows.Forms.Button btXOA;
        private System.Windows.Forms.Button btTIMKIEM;
        private System.Windows.Forms.Button btQUAYLAI;
        private System.Windows.Forms.Panel panel1;
    }
}