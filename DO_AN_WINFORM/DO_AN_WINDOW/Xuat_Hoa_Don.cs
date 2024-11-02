using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using WindowsFormsApp1.SQL;

namespace WindowsFormsApp1
{
    public partial class Xuat_Hoa_Don : Form
    {
        private Model db = new Model();
        private string MaHoaDon;

        public Xuat_Hoa_Don(string maHoaDon)
        {
            InitializeComponent();
            MaHoaDon = maHoaDon; // Gán giá trị mã hóa đơn
        }

        private void Xuat_Hoa_Don_Load(object sender, EventArgs e)
        {
            // Làm mới và hiển thị ReportViewer
            this.rvInHoaDon.RefreshReport();
        }

        private void rvInHoaDon_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaHoaDon))
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ.");
                return;
            }

            // Lấy dữ liệu từ View_HoaDonReport theo mã hóa đơn
            var hoaDonData = db.View_HoaDonReport.Where(hd => hd.MaHoaDon == MaHoaDon).ToList();

            if (hoaDonData.Any())
            {
                
                ReportDataSource reportDataSource = new ReportDataSource("DataSet", hoaDonData);

                rvInHoaDon.LocalReport.DataSources.Clear();
                rvInHoaDon.LocalReport.DataSources.Add(reportDataSource);
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn với mã: " + MaHoaDon);
            }

            // Làm mới và hiển thị ReportViewer
            rvInHoaDon.RefreshReport();
        }

    }
}
