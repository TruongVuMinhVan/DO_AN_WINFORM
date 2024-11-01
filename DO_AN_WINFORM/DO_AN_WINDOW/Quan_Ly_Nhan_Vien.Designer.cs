namespace WindowsFormsApp1
{
    partial class frmQuanLyNhanVien
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
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.grbQLNV = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.btnXoaNhanVien = new System.Windows.Forms.Button();
            this.btnSuaNhanVien = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.nv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nv_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nv_diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nv_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbQLNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(138, 69);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(223, 22);
            this.txtTenNV.TabIndex = 21;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSDT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSDT.Location = new System.Drawing.Point(507, 73);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(111, 20);
            this.lblSDT.TabIndex = 20;
            this.lblSDT.Text = "Số điện thoại:";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenKhachHang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTenKhachHang.Location = new System.Drawing.Point(19, 71);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(118, 20);
            this.lblTenKhachHang.TabIndex = 19;
            this.lblTenKhachHang.Text = "Tên nhân viên:";
            this.lblTenKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(138, 27);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(223, 22);
            this.txtMaNV.TabIndex = 24;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaNV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMaNV.Location = new System.Drawing.Point(19, 27);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(113, 20);
            this.lblMaNV.TabIndex = 25;
            this.lblMaNV.Text = "Mã nhân viên:";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbQLNV
            // 
            this.grbQLNV.Controls.Add(this.txtSDT);
            this.grbQLNV.Controls.Add(this.label2);
            this.grbQLNV.Controls.Add(this.txtDiachi);
            this.grbQLNV.Controls.Add(this.txtTenNV);
            this.grbQLNV.Controls.Add(this.lblMaNV);
            this.grbQLNV.Controls.Add(this.lblTenKhachHang);
            this.grbQLNV.Controls.Add(this.txtMaNV);
            this.grbQLNV.Controls.Add(this.lblSDT);
            this.grbQLNV.Location = new System.Drawing.Point(12, 60);
            this.grbQLNV.Name = "grbQLNV";
            this.grbQLNV.Size = new System.Drawing.Size(1074, 147);
            this.grbQLNV.TabIndex = 26;
            this.grbQLNV.TabStop = false;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(632, 71);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(223, 22);
            this.txtSDT.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(507, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Địa Chỉ : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(632, 27);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(223, 22);
            this.txtDiachi.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(-6, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1092, 56);
            this.label1.TabIndex = 30;
            this.label1.Text = "Danh Sách Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nv_id,
            this.nv_ten,
            this.nv_diachi,
            this.nv_sdt});
            this.dgvNhanVien.Location = new System.Drawing.Point(2, 213);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(951, 276);
            this.dgvNhanVien.TabIndex = 31;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.ImageKey = "(none)";
            this.btnThemNhanVien.Location = new System.Drawing.Point(35, 531);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(100, 45);
            this.btnThemNhanVien.TabIndex = 32;
            this.btnThemNhanVien.Text = "Thêm";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click_1);
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.Location = new System.Drawing.Point(195, 533);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(103, 43);
            this.btnXoaNhanVien.TabIndex = 33;
            this.btnXoaNhanVien.Text = "Xóa";
            this.btnXoaNhanVien.UseVisualStyleBackColor = true;
            this.btnXoaNhanVien.Click += new System.EventHandler(this.btnXoaNhanVien_Click_1);
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.Location = new System.Drawing.Point(367, 533);
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.Size = new System.Drawing.Size(98, 43);
            this.btnSuaNhanVien.TabIndex = 34;
            this.btnSuaNhanVien.Text = "Sửa";
            this.btnSuaNhanVien.UseVisualStyleBackColor = true;
            this.btnSuaNhanVien.Click += new System.EventHandler(this.btnSuaNhanVien_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(644, 533);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 43);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(807, 533);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(118, 43);
            this.btnDong.TabIndex = 37;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // nv_id
            // 
            this.nv_id.HeaderText = "Mã nhân viên";
            this.nv_id.MinimumWidth = 6;
            this.nv_id.Name = "nv_id";
            // 
            // nv_ten
            // 
            this.nv_ten.HeaderText = "Tên nhân viên";
            this.nv_ten.MinimumWidth = 6;
            this.nv_ten.Name = "nv_ten";
            // 
            // nv_diachi
            // 
            this.nv_diachi.HeaderText = "Địa Chỉ";
            this.nv_diachi.MinimumWidth = 6;
            this.nv_diachi.Name = "nv_diachi";
            // 
            // nv_sdt
            // 
            this.nv_sdt.HeaderText = "Số điện thoại";
            this.nv_sdt.MinimumWidth = 6;
            this.nv_sdt.Name = "nv_sdt";
            // 
            // frmQuanLyNhanVien
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
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbQLNV);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmQuanLyNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.grbQLNV.ResumeLayout(false);
            this.grbQLNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.GroupBox grbQLNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.MaskedTextBox txtSDT;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Button btnXoaNhanVien;
        private System.Windows.Forms.Button btnSuaNhanVien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn nv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nv_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn nv_diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nv_sdt;
    }
}