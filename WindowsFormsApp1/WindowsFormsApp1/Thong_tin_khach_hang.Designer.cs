namespace WindowsFormsApp1
{
    partial class Thong_tin_khach_hang
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQLKhachhang
            // 
            this.lblQLKhachhang.BackColor = System.Drawing.Color.HotPink;
            this.lblQLKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQLKhachhang.Location = new System.Drawing.Point(-2, 0);
            this.lblQLKhachhang.Name = "lblQLKhachhang";
            this.lblQLKhachhang.Size = new System.Drawing.Size(608, 86);
            this.lblQLKhachhang.TabIndex = 18;
            this.lblQLKhachhang.Text = "Quản Lý Khách Hàng ";
            this.lblQLKhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(239, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 22);
            this.textBox3.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 22);
            this.textBox1.TabIndex = 16;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSDT.Location = new System.Drawing.Point(122, 158);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(111, 20);
            this.lblSDT.TabIndex = 15;
            this.lblSDT.Text = "Số điện thoại:";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(101, 114);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(132, 20);
            this.lblTenKhachHang.TabIndex = 14;
            this.lblTenKhachHang.Text = "Tên khách hàng:";
            this.lblTenKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Thong_tin_khach_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 188);
            this.Controls.Add(this.lblQLKhachhang);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblTenKhachHang);
            this.Name = "Thong_tin_khach_hang";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLKhachhang;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenKhachHang;
    }
}