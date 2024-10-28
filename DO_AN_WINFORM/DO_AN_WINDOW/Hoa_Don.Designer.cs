namespace WindowsFormsApp1
{
    partial class Hoa_Don
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
            this.lblThongtinhoadon = new System.Windows.Forms.Label();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.dgvDanhSachHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.grpThongTinChung = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.cmbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.cmbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpThonTinHoaDon = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHuyHoaDon = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.khacH_HANGTableAdapter1 = new WindowsFormsApp1.QL_BANHANGDataSetTableAdapters.KHACH_HANGTableAdapter();
            this.cmbTimKiemMHD = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHD)).BeginInit();
            this.grpThongTinChung.SuspendLayout();
            this.grpThonTinHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThongtinhoadon
            // 
            this.lblThongtinhoadon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblThongtinhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongtinhoadon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblThongtinhoadon.Location = new System.Drawing.Point(6, 9);
            this.lblThongtinhoadon.Name = "lblThongtinhoadon";
            this.lblThongtinhoadon.Size = new System.Drawing.Size(931, 57);
            this.lblThongtinhoadon.TabIndex = 23;
            this.lblThongtinhoadon.Text = "Thông tin hóa đơn";
            this.lblThongtinhoadon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTongHoaDon
            // 
            this.lblTongHoaDon.AutoSize = true;
            this.lblTongHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongHoaDon.Location = new System.Drawing.Point(692, 516);
            this.lblTongHoaDon.Name = "lblTongHoaDon";
            this.lblTongHoaDon.Size = new System.Drawing.Size(122, 20);
            this.lblTongHoaDon.TabIndex = 15;
            this.lblTongHoaDon.Text = "Tổng Hóa Đơn:";
            // 
            // dgvDanhSachHD
            // 
            this.dgvDanhSachHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaNV,
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.DonGia});
            this.dgvDanhSachHD.Location = new System.Drawing.Point(6, 109);
            this.dgvDanhSachHD.Name = "dgvDanhSachHD";
            this.dgvDanhSachHD.RowHeadersWidth = 51;
            this.dgvDanhSachHD.RowTemplate.Height = 24;
            this.dgvDanhSachHD.Size = new System.Drawing.Size(913, 221);
            this.dgvDanhSachHD.TabIndex = 14;
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(118, 27);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(248, 22);
            this.txtMaHoaDon.TabIndex = 25;
            // 
            // grpThongTinChung
            // 
            this.grpThongTinChung.Controls.Add(this.rbNu);
            this.grpThongTinChung.Controls.Add(this.rbNam);
            this.grpThongTinChung.Controls.Add(this.cmbMaKhachHang);
            this.grpThongTinChung.Controls.Add(this.cmbMaNhanVien);
            this.grpThongTinChung.Controls.Add(this.dtpNgayBan);
            this.grpThongTinChung.Controls.Add(this.label5);
            this.grpThongTinChung.Controls.Add(this.textBox7);
            this.grpThongTinChung.Controls.Add(this.label6);
            this.grpThongTinChung.Controls.Add(this.label7);
            this.grpThongTinChung.Controls.Add(this.txtTenKhachHang);
            this.grpThongTinChung.Controls.Add(this.label8);
            this.grpThongTinChung.Controls.Add(this.label4);
            this.grpThongTinChung.Controls.Add(this.txtTenNhanVien);
            this.grpThongTinChung.Controls.Add(this.label3);
            this.grpThongTinChung.Controls.Add(this.label2);
            this.grpThongTinChung.Controls.Add(this.label1);
            this.grpThongTinChung.Controls.Add(this.txtMaHoaDon);
            this.grpThongTinChung.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpThongTinChung.Location = new System.Drawing.Point(12, 69);
            this.grpThongTinChung.Name = "grpThongTinChung";
            this.grpThongTinChung.Size = new System.Drawing.Size(925, 155);
            this.grpThongTinChung.TabIndex = 26;
            this.grpThongTinChung.TabStop = false;
            this.grpThongTinChung.Text = "Thông tin Chung";
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(728, 91);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(45, 20);
            this.rbNu.TabIndex = 44;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(595, 91);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 20);
            this.rbNam.TabIndex = 43;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // cmbMaKhachHang
            // 
            this.cmbMaKhachHang.FormattingEnabled = true;
            this.cmbMaKhachHang.Location = new System.Drawing.Point(595, 24);
            this.cmbMaKhachHang.Name = "cmbMaKhachHang";
            this.cmbMaKhachHang.Size = new System.Drawing.Size(236, 24);
            this.cmbMaKhachHang.TabIndex = 42;
            // 
            // cmbMaNhanVien
            // 
            this.cmbMaNhanVien.FormattingEnabled = true;
            this.cmbMaNhanVien.Location = new System.Drawing.Point(118, 87);
            this.cmbMaNhanVien.Name = "cmbMaNhanVien";
            this.cmbMaNhanVien.Size = new System.Drawing.Size(248, 24);
            this.cmbMaNhanVien.TabIndex = 41;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBan.Location = new System.Drawing.Point(118, 54);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(248, 22);
            this.dtpNgayBan.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(469, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Điện thoại";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(595, 127);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(236, 22);
            this.textBox7.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(469, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(469, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tên khách hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(595, 59);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(236, 22);
            this.txtTenKhachHang.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(474, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(19, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tên nhân viên";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(118, 120);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(248, 22);
            this.txtTenNhanVien.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(19, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ngày bán";
            // 
            // grpThonTinHoaDon
            // 
            this.grpThonTinHoaDon.Controls.Add(this.btnDong);
            this.grpThonTinHoaDon.Controls.Add(this.label12);
            this.grpThonTinHoaDon.Controls.Add(this.btnLuuHoaDon);
            this.grpThonTinHoaDon.Controls.Add(this.label11);
            this.grpThonTinHoaDon.Controls.Add(this.btnHuyHoaDon);
            this.grpThonTinHoaDon.Controls.Add(this.txtTongTien);
            this.grpThonTinHoaDon.Controls.Add(this.label25);
            this.grpThonTinHoaDon.Controls.Add(this.btnThemHoaDon);
            this.grpThonTinHoaDon.Controls.Add(this.label9);
            this.grpThonTinHoaDon.Controls.Add(this.txtMaSanPham);
            this.grpThonTinHoaDon.Controls.Add(this.label24);
            this.grpThonTinHoaDon.Controls.Add(this.label10);
            this.grpThonTinHoaDon.Controls.Add(this.txtSoLuong);
            this.grpThonTinHoaDon.Controls.Add(this.label23);
            this.grpThonTinHoaDon.Controls.Add(this.dgvDanhSachHD);
            this.grpThonTinHoaDon.Controls.Add(this.label22);
            this.grpThonTinHoaDon.Controls.Add(this.label21);
            this.grpThonTinHoaDon.Controls.Add(this.label14);
            this.grpThonTinHoaDon.Controls.Add(this.label20);
            this.grpThonTinHoaDon.Controls.Add(this.txtTenSanPham);
            this.grpThonTinHoaDon.Controls.Add(this.label19);
            this.grpThonTinHoaDon.Controls.Add(this.label15);
            this.grpThonTinHoaDon.Controls.Add(this.label18);
            this.grpThonTinHoaDon.Controls.Add(this.txtThanhTien);
            this.grpThonTinHoaDon.Controls.Add(this.label16);
            this.grpThonTinHoaDon.Controls.Add(this.txtDonGia);
            this.grpThonTinHoaDon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpThonTinHoaDon.Location = new System.Drawing.Point(12, 230);
            this.grpThonTinHoaDon.Name = "grpThonTinHoaDon";
            this.grpThonTinHoaDon.Size = new System.Drawing.Size(925, 395);
            this.grpThonTinHoaDon.TabIndex = 40;
            this.grpThonTinHoaDon.TabStop = false;
            this.grpThonTinHoaDon.Text = "Thông tin Hóa Đơn";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(799, 367);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(118, 27);
            this.btnDong.TabIndex = 50;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(6, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 16);
            this.label12.TabIndex = 42;
            this.label12.Text = "Nháy đúp 1 dòng để xóa";
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.Location = new System.Drawing.Point(210, 367);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(107, 27);
            this.btnLuuHoaDon.TabIndex = 49;
            this.btnLuuHoaDon.Text = "Lưu hóa đơn";
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(661, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 40;
            this.label11.Text = "Tổng tiền";
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.Location = new System.Drawing.Point(421, 366);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(114, 27);
            this.btnHuyHoaDon.TabIndex = 48;
            this.btnHuyHoaDon.Text = "Hủy hóa đơn";
            this.btnHuyHoaDon.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(730, 333);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(187, 22);
            this.txtTongTien.TabIndex = 41;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(384, 643);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(103, 27);
            this.btnInHoaDon.TabIndex = 47;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label25.Location = new System.Drawing.Point(469, -38);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(66, 16);
            this.label25.TabIndex = 38;
            this.label25.Text = "Điện thoại";
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.ImageKey = "(none)";
            this.btnThemHoaDon.Location = new System.Drawing.Point(22, 366);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(124, 29);
            this.btnThemHoaDon.TabIndex = 46;
            this.btnThemHoaDon.Text = "Thêm hóa đơn";
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(631, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Thành tiền";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(118, 25);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(187, 22);
            this.txtMaSanPham.TabIndex = 39;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label24.Location = new System.Drawing.Point(469, -71);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 16);
            this.label24.TabIndex = 36;
            this.label24.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(351, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Đơn Giá";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(118, 64);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(97, 22);
            this.txtSoLuong.TabIndex = 37;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label23.Location = new System.Drawing.Point(469, -99);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 16);
            this.label23.TabIndex = 34;
            this.label23.Text = "Tên khách hàng";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label22.Location = new System.Drawing.Point(474, -129);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 16);
            this.label22.TabIndex = 32;
            this.label22.Text = "Mã khách hàng";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label21.Location = new System.Drawing.Point(19, -38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 16);
            this.label21.TabIndex = 30;
            this.label21.Text = "Tên nhân viên";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(322, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Tên sản phảm";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label20.Location = new System.Drawing.Point(19, -71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 16);
            this.label20.TabIndex = 28;
            this.label20.Text = "Mã nhân viên";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(421, 28);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(187, 22);
            this.txtTenSanPham.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.Location = new System.Drawing.Point(19, -102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 16);
            this.label19.TabIndex = 26;
            this.label19.Text = "Ngày bán";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(24, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Số lượng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label18.Location = new System.Drawing.Point(19, -134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 16);
            this.label18.TabIndex = 24;
            this.label18.Text = "Mã hóa đơn";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(706, 28);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(174, 22);
            this.txtThanhTien.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(24, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "Mã sản phẩm";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(421, 67);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(187, 22);
            this.txtDonGia.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label17.Location = new System.Drawing.Point(31, 645);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 16);
            this.label17.TabIndex = 43;
            this.label17.Text = "Mã hóa đơn";
            // 
            // khacH_HANGTableAdapter1
            // 
            this.khacH_HANGTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbTimKiemMHD
            // 
            this.cmbTimKiemMHD.FormattingEnabled = true;
            this.cmbTimKiemMHD.Location = new System.Drawing.Point(115, 643);
            this.cmbTimKiemMHD.Name = "cmbTimKiemMHD";
            this.cmbTimKiemMHD.Size = new System.Drawing.Size(263, 24);
            this.cmbTimKiemMHD.TabIndex = 44;
            this.cmbTimKiemMHD.SelectedIndexChanged += new System.EventHandler(this.cmbTimKiemMHD_SelectedIndexChanged);
            // 
            // Hoa_Don
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 679);
            this.Controls.Add(this.cmbTimKiemMHD);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.grpThonTinHoaDon);
            this.Controls.Add(this.grpThongTinChung);
            this.Controls.Add(this.lblThongtinhoadon);
            this.Controls.Add(this.lblTongHoaDon);
            this.Controls.Add(this.btnInHoaDon);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "Hoa_Don";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.Hoa_Don_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHD)).EndInit();
            this.grpThongTinChung.ResumeLayout(false);
            this.grpThongTinChung.PerformLayout();
            this.grpThonTinHoaDon.ResumeLayout(false);
            this.grpThonTinHoaDon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongtinhoadon;
        private System.Windows.Forms.Label lblTongHoaDon;
        private System.Windows.Forms.DataGridView dgvDanhSachHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.GroupBox grpThongTinChung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpThonTinHoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cmbMaKhachHang;
        private System.Windows.Forms.ComboBox cmbMaNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Button btnHuyHoaDon;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnThemHoaDon;
        private QL_BANHANGDataSetTableAdapters.KHACH_HANGTableAdapter khacH_HANGTableAdapter1;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.ComboBox cmbTimKiemMHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}