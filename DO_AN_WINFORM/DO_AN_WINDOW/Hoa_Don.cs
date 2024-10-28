using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.SQL;

namespace WindowsFormsApp1
{
    public partial class Hoa_Don : Form
    {
        public Hoa_Don()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.ShowInTaskbar = false;
        }

        private void Hoa_Don_Load(object sender, EventArgs e)
        {
            try
            {
                Model context = new Model();
                List<NHAN_VIEN> listNhanVien = context.NHAN_VIEN.ToList();
                List<KHACH_HANG> listKhachHang = context.KHACH_HANG.ToList();
                List<CHI_TIET_HOA_DON> listCTHD = context.CHI_TIET_HOA_DON.ToList();
                FillNhanVienCmb(listNhanVien);
                FillKhachHangCmb(listKhachHang);

                BindGrid(listCTHD);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

       
        private void FillNhanVienCmb(List<NHAN_VIEN> listNhanVien)
        {
            cmbMaNhanVien.DataSource = listNhanVien;
            cmbMaNhanVien.DisplayMember = "nv_id";   // Hiển thị tên nhân viên
            cmbMaNhanVien.ValueMember = "nv_id";      // Lưu mã nhân viên
        }

        
        private void FillKhachHangCmb(List<KHACH_HANG> listKhachHang)
        {
            cmbMaKhachHang.DataSource = listKhachHang;
            cmbMaKhachHang.DisplayMember = "kh_id";  // Hiển thị tên khách hàng
            cmbMaKhachHang.ValueMember = "kh_id";     // Lưu mã khách hàng
        }


        private void BindGrid(List<CHI_TIET_HOA_DON> listChiTietHoaDon)
        {
            
            dgvDanhSachHD.Rows.Clear();
            foreach (var item in listChiTietHoaDon)
            {
                // Thêm một hàng mới vào DataGridView
                int index = dgvDanhSachHD.Rows.Add();

                dgvDanhSachHD.Rows[index].Cells[0].Value = item.hd_id; // Mã hóa đơn
                dgvDanhSachHD.Rows[index].Cells[1].Value = item.HOA_DON.nv_id; // Mã nhân viên
                dgvDanhSachHD.Rows[index].Cells[2].Value = item.sp_id; // Mã sản phẩm
                dgvDanhSachHD.Rows[index].Cells[3].Value = item.SAN_PHAM.sp_ten; // Tên sản phẩm
                dgvDanhSachHD.Rows[index].Cells[4].Value = item.soluong; // Số lượng
                dgvDanhSachHD.Rows[index].Cells[5].Value = item.SAN_PHAM.sp_gia; // Đơn giá
            }
        }

        private void cmbTimKiemMHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            Xuat_Hoa_Don XuatHD = new Xuat_Hoa_Don();
            XuatHD.Show();
        }
    }

}