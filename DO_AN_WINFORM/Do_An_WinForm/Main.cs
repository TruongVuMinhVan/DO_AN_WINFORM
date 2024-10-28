using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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

        private void SanphamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SanphamToolStripMenuItem.Click += new EventHandler(SanphamToolStripMenuItem_Click);
            frmSanPham sanpham_form = new frmSanPham();
            ShowFormInPanel(sanpham_form);
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.quảnLýNhânViênToolStripMenuItem.Click += new EventHandler(quảnLýNhânViênToolStripMenuItem_Click);
            frmQuanLyNhanVien NhanVien_form = new frmQuanLyNhanVien();
            ShowFormInPanel(NhanVien_form);
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.quảnLýKháchHàngToolStripMenuItem.Click += new EventHandler(quảnLýKháchHàngToolStripMenuItem_Click);
            frmKhachHang khachhang_form = new frmKhachHang();
            ShowFormInPanel(khachhang_form);
        }

        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.thôngKêToolStripMenuItem.Click += new EventHandler(thôngKêToolStripMenuItem_Click);
            frmThongKe Thongke_form = new frmThongKe();
            ShowFormInPanel(Thongke_form);
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hóaĐơnToolStripMenuItem.Click += new EventHandler(hóaĐơnToolStripMenuItem_Click);
            frmHoaDon hoadon_form = new frmHoaDon();
            ShowFormInPanel(hoadon_form);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmHoaDon main_form = new frmHoaDon();
            ShowFormInPanel(main_form);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Close();
                frmDangNhap loginForm = new frmDangNhap();
                loginForm.Show();
            }
        }
    }
}
