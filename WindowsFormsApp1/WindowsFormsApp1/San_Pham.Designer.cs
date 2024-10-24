namespace WindowsFormsApp1
{
    partial class San_Pham
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
            this.lblQLSanpham = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQLSanpham
            // 
            this.lblQLSanpham.BackColor = System.Drawing.Color.HotPink;
            this.lblQLSanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQLSanpham.Location = new System.Drawing.Point(0, 4);
            this.lblQLSanpham.Name = "lblQLSanpham";
            this.lblQLSanpham.Size = new System.Drawing.Size(1046, 56);
            this.lblQLSanpham.TabIndex = 25;
            this.lblQLSanpham.Text = "Danh Sách Sản Phẩm";
            this.lblQLSanpham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // San_Pham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 567);
            this.Controls.Add(this.lblQLSanpham);
            this.Name = "San_Pham";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblQLSanpham;
    }
}