namespace WindowsFormsApp1
{
    partial class Thong_tin_hoa_don
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
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTienThua = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongtinhoadon
            // 
            this.lblThongtinhoadon.BackColor = System.Drawing.Color.HotPink;
            this.lblThongtinhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongtinhoadon.Location = new System.Drawing.Point(84, 37);
            this.lblThongtinhoadon.Name = "lblThongtinhoadon";
            this.lblThongtinhoadon.Size = new System.Drawing.Size(635, 57);
            this.lblThongtinhoadon.TabIndex = 23;
            this.lblThongtinhoadon.Text = "Thông tin hóa đơn";
            this.lblThongtinhoadon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoaDon.Location = new System.Drawing.Point(358, 266);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(95, 20);
            this.lblHoaDon.TabIndex = 22;
            this.lblHoaDon.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(352, 301);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 22);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(427, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Hủy (F12)";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThanhToan.Location = new System.Drawing.Point(248, 378);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(154, 32);
            this.btnThanhToan.TabIndex = 18;
            this.btnThanhToan.Text = "Thanh Toán (F9)";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // lblTienThua
            // 
            this.lblTienThua.AutoSize = true;
            this.lblTienThua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTienThua.Location = new System.Drawing.Point(258, 340);
            this.lblTienThua.Name = "lblTienThua";
            this.lblTienThua.Size = new System.Drawing.Size(88, 20);
            this.lblTienThua.TabIndex = 17;
            this.lblTienThua.Text = "Tiền Thừa:";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(207, 303);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(139, 20);
            this.lblTenKhachHang.TabIndex = 16;
            this.lblTenKhachHang.Text = "Tên Khách Hàng:";
            // 
            // lblTongHoaDon
            // 
            this.lblTongHoaDon.AutoSize = true;
            this.lblTongHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongHoaDon.Location = new System.Drawing.Point(224, 266);
            this.lblTongHoaDon.Name = "lblTongHoaDon";
            this.lblTongHoaDon.Size = new System.Drawing.Size(122, 20);
            this.lblTongHoaDon.TabIndex = 15;
            this.lblTongHoaDon.Text = "Tổng Hóa Đơn:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(638, 157);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThongtinhoadon);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblTienThua);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblTongHoaDon);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongtinhoadon;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTienThua;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblTongHoaDon;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}