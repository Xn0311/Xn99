namespace QuanLyBanMayTinh
{
    partial class QLTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLTaiKhoan));
            this.txtPass = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DgvDangnhap = new System.Windows.Forms.DataGridView();
            this.txtUsename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnquanly = new System.Windows.Forms.RadioButton();
            this.rbtNhanvien = new System.Windows.Forms.RadioButton();
            this.bntDangKi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btndoimatkhau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDangnhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(115, 76);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(181, 22);
            this.txtPass.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DgvDangnhap
            // 
            this.DgvDangnhap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvDangnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDangnhap.Location = new System.Drawing.Point(12, 50);
            this.DgvDangnhap.Name = "DgvDangnhap";
            this.DgvDangnhap.RowHeadersWidth = 51;
            this.DgvDangnhap.RowTemplate.Height = 24;
            this.DgvDangnhap.Size = new System.Drawing.Size(776, 225);
            this.DgvDangnhap.TabIndex = 2;
            // 
            // txtUsename
            // 
            this.txtUsename.Location = new System.Drawing.Point(115, 48);
            this.txtUsename.Name = "txtUsename";
            this.txtUsename.Size = new System.Drawing.Size(181, 22);
            this.txtUsename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "PassWord";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnquanly);
            this.groupBox1.Controls.Add(this.rbtNhanvien);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsename);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(94, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài Khoản";
            // 
            // rbtnquanly
            // 
            this.rbtnquanly.AutoSize = true;
            this.rbtnquanly.Location = new System.Drawing.Point(219, 109);
            this.rbtnquanly.Name = "rbtnquanly";
            this.rbtnquanly.Size = new System.Drawing.Size(77, 20);
            this.rbtnquanly.TabIndex = 4;
            this.rbtnquanly.TabStop = true;
            this.rbtnquanly.Text = "Quản Lý";
            this.rbtnquanly.UseVisualStyleBackColor = true;
            // 
            // rbtNhanvien
            // 
            this.rbtNhanvien.AutoSize = true;
            this.rbtNhanvien.Location = new System.Drawing.Point(115, 109);
            this.rbtNhanvien.Name = "rbtNhanvien";
            this.rbtNhanvien.Size = new System.Drawing.Size(90, 20);
            this.rbtNhanvien.TabIndex = 3;
            this.rbtNhanvien.TabStop = true;
            this.rbtNhanvien.Text = "Nhân Viên";
            this.rbtNhanvien.UseVisualStyleBackColor = true;
            // 
            // bntDangKi
            // 
            this.bntDangKi.Location = new System.Drawing.Point(441, 354);
            this.bntDangKi.Name = "bntDangKi";
            this.bntDangKi.Size = new System.Drawing.Size(139, 31);
            this.bntDangKi.TabIndex = 5;
            this.bntDangKi.Text = "Đăng Kí";
            this.bntDangKi.UseVisualStyleBackColor = true;
            this.bntDangKi.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(586, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tìm Kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quản Lý Tài Khoản";
            // 
            // btndoimatkhau
            // 
            this.btndoimatkhau.Location = new System.Drawing.Point(441, 394);
            this.btndoimatkhau.Name = "btndoimatkhau";
            this.btndoimatkhau.Size = new System.Drawing.Size(139, 31);
            this.btndoimatkhau.TabIndex = 5;
            this.btndoimatkhau.Text = "Đổi Mật Khẩu";
            this.btndoimatkhau.UseVisualStyleBackColor = true;
            this.btndoimatkhau.Click += new System.EventHandler(this.button1_Click);
            // 
            // QLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btndoimatkhau);
            this.Controls.Add(this.bntDangKi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvDangnhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLTaiKhoan";
            this.Text = "QLTaiKhoan";
            this.Load += new System.EventHandler(this.QLTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDangnhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView DgvDangnhap;
        private System.Windows.Forms.TextBox txtUsename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntDangKi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbtnquanly;
        private System.Windows.Forms.RadioButton rbtNhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndoimatkhau;
    }
}