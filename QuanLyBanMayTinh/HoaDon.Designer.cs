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
            this.lbngaydat = new System.Windows.Forms.Label();
            this.ttbmahd = new System.Windows.Forms.TextBox();
            this.ttbmakh = new System.Windows.Forms.TextBox();
            this.dtpngaydat = new System.Windows.Forms.DateTimePicker();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // ldhd
            // 
            this.ldhd.AutoSize = true;
            this.ldhd.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ldhd.Location = new System.Drawing.Point(482, 9);
            this.ldhd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldhd.Name = "ldhd";
            this.ldhd.Size = new System.Drawing.Size(301, 37);
            this.ldhd.TabIndex = 0;
            this.ldhd.Text = "Hóa Đơn Thanh Toán";
            // 
            // lbmahd
            // 
            this.lbmahd.AutoSize = true;
            this.lbmahd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmahd.Location = new System.Drawing.Point(364, 89);
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
            this.lbmakh.Location = new System.Drawing.Point(364, 130);
            this.lbmakh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmakh.Name = "lbmakh";
            this.lbmakh.Size = new System.Drawing.Size(137, 22);
            this.lbmakh.TabIndex = 0;
            this.lbmakh.Text = "Mã Khách Hàng";
            // 
            // lbngaydat
            // 
            this.lbngaydat.AutoSize = true;
            this.lbngaydat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbngaydat.Location = new System.Drawing.Point(364, 173);
            this.lbngaydat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbngaydat.Name = "lbngaydat";
            this.lbngaydat.Size = new System.Drawing.Size(91, 22);
            this.lbngaydat.TabIndex = 0;
            this.lbngaydat.Text = "Ngày Mua";
            // 
            // ttbmahd
            // 
            this.ttbmahd.Location = new System.Drawing.Point(508, 81);
            this.ttbmahd.Name = "ttbmahd";
            this.ttbmahd.Size = new System.Drawing.Size(233, 30);
            this.ttbmahd.TabIndex = 1;
            // 
            // ttbmakh
            // 
            this.ttbmakh.Location = new System.Drawing.Point(508, 127);
            this.ttbmakh.Name = "ttbmakh";
            this.ttbmakh.Size = new System.Drawing.Size(233, 30);
            this.ttbmakh.TabIndex = 2;
            // 
            // dtpngaydat
            // 
            this.dtpngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaydat.Location = new System.Drawing.Point(508, 165);
            this.dtpngaydat.Name = "dtpngaydat";
            this.dtpngaydat.Size = new System.Drawing.Size(233, 30);
            this.dtpngaydat.TabIndex = 4;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(791, 119);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(109, 32);
            this.btntimkiem.TabIndex = 9;
            this.btntimkiem.Text = "Xóa";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(791, 81);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(109, 32);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Sửa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(128, 234);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(1113, 374);
            this.dgv1.TabIndex = 5;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 659);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.dtpngaydat);
            this.Controls.Add(this.ttbmakh);
            this.Controls.Add(this.ttbmahd);
            this.Controls.Add(this.lbmakh);
            this.Controls.Add(this.lbngaydat);
            this.Controls.Add(this.lbmahd);
            this.Controls.Add(this.ldhd);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lbngaydat;
        private System.Windows.Forms.TextBox ttbmahd;
        private System.Windows.Forms.TextBox ttbmakh;
        private System.Windows.Forms.DateTimePicker dtpngaydat;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dgv1;
    }
}