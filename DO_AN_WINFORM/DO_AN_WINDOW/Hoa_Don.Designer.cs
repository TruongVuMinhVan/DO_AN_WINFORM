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
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMDM = new System.Windows.Forms.TextBox();
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
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTimKiemMHD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.colMaHD,
            this.colMaNV,
            this.colMaSP,
            this.colTenSP,
            this.colSoluong,
            this.colGia,
            this.colMaKH,
            this.colTenKH,
            this.colSDT,
            this.colTenNV,
            this.colDanhMuc,
            this.colNgayLap,
            this.colThanhTien});
            this.dgvDanhSachHD.Location = new System.Drawing.Point(6, 109);
            this.dgvDanhSachHD.Name = "dgvDanhSachHD";
            this.dgvDanhSachHD.RowHeadersWidth = 51;
            this.dgvDanhSachHD.RowTemplate.Height = 24;
            this.dgvDanhSachHD.Size = new System.Drawing.Size(913, 221);
            this.dgvDanhSachHD.TabIndex = 14;
            this.dgvDanhSachHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHD_CellClick);
            this.dgvDanhSachHD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHD_CellDoubleClick);
            // 
            // colMaHD
            // 
            this.colMaHD.HeaderText = "Mã Hóa Đơn";
            this.colMaHD.MinimumWidth = 6;
            this.colMaHD.Name = "colMaHD";
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Mã Nhân VIên";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            // 
            // colMaSP
            // 
            this.colMaSP.HeaderText = "Mã Sản Phẩm";
            this.colMaSP.MinimumWidth = 6;
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Visible = false;
            // 
            // colTenSP
            // 
            this.colTenSP.HeaderText = "Tên Sản Phẩm";
            this.colTenSP.MinimumWidth = 6;
            this.colTenSP.Name = "colTenSP";
            // 
            // colSoluong
            // 
            this.colSoluong.HeaderText = "Số Lượng";
            this.colSoluong.MinimumWidth = 6;
            this.colSoluong.Name = "colSoluong";
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Đơn Giá";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "colGia";
            // 
            // colMaKH
            // 
            this.colMaKH.HeaderText = "Mã Khách Hàng";
            this.colMaKH.MinimumWidth = 6;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Visible = false;
            // 
            // colTenKH
            // 
            this.colTenKH.HeaderText = "Tên Khách Hàng";
            this.colTenKH.MinimumWidth = 6;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Visible = false;
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "Số Điện Thoại";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = false;
            // 
            // colTenNV
            // 
            this.colTenNV.HeaderText = "Tên Nhân Viên";
            this.colTenNV.MinimumWidth = 6;
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.Visible = false;
            // 
            // colDanhMuc
            // 
            this.colDanhMuc.HeaderText = "Mã Danh Mục";
            this.colDanhMuc.MinimumWidth = 6;
            this.colDanhMuc.Name = "colDanhMuc";
            this.colDanhMuc.Visible = false;
            // 
            // colNgayLap
            // 
            this.colNgayLap.HeaderText = "Ngày Lập";
            this.colNgayLap.MinimumWidth = 6;
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.Visible = false;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
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
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(118, 27);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(248, 22);
            this.txtMaHD.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMaKH);
            this.groupBox1.Controls.Add(this.cmbMaNV);
            this.groupBox1.Controls.Add(this.dtpNgayBan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 155);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Chung";
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(595, 24);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(236, 24);
            this.cmbMaKH.TabIndex = 42;
            this.cmbMaKH.SelectedIndexChanged += new System.EventHandler(this.cmbMaKH_SelectedIndexChanged);
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(118, 87);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(248, 24);
            this.cmbMaNV.TabIndex = 41;
            this.cmbMaNV.SelectedIndexChanged += new System.EventHandler(this.cmbMaNV_SelectedIndexChanged);
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
            this.label5.Location = new System.Drawing.Point(474, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Số Điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(595, 91);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(236, 22);
            this.txtSDT.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(474, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tên khách hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(595, 59);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(236, 22);
            this.txtTenKH.TabIndex = 35;
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
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(118, 120);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(248, 22);
            this.txtTenNV.TabIndex = 31;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMDM);
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnLuuHoaDon);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnHuyHoaDon);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.btnInHoaDon);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.btnThemHoaDon);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMaSP);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.dgvDanhSachHD);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(925, 395);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Hóa Đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(635, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Mã Danh Mục";
            // 
            // txtMDM
            // 
            this.txtMDM.Location = new System.Drawing.Point(730, 28);
            this.txtMDM.Name = "txtMDM";
            this.txtMDM.Size = new System.Drawing.Size(174, 22);
            this.txtMDM.TabIndex = 51;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(799, 367);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(118, 27);
            this.btnDong.TabIndex = 50;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
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
            this.btnLuuHoaDon.Click += new System.EventHandler(this.btnLuuHoaDon_Click);
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
            this.btnHuyHoaDon.Location = new System.Drawing.Point(391, 366);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(125, 27);
            this.btnHuyHoaDon.TabIndex = 48;
            this.btnHuyHoaDon.Text = "Hủy hóa đơn";
            this.btnHuyHoaDon.UseVisualStyleBackColor = true;
            this.btnHuyHoaDon.Click += new System.EventHandler(this.btnHuyHoaDon_Click);
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
            this.btnInHoaDon.Location = new System.Drawing.Point(612, 366);
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
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(655, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Thành tiền";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(118, 25);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(187, 22);
            this.txtMaSP.TabIndex = 39;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
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
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(421, 28);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(187, 22);
            this.txtTenSP.TabIndex = 29;
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
            this.txtThanhTien.Location = new System.Drawing.Point(730, 67);
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
            this.label17.Location = new System.Drawing.Point(46, 645);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 16);
            this.label17.TabIndex = 43;
            this.label17.Text = "Tìm Kiếm";
            // 
            // txtTimKiemMHD
            // 
            this.txtTimKiemMHD.Location = new System.Drawing.Point(116, 645);
            this.txtTimKiemMHD.Name = "txtTimKiemMHD";
            this.txtTimKiemMHD.Size = new System.Drawing.Size(157, 22);
            this.txtTimKiemMHD.TabIndex = 44;
            this.txtTimKiemMHD.TextChanged += new System.EventHandler(this.txtTimKiemMHD_TextChanged);
            // 
            // Hoa_Don
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(945, 695);
            this.Controls.Add(this.txtTimKiemMHD);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblThongtinhoadon);
            this.Controls.Add(this.lblTongHoaDon);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "Hoa_Don";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.Hoa_Don_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongtinhoadon;
        private System.Windows.Forms.Label lblTongHoaDon;
        private System.Windows.Forms.DataGridView dgvDanhSachHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private System.Windows.Forms.ComboBox cmbMaNV;
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
        private System.Windows.Forms.TextBox txtTimKiemMHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}