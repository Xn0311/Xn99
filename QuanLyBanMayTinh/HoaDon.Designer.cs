namespace QuanLyBanMayTinh
{
    partial class HoaDon
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
            this.ldhd = new System.Windows.Forms.Label();
            this.lbmahd = new System.Windows.Forms.Label();
            this.lbmakh = new System.Windows.Forms.Label();
            this.lbmanv = new System.Windows.Forms.Label();
            this.lbngaydat = new System.Windows.Forms.Label();
            this.lbngaynhan = new System.Windows.Forms.Label();
            this.lbnoinhan = new System.Windows.Forms.Label();
            this.ttbnoinhan = new System.Windows.Forms.TextBox();
            this.ttbmahd = new System.Windows.Forms.TextBox();
            this.ttbmakh = new System.Windows.Forms.TextBox();
            this.ttbmanv = new System.Windows.Forms.TextBox();
            this.dtpngaynhan = new System.Windows.Forms.DateTimePicker();
            this.dtpngaydat = new System.Windows.Forms.DateTimePicker();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // ldhd
            // 
            this.ldhd.AutoSize = true;
            this.ldhd.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ldhd.Location = new System.Drawing.Point(450, 9);
            this.ldhd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldhd.Name = "ldhd";
            this.ldhd.Size = new System.Drawing.Size(301, 37);
            this.ldhd.TabIndex = 0;
            this.ldhd.Text = "Hóa Đơn Thanh Toán";
            this.ldhd.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbmahd
            // 
            this.lbmahd.AutoSize = true;
            this.lbmahd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmahd.Location = new System.Drawing.Point(170, 66);
            this.lbmahd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmahd.Name = "lbmahd";
            this.lbmahd.Size = new System.Drawing.Size(113, 22);
            this.lbmahd.TabIndex = 0;
            this.lbmahd.Text = "Mã Hóa Đơn";
            // 
            // lbmakh
            // 
            this.lbmakh.AutoSize = true;
            this.lbmakh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmakh.Location = new System.Drawing.Point(146, 98);
            this.lbmakh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmakh.Name = "lbmakh";
            this.lbmakh.Size = new System.Drawing.Size(137, 22);
            this.lbmakh.TabIndex = 0;
            this.lbmakh.Text = "Mã Khách Hàng";
            this.lbmakh.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbmanv
            // 
            this.lbmanv.AutoSize = true;
            this.lbmanv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmanv.Location = new System.Drawing.Point(160, 136);
            this.lbmanv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmanv.Name = "lbmanv";
            this.lbmanv.Size = new System.Drawing.Size(123, 22);
            this.lbmanv.TabIndex = 0;
            this.lbmanv.Text = "Mã Nhân Viên";
            // 
            // lbngaydat
            // 
            this.lbngaydat.AutoSize = true;
            this.lbngaydat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbngaydat.Location = new System.Drawing.Point(641, 66);
            this.lbngaydat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbngaydat.Name = "lbngaydat";
            this.lbngaydat.Size = new System.Drawing.Size(84, 22);
            this.lbngaydat.TabIndex = 0;
            this.lbngaydat.Text = "Ngày Đặt";
            // 
            // lbngaynhan
            // 
            this.lbngaynhan.AutoSize = true;
            this.lbngaynhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbngaynhan.Location = new System.Drawing.Point(628, 98);
            this.lbngaynhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbngaynhan.Name = "lbngaynhan";
            this.lbngaynhan.Size = new System.Drawing.Size(97, 22);
            this.lbngaynhan.TabIndex = 0;
            this.lbngaynhan.Text = "Ngày Nhận";
            // 
            // lbnoinhan
            // 
            this.lbnoinhan.AutoSize = true;
            this.lbnoinhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbnoinhan.Location = new System.Drawing.Point(638, 136);
            this.lbnoinhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnoinhan.Name = "lbnoinhan";
            this.lbnoinhan.Size = new System.Drawing.Size(87, 22);
            this.lbnoinhan.TabIndex = 0;
            this.lbnoinhan.Text = "Nơi Nhận";
            // 
            // ttbnoinhan
            // 
            this.ttbnoinhan.Location = new System.Drawing.Point(745, 131);
            this.ttbnoinhan.Name = "ttbnoinhan";
            this.ttbnoinhan.Size = new System.Drawing.Size(246, 30);
            this.ttbnoinhan.TabIndex = 1;
            // 
            // ttbmahd
            // 
            this.ttbmahd.Location = new System.Drawing.Point(290, 60);
            this.ttbmahd.Name = "ttbmahd";
            this.ttbmahd.Size = new System.Drawing.Size(233, 30);
            this.ttbmahd.TabIndex = 1;
            // 
            // ttbmakh
            // 
            this.ttbmakh.Location = new System.Drawing.Point(290, 95);
            this.ttbmakh.Name = "ttbmakh";
            this.ttbmakh.Size = new System.Drawing.Size(233, 30);
            this.ttbmakh.TabIndex = 1;
            // 
            // ttbmanv
            // 
            this.ttbmanv.Location = new System.Drawing.Point(290, 131);
            this.ttbmanv.Name = "ttbmanv";
            this.ttbmanv.Size = new System.Drawing.Size(233, 30);
            this.ttbmanv.TabIndex = 2;
            // 
            // dtpngaynhan
            // 
            this.dtpngaynhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaynhan.Location = new System.Drawing.Point(745, 94);
            this.dtpngaynhan.Name = "dtpngaynhan";
            this.dtpngaynhan.Size = new System.Drawing.Size(140, 30);
            this.dtpngaynhan.TabIndex = 3;
            // 
            // dtpngaydat
            // 
            this.dtpngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaydat.Location = new System.Drawing.Point(745, 58);
            this.dtpngaydat.Name = "dtpngaydat";
            this.dtpngaydat.Size = new System.Drawing.Size(140, 30);
            this.dtpngaydat.TabIndex = 3;
            // 
            // btnquaylai
            // 
            this.btnquaylai.Location = new System.Drawing.Point(900, 569);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(91, 31);
            this.btnquaylai.TabIndex = 0;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(759, 569);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(93, 31);
            this.btntimkiem.TabIndex = 0;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(642, 569);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(74, 31);
            this.btnxoa.TabIndex = 0;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(525, 569);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(74, 31);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(407, 569);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(68, 31);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(119, 189);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(1158, 349);
            this.dgv1.TabIndex = 5;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 632);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.dtpngaydat);
            this.Controls.Add(this.dtpngaynhan);
            this.Controls.Add(this.ttbmanv);
            this.Controls.Add(this.ttbmakh);
            this.Controls.Add(this.ttbmahd);
            this.Controls.Add(this.ttbnoinhan);
            this.Controls.Add(this.lbmanv);
            this.Controls.Add(this.lbmakh);
            this.Controls.Add(this.lbnoinhan);
            this.Controls.Add(this.lbngaynhan);
            this.Controls.Add(this.lbngaydat);
            this.Controls.Add(this.lbmahd);
            this.Controls.Add(this.ldhd);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoaDon";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ldhd;
        private System.Windows.Forms.Label lbmahd;
        private System.Windows.Forms.Label lbmakh;
        private System.Windows.Forms.Label lbmanv;
        private System.Windows.Forms.Label lbngaydat;
        private System.Windows.Forms.Label lbngaynhan;
        private System.Windows.Forms.Label lbnoinhan;
        private System.Windows.Forms.TextBox ttbnoinhan;
        private System.Windows.Forms.TextBox ttbmahd;
        private System.Windows.Forms.TextBox ttbmakh;
        private System.Windows.Forms.TextBox ttbmanv;
        private System.Windows.Forms.DateTimePicker dtpngaynhan;
        private System.Windows.Forms.DateTimePicker dtpngaydat;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgv1;
    }
}