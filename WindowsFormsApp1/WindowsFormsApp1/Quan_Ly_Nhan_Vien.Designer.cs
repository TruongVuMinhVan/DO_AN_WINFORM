namespace WindowsFormsApp1
{
    partial class Quan_Ly_Nhan_Vien
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
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtQLNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.grbQLNV = new System.Windows.Forms.GroupBox();
            this.dgvQLNV = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbQLNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLKhachhang
            // 
            this.lblQLKhachhang.BackColor = System.Drawing.Color.HotPink;
            this.lblQLKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQLKhachhang.Location = new System.Drawing.Point(2, 2);
            this.lblQLKhachhang.Name = "lblQLKhachhang";
            this.lblQLKhachhang.Size = new System.Drawing.Size(799, 86);
            this.lblQLKhachhang.TabIndex = 23;
            this.lblQLKhachhang.Text = "Quản Lý Nhân viên";
            this.lblQLKhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(155, 109);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(223, 22);
            this.txtSDT.TabIndex = 22;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(155, 73);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(223, 22);
            this.txtTenNV.TabIndex = 21;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSDT.Location = new System.Drawing.Point(19, 109);
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
            this.lblTenKhachHang.Location = new System.Drawing.Point(19, 73);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(118, 20);
            this.lblTenKhachHang.TabIndex = 19;
            this.lblTenKhachHang.Text = "Tên nhân viên:";
            this.lblTenKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQLNV
            // 
            this.txtQLNV.Location = new System.Drawing.Point(155, 31);
            this.txtQLNV.Name = "txtQLNV";
            this.txtQLNV.Size = new System.Drawing.Size(223, 22);
            this.txtQLNV.TabIndex = 24;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaNV.Location = new System.Drawing.Point(19, 31);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(113, 20);
            this.lblMaNV.TabIndex = 25;
            this.lblMaNV.Text = "Mã nhân viên:";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbQLNV
            // 
            this.grbQLNV.Controls.Add(this.btnThoat);
            this.grbQLNV.Controls.Add(this.btnLuu);
            this.grbQLNV.Controls.Add(this.btnSua);
            this.grbQLNV.Controls.Add(this.btnXoa);
            this.grbQLNV.Controls.Add(this.btnThem);
            this.grbQLNV.Controls.Add(this.txtTenNV);
            this.grbQLNV.Controls.Add(this.lblMaNV);
            this.grbQLNV.Controls.Add(this.lblTenKhachHang);
            this.grbQLNV.Controls.Add(this.txtQLNV);
            this.grbQLNV.Controls.Add(this.lblSDT);
            this.grbQLNV.Controls.Add(this.txtSDT);
            this.grbQLNV.Location = new System.Drawing.Point(8, 103);
            this.grbQLNV.Name = "grbQLNV";
            this.grbQLNV.Size = new System.Drawing.Size(389, 408);
            this.grbQLNV.TabIndex = 26;
            this.grbQLNV.TabStop = false;
            // 
            // dgvQLNV
            // 
            this.dgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNV.Location = new System.Drawing.Point(403, 103);
            this.dgvQLNV.Name = "dgvQLNV";
            this.dgvQLNV.RowHeadersWidth = 51;
            this.dgvQLNV.RowTemplate.Height = 24;
            this.dgvQLNV.Size = new System.Drawing.Size(397, 407);
            this.dgvQLNV.TabIndex = 29;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 175);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 32);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(122, 175);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 32);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(245, 175);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 32);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(56, 242);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 32);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(189, 242);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 32);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Quan_Ly_Nhan_Vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.dgvQLNV);
            this.Controls.Add(this.grbQLNV);
            this.Controls.Add(this.lblQLKhachhang);
            this.Name = "Quan_Ly_Nhan_Vien";
            this.Text = "Quan_Ly_Nhan_Vien";
            this.grbQLNV.ResumeLayout(false);
            this.grbQLNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQLKhachhang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtQLNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.GroupBox grbQLNV;
        private System.Windows.Forms.DataGridView dgvQLNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}