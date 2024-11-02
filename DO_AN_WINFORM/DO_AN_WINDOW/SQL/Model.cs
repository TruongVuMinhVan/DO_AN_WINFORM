using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1.SQL
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model_QuanLyBanHang")
        {
        }

        public virtual DbSet<CHI_TIET_HOA_DON> CHI_TIET_HOA_DON { get; set; }
        public virtual DbSet<DANH_MUC> DANH_MUC { get; set; }
        public virtual DbSet<HOA_DON> HOA_DON { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public virtual DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
        public virtual DbSet<SAN_PHAM> SAN_PHAM { get; set; }
        public virtual DbSet<View_HoaDonReport> View_HoaDonReport { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHI_TIET_HOA_DON>()
                .Property(e => e.sp_id)
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_HOA_DON>()
                .Property(e => e.hd_id)
                .IsUnicode(false);

            modelBuilder.Entity<DANH_MUC>()
                .Property(e => e.dm_id)
                .IsUnicode(false);

            modelBuilder.Entity<DANH_MUC>()
                .HasMany(e => e.SAN_PHAM)
                .WithRequired(e => e.DANH_MUC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.hd_id)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.hd_tongthanhtoan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.nv_id)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.kh_id)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .HasMany(e => e.CHI_TIET_HOA_DON)
                .WithRequired(e => e.HOA_DON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACH_HANG>()
                .Property(e => e.kh_id)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_HANG>()
                .HasMany(e => e.HOA_DON)
                .WithRequired(e => e.KHACH_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.nv_id)
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .HasMany(e => e.HOA_DON)
                .WithRequired(e => e.NHAN_VIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAN_PHAM>()
                .Property(e => e.sp_id)
                .IsUnicode(false);

            modelBuilder.Entity<SAN_PHAM>()
                .Property(e => e.sp_gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAN_PHAM>()
                .Property(e => e.sp_anh)
                .IsUnicode(false);

            modelBuilder.Entity<SAN_PHAM>()
                .Property(e => e.dm_id)
                .IsUnicode(false);

            modelBuilder.Entity<SAN_PHAM>()
                .HasMany(e => e.CHI_TIET_HOA_DON)
                .WithRequired(e => e.SAN_PHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<View_HoaDonReport>()
                .Property(e => e.MaHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<View_HoaDonReport>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_HoaDonReport>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_HoaDonReport>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);
        }
    }
}
