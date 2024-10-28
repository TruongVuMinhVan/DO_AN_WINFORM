namespace WindowsFormsApp1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelcontent = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.SanphamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontent
            // 
            this.panelcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontent.Location = new System.Drawing.Point(0, 28);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(949, 651);
            this.panelcontent.TabIndex = 6;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SanphamToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.thôngKêToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(949, 28);
            this.menu.TabIndex = 3;
            this.menu.Text = "Menu";
            // 
            // SanphamToolStripMenuItem
            // 
            this.SanphamToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SanphamToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SanphamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SanphamToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SanphamToolStripMenuItem.Image")));
            this.SanphamToolStripMenuItem.Name = "SanphamToolStripMenuItem";
            this.SanphamToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.SanphamToolStripMenuItem.Text = "Sản phẩm ";
            this.SanphamToolStripMenuItem.Click += new System.EventHandler(this.SanphamToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quảnLýNhânViênToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.quảnLýNhânViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýNhânViênToolStripMenuItem.Image")));
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Nhân Viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quảnLýKháchHàngToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.quảnLýKháchHàngToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.quảnLýKháchHàngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýKháchHàngToolStripMenuItem.Image")));
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Khách Hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // thôngKêToolStripMenuItem
            // 
            this.thôngKêToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.thôngKêToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.thôngKêToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngKêToolStripMenuItem.Image")));
            this.thôngKêToolStripMenuItem.Name = "thôngKêToolStripMenuItem";
            this.thôngKêToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.thôngKêToolStripMenuItem.Text = "Thông Kê ";
            this.thôngKêToolStripMenuItem.Click += new System.EventHandler(this.thôngKêToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hóaĐơnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.hóaĐơnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hóaĐơnToolStripMenuItem.Image")));
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 679);
            this.Controls.Add(this.panelcontent);
            this.Controls.Add(this.menu);
            this.Name = "Main";
            this.Text = "Chương trình Quản lý bán quần áo";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelcontent;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem SanphamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}