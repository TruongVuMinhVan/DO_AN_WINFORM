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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            txtMatkhau.UseSystemPasswordChar = true;
            txtMatkhau.KeyDown += new KeyEventHandler(txtMatkhau_KeyDown);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            String Tendangnhap = txtTenDangNhap.Text;
            string Matkhau = txtMatkhau.Text;
            if (Tendangnhap == "admin" && Matkhau == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Chuyển sang form Main
                frmMain mainform = new frmMain();
                this.Hide();
                mainform.Show();
            }
            else
            {
                CheckInput();
                MessageBox.Show("Thông tin đăng nhập không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Clear();
                txtMatkhau.Clear();
            }
        }

        private void txtMatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnDangnhap.PerformClick();
            }
        }
        private void CheckInput()
        {
            // Kiểm tra nếu TextBox rỗng
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) && string.IsNullOrWhiteSpace(txtMatkhau.Text))
            {
                MessageBox.Show("Thông tin chưa được nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbHienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatkhau.UseSystemPasswordChar = !cbHienmatkhau.Checked;
        }
    }
}
