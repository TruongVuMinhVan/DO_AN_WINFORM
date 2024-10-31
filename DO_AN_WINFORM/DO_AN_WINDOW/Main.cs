using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            San_Pham sanpham_form = new San_Pham();
            ShowFormInPanel(sanpham_form);
        }
        private void ShowFormInPanel(Form form)
        {
            // Xóa các điều khiển cũ trong panel nếu có
            panelcontent.Controls.Clear();

            // Cài đặt form con và thêm vào panel
            form.TopLevel = false; // Đặt thành form con
            form.FormBorderStyle = FormBorderStyle.None; // Bỏ viền
            form.Dock = DockStyle.Fill; // Form sẽ chiếm toàn bộ panel

            
            panelcontent.Controls.Add(form);
            form.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.quảnLýNhânViênToolStripMenuItem.Click += new EventHandler(quảnLýNhânViênToolStripMenuItem_Click);
            frmQuanLyNhanVien NhanVien_form = new frmQuanLyNhanVien();
            ShowFormInPanel(  NhanVien_form  );
        }

        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.thôngKêToolStripMenuItem.Click += new EventHandler(thôngKêToolStripMenuItem_Click);
            Thong_Ke Thongke_form = new Thong_Ke();
            ShowFormInPanel(Thongke_form);
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hóaĐơnToolStripMenuItem.Click += new EventHandler(hóaĐơnToolStripMenuItem_Click);
            Hoa_Don hoadon_form = new Hoa_Don();
            ShowFormInPanel(hoadon_form);
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.quảnLýKháchHàngToolStripMenuItem.Click += new EventHandler(quảnLýKháchHàngToolStripMenuItem_Click);
            frmKhachHang khachhang_form = new frmKhachHang();
            ShowFormInPanel(khachhang_form);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Hoa_Don main_form = new Hoa_Don();
            ShowFormInPanel(main_form);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                this.Close();
                Dang_nhap loginForm = new Dang_nhap();
                loginForm.Show();
            }
        }
    }
}
