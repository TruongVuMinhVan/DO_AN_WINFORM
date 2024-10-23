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
            this.lblThongkebanhang = new System.Windows.Forms.Label();
            this.grbThongKe = new System.Windows.Forms.GroupBox();
            this.dtpKetthuc = new System.Windows.Forms.DateTimePicker();
            this.dtpBatdau = new System.Windows.Forms.DateTimePicker();
            this.cmbLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.lblLoaiiTK = new System.Windows.Forms.Label();
            this.lblBatdau = new System.Windows.Forms.Label();
            this.lblketthuc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTongdoanhthu = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.grbThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongkebanhang
            // 
            this.lblThongkebanhang.BackColor = System.Drawing.Color.HotPink;
            this.lblThongkebanhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongkebanhang.Location = new System.Drawing.Point(2, 9);
            this.lblThongkebanhang.Name = "lblThongkebanhang";
            this.lblThongkebanhang.Size = new System.Drawing.Size(805, 86);
            this.lblThongkebanhang.TabIndex = 23;
            this.lblThongkebanhang.Text = "Thống Kê Bán Hàng";
            this.lblThongkebanhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbThongKe
            // 
            this.grbThongKe.Controls.Add(this.dtpKetthuc);
            this.grbThongKe.Controls.Add(this.dtpBatdau);
            this.grbThongKe.Controls.Add(this.cmbLoaiThongKe);
            this.grbThongKe.Controls.Add(this.btnXuatBaoCao);
            this.grbThongKe.Controls.Add(this.btnLoc);
            this.grbThongKe.Controls.Add(this.lblLoaiiTK);
            this.grbThongKe.Controls.Add(this.lblBatdau);
            this.grbThongKe.Controls.Add(this.lblketthuc);
            this.grbThongKe.Location = new System.Drawing.Point(12, 108);
            this.grbThongKe.Name = "grbThongKe";
            this.grbThongKe.Size = new System.Drawing.Size(389, 312);
            this.grbThongKe.TabIndex = 27;
            this.grbThongKe.TabStop = false;
            // 
            // dtpKetthuc
            // 
            this.dtpKetthuc.Location = new System.Drawing.Point(153, 107);
            this.dtpKetthuc.Name = "dtpKetthuc";
            this.dtpKetthuc.Size = new System.Drawing.Size(200, 22);
            this.dtpKetthuc.TabIndex = 33;
            // 
            // dtpBatdau
            // 
            this.dtpBatdau.Location = new System.Drawing.Point(153, 71);
            this.dtpBatdau.Name = "dtpBatdau";
            this.dtpBatdau.Size = new System.Drawing.Size(200, 22);
            this.dtpBatdau.TabIndex = 32;
            // 
            // cmbLoaiThongKe
            // 
            this.cmbLoaiThongKe.FormattingEnabled = true;
            this.cmbLoaiThongKe.Location = new System.Drawing.Point(153, 27);
            this.cmbLoaiThongKe.Name = "cmbLoaiThongKe";
            this.cmbLoaiThongKe.Size = new System.Drawing.Size(200, 24);
            this.cmbLoaiThongKe.TabIndex = 31;
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Location = new System.Drawing.Point(225, 177);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(128, 30);
            this.btnXuatBaoCao.TabIndex = 27;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(23, 177);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(128, 30);
            this.btnLoc.TabIndex = 26;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // lblLoaiiTK
            // 
            this.lblLoaiiTK.AutoSize = true;
            this.lblLoaiiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaiiTK.Location = new System.Drawing.Point(19, 31);
            this.lblLoaiiTK.Name = "lblLoaiiTK";
            this.lblLoaiiTK.Size = new System.Drawing.Size(114, 20);
            this.lblLoaiiTK.TabIndex = 25;
            this.lblLoaiiTK.Text = "Loại thống kê:";
            this.lblLoaiiTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBatdau
            // 
            this.lblBatdau.AutoSize = true;
            this.lblBatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBatdau.Location = new System.Drawing.Point(19, 73);
            this.lblBatdau.Name = "lblBatdau";
            this.lblBatdau.Size = new System.Drawing.Size(73, 20);
            this.lblBatdau.TabIndex = 19;
            this.lblBatdau.Text = "Tử ngày:";
            this.lblBatdau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblketthuc
            // 
            this.lblketthuc.AutoSize = true;
            this.lblketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblketthuc.Location = new System.Drawing.Point(19, 109);
            this.lblketthuc.Name = "lblketthuc";
            this.lblketthuc.Size = new System.Drawing.Size(84, 20);
            this.lblketthuc.TabIndex = 20;
            this.lblketthuc.Text = "Đến ngày:";
            this.lblketthuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(407, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(381, 312);
            this.dataGridView1.TabIndex = 28;
            // 
            // lblTongdoanhthu
            // 
            this.lblTongdoanhthu.AutoSize = true;
            this.lblTongdoanhthu.Location = new System.Drawing.Point(405, 447);
            this.lblTongdoanhthu.Name = "lblTongdoanhthu";
            this.lblTongdoanhthu.Size = new System.Drawing.Size(103, 16);
            this.lblTongdoanhthu.TabIndex = 29;
            this.lblTongdoanhthu.Text = "Tổng doanh thu:";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(512, 447);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(14, 16);
            this.lblTong.TabIndex = 30;
            this.lblTong.Text = "0";
            // 
            // Thong_Ke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.lblTongdoanhthu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbThongKe);
            this.Controls.Add(this.lblThongkebanhang);
            this.Name = "Thong_Ke";
            this.Text = "Thong_Ke";
            this.grbThongKe.ResumeLayout(false);
            this.grbThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongkebanhang;
        private System.Windows.Forms.GroupBox grbThongKe;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label lblLoaiiTK;
        private System.Windows.Forms.Label lblBatdau;
        private System.Windows.Forms.Label lblketthuc;
        private System.Windows.Forms.DateTimePicker dtpKetthuc;
        private System.Windows.Forms.DateTimePicker dtpBatdau;
        private System.Windows.Forms.ComboBox cmbLoaiThongKe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTongdoanhthu;
        private System.Windows.Forms.Label lblTong;
    }
}