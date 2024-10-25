namespace WindowsFormsApp1
{
    partial class San_Pham
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
            this.lblQLSanpham = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.ptbAnh = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDongianhap = new System.Windows.Forms.TextBox();
            this.txtDongiaban = new System.Windows.Forms.TextBox();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSuaNhanVien = new System.Windows.Forms.Button();
            this.btnXoaNhanVien = new System.Windows.Forms.Button();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.txtURLAnh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLSanpham
            // 
            this.lblQLSanpham.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQLSanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQLSanpham.Location = new System.Drawing.Point(0, 4);
            this.lblQLSanpham.Name = "lblQLSanpham";
            this.lblQLSanpham.Size = new System.Drawing.Size(1046, 56);
            this.lblQLSanpham.TabIndex = 25;
            this.lblQLSanpham.Text = "Danh Sách Sản Phẩm";
            this.lblQLSanpham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Loại sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Đơn giá nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Đơn giá bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ảnh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ghi chú";
            // 
            // cmbLoaiSP
            // 
            this.cmbLoaiSP.FormattingEnabled = true;
            this.cmbLoaiSP.Location = new System.Drawing.Point(116, 154);
            this.cmbLoaiSP.Name = "cmbLoaiSP";
            this.cmbLoaiSP.Size = new System.Drawing.Size(227, 24);
            this.cmbLoaiSP.TabIndex = 34;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(116, 91);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(227, 22);
            this.txtMaSP.TabIndex = 35;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(116, 121);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(227, 22);
            this.txtTenSP.TabIndex = 36;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(116, 185);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(227, 22);
            this.txtSoluong.TabIndex = 37;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(421, 174);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(252, 96);
            this.txtGhichu.TabIndex = 39;
            // 
            // ptbAnh
            // 
            this.ptbAnh.Location = new System.Drawing.Point(758, 91);
            this.ptbAnh.Name = "ptbAnh";
            this.ptbAnh.Size = new System.Drawing.Size(181, 179);
            this.ptbAnh.TabIndex = 40;
            this.ptbAnh.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Mở";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDongianhap
            // 
            this.txtDongianhap.Location = new System.Drawing.Point(116, 217);
            this.txtDongianhap.Name = "txtDongianhap";
            this.txtDongianhap.Size = new System.Drawing.Size(227, 22);
            this.txtDongianhap.TabIndex = 42;
            // 
            // txtDongiaban
            // 
            this.txtDongiaban.Location = new System.Drawing.Point(116, 251);
            this.txtDongiaban.Name = "txtDongiaban";
            this.txtDongiaban.Size = new System.Drawing.Size(227, 22);
            this.txtDongiaban.TabIndex = 43;
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Location = new System.Drawing.Point(0, 292);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.RowHeadersWidth = 51;
            this.dgvSanpham.RowTemplate.Height = 24;
            this.dgvSanpham.Size = new System.Drawing.Size(950, 225);
            this.dgvSanpham.TabIndex = 44;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(821, 524);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(118, 43);
            this.btnDong.TabIndex = 49;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(708, 525);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 43);
            this.btnLuu.TabIndex = 48;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.Location = new System.Drawing.Point(299, 525);
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.Size = new System.Drawing.Size(98, 43);
            this.btnSuaNhanVien.TabIndex = 47;
            this.btnSuaNhanVien.Text = "Sửa";
            this.btnSuaNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.Location = new System.Drawing.Point(148, 525);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(103, 43);
            this.btnXoaNhanVien.TabIndex = 46;
            this.btnXoaNhanVien.Text = "Xóa";
            this.btnXoaNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.ImageKey = "(none)";
            this.btnThemNhanVien.Location = new System.Drawing.Point(6, 523);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(100, 45);
            this.btnThemNhanVien.TabIndex = 45;
            this.btnThemNhanVien.Text = "Thêm";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            // 
            // txtURLAnh
            // 
            this.txtURLAnh.Location = new System.Drawing.Point(421, 91);
            this.txtURLAnh.Multiline = true;
            this.txtURLAnh.Name = "txtURLAnh";
            this.txtURLAnh.Size = new System.Drawing.Size(252, 62);
            this.txtURLAnh.TabIndex = 38;
            // 
            // San_Pham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 679);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSuaNhanVien);
            this.Controls.Add(this.btnXoaNhanVien);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.dgvSanpham);
            this.Controls.Add(this.txtDongiaban);
            this.Controls.Add(this.txtDongianhap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ptbAnh);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.txtURLAnh);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.cmbLoaiSP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQLSanpham);
            this.Name = "San_Pham";
            this.Text = "Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQLSanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbLoaiSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.PictureBox ptbAnh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDongianhap;
        private System.Windows.Forms.TextBox txtDongiaban;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSuaNhanVien;
        private System.Windows.Forms.Button btnXoaNhanVien;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.TextBox txtURLAnh;
    }
}