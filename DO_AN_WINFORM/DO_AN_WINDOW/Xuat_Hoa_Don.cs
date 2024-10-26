using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Xuat_Hoa_Don : Form
    {
        public Xuat_Hoa_Don()
        {
            InitializeComponent();
        }

        private void Xuat_Hoa_Don_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
