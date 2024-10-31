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
            this.TopLevel = false; //hoạt động trong panel
            this.FormBorderStyle = FormBorderStyle.None;// ẩn viền
            this.Dock = DockStyle.Fill;
        }
        private void LoadNhanVien()
        {
            var employees = dbcontext.NHAN_VIEN.ToList();
            BindGrid(employees);
        }

        private void BindGrid(IEnumerable<NHAN_VIEN> employees)
        {
            dgvQL_NV.Rows.Clear();
            foreach (var emp in employees)
            {
                dgvQL_NV.Rows.Add(emp.nv_id, emp.nv_ten, emp.nv_diachi, emp.nv_sdt);
            }
        }
        private void ClearInputFields()
        {
            txtIDNV.Clear();
            txtTenNV.Clear();
            txtDC.Clear();
            mtbSDT.Clear();
        }
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường thông tin không được bỏ trống
            if (string.IsNullOrWhiteSpace(txtIDNV.Text) || string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            var newEmployee = new NHAN_VIEN
            {
                nv_id = txtIDNV.Text.Trim(),
                nv_ten = txtTenNV.Text.Trim(),
                nv_diachi = txtDC.Text.Trim(),
                nv_sdt = string.IsNullOrEmpty(mtbSDT.Text) ? (int?)null : int.Parse(mtbSDT.Text.Trim())
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
        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
                return;
            }

            var employeeId = txtIDNV.Text.Trim();
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


        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!");
                return;
            }

            var employeeId = txtIDNV.Text.Trim();
            var employee = dbcontext.NHAN_VIEN.Find(employeeId);

            if (employee == null)
            {
                MessageBox.Show("Nhân viên cần sửa không tồn tại!");
                return;
            }

            employee.nv_ten = txtTenNV.Text.Trim();
            employee.nv_diachi = txtDC.Text.Trim();
            employee.nv_sdt = string.IsNullOrEmpty(mtbSDT.Text) ? (int?)null : int.Parse(mtbSDT.Text.Trim());

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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để lưu!");
                return;
            }

            var employeeId = txtIDNV.Text.Trim();
            var employee = dbcontext.NHAN_VIEN.FirstOrDefault(emp => emp.nv_id == employeeId);

            if (employee == null)
            {
                MessageBox.Show("Nhân viên không tồn tại!");
                return;
            }

            employee.nv_ten = txtTenNV.Text.Trim();
            employee.nv_diachi = txtDC.Text.Trim();
            employee.nv_sdt = string.IsNullOrEmpty(mtbSDT.Text) ? (int?)null : int.Parse(mtbSDT.Text.Trim());

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


