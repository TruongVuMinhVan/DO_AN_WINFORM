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
using System.Data.Entity;
using WindowsFormsApp1.SQL;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

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
            cmbMaNV.DataSource = listNhanVien;
            cmbMaNV.DisplayMember = "nv_id";
            cmbMaNV.ValueMember = "nv_id";      // Lưu mã nhân viên
        }


        private void FillKhachHangCmb(List<KHACH_HANG> listKhachHang)
        {
            cmbMaKH.DataSource = listKhachHang;
            cmbMaKH.DisplayMember = "kh_id";
            cmbMaKH.ValueMember = "kh_id";     // Lưu mã khách hàng
        }


        private void BindGrid(List<CHI_TIET_HOA_DON> listChiTietHoaDon)
        {

            dgvDanhSachHD.Rows.Clear();


            decimal tongTien = 0;
            
            foreach (var item in listChiTietHoaDon)
            {

                int index = dgvDanhSachHD.Rows.Add();

                dgvDanhSachHD.Rows[index].Cells[0].Value = item.hd_id;
                dgvDanhSachHD.Rows[index].Cells[1].Value = item.HOA_DON.nv_id;
                dgvDanhSachHD.Rows[index].Cells[2].Value = item.sp_id;
                dgvDanhSachHD.Rows[index].Cells[3].Value = item.SAN_PHAM.sp_ten;
                dgvDanhSachHD.Rows[index].Cells[4].Value = item.soluong;
                dgvDanhSachHD.Rows[index].Cells[5].Value = item.SAN_PHAM.sp_gia;
                dgvDanhSachHD.Rows[index].Cells[6].Value = item.HOA_DON.KHACH_HANG.kh_id;   //(ẩn)
                dgvDanhSachHD.Rows[index].Cells[7].Value = item.HOA_DON.KHACH_HANG.kh_ten;  //(ẩn)
                dgvDanhSachHD.Rows[index].Cells[8].Value = item.HOA_DON.KHACH_HANG.kh_sdt;  //(ẩn)
                dgvDanhSachHD.Rows[index].Cells[9].Value = item.HOA_DON.NHAN_VIEN.nv_ten;   //(ẩn)
                dgvDanhSachHD.Rows[index].Cells[10].Value = item.SAN_PHAM.dm_id;            //(ẩn)
                dgvDanhSachHD.Rows[index].Cells[11].Value = item.HOA_DON.hd_ngaylap;        //(ẩn) 



                decimal thanhTien = (decimal)item.soluong * (decimal)item.SAN_PHAM.sp_gia;
                dgvDanhSachHD.Rows[index].Cells[12].Value = thanhTien;

                tongTien += thanhTien;
            }
            txtTongTien.Text = tongTien.ToString("N0");
        }


        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

            string maHoaDon = txtTimKiemMHD.Text;
            
            if (string.IsNullOrEmpty(maHoaDon))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn.");
                return;
            }

            Xuat_Hoa_Don xuatHD = new Xuat_Hoa_Don(maHoaDon);

            xuatHD.Show();
        }


        private void dgvDanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDanhSachHD.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                cmbMaNV.Text = row.Cells[1].Value.ToString();
                txtMaSP.Text = row.Cells[2].Value.ToString();           //(ẩn)
                txtTenSP.Text = row.Cells[3].Value.ToString();
                txtSoLuong.Text = row.Cells[4].Value.ToString();
                txtDonGia.Text = row.Cells[5].Value.ToString();
                cmbMaKH.SelectedValue = row.Cells[6].Value.ToString();  //(ẩn)
                txtTenKH.Text = row.Cells[7].Value.ToString();          //(ẩn)
                txtSDT.Text = row.Cells[8].Value.ToString();            //(ẩn)   
                txtTenNV.Text = row.Cells[9].Value.ToString();          //(ẩn)  
                txtMDM.Text = row.Cells[10].Value.ToString();           //(ẩn)
                dtpNgayBan.Text = row.Cells[11].Value.ToString();       //(ẩn)

                if (int.TryParse(row.Cells[4].Value?.ToString(), out int soLuong) &&
            decimal.TryParse(row.Cells[5].Value?.ToString(), out decimal donGia))
                {
                    decimal thanhTien = soLuong * donGia;
                    txtThanhTien.Text = thanhTien.ToString("F4"); 
                }
                else
                {
                    txtThanhTien.Text = "0.0000"; // Định dạng mặc định với 4 số 0 thập phân
                }
            }
        }


        private Model db = new Model(); 
        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra tính hợp lệ của dữ liệu
                if (string.IsNullOrEmpty(txtMaHD.Text) || string.IsNullOrEmpty(txtMaSP.Text) || string.IsNullOrEmpty(txtSoLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hóa đơn và sản phẩm.");
                    return;
                }

                int soLuong;
                if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải là một số dương.");
                    return;
                }

                using (var context = new Model())
                {
                    var hoaDon = context.HOA_DON.FirstOrDefault(hd => hd.hd_id == txtMaHD.Text);
                    if (hoaDon == null)
                    {
                        hoaDon = new HOA_DON
                        {
                            hd_id = txtMaHD.Text,
                            nv_id = cmbMaNV.SelectedValue.ToString(),
                            kh_id = cmbMaKH.SelectedValue.ToString(),
                            hd_ngaylap = dtpNgayBan.Value
                        };
                        context.HOA_DON.Add(hoaDon);
                    }

                    var chiTietHoaDon = new CHI_TIET_HOA_DON
                    {
                        hd_id = txtMaHD.Text,
                        sp_id = txtMaSP.Text,
                        soluong = soLuong
                    };

                    context.CHI_TIET_HOA_DON.Add(chiTietHoaDon);
                    context.SaveChanges();

                    MessageBox.Show("Thêm hóa đơn thành công!");
                    LoadHoaDon(); 
                    ResetFields(); 
                }
            }
            catch (Exception ex)
            {
                // Hiển thị chi tiết lỗi
                string errorMessage = "Lỗi khi thêm hóa đơn: " + ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += "\nChi tiết lỗi: " + ex.InnerException.Message;
                }
                MessageBox.Show(errorMessage);
            }
        }



        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text) || string.IsNullOrEmpty(txtMaSP.Text) || string.IsNullOrEmpty(txtSoLuong.Text) || string.IsNullOrEmpty(txtDonGia.Text) || cmbMaKH.SelectedIndex == -1 || cmbMaNV.SelectedIndex == -1 || string.IsNullOrEmpty(txtMDM.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hóa đơn, bao gồm Mã Danh Mục!");
                return;
            }

            using (var context = new Model())
            {
                var cthd = context.CHI_TIET_HOA_DON
                                 .Include(ct => ct.HOA_DON)
                                 .FirstOrDefault(ct => ct.hd_id == txtMaHD.Text && ct.sp_id == txtMaSP.Text);

                if (cthd != null)
                {
                    cthd.soluong = int.Parse(txtSoLuong.Text);
                    cthd.SAN_PHAM.sp_gia = decimal.Parse(txtDonGia.Text);
                    cthd.HOA_DON.kh_id = cmbMaKH.SelectedValue.ToString();
                    cthd.HOA_DON.nv_id = cmbMaNV.SelectedValue.ToString();
                    cthd.HOA_DON.hd_ngaylap = dtpNgayBan.Value;

                    context.SaveChanges();
                    MessageBox.Show("Cập nhật hóa đơn thành công!");
                }
                else
                {
                    MessageBox.Show("Chi tiết hóa đơn không tồn tại để cập nhật!");
                }

                LoadHoaDon();
                ResetFields();
            }
        }


        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn này không? Tất cả thông tin sẽ bị mất.", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ResetFields();
            }
        }


        private void dgvDanhSachHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDanhSachHD.Rows[e.RowIndex];
                string maHD = row.Cells[0].Value.ToString();

                using (var context = new Model())
                {
                    var hoaDon = context.HOA_DON.Include(hd => hd.CHI_TIET_HOA_DON)
                                            .FirstOrDefault(hd => hd.hd_id == maHD);

                    if (hoaDon != null)
                    {
                        var result = MessageBox.Show("Bạn có muốn xóa hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            context.CHI_TIET_HOA_DON.RemoveRange(hoaDon.CHI_TIET_HOA_DON);
                            context.HOA_DON.Remove(hoaDon);
                            context.SaveChanges();

                            MessageBox.Show("Xóa hóa đơn thành công!");
                            LoadHoaDon();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn cần xóa không tồn tại!");
                    }
                }
            }
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtTimKiemMHD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model())
                {
                    string keyword = txtTimKiemMHD.Text.ToLower().Trim();

                    var filteredList = context.CHI_TIET_HOA_DON
                                              .Where(hd => hd.hd_id.ToString().Contains(keyword) ||
                                                           hd.HOA_DON.nv_id.ToString().Contains(keyword) ||
                                                           hd.sp_id.ToString().Contains(keyword) ||
                                                           hd.SAN_PHAM.sp_ten.ToLower().Contains(keyword))
                                              .ToList();

                    BindGrid(filteredList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm hóa đơn: " + ex.Message);
            }
        }


        private void cmbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNhanVienId = cmbMaNV.SelectedValue?.ToString();

            if (!string.IsNullOrEmpty(selectedNhanVienId))
            {
                using (var context = new Model())
                {
                    var nhanVien = context.NHAN_VIEN.FirstOrDefault(nv => nv.nv_id == selectedNhanVienId);

                    if (nhanVien != null)
                    {
                        txtTenNV.Text = nhanVien.nv_ten;
                    }
                }
            }
            else
            {
                txtTenNV.Clear();
            }
        }


        private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedKhachHangId = cmbMaKH.SelectedValue?.ToString();

            if (!string.IsNullOrEmpty(selectedKhachHangId))
            {
                using (var context = new Model())
                {
                    var khachHang = context.KHACH_HANG.FirstOrDefault(kh => kh.kh_id == selectedKhachHangId);

                    if (khachHang != null)
                    {
                        txtTenKH.Text = khachHang.kh_ten;
                        txtSDT.Text = khachHang.kh_sdt.ToString(); 
                    }
                }
            }
            else
            {
                txtTenKH.Clear();
                txtSDT.Clear(); 
            }
        }


        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();

            if (maSP.Length == 5)
            {
                using (var context = new Model())
                {

                    var sanPham = context.SAN_PHAM.FirstOrDefault(sp => sp.sp_id == maSP);

                    if (sanPham != null)
                    {

                        txtTenSP.Text = sanPham.sp_ten;
                        txtDonGia.Text = sanPham.sp_gia.HasValue ? sanPham.sp_gia.Value.ToString("F4") : "";
                        txtMDM.Text = sanPham.dm_id;
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm không tồn tại!");
                        txtTenSP.Clear();
                        txtDonGia.Clear();
                        txtMDM.Clear();
                    }
                }
            }
            else
            {

                txtTenSP.Clear();
                txtDonGia.Clear();
                txtMDM.Clear();
            }
        }



        private void LoadHoaDon()
        {
            using (var context = new Model())
            {
                var listCTHD = context.CHI_TIET_HOA_DON.ToList();
                BindGrid(listCTHD);
            }
        }


        private void ResetFields()
        {
            txtMaHD.Clear();
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            cmbMaNV.SelectedIndex = -1;
            cmbMaKH.SelectedIndex = -1;
            txtTenSP.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtTenNV.Clear();
            dtpNgayBan.Value = DateTime.Now;
            txtMDM.Clear();
        }


    }

}


