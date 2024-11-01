using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.SQL;

namespace WindowsFormsApp1
{
    public partial class frmQuanLyNhanVien : Form
    {
        private Model1 dbcontext;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            dbcontext = new Model1();
            LoadNhanVien();
        }

        private void LoadNhanVien()
        {
            var employees = dbcontext.NHAN_VIEN.ToList();
            BindGrid(employees);
        }

        private void BindGrid(IEnumerable<NHAN_VIEN> employees)
        {
            dgvNhanVien.Rows.Clear();
            foreach (var emp in employees)
            {
                dgvNhanVien.Rows.Add(emp.nv_id, emp.nv_ten, emp.nv_diachi, emp.nv_sdt);
            }
        }
        private void ClearInputFields()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiachi.Clear();
            txtSDT.Clear();
        }
        private void btnThemNhanVien_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra các trường thông tin không được bỏ trống
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            var newEmployee = new NHAN_VIEN
            {
                nv_id = txtMaNV.Text.Trim(),
                nv_ten = txtTenNV.Text.Trim(),
                nv_diachi = txtDiachi.Text.Trim(),
                nv_sdt = string.IsNullOrEmpty(txtSDT.Text) ? (int?)null : int.Parse(txtSDT.Text.Trim())
            };

            try
            {
                dbcontext.NHAN_VIEN.Add(newEmployee);
                dbcontext.SaveChanges();
                LoadNhanVien(); // Gọi phương thức để tải lại dữ liệu nhân viên
                MessageBox.Show("Thêm nhân viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}");
            }
        }

        private void btnXoaNhanVien_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
                return;
            }

            var employeeId = txtMaNV.Text.Trim();
            var employee = dbcontext.NHAN_VIEN.Find(employeeId);
            if (employee == null)
            {
                MessageBox.Show("Nhân viên cần xóa không tồn tại!");
                return;
            }
            var result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dbcontext.NHAN_VIEN.Remove(employee);
                dbcontext.SaveChanges();
                MessageBox.Show("Xóa nhân viên thành công!");
                LoadNhanVien();
                ClearInputFields();
            }
        }

            private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có phải là hàng dữ liệu không và ô được nhấp không phải là ô trống
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var selectedRow = dgvNhanVien.Rows[e.RowIndex];

                    // Kiểm tra ô ID nhân viên có giá trị không
                    if (selectedRow.Cells["nv_id"].Value != null && !string.IsNullOrWhiteSpace(selectedRow.Cells["nv_id"].Value.ToString()))
                    {
                        txtMaNV.Text = selectedRow.Cells["nv_id"].Value.ToString(); // Lấy mã nhân viên
                        txtTenNV.Text = selectedRow.Cells["nv_ten"].Value?.ToString(); // Lấy tên nhân viên
                        txtDiachi.Text = selectedRow.Cells["nv_diachi"].Value?.ToString(); // Lấy địa chỉ
                        txtSDT.Text = selectedRow.Cells["nv_sdt"].Value != null ? selectedRow.Cells["nv_sdt"].Value.ToString() : string.Empty; // Lấy số điện thoại
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn nhân viên: {ex.Message}");
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!");
                return;
            }

            var employeeId = txtMaNV.Text.Trim();
            var employee = dbcontext.NHAN_VIEN.Find(employeeId);

            if (employee == null)
            {
                MessageBox.Show("Nhân viên cần sửa không tồn tại!");
                return;
            }

            employee.nv_ten = txtTenNV.Text.Trim();
            employee.nv_diachi = txtDiachi.Text.Trim();
            employee.nv_sdt = string.IsNullOrEmpty(txtSDT.Text) ? (int?)null : int.Parse(txtSDT.Text.Trim());

            try
            {
                dbcontext.SaveChanges();
                LoadNhanVien(); // Gọi phương thức để tải lại dữ liệu nhân viên
                ClearInputFields();
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật thông tin nhân viên: {ex.Message}");
            }
        }




        private void btnDong_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để lưu!");
                return;
            }

            var employeeId = txtMaNV.Text.Trim();
            var employee = dbcontext.NHAN_VIEN.FirstOrDefault(emp => emp.nv_id == employeeId);

            if (employee == null)
            {
                MessageBox.Show("Nhân viên không tồn tại!");
                return;
            }

            employee.nv_ten = txtTenNV.Text.Trim();
            employee.nv_diachi = txtDiachi.Text.Trim();
            employee.nv_sdt = string.IsNullOrEmpty(txtSDT.Text) ? (int?)null : int.Parse(txtSDT.Text.Trim());

            try
            {
                dbcontext.SaveChanges();
                LoadNhanVien(); // Gọi phương thức để tải lại dữ liệu nhân viên
                MessageBox.Show("Lưu thông tin nhân viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu thông tin nhân viên: {ex.Message}");
            }
        }
    }
}


