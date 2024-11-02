namespace WindowsFormsApp1
{
    partial class Thong_Ke
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
            this.lblTong = new System.Windows.Forms.Label();
            this.lblTongdoanhthu = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.grbThongKe = new System.Windows.Forms.GroupBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dtpKetthuc = new System.Windows.Forms.DateTimePicker();
            this.dtpBatdau = new System.Windows.Forms.DateTimePicker();
            this.cmbLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.lblLoaiiTK = new System.Windows.Forms.Label();
            this.lblBatdau = new System.Windows.Forms.Label();
            this.lblketthuc = new System.Windows.Forms.Label();
            this.lblThongkebanhang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.grbThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTong.Location = new System.Drawing.Point(795, 532);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(18, 20);
            this.lblTong.TabIndex = 42;
            this.lblTong.Text = "0";
            // 
            // lblTongdoanhthu
            // 
            this.lblTongdoanhthu.AutoSize = true;
            this.lblTongdoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongdoanhthu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTongdoanhthu.Location = new System.Drawing.Point(622, 532);
            this.lblTongdoanhthu.Name = "lblTongdoanhthu";
            this.lblTongdoanhthu.Size = new System.Drawing.Size(129, 20);
            this.lblTongdoanhthu.TabIndex = 41;
            this.lblTongdoanhthu.Text = "Tổng doanh thu:";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(9, 185);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(941, 327);
            this.dgvThongKe.TabIndex = 40;
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoc.Location = new System.Drawing.Point(9, 518);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(128, 55);
            this.btnLoc.TabIndex = 36;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatBaoCao.Location = new System.Drawing.Point(302, 524);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(248, 43);
            this.btnXuatBaoCao.TabIndex = 37;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            // 
            // grbThongKe
            // 
            this.grbThongKe.Controls.Add(this.txtTim);
            this.grbThongKe.Controls.Add(this.dtpKetthuc);
            this.grbThongKe.Controls.Add(this.dtpBatdau);
            this.grbThongKe.Controls.Add(this.cmbLoaiThongKe);
            this.grbThongKe.Controls.Add(this.lblLoaiiTK);
            this.grbThongKe.Controls.Add(this.lblBatdau);
            this.grbThongKe.Controls.Add(this.lblketthuc);
            this.grbThongKe.Location = new System.Drawing.Point(13, 99);
            this.grbThongKe.Name = "grbThongKe";
            this.grbThongKe.Size = new System.Drawing.Size(937, 80);
            this.grbThongKe.TabIndex = 39;
            this.grbThongKe.TabStop = false;
            // 
            // txtTim
            // 
            this.txtTim.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTim.Location = new System.Drawing.Point(6, 58);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(299, 22);
            this.txtTim.TabIndex = 34;
            this.txtTim.Text = "Tìm kiếm";
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // dtpKetthuc
            // 
            this.dtpKetthuc.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpKetthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpKetthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKetthuc.Location = new System.Drawing.Point(569, 48);
            this.dtpKetthuc.Name = "dtpKetthuc";
            this.dtpKetthuc.Size = new System.Drawing.Size(231, 26);
            this.dtpKetthuc.TabIndex = 33;
            // 
            // dtpBatdau
            // 
            this.dtpBatdau.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpBatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpBatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBatdau.Location = new System.Drawing.Point(569, 13);
            this.dtpBatdau.Name = "dtpBatdau";
            this.dtpBatdau.Size = new System.Drawing.Size(231, 26);
            this.dtpBatdau.TabIndex = 32;
            // 
            // cmbLoaiThongKe
            // 
            this.cmbLoaiThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLoaiThongKe.FormattingEnabled = true;
            this.cmbLoaiThongKe.Items.AddRange(new object[] {
            "Nhân Viên",
            "Sản Phẩm",
            "Doanh Thu"});
            this.cmbLoaiThongKe.Location = new System.Drawing.Point(130, 10);
            this.cmbLoaiThongKe.Name = "cmbLoaiThongKe";
            this.cmbLoaiThongKe.Size = new System.Drawing.Size(231, 28);
            this.cmbLoaiThongKe.TabIndex = 31;
            // 
            // lblLoaiiTK
            // 
            this.lblLoaiiTK.AutoSize = true;
            this.lblLoaiiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaiiTK.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLoaiiTK.Location = new System.Drawing.Point(10, 13);
            this.lblLoaiiTK.Name = "lblLoaiiTK";
            this.lblLoaiiTK.Size = new System.Drawing.Size(114, 20);
            this.lblLoaiiTK.TabIndex = 25;
            this.lblLoaiiTK.Text = "Loại thống kê:";
            this.lblLoaiiTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBatdau
            // 
            this.lblBatdau.AutoSize = true;
            this.lblBatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBatdau.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBatdau.Location = new System.Drawing.Point(453, 18);
            this.lblBatdau.Name = "lblBatdau";
            this.lblBatdau.Size = new System.Drawing.Size(73, 20);
            this.lblBatdau.TabIndex = 19;
            this.lblBatdau.Text = "Tử ngày:";
            this.lblBatdau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblketthuc
            // 
            this.lblketthuc.AutoSize = true;
            this.lblketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblketthuc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblketthuc.Location = new System.Drawing.Point(453, 54);
            this.lblketthuc.Name = "lblketthuc";
            this.lblketthuc.Size = new System.Drawing.Size(84, 20);
            this.lblketthuc.TabIndex = 20;
            this.lblketthuc.Text = "Đến ngày:";
            this.lblketthuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThongkebanhang
            // 
            this.lblThongkebanhang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblThongkebanhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongkebanhang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblThongkebanhang.Location = new System.Drawing.Point(3, 0);
            this.lblThongkebanhang.Name = "lblThongkebanhang";
            this.lblThongkebanhang.Size = new System.Drawing.Size(947, 86);
            this.lblThongkebanhang.TabIndex = 38;
            this.lblThongkebanhang.Text = "Thống Kê Bán Hàng";
            this.lblThongkebanhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Thong_Ke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 679);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.lblTongdoanhthu);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.grbThongKe);
            this.Controls.Add(this.lblThongkebanhang);
            this.Name = "Thong_Ke";
            this.Text = "Thong_Ke";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.grbThongKe.ResumeLayout(false);
            this.grbThongKe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblTongdoanhthu;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.GroupBox grbThongKe;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DateTimePicker dtpKetthuc;
        private System.Windows.Forms.DateTimePicker dtpBatdau;
        private System.Windows.Forms.ComboBox cmbLoaiThongKe;
        private System.Windows.Forms.Label lblLoaiiTK;
        private System.Windows.Forms.Label lblBatdau;
        private System.Windows.Forms.Label lblketthuc;
        private System.Windows.Forms.Label lblThongkebanhang;
    }
}