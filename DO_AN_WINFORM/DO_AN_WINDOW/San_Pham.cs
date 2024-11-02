using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.SQL;

namespace WindowsFormsApp1
{
    public partial class San_Pham : Form
    {
        private Model dbContext;
        public San_Pham()
        {
            InitializeComponent();
            this.TopLevel = false; // Hoạt động trong panel
            this.FormBorderStyle = FormBorderStyle.None; // Ẩn viền
            this.Dock = DockStyle.Fill;
            dbContext = new Model();
            LoadSanPham();
        }

        private void LoadSanPham()
        {
            try
            {
                var products = dbContext.SAN_PHAM.ToList();
                BindGrid(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(IEnumerable<SAN_PHAM> products)
        {
            dgvSanpham.Rows.Clear();
            foreach (var product in products)
            {
                dgvSanpham.Rows.Add(product.sp_id, product.sp_ten, product.soluongton, product.sp_gia, product.sp_anh, product.dm_id);
            }
        }
        private void ClearInputFields()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSoluong.Clear();
            txtDongianban.Clear();
            txtDanhMucID.Clear();
            txtURLAnh.Clear();
            ptbAnh.Image = null;
        }

        private void dgvSanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var selectedRow = dgvSanpham.Rows[e.RowIndex];

                    // Ensure the selected cells have values before trying to access them
                    if (selectedRow.Cells["sp_id"].Value != null)
                        txtMaSP.Text = selectedRow.Cells["sp_id"].Value.ToString();
                    if (selectedRow.Cells["sp_ten"].Value != null)
                        txtTenSP.Text = selectedRow.Cells["sp_ten"].Value.ToString();
                    if (selectedRow.Cells["soluongton"].Value != null)
                        txtSoluong.Text = selectedRow.Cells["soluongton"].Value.ToString();
                    if (selectedRow.Cells["sp_gia"].Value != null)
                        txtDongianban.Text = selectedRow.Cells["sp_gia"].Value.ToString();
                    if (selectedRow.Cells["sp_anh"].Value != null)
                        txtURLAnh.Text = selectedRow.Cells["sp_anh"].Value.ToString();
                    if (selectedRow.Cells["dm_id"].Value != null)
                        txtDanhMucID.Text = selectedRow.Cells["dm_id"].Value.ToString();

                    // Load the image into the PictureBox
                    string imageUrl = selectedRow.Cells["sp_anh"].Value?.ToString();
                    if (!string.IsNullOrEmpty(imageUrl) && System.IO.File.Exists(imageUrl)) // Check if the image file exists
                    {
                        ptbAnh.Image = Image.FromFile(imageUrl); // Ensure the file exists
                    }
                    else
                    {
                        ptbAnh.Image = null; // Clear the image if the file does not exist
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.");
                return;
            }

            var newProduct = new SAN_PHAM
            {
                sp_id = txtMaSP.Text.Trim(),
                sp_ten = txtTenSP.Text.Trim(),
                soluongton = int.Parse(txtSoluong.Text),
                sp_gia = decimal.Parse(txtDongianban.Text),
                sp_anh = txtURLAnh.Text.Trim(),
                dm_id = txtDanhMucID.Text.Trim()
            };

            try
            {
                dbContext.SAN_PHAM.Add(newProduct);
                dbContext.SaveChanges();
                LoadSanPham(); // Tải lại danh sách sản phẩm
                MessageBox.Show("Thêm sản phẩm thành công!");
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sản phẩm: {ex.Message}");
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!");
                return;
            }

            var productId = txtMaSP.Text.Trim();
            var product = dbContext.SAN_PHAM.Find(productId);
            if (product == null)
            {
                MessageBox.Show("Sản phẩm không tồn tại!");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dbContext.SAN_PHAM.Remove(product);
                dbContext.SaveChanges();
                MessageBox.Show("Xóa sản phẩm thành công!");
                LoadSanPham();
                ClearInputFields();
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa!");
                return;
            }

            var productId = txtMaSP.Text.Trim();
            var product = dbContext.SAN_PHAM.Find(productId);

            if (product == null)
            {
                MessageBox.Show("Sản phẩm không tồn tại!");
                return;
            }

            product.sp_ten = txtTenSP.Text.Trim();
            product.soluongton = int.Parse(txtSoluong.Text);
            product.sp_gia = decimal.Parse(txtDongianban.Text);
            product.sp_anh = txtURLAnh.Text.Trim();
            product.dm_id = txtDanhMucID.Text.Trim();

            try
            {
                dbContext.SaveChanges();
                LoadSanPham();
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công!");
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa sản phẩm: {ex.Message}");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSP.Text))
                {
                    MessageBox.Show("Mã sản phẩm không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var productId = txtMaSP.Text.Trim();
                var product = dbContext.SAN_PHAM.Find(productId);

                if (product != null)
                {
                    product.sp_ten = txtTenSP.Text.Trim();
                    product.soluongton = int.Parse(txtSoluong.Text);
                    product.sp_gia = decimal.Parse(txtDongianban.Text);
                    product.sp_anh = txtURLAnh.Text.Trim();
                    product.dm_id = txtDanhMucID.Text.Trim();

                    dbContext.SaveChanges();
                    MessageBox.Show("Lưu sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {dbEx.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng kiểm tra lại định dạng số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
