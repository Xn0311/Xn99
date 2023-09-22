namespace QuanLyBanMayTinh
{
    partial class NhanViencs
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
            this.dtpns = new System.Windows.Forms.DateTimePicker();
            this.lbGIOITINH = new System.Windows.Forms.Label();
            this.dgvnv = new System.Windows.Forms.DataGridView();
            this.lbQLNV = new System.Windows.Forms.Label();
            this.lbMANV = new System.Windows.Forms.Label();
            this.lbTTLH = new System.Windows.Forms.Label();
            this.lbCHUCVU = new System.Windows.Forms.Label();
            this.lbTENNV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbmanv = new System.Windows.Forms.TextBox();
            this.ttbtennv = new System.Windows.Forms.TextBox();
            this.ttbgt = new System.Windows.Forms.TextBox();
            this.ttbcv = new System.Windows.Forms.TextBox();
            this.ttbttlh = new System.Windows.Forms.TextBox();
            this.btSUA = new System.Windows.Forms.Button();
            this.btXOA = new System.Windows.Forms.Button();
            this.btTIMKIEM = new System.Windows.Forms.Button();
            this.btQUAYLAI = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btTHEM
            // 
            this.btTHEM.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTHEM.Location = new System.Drawing.Point(430, 672);
            this.btTHEM.Margin = new System.Windows.Forms.Padding(6);
            this.btTHEM.Name = "btTHEM";
            this.btTHEM.Size = new System.Drawing.Size(95, 39);
            this.btTHEM.TabIndex = 0;
            this.btTHEM.Text = "Thêm ";
            this.btTHEM.UseVisualStyleBackColor = true;
            this.btTHEM.Click += new System.EventHandler(this.Them_Click);
            // 
            // dtpns
            // 
            this.dtpns.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpns.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpns.Location = new System.Drawing.Point(165, 140);
            this.dtpns.Margin = new System.Windows.Forms.Padding(6);
            this.dtpns.Name = "dtpns";
            this.dtpns.Size = new System.Drawing.Size(150, 30);
            this.dtpns.TabIndex = 1;
            // 
            // lbGIOITINH
            // 
            this.lbGIOITINH.AutoSize = true;
            this.lbGIOITINH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGIOITINH.Location = new System.Drawing.Point(753, 45);
            this.lbGIOITINH.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbGIOITINH.Name = "lbGIOITINH";
            this.lbGIOITINH.Size = new System.Drawing.Size(88, 22);
            this.lbGIOITINH.TabIndex = 2;
            this.lbGIOITINH.Text = "Giới Tính";
            // 
            // dgvnv
            // 
            this.dgvnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnv.Location = new System.Drawing.Point(202, 249);
            this.dgvnv.Margin = new System.Windows.Forms.Padding(6);
            this.dgvnv.Name = "dgvnv";
            this.dgvnv.Size = new System.Drawing.Size(1071, 411);
            this.dgvnv.TabIndex = 3;
            this.dgvnv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnv_CellContentClick);
            // 
            // lbQLNV
            // 
            this.lbQLNV.AutoSize = true;
            this.lbQLNV.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQLNV.Location = new System.Drawing.Point(617, 15);
            this.lbQLNV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbQLNV.Name = "lbQLNV";
            this.lbQLNV.Size = new System.Drawing.Size(279, 37);
            this.lbQLNV.TabIndex = 2;
            this.lbQLNV.Text = "Quản Lý Nhân Viên";
            // 
            // lbMANV
            // 
            this.lbMANV.AutoSize = true;
            this.lbMANV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMANV.Location = new System.Drawing.Point(26, 45);
            this.lbMANV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbMANV.Name = "lbMANV";
            this.lbMANV.Size = new System.Drawing.Size(123, 22);
            this.lbMANV.TabIndex = 2;
            this.lbMANV.Text = "Mã Nhân Viên";
            // 
            // lbTTLH
            // 
            this.lbTTLH.AutoSize = true;
            this.lbTTLH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTTLH.Location = new System.Drawing.Point(683, 140);
            this.lbTTLH.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTTLH.Name = "lbTTLH";
            this.lbTTLH.Size = new System.Drawing.Size(158, 22);
            this.lbTTLH.TabIndex = 2;
            this.lbTTLH.Text = "Thông Tin Liên Hệ";
            // 
            // lbCHUCVU
            // 
            this.lbCHUCVU.AutoSize = true;
            this.lbCHUCVU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCHUCVU.Location = new System.Drawing.Point(753, 94);
            this.lbCHUCVU.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCHUCVU.Name = "lbCHUCVU";
            this.lbCHUCVU.Size = new System.Drawing.Size(79, 22);
            this.lbCHUCVU.TabIndex = 2;
            this.lbCHUCVU.Text = "Chức Vụ";
            // 
            // lbTENNV
            // 
            this.lbTENNV.AutoSize = true;
            this.lbTENNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTENNV.Location = new System.Drawing.Point(26, 94);
            this.lbTENNV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTENNV.Name = "lbTENNV";
            this.lbTENNV.Size = new System.Drawing.Size(127, 22);
            this.lbTENNV.TabIndex = 2;
            this.lbTENNV.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(62, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Sinh";
            // 
            // ttbmanv
            // 
            this.ttbmanv.Location = new System.Drawing.Point(165, 42);
            this.ttbmanv.Margin = new System.Windows.Forms.Padding(6);
            this.ttbmanv.Name = "ttbmanv";
            this.ttbmanv.Size = new System.Drawing.Size(250, 30);
            this.ttbmanv.TabIndex = 4;
            // 
            // ttbtennv
            // 
            this.ttbtennv.Location = new System.Drawing.Point(165, 93);
            this.ttbtennv.Margin = new System.Windows.Forms.Padding(6);
            this.ttbtennv.Name = "ttbtennv";
            this.ttbtennv.Size = new System.Drawing.Size(253, 30);
            this.ttbtennv.TabIndex = 4;
            // 
            // ttbgt
            // 
            this.ttbgt.Location = new System.Drawing.Point(844, 42);
            this.ttbgt.Margin = new System.Windows.Forms.Padding(6);
            this.ttbgt.Name = "ttbgt";
            this.ttbgt.Size = new System.Drawing.Size(257, 30);
            this.ttbgt.TabIndex = 4;
            // 
            // ttbcv
            // 
            this.ttbcv.Location = new System.Drawing.Point(844, 91);
            this.ttbcv.Margin = new System.Windows.Forms.Padding(6);
            this.ttbcv.Name = "ttbcv";
            this.ttbcv.Size = new System.Drawing.Size(257, 30);
            this.ttbcv.TabIndex = 4;
            // 
            // ttbttlh
            // 
            this.ttbttlh.Location = new System.Drawing.Point(844, 140);
            this.ttbttlh.Margin = new System.Windows.Forms.Padding(6);
            this.ttbttlh.Name = "ttbttlh";
            this.ttbttlh.Size = new System.Drawing.Size(257, 30);
            this.ttbttlh.TabIndex = 4;
            // 
            // btSUA
            // 
            this.btSUA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSUA.Location = new System.Drawing.Point(559, 672);
            this.btSUA.Margin = new System.Windows.Forms.Padding(6);
            this.btSUA.Name = "btSUA";
            this.btSUA.Size = new System.Drawing.Size(86, 39);
            this.btSUA.TabIndex = 0;
            this.btSUA.Text = "Sửa ";
            this.btSUA.UseVisualStyleBackColor = true;
            this.btSUA.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btXOA
            // 
            this.btXOA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXOA.Location = new System.Drawing.Point(682, 672);
            this.btXOA.Margin = new System.Windows.Forms.Padding(6);
            this.btXOA.Name = "btXOA";
            this.btXOA.Size = new System.Drawing.Size(92, 39);
            this.btXOA.TabIndex = 0;
            this.btXOA.Text = "Xóa";
            this.btXOA.UseVisualStyleBackColor = true;
            // 
            // btTIMKIEM
            // 
            this.btTIMKIEM.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTIMKIEM.Location = new System.Drawing.Point(817, 672);
            this.btTIMKIEM.Margin = new System.Windows.Forms.Padding(6);
            this.btTIMKIEM.Name = "btTIMKIEM";
            this.btTIMKIEM.Size = new System.Drawing.Size(116, 39);
            this.btTIMKIEM.TabIndex = 0;
            this.btTIMKIEM.Text = "Tìm Kiếm";
            this.btTIMKIEM.UseVisualStyleBackColor = true;
            // 
            // btQUAYLAI
            // 
            this.btQUAYLAI.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQUAYLAI.Location = new System.Drawing.Point(970, 672);
            this.btQUAYLAI.Margin = new System.Windows.Forms.Padding(6);
            this.btQUAYLAI.Name = "btQUAYLAI";
            this.btQUAYLAI.Size = new System.Drawing.Size(117, 39);
            this.btQUAYLAI.TabIndex = 0;
            this.btQUAYLAI.Text = "Quay Lại";
            this.btQUAYLAI.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ttbtennv);
            this.panel1.Controls.Add(this.ttbttlh);
            this.panel1.Controls.Add(this.ttbcv);
            this.panel1.Controls.Add(this.ttbgt);
            this.panel1.Controls.Add(this.ttbmanv);
            this.panel1.Controls.Add(this.lbCHUCVU);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbTTLH);
            this.panel1.Controls.Add(this.lbTENNV);
            this.panel1.Controls.Add(this.lbMANV);
            this.panel1.Controls.Add(this.lbGIOITINH);
            this.panel1.Controls.Add(this.dtpns);
            this.panel1.Location = new System.Drawing.Point(172, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 183);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // NhanViencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvnv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbQLNV);
            this.Controls.Add(this.btQUAYLAI);
            this.Controls.Add(this.btTIMKIEM);
            this.Controls.Add(this.btXOA);
            this.Controls.Add(this.btSUA);
            this.Controls.Add(this.btTHEM);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NhanViencs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.NhanViencs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTHEM;
        private System.Windows.Forms.DateTimePicker dtpns;
        private System.Windows.Forms.Label lbGIOITINH;
        private System.Windows.Forms.DataGridView dgvnv;
        private System.Windows.Forms.Label lbQLNV;
        private System.Windows.Forms.Label lbMANV;
        private System.Windows.Forms.Label lbTTLH;
        private System.Windows.Forms.Label lbCHUCVU;
        private System.Windows.Forms.Label lbTENNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbmanv;
        private System.Windows.Forms.TextBox ttbtennv;
        private System.Windows.Forms.TextBox ttbgt;
        private System.Windows.Forms.TextBox ttbcv;
        private System.Windows.Forms.TextBox ttbttlh;
        private System.Windows.Forms.Button btSUA;
        private System.Windows.Forms.Button btXOA;
        private System.Windows.Forms.Button btTIMKIEM;
        private System.Windows.Forms.Button btQUAYLAI;
        private System.Windows.Forms.Panel panel1;
    }
}