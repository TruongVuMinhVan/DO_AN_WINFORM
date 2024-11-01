namespace Do_An_WinForm
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
            this.btnTimKhachHang = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSuaNhanVien = new System.Windows.Forms.Button();
            this.btnXoaNhanVien = new System.Windows.Forms.Button();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.lblQLKhachhang = new System.Windows.Forms.Label();
            this.dgvQLKH = new System.Windows.Forms.DataGridView();
            this.grbQLNV = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKH)).BeginInit();
            this.grbQLNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKhachHang
            // 
            this.btnTimKhachHang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTimKhachHang.Location = new System.Drawing.Point(514, 77);
            this.btnTimKhachHang.Name = "btnTimKhachHang";
            this.btnTimKhachHang.Size = new System.Drawing.Size(75, 23);
            this.btnTimKhachHang.TabIndex = 54;
            this.btnTimKhachHang.Text = "Tìm ";
            this.btnTimKhachHang.UseVisualStyleBackColor = false;
            this.btnTimKhachHang.Click += new System.EventHandler(this.btnTimKhachHang_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtTimkiem.Location = new System.Drawing.Point(611, 77);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(229, 22);
            this.txtTimkiem.TabIndex = 53;
            this.txtTimkiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimkiem_KeyPress);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(805, 554);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(94, 25);
            this.btnDong.TabIndex = 52;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(680, 554);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(83, 25);
            this.btnLuu.TabIndex = 51;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.Location = new System.Drawing.Point(300, 554);
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.Size = new System.Drawing.Size(74, 25);
            this.btnSuaNhanVien.TabIndex = 50;
            this.btnSuaNhanVien.Text = "Sửa";
            this.btnSuaNhanVien.UseVisualStyleBackColor = true;
            this.btnSuaNhanVien.Click += new System.EventHandler(this.btnSuaNhanVien_Click);
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.Location = new System.Drawing.Point(149, 554);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(79, 25);
            this.btnXoaNhanVien.TabIndex = 49;
            this.btnXoaNhanVien.Text = "Xóa";
            this.btnXoaNhanVien.UseVisualStyleBackColor = true;
            this.btnXoaNhanVien.Click += new System.EventHandler(this.btnXoaNhanVien_Click);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.ImageKey = "(none)";
            this.btnThemNhanVien.Location = new System.Drawing.Point(7, 552);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(76, 27);
            this.btnThemNhanVien.TabIndex = 48;
            this.btnThemNhanVien.Text = "Thêm";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // lblQLKhachhang
            // 
            this.lblQLKhachhang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQLKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQLKhachhang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQLKhachhang.Location = new System.Drawing.Point(-2, -1);
            this.lblQLKhachhang.Name = "lblQLKhachhang";
            this.lblQLKhachhang.Size = new System.Drawing.Size(952, 58);
            this.lblQLKhachhang.TabIndex = 45;
            this.lblQLKhachhang.Text = "Quản Lý Khách Hàng";
            this.lblQLKhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvQLKH
            // 
            this.dgvQLKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLKH.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvQLKH.Location = new System.Drawing.Point(4, 212);
            this.dgvQLKH.Name = "dgvQLKH";
            this.dgvQLKH.RowHeadersWidth = 51;
            this.dgvQLKH.RowTemplate.Height = 24;
            this.dgvQLKH.Size = new System.Drawing.Size(946, 334);
            this.dgvQLKH.TabIndex = 47;
            this.dgvQLKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLKH_CellClick);
            this.dgvQLKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLKH_CellContentClick);
            // 
            // grbQLNV
            // 
            this.grbQLNV.Controls.Add(this.rdbNu);
            this.grbQLNV.Controls.Add(this.rdbNam);
            this.grbQLNV.Controls.Add(this.label5);
            this.grbQLNV.Controls.Add(this.txtTenKH);
            this.grbQLNV.Controls.Add(this.txtMaKH);
            this.grbQLNV.Controls.Add(this.txtSDT);
            this.grbQLNV.Controls.Add(this.label4);
            this.grbQLNV.Controls.Add(this.label3);
            this.grbQLNV.Controls.Add(this.label2);
            this.grbQLNV.Location = new System.Drawing.Point(4, 105);
            this.grbQLNV.Name = "grbQLNV";
            this.grbQLNV.Size = new System.Drawing.Size(946, 101);
            this.grbQLNV.TabIndex = 46;
            this.grbQLNV.TabStop = false;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(741, 19);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 20);
            this.rdbNu.TabIndex = 28;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(615, 19);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(57, 20);
            this.rdbNam.TabIndex = 27;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(474, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Giới Tính:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtSDT.Location = new System.Drawing.Point(607, 60);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(223, 22);
            this.txtSDT.TabIndex = 22;
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
            this.label2.Location = new System.Drawing.Point(474, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Số điện thoại:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Khách Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SĐT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 679);
            this.Controls.Add(this.btnTimKhachHang);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSuaNhanVien);
            this.Controls.Add(this.btnXoaNhanVien);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.lblQLKhachhang);
            this.Controls.Add(this.dgvQLKH);
            this.Controls.Add(this.grbQLNV);
            this.Name = "frmKhachHang";
            this.Text = "Khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKH)).EndInit();
            this.grbQLNV.ResumeLayout(false);
            this.grbQLNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKhachHang;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSuaNhanVien;
        private System.Windows.Forms.Button btnXoaNhanVien;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Label lblQLKhachhang;
        private System.Windows.Forms.DataGridView dgvQLKH;
        private System.Windows.Forms.GroupBox grbQLNV;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}