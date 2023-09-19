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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lbcthd.Click += new System.EventHandler(this.lbcthd_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 539);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(353, 181);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 155);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "Quay lại";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 35);
            this.button4.TabIndex = 0;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(30, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 35);
            this.button5.TabIndex = 0;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 563);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbcthd);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChiTietHoaDon";
            this.Text = "ChiTietHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}