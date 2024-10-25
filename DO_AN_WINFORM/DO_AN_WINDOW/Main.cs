using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }


        private void SanphamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SanphamToolStripMenuItem.Click += new EventHandler(SanphamToolStripMenuItem_Click);
            San_Pham productForm = new San_Pham();
            ShowFormInPanel(productForm);
        }
        private void ShowFormInPanel(Form form)
        {
            // Xóa các điều khiển cũ trong panel nếu có
            panelcontent.Controls.Clear();

            // Cài đặt form con và thêm vào panel
            form.TopLevel = false; // Đặt thành form con
            form.FormBorderStyle = FormBorderStyle.None; // Bỏ viền
            form.Dock = DockStyle.Fill; // Form sẽ chiếm toàn bộ panel

            // Thêm form vào panel và hiển thị
            panelcontent.Controls.Add(form);
            form.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.quảnLýNhânViênToolStripMenuItem.Click += new EventHandler(quảnLýNhânViênToolStripMenuItem_Click);
            frmQuanLyNhanVien productform = new frmQuanLyNhanVien();
            ShowFormInPanel(productform);
        }

        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.thôngKêToolStripMenuItem.Click += new EventHandler(thôngKêToolStripMenuItem_Click);
            Thong_Ke productform = new Thong_Ke();
            ShowFormInPanel(productform);
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hóaĐơnToolStripMenuItem.Click += new EventHandler(hóaĐơnToolStripMenuItem_Click);
            Hoa_Don productform = new Hoa_Don();
            ShowFormInPanel(productform);
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.quảnLýKháchHàngToolStripMenuItem.Click += new EventHandler(quảnLýKháchHàngToolStripMenuItem_Click);
            frmKhachHang productform = new frmKhachHang();
            ShowFormInPanel(productform);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Hoa_Don productform = new Hoa_Don();
            ShowFormInPanel(productform);
        }
    }
}
