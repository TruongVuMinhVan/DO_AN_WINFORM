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
            this.txtQLNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.grbQLNV = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.btnXoaNhanVien = new System.Windows.Forms.Button();
            this.btnSuaNhanVien = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.clmMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbQLNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // txtQLNV
            // 
            this.txtQLNV.Location = new System.Drawing.Point(138, 27);
            this.txtQLNV.Name = "txtQLNV";
            this.txtQLNV.Size = new System.Drawing.Size(223, 22);
            this.txtQLNV.TabIndex = 24;
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
            this.grbQLNV.Controls.Add(this.radioButton2);
            this.grbQLNV.Controls.Add(this.radioButton1);
            this.grbQLNV.Controls.Add(this.maskedTextBox1);
            this.grbQLNV.Controls.Add(this.dateTimePicker1);
            this.grbQLNV.Controls.Add(this.label3);
            this.grbQLNV.Controls.Add(this.label2);
            this.grbQLNV.Controls.Add(this.textBox2);
            this.grbQLNV.Controls.Add(this.label4);
            this.grbQLNV.Controls.Add(this.txtTenNV);
            this.grbQLNV.Controls.Add(this.lblMaNV);
            this.grbQLNV.Controls.Add(this.lblTenKhachHang);
            this.grbQLNV.Controls.Add(this.txtQLNV);
            this.grbQLNV.Controls.Add(this.lblSDT);
            this.grbQLNV.Location = new System.Drawing.Point(12, 60);
            this.grbQLNV.Name = "grbQLNV";
            this.grbQLNV.Size = new System.Drawing.Size(876, 147);
            this.grbQLNV.TabIndex = 26;
            this.grbQLNV.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 48);
            this.label1.TabIndex = 30;
            this.label1.Text = "Danh Sách Nhân Viên";
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(632, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 22);
            this.textBox2.TabIndex = 30;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(19, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Giới tính :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(507, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ngày sinh :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(632, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 26);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(632, 71);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(223, 22);
            this.maskedTextBox1.TabIndex = 34;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton1.Location = new System.Drawing.Point(138, 111);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 20);
            this.radioButton1.TabIndex = 35;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton2.Location = new System.Drawing.Point(229, 111);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 20);
            this.radioButton2.TabIndex = 36;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaNV,
            this.clmTenNV,
            this.clmGioitinh,
            this.clmDiachi,
            this.clmSDT,
            this.clmNgaysinh});
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 274);
            this.dataGridView1.TabIndex = 31;
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.ImageKey = "(none)";
            this.btnThemNhanVien.Location = new System.Drawing.Point(35, 493);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(100, 45);
            this.btnThemNhanVien.TabIndex = 32;
            this.btnThemNhanVien.Text = "Thêm";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.Location = new System.Drawing.Point(195, 495);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(103, 43);
            this.btnXoaNhanVien.TabIndex = 33;
            this.btnXoaNhanVien.Text = "Xóa";
            this.btnXoaNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.Location = new System.Drawing.Point(367, 495);
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.Size = new System.Drawing.Size(98, 43);
            this.btnSuaNhanVien.TabIndex = 34;
            this.btnSuaNhanVien.Text = "Sửa";
            this.btnSuaNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(644, 501);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 43);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(767, 501);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(118, 43);
            this.btnDong.TabIndex = 37;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // clmMaNV
            // 
            this.clmMaNV.HeaderText = "Mã nhân viên";
            this.clmMaNV.MinimumWidth = 6;
            this.clmMaNV.Name = "clmMaNV";
            // 
            // clmTenNV
            // 
            this.clmTenNV.HeaderText = "Tên nhân viên";
            this.clmTenNV.MinimumWidth = 6;
            this.clmTenNV.Name = "clmTenNV";
            // 
            // clmGioitinh
            // 
            this.clmGioitinh.HeaderText = "Giới tính";
            this.clmGioitinh.MinimumWidth = 6;
            this.clmGioitinh.Name = "clmGioitinh";
            // 
            // clmDiachi
            // 
            this.clmDiachi.HeaderText = "Địa Chỉ";
            this.clmDiachi.MinimumWidth = 6;
            this.clmDiachi.Name = "clmDiachi";
            // 
            // clmSDT
            // 
            this.clmSDT.HeaderText = "Số điện thoại";
            this.clmSDT.MinimumWidth = 6;
            this.clmSDT.Name = "clmSDT";
            // 
            // clmNgaysinh
            // 
            this.clmNgaysinh.HeaderText = "Ngày sinh";
            this.clmNgaysinh.MinimumWidth = 6;
            this.clmNgaysinh.Name = "clmNgaysinh";
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 556);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSuaNhanVien);
            this.Controls.Add(this.btnXoaNhanVien);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbQLNV);
            this.Name = "frmQuanLyNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.grbQLNV.ResumeLayout(false);
            this.grbQLNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtQLNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.GroupBox grbQLNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Button btnXoaNhanVien;
        private System.Windows.Forms.Button btnSuaNhanVien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgaysinh;
    }
}