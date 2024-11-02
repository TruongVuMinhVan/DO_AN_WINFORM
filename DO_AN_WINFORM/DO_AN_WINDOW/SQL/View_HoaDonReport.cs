namespace WindowsFormsApp1.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_HoaDonReport
    {
        public long? STT { get; set; }

        [Key]
        [StringLength(10)]
        public string MaHoaDon { get; set; }

        [StringLength(50)]
        public string NhanVienLap { get; set; }

        [StringLength(50)]
        public string TenKhachHang { get; set; }

        public DateTime? NgayLap { get; set; }

        [StringLength(50)]
        public string PhuongThucThanhToan { get; set; }

        [StringLength(50)]
        public string TenSanPham { get; set; }

        public int? SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }
    }
}
