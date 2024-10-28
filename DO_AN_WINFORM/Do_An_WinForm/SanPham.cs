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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
            this.TopLevel = false; //hoạt động trong panel
            this.FormBorderStyle = FormBorderStyle.None;// ẩn viền
            this.Dock = DockStyle.Fill;
        }
    }
}
