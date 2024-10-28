using Do_An_WinForm.SQL;
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
    public partial class frmKhachHang : Form
    {
        private Model1 dbContext;
        public frmKhachHang()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            dbContext = new Model1();
            LoadKhachhang();
        }
        private void LoadKhachhang()
        {
            try
            {
                var customers = dbContext.KHACH_HANG.ToList();
                BindGrid(customers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải khách hàng: {ex.Message}");
            }
        }
        private void BindGrid(IEnumerable<KHACH_HANG> customers)
        {
            dgvQLKH.Rows.Clear();

            if (!customers?.Any() ?? true)
            {
                MessageBox.Show("Không tìm thấy khách hàng.");

            }

            foreach (var customer in customers)
            {
                dgvQLKH.Rows.Add(customer.kh_id, customer.kh_ten, customer.kh_gioitinh, customer.kh_sdt);
            }
        }
        private void ClearInputFields()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            txtSDT.Clear();
        }

        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {
            string searchTerm = txtTimkiem.Text.Trim().ToLower(); // Chuyển đổi từ khóa tìm kiếm về chữ thường

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.");
                return;
            }

            var results = dbContext.KHACH_HANG
                .Where(c => c.kh_id.ToLower().Contains(searchTerm) || c.kh_ten.ToLower().Contains(searchTerm)) // Chuyển đổi giá trị trong cơ sở dữ liệu về chữ thường
                .ToList();

            if (results.Any())
            {
                BindGrid(results);
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng nào.");
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng.");
                return;
            }

            var newCustomer = new KHACH_HANG
            {
                kh_id = txtMaKH.Text.Trim(),
                kh_ten = txtTenKH.Text.Trim(),
                kh_gioitinh = rdbNam.Checked ? "Nam" : (rdbNu.Checked ? "Nữ" : null),
                kh_sdt = string.IsNullOrEmpty(txtSDT.Text) ? (int?)null : int.Parse(txtSDT.Text.Trim())
            };

            try
            {
                dbContext.KHACH_HANG.Add(newCustomer);
                dbContext.SaveChanges();
                LoadKhachhang();
                MessageBox.Show("Thêm khách hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm khách hàng: {ex.Message}");
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!");
                return;
            }

            var customerId = txtMaKH.Text.Trim();
            var customer = dbContext.KHACH_HANG.Find(customerId);
            if (customer == null)
            {
                MessageBox.Show("Khách hàng cần xóa không tồn tại!");
                return;
            }

            if (customer.kh_ten != txtTenKH.Text.Trim() || customer.kh_sdt.ToString() != txtSDT.Text.Trim())
            {
                MessageBox.Show("Thông tin không khớp với khách hàng.");
                return;
            }

            var result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dbContext.KHACH_HANG.Remove(customer);
                dbContext.SaveChanges();
                MessageBox.Show("Xóa thành công!");
                LoadKhachhang();
                ClearInputFields();
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa!");
                return;
            }

            var customerId = txtMaKH.Text.Trim();
            var customer = dbContext.KHACH_HANG.Find(customerId);

            if (customer == null)
            {
                MessageBox.Show("Khách hàng cần sửa không tồn tại!");
                return;
            }

            customer.kh_ten = txtTenKH.Text.Trim();
            customer.kh_gioitinh = rdbNam.Checked ? "Nam" : (rdbNu.Checked ? "Nữ" : null);
            customer.kh_sdt = string.IsNullOrEmpty(txtSDT.Text) ? (int?)null : int.Parse(txtSDT.Text.Trim());

            try
            {
                dbContext.SaveChanges();
                LoadKhachhang();
                ClearInputFields();
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật thông tin khách hàng: {ex.Message}");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
        }

        private void dgvQLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedRow = dgvQLKH.Rows[e.RowIndex];


                if (selectedRow.Cells[0].Value != null && !string.IsNullOrWhiteSpace(selectedRow.Cells[0].Value.ToString()))
                {
                    txtMaKH.Text = selectedRow.Cells[0].Value.ToString();
                    txtTenKH.Text = selectedRow.Cells[1].Value.ToString();
                    string gender = selectedRow.Cells[2].Value.ToString();
                    rdbNam.Checked = gender == "Nam";
                    rdbNu.Checked = gender == "Nữ";
                    txtSDT.Text = selectedRow.Cells[3].Value.ToString();
                }
            }
        }

        private void dgvQLKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedRow = dgvQLKH.Rows[e.RowIndex];


                if (selectedRow.Cells[0].Value != null && !string.IsNullOrWhiteSpace(selectedRow.Cells[0].Value.ToString()))
                {
                    txtMaKH.Text = selectedRow.Cells[0].Value.ToString();
                    txtTenKH.Text = selectedRow.Cells[1].Value.ToString();
                    string gender = selectedRow.Cells[2].Value.ToString();
                    rdbNam.Checked = gender == "Nam";
                    rdbNu.Checked = gender == "Nữ";
                    txtSDT.Text = selectedRow.Cells[3].Value.ToString();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để lưu!");

            }

            var customerId = txtMaKH.Text.Trim();
            var customer = dbContext.KHACH_HANG.FirstOrDefault(c => c.kh_id == customerId);

            if (customer == null)
            {
                MessageBox.Show("Khách hàng không tồn tại!");

            }


            customer.kh_ten = txtTenKH.Text.Trim();
            customer.kh_gioitinh = rdbNam.Checked ? "Nam" : (rdbNu.Checked ? "Nữ" : null);
            customer.kh_sdt = string.IsNullOrEmpty(txtSDT.Text) ? (int?)null : int.Parse(txtSDT.Text.Trim());
            try
            {
                dbContext.SaveChanges();
                LoadKhachhang();
                MessageBox.Show("Lưu thông tin khách hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu thông tin khách hàng: {ex.Message}");
            }
        }

        private void txtTimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTimKhachHang_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
