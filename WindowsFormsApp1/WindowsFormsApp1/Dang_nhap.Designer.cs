﻿namespace WindowsFormsApp1
{
    partial class Dang_nhap
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
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbHienmatkhau = new System.Windows.Forms.CheckBox();
            this.lblDangnhap = new System.Windows.Forms.Label();
            this.lblMatkhau = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangnhap.Location = new System.Drawing.Point(278, 333);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(283, 68);
            this.btnDangnhap.TabIndex = 15;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(291, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 22);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 22);
            this.textBox1.TabIndex = 13;
            // 
            // cbHienmatkhau
            // 
            this.cbHienmatkhau.AutoSize = true;
            this.cbHienmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHienmatkhau.Location = new System.Drawing.Point(291, 282);
            this.cbHienmatkhau.Name = "cbHienmatkhau";
            this.cbHienmatkhau.Size = new System.Drawing.Size(125, 22);
            this.cbHienmatkhau.TabIndex = 12;
            this.cbHienmatkhau.Text = "Hiện mật khẩu";
            this.cbHienmatkhau.UseVisualStyleBackColor = true;
            // 
            // lblDangnhap
            // 
            this.lblDangnhap.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDangnhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDangnhap.Location = new System.Drawing.Point(-4, -1);
            this.lblDangnhap.Name = "lblDangnhap";
            this.lblDangnhap.Size = new System.Drawing.Size(804, 111);
            this.lblDangnhap.TabIndex = 10;
            this.lblDangnhap.Text = "Đăng Nhập Hệ Thống";
            this.lblDangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.AutoSize = true;
            this.lblMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatkhau.Location = new System.Drawing.Point(115, 149);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(157, 25);
            this.lblMatkhau.TabIndex = 9;
            this.lblMatkhau.Text = "Tên Đăng Nhập:";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(115, 213);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(103, 25);
            this.lblTenDangNhap.TabIndex = 8;
            this.lblTenDangNhap.Text = "Mật Khẩu:";
            // 
            // Dang_nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbHienmatkhau);
            this.Controls.Add(this.lblDangnhap);
            this.Controls.Add(this.lblMatkhau);
            this.Controls.Add(this.lblTenDangNhap);
            this.Name = "Dang_nhap";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbHienmatkhau;
        private System.Windows.Forms.Label lblDangnhap;
        private System.Windows.Forms.Label lblMatkhau;
        private System.Windows.Forms.Label lblTenDangNhap;
    }
}