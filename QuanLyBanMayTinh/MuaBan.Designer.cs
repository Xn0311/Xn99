namespace QuanLyBanMayTinh
{
    partial class MuaBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuaBan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgvDongMay = new System.Windows.Forms.DataGridView();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.txtTimDongMay = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTimKhach = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgvDongMay
            // 
            this.dgvDongMay.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDongMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDongMay.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDongMay.Location = new System.Drawing.Point(12, 79);
            this.dgvDongMay.Name = "dgvDongMay";
            this.dgvDongMay.RowHeadersWidth = 51;
            this.dgvDongMay.RowTemplate.Height = 24;
            this.dgvDongMay.Size = new System.Drawing.Size(894, 272);
            this.dgvDongMay.TabIndex = 3;
            this.dgvDongMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDongMay_CellClick);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(432, 357);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(938, 297);
            this.dgvKhachHang.TabIndex = 4;
            // 
            // txtTimDongMay
            // 
            this.txtTimDongMay.Location = new System.Drawing.Point(12, 49);
            this.txtTimDongMay.Name = "txtTimDongMay";
            this.txtTimDongMay.Size = new System.Drawing.Size(165, 22);
            this.txtTimDongMay.TabIndex = 5;
            this.txtTimDongMay.Enter += new System.EventHandler(this.txtTimDongMay_Enter);
            this.txtTimDongMay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimDongMay_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtTimKhach
            // 
            this.txtTimKhach.Location = new System.Drawing.Point(1182, 329);
            this.txtTimKhach.Name = "txtTimKhach";
            this.txtTimKhach.Size = new System.Drawing.Size(188, 22);
            this.txtTimKhach.TabIndex = 5;
            this.txtTimKhach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKhach_KeyDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1152, 327);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(67, 87);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(120, 27);
            this.nudSoLuong.TabIndex = 7;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.btnMua);
            this.groupBox1.Controls.Add(this.nudSoLuong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(989, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 197);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mua Hàng";
            // 
            // btnMua
            // 
            this.btnMua.Location = new System.Drawing.Point(193, 76);
            this.btnMua.Name = "btnMua";
            this.btnMua.Size = new System.Drawing.Size(95, 47);
            this.btnMua.TabIndex = 8;
            this.btnMua.Text = "Mua";
            this.btnMua.UseVisualStyleBackColor = true;
            this.btnMua.Click += new System.EventHandler(this.btnMua_Click);
            // 
            // MuaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTimKhach);
            this.Controls.Add(this.txtTimDongMay);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.dgvDongMay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MuaBan";
            this.Text = "Mua Hàng";
            this.Load += new System.EventHandler(this.MuaBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvDongMay;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtTimDongMay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimKhach;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMua;
    }
}