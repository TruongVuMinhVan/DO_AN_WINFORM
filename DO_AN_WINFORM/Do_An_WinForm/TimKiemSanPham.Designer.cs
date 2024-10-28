namespace Do_An_WinForm
{
    partial class frmTimKiemSanPham
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTimkiemSanPham = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.cmbLoaisp = new System.Windows.Forms.ComboBox();
            this.txtTensanpham = new System.Windows.Forms.TextBox();
            this.lblLoaisabpham = new System.Windows.Forms.Label();
            this.lbltensanpham = new System.Windows.Forms.Label();
            this.lblTimKiemSanPham = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mã sản phẩm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 22);
            this.textBox1.TabIndex = 48;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 458);
            this.dataGridView1.TabIndex = 47;
            // 
            // btnTimkiemSanPham
            // 
            this.btnTimkiemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemSanPham.Location = new System.Drawing.Point(811, 34);
            this.btnTimkiemSanPham.Name = "btnTimkiemSanPham";
            this.btnTimkiemSanPham.Size = new System.Drawing.Size(126, 92);
            this.btnTimkiemSanPham.TabIndex = 46;
            this.btnTimkiemSanPham.Text = "Tìm kiếm";
            this.btnTimkiemSanPham.UseVisualStyleBackColor = true;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLammoi.Location = new System.Drawing.Point(8, 34);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(141, 92);
            this.btnLammoi.TabIndex = 45;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            // 
            // cmbLoaisp
            // 
            this.cmbLoaisp.FormattingEnabled = true;
            this.cmbLoaisp.Location = new System.Drawing.Point(613, 76);
            this.cmbLoaisp.Name = "cmbLoaisp";
            this.cmbLoaisp.Size = new System.Drawing.Size(121, 24);
            this.cmbLoaisp.TabIndex = 44;
            // 
            // txtTensanpham
            // 
            this.txtTensanpham.Location = new System.Drawing.Point(422, 76);
            this.txtTensanpham.Name = "txtTensanpham";
            this.txtTensanpham.Size = new System.Drawing.Size(185, 22);
            this.txtTensanpham.TabIndex = 43;
            // 
            // lblLoaisabpham
            // 
            this.lblLoaisabpham.AutoSize = true;
            this.lblLoaisabpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaisabpham.Location = new System.Drawing.Point(615, 49);
            this.lblLoaisabpham.Name = "lblLoaisabpham";
            this.lblLoaisabpham.Size = new System.Drawing.Size(119, 20);
            this.lblLoaisabpham.TabIndex = 42;
            this.lblLoaisabpham.Text = "Loại sản phẩm";
            // 
            // lbltensanpham
            // 
            this.lbltensanpham.AutoSize = true;
            this.lbltensanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltensanpham.Location = new System.Drawing.Point(456, 53);
            this.lbltensanpham.Name = "lbltensanpham";
            this.lbltensanpham.Size = new System.Drawing.Size(115, 20);
            this.lbltensanpham.TabIndex = 41;
            this.lbltensanpham.Text = "Tên sản phẩm";
            // 
            // lblTimKiemSanPham
            // 
            this.lblTimKiemSanPham.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTimKiemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimKiemSanPham.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTimKiemSanPham.Location = new System.Drawing.Point(-1, -1);
            this.lblTimKiemSanPham.Name = "lblTimKiemSanPham";
            this.lblTimKiemSanPham.Size = new System.Drawing.Size(949, 32);
            this.lblTimKiemSanPham.TabIndex = 40;
            this.lblTimKiemSanPham.Text = "Tìm Kiếm Sản Phẩm";
            this.lblTimKiemSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTimKiemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 679);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTimkiemSanPham);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.cmbLoaisp);
            this.Controls.Add(this.txtTensanpham);
            this.Controls.Add(this.lblLoaisabpham);
            this.Controls.Add(this.lbltensanpham);
            this.Controls.Add(this.lblTimKiemSanPham);
            this.Name = "frmTimKiemSanPham";
            this.Text = "Tìm kiếm sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTimkiemSanPham;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.ComboBox cmbLoaisp;
        private System.Windows.Forms.TextBox txtTensanpham;
        private System.Windows.Forms.Label lblLoaisabpham;
        private System.Windows.Forms.Label lbltensanpham;
        private System.Windows.Forms.Label lblTimKiemSanPham;
    }
}