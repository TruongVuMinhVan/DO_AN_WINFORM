namespace WindowsFormsApp1
{
    partial class frmKhachHang
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
            this.lblQLKhachhang = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dgvQLKH = new System.Windows.Forms.DataGridView();
            this.grbQLNV = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSuaNhanVien = new System.Windows.Forms.Button();
            this.btnXoaNhanVien = new System.Windows.Forms.Button();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnTimKhachHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKH)).BeginInit();
            this.grbQLNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQLKhachhang
            // 
            this.lblQLKhachhang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQLKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQLKhachhang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQLKhachhang.Location = new System.Drawing.Point(1, -1);
            this.lblQLKhachhang.Name = "lblQLKhachhang";
            this.lblQLKhachhang.Size = new System.Drawing.Size(799, 58);
            this.lblQLKhachhang.TabIndex = 30;
            this.lblQLKhachhang.Text = "Quản Lý Khách Hàng";
            this.lblQLKhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQLKhachhang.Click += new System.EventHandler(this.lblQLKhachhang_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(142, 60);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(223, 22);
            this.txtTenKH.TabIndex = 21;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(142, 18);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(223, 22);
            this.txtMaKH.TabIndex = 24;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(562, 60);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(223, 22);
            this.txtSDT.TabIndex = 22;
            // 
            // dgvQLKH
            // 
            this.dgvQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLKH.Location = new System.Drawing.Point(7, 212);
            this.dgvQLKH.Name = "dgvQLKH";
            this.dgvQLKH.RowHeadersWidth = 51;
            this.dgvQLKH.RowTemplate.Height = 24;
            this.dgvQLKH.Size = new System.Drawing.Size(793, 241);
            this.dgvQLKH.TabIndex = 32;
            // 
            // grbQLNV
            // 
            this.grbQLNV.Controls.Add(this.label5);
            this.grbQLNV.Controls.Add(this.textBox1);
            this.grbQLNV.Controls.Add(this.txtTenKH);
            this.grbQLNV.Controls.Add(this.txtMaKH);
            this.grbQLNV.Controls.Add(this.txtSDT);
            this.grbQLNV.Controls.Add(this.label4);
            this.grbQLNV.Controls.Add(this.label3);
            this.grbQLNV.Controls.Add(this.label2);
            this.grbQLNV.Location = new System.Drawing.Point(7, 105);
            this.grbQLNV.Name = "grbQLNV";
            this.grbQLNV.Size = new System.Drawing.Size(793, 101);
            this.grbQLNV.TabIndex = 31;
            this.grbQLNV.TabStop = false;
            this.grbQLNV.Enter += new System.EventHandler(this.grbQLNV_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(429, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Địa chỉ :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(562, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 22);
            this.textBox1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mã khách hàng:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên khách hàng:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(429, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Số điện thoại:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(701, 463);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(94, 25);
            this.btnDong.TabIndex = 42;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 25);
            this.button1.TabIndex = 41;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.Location = new System.Drawing.Point(319, 463);
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.Size = new System.Drawing.Size(74, 25);
            this.btnSuaNhanVien.TabIndex = 40;
            this.btnSuaNhanVien.Text = "Sửa";
            this.btnSuaNhanVien.UseVisualStyleBackColor = true;
            this.btnSuaNhanVien.Click += new System.EventHandler(this.btnSuaNhanVien_Click);
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.Location = new System.Drawing.Point(168, 463);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(79, 25);
            this.btnXoaNhanVien.TabIndex = 39;
            this.btnXoaNhanVien.Text = "Xóa";
            this.btnXoaNhanVien.UseVisualStyleBackColor = true;
            this.btnXoaNhanVien.Click += new System.EventHandler(this.btnXoaNhanVien_Click);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.ImageKey = "(none)";
            this.btnThemNhanVien.Location = new System.Drawing.Point(26, 461);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(76, 27);
            this.btnThemNhanVien.TabIndex = 38;
            this.btnThemNhanVien.Text = "Thêm";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(563, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 22);
            this.textBox2.TabIndex = 43;
            this.textBox2.Text = "Nhập SĐT khách hàng";
            // 
            // btnTimKhachHang
            // 
            this.btnTimKhachHang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTimKhachHang.Location = new System.Drawing.Point(482, 76);
            this.btnTimKhachHang.Name = "btnTimKhachHang";
            this.btnTimKhachHang.Size = new System.Drawing.Size(75, 23);
            this.btnTimKhachHang.TabIndex = 44;
            this.btnTimKhachHang.Text = "Tìm ";
            this.btnTimKhachHang.UseVisualStyleBackColor = false;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 500);
            this.Controls.Add(this.btnTimKhachHang);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSuaNhanVien);
            this.Controls.Add(this.btnXoaNhanVien);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.lblQLKhachhang);
            this.Controls.Add(this.dgvQLKH);
            this.Controls.Add(this.grbQLNV);
            this.Name = "frmKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKH)).EndInit();
            this.grbQLNV.ResumeLayout(false);
            this.grbQLNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLKhachhang;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridView dgvQLKH;
        private System.Windows.Forms.GroupBox grbQLNV;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSuaNhanVien;
        private System.Windows.Forms.Button btnXoaNhanVien;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnTimKhachHang;
    }
}