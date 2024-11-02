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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtDanhMucID = new System.Windows.Forms.TextBox();
            this.ptbAnh = new System.Windows.Forms.PictureBox();
            this.txtDongianban = new System.Windows.Forms.TextBox();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.sp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
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
            this.lblQLSanpham.Size = new System.Drawing.Size(1072, 56);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Giá";
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
            this.label8.Location = new System.Drawing.Point(12, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Danh mục ID";
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
            this.txtSoluong.Location = new System.Drawing.Point(116, 153);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(227, 22);
            this.txtSoluong.TabIndex = 37;
            // 
            // txtDanhMucID
            // 
            this.txtDanhMucID.Location = new System.Drawing.Point(116, 236);
            this.txtDanhMucID.Multiline = true;
            this.txtDanhMucID.Name = "txtDanhMucID";
            this.txtDanhMucID.Size = new System.Drawing.Size(227, 22);
            this.txtDanhMucID.TabIndex = 39;
            // 
            // ptbAnh
            // 
            this.ptbAnh.Location = new System.Drawing.Point(758, 91);
            this.ptbAnh.Name = "ptbAnh";
            this.ptbAnh.Size = new System.Drawing.Size(314, 195);
            this.ptbAnh.TabIndex = 40;
            this.ptbAnh.TabStop = false;
            // 
            // txtDongianban
            // 
            this.txtDongianban.Location = new System.Drawing.Point(116, 194);
            this.txtDongianban.Name = "txtDongianban";
            this.txtDongianban.Size = new System.Drawing.Size(227, 22);
            this.txtDongianban.TabIndex = 42;
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sp_id,
            this.sp_ten,
            this.soluongton,
            this.sp_gia,
            this.sp_anh,
            this.dm_id});
            this.dgvSanpham.Location = new System.Drawing.Point(0, 292);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.RowHeadersWidth = 51;
            this.dgvSanpham.RowTemplate.Height = 24;
            this.dgvSanpham.Size = new System.Drawing.Size(1072, 225);
            this.dgvSanpham.TabIndex = 44;
            this.dgvSanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanpham_CellContentClick);
            // 
            // sp_id
            // 
            this.sp_id.HeaderText = "Mã sản phẩm";
            this.sp_id.MinimumWidth = 6;
            this.sp_id.Name = "sp_id";
            this.sp_id.Width = 125;
            // 
            // sp_ten
            // 
            this.sp_ten.HeaderText = "Tên sản phẩm";
            this.sp_ten.MinimumWidth = 6;
            this.sp_ten.Name = "sp_ten";
            this.sp_ten.Width = 125;
            // 
            // soluongton
            // 
            this.soluongton.HeaderText = "Số lượng tồn";
            this.soluongton.MinimumWidth = 6;
            this.soluongton.Name = "soluongton";
            this.soluongton.Width = 125;
            // 
            // sp_gia
            // 
            this.sp_gia.HeaderText = "Giá ";
            this.sp_gia.MinimumWidth = 6;
            this.sp_gia.Name = "sp_gia";
            this.sp_gia.Width = 125;
            // 
            // sp_anh
            // 
            this.sp_anh.HeaderText = "Ảnh";
            this.sp_anh.MinimumWidth = 6;
            this.sp_anh.Name = "sp_anh";
            this.sp_anh.Width = 125;
            // 
            // dm_id
            // 
            this.dm_id.HeaderText = "Danh mục ID";
            this.dm_id.MinimumWidth = 6;
            this.dm_id.Name = "dm_id";
            this.dm_id.Width = 125;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(964, 523);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(118, 43);
            this.btnDong.TabIndex = 49;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(802, 523);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 43);
            this.btnLuu.TabIndex = 48;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Location = new System.Drawing.Point(299, 525);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(98, 43);
            this.btnSuaSP.TabIndex = 47;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = true;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(148, 525);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(103, 43);
            this.btnXoaSP.TabIndex = 46;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.ImageKey = "(none)";
            this.btnThemSP.Location = new System.Drawing.Point(6, 523);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(100, 45);
            this.btnThemSP.TabIndex = 45;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
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
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1072, 593);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSuaSP);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.dgvSanpham);
            this.Controls.Add(this.txtDongianban);
            this.Controls.Add(this.ptbAnh);
            this.Controls.Add(this.txtDanhMucID);
            this.Controls.Add(this.txtURLAnh);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtDanhMucID;
        private System.Windows.Forms.PictureBox ptbAnh;
        private System.Windows.Forms.TextBox txtDongianban;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtURLAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sp_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongton;
        private System.Windows.Forms.DataGridViewTextBoxColumn sp_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sp_anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dm_id;
    }
}