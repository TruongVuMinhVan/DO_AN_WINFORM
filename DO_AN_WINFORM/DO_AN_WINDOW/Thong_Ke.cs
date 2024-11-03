using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.SQL;

namespace WindowsFormsApp1
{

    public partial class Thong_Ke : Form
    {
        private readonly Model context;
        public Thong_Ke()
        {
            InitializeComponent();
            this.TopLevel = false; //hoạt động trong panel
            this.FormBorderStyle = FormBorderStyle.None;// ẩn viền
            this.Dock = DockStyle.Fill;
            context = new Model();
        }
        //tạo thêm cột thống kê sản phẩm
        private void AddCotSanPham()
        {
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "clmID";
            column1.HeaderText = "Mã Sản phẩm";
            dgvThongKe.Columns.Add(column1);

            // Thêm cột thứ hai
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "clmName";
            column2.HeaderText = "Tên Sản phẩm";
            dgvThongKe.Columns.Add(column2);

            // Thêm cột thứ ba
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "clmMoney";
            column3.HeaderText = "Giá tiền";
            dgvThongKe.Columns.Add(column3);

            // Thêm cột thứ tư
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.Name = "clmSoluongTon";
            column4.HeaderText = "Số lượng tồn";
            dgvThongKe.Columns.Add(column4);
            //thêm cột thứ năm
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.Name = "clmSoluongban";
            column5.HeaderText = "Số lượng bán";
            dgvThongKe.Columns.Add(column5);
        }
        //tạo thêm cột thống kê nhân viên
        private void AddCotNhanVien()
        {
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "clmID";
            column1.HeaderText = "Mã Nhân viên";
            dgvThongKe.Columns.Add(column1);

            // Thêm cột thứ hai
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "clmName";
            column2.HeaderText = "Mã Hóa đơn";
            dgvThongKe.Columns.Add(column2);

            // Thêm cột thứ ba
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "clmDate";
            column3.HeaderText = "Ngày";
            dgvThongKe.Columns.Add(column3);

            // Thêm cột thứ tư
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.Name = "clmMoney";
            column4.HeaderText = "Giá tiền";
            dgvThongKe.Columns.Add(column4);
        }
        private void AddCotDoanhThu()
        {
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "clmID";
            column1.HeaderText = "Mã Hóa đơn";
            dgvThongKe.Columns.Add(column1);

            // Thêm cột thứ hai
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "clmDate";
            column2.HeaderText = "Ngày";
            dgvThongKe.Columns.Add(column2);

            // Thêm cột thứ ba
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "clmSumMoney";
            column3.HeaderText = "Tổng tiền";
            dgvThongKe.Columns.Add(column3);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            lblTong.Visible = true;
            lblTongdoanhthu.Visible = true;
            var loaithongke = (string)cmbLoaiThongKe.SelectedItem;
            dgvThongKe.Columns.Clear(); //xóa hết cột trong dgv
            if (loaithongke == "Nhân Viên")
            {
                dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                AddCotNhanVien();
                using (var context = new Model())
                {
                    var ngayBatDau = dtpBatdau.Value.Date;
                    var ngayKetThuc = dtpKetthuc.Value.Date;
                    var results = context.HOA_DON.Where(x => x.hd_ngaylap >= ngayBatDau && x.hd_ngaylap <= ngayKetThuc).ToList();
                    decimal tongdoanhthu = 0;
                    foreach (var result in results)
                    {
                        int index = dgvThongKe.Rows.Add();
                        dgvThongKe.Rows[index].Cells[0].Value = result.nv_id;
                        dgvThongKe.Rows[index].Cells[1].Value = result.hd_id;
                        dgvThongKe.Rows[index].Cells[2].Value = result.hd_ngaylap;
                        dgvThongKe.Rows[index].Cells[3].Value = result.hd_tongthanhtoan.ToString();
                        tongdoanhthu += (decimal)result.hd_tongthanhtoan;
                    }
                    lblTong.Text = tongdoanhthu.ToString();
                }
            }
            else if (loaithongke == "Sản Phẩm")
            {
                lblTong.Visible = false;
                lblTongdoanhthu.Visible = false;
                dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                AddCotSanPham();
                using (var context = new Model())
                {
                    var ngayBatDau = dtpBatdau.Value.Date;
                    var ngayKetThuc = dtpKetthuc.Value.Date;
                    var sanphams = context.SAN_PHAM.ToList();
                    var hoadons = context.HOA_DON.Where(x => x.hd_ngaylap >= ngayBatDau && x.hd_ngaylap <= ngayKetThuc).ToList();
                    var chitiethoadons = context.CHI_TIET_HOA_DON.ToList();
                    foreach (var sanpham in sanphams)
                    {
                        int index = dgvThongKe.Rows.Add();
                        dgvThongKe.Rows[index].Cells[0].Value = sanpham.sp_id;
                        dgvThongKe.Rows[index].Cells[1].Value = sanpham.sp_ten;
                        dgvThongKe.Rows[index].Cells[2].Value = sanpham.sp_gia.ToString();
                        int soluongban = 0;
                        foreach (var hoadon in hoadons)
                        {
                            foreach (var chitiethoadon in chitiethoadons)
                            {
                                if (chitiethoadon.hd_id == hoadon.hd_id)
                                {
                                    if (chitiethoadon.sp_id == sanpham.sp_id)
                                    {
                                        soluongban += (int)chitiethoadon.soluong;
                                        sanpham.soluongton = (int)sanpham.soluongton - soluongban;
                                    }
                                }
                            }
                        }
                        dgvThongKe.Rows[index].Cells[3].Value = sanpham.soluongton.ToString();
                        dgvThongKe.Rows[index].Cells[4].Value = soluongban.ToString();

                    }
                }
            }
            else
            {
                lblTong.Visible = true;
                lblTongdoanhthu.Visible = true;
                dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                AddCotDoanhThu();
                var ngayBatDau = dtpBatdau.Value.Date;
                var ngayKetThuc = dtpKetthuc.Value.Date;
                var results = context.HOA_DON.Where(x => x.hd_ngaylap >= ngayBatDau && x.hd_ngaylap <= ngayKetThuc).ToList();
                decimal tongdoanhthu = 0;
                foreach (var result in results)
                {
                    int index = dgvThongKe.Rows.Add();
                    dgvThongKe.Rows[index].Cells[0].Value = result.hd_id;
                    dgvThongKe.Rows[index].Cells[1].Value = result.hd_ngaylap;
                    dgvThongKe.Rows[index].Cells[2].Value = result.hd_tongthanhtoan.ToString();
                    tongdoanhthu += (decimal)result.hd_tongthanhtoan;
                }
                lblTong.Text = tongdoanhthu.ToString();
            }
        }
        private void TimKiem(string keyword)
        {
            var loaithongke = (string)cmbLoaiThongKe.SelectedItem;
            using (var context = new Model())
            {
                if (loaithongke == "Nhân Viên")
                {
                    dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    AddCotNhanVien();
                    var ngayBatDau = dtpBatdau.Value.Date;
                    var ngayKetThuc = dtpKetthuc.Value.Date;
                    var NhanVienList = context.HOA_DON.Where(x => x.hd_ngaylap >= ngayBatDau && x.hd_ngaylap <= ngayKetThuc).ToList();
                    var ketQua = NhanVienList.Where(s =>
                        s.nv_id.Contains(keyword) ||
                        s.hd_id.Contains(keyword))
                        .Select(s => new
                        {
                            s.nv_id,
                            s.hd_id,
                            s.hd_ngaylap,
                            s.hd_tongthanhtoan,
                        }).ToList();
                    decimal tongdoanhthu = 0;
                    foreach (var result in ketQua)
                    {
                        int index = dgvThongKe.Rows.Add();
                        dgvThongKe.Rows[index].Cells[0].Value = result.nv_id;
                        dgvThongKe.Rows[index].Cells[1].Value = result.hd_id;
                        dgvThongKe.Rows[index].Cells[2].Value = result.hd_ngaylap;
                        dgvThongKe.Rows[index].Cells[3].Value = result.hd_tongthanhtoan.ToString();
                        tongdoanhthu += (decimal)result.hd_tongthanhtoan;
                    }
                    lblTong.Text = tongdoanhthu.ToString();
                }
                else if (loaithongke == "Sản Phẩm")
                {
                    dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    AddCotSanPham();
                    var ngayBatDau = dtpBatdau.Value.Date;
                    var ngayKetThuc = dtpKetthuc.Value.Date;
                    var sanphams = context.SAN_PHAM.ToList();
                    var hoadons = context.HOA_DON.Where(x => x.hd_ngaylap >= ngayBatDau && x.hd_ngaylap <= ngayKetThuc).ToList();
                    var chitiethoadons = context.CHI_TIET_HOA_DON.ToList();
                    var ketQua = sanphams.Where(s =>
                        s.sp_id.Contains(keyword) ||
                        s.sp_ten.Contains(keyword))
                        .Select(s => new
                        {
                            s.sp_id,
                            s.sp_ten,
                            s.sp_gia,
                            s.soluongton,
                        }).ToList();

                    foreach (var sanpham in ketQua)
                    {
                        int index = dgvThongKe.Rows.Add();
                        dgvThongKe.Rows[index].Cells[0].Value = sanpham.sp_id;
                        dgvThongKe.Rows[index].Cells[1].Value = sanpham.sp_ten;
                        dgvThongKe.Rows[index].Cells[2].Value = sanpham.sp_gia.ToString();

                        int soluongban = chitiethoadons
                            .Where(cthd => hoadons.Any(hd => hd.hd_id == cthd.hd_id) && cthd.sp_id == sanpham.sp_id)
                            .Sum(cthd => (int)cthd.soluong);

                        dgvThongKe.Rows[index].Cells[3].Value = (sanpham.soluongton - soluongban).ToString();
                        dgvThongKe.Rows[index].Cells[4].Value = soluongban.ToString();
                    }
                }
                else 
                {
                    dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    AddCotDoanhThu();
                    var ngayBatDau = dtpBatdau.Value.Date;
                    var ngayKetThuc = dtpKetthuc.Value.Date;
                    var results = context.HOA_DON.Where(x => x.hd_ngaylap >= ngayBatDau && x.hd_ngaylap <= ngayKetThuc).ToList();
                    decimal tongdoanhthu = 0;
                    var ketQua = results.Where(s =>
                        s.nv_id.Contains(keyword) ||
                        s.hd_id.Contains(keyword))
                        .Select(s => new
                        {
                            s.hd_id,
                            s.hd_ngaylap,
                            s.hd_tongthanhtoan,
                        }).ToList();
                    foreach (var result in results)
                    {
                        int index = dgvThongKe.Rows.Add();
                        dgvThongKe.Rows[index].Cells[0].Value = result.hd_id;
                        dgvThongKe.Rows[index].Cells[1].Value = result.hd_ngaylap;
                        dgvThongKe.Rows[index].Cells[2].Value = result.hd_tongthanhtoan.ToString();
                        tongdoanhthu += (decimal)result.hd_tongthanhtoan;
                    }
                    lblTong.Text = tongdoanhthu.ToString();
                }
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var keyword = txtTim.Text.ToLower();
                TimKiem(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
