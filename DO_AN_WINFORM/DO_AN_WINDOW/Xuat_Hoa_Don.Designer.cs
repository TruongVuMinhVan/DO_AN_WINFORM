namespace WindowsFormsApp1
{
    partial class Xuat_Hoa_Don
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
            this.rvInHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvInHoaDon
            // 
            this.rvInHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvInHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rvInHoaDon.Name = "reportViewer1";
            this.rvInHoaDon.ServerReport.BearerToken = null;
            this.rvInHoaDon.Size = new System.Drawing.Size(800, 450);
            this.rvInHoaDon.TabIndex = 0;
            // 
            // Xuat_Hoa_Don
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvInHoaDon);
            this.Name = "Xuat_Hoa_Don";
            this.Text = "Xuất Hóa Đơn";
            this.Load += new System.EventHandler(this.Xuat_Hoa_Don_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvInHoaDon;
    }
}