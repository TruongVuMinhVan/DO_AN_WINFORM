namespace Do_An_WinForm.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOA_DON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOA_DON()
        {
            CHI_TIET_HOA_DON = new HashSet<CHI_TIET_HOA_DON>();
        }

        [Key]
        [StringLength(10)]
        public string hd_id { get; set; }

        public DateTime? hd_ngaylap { get; set; }

        [Column(TypeName = "money")]
        public decimal? hd_tongthanhtoan { get; set; }

        [StringLength(50)]
        public string phuongthucthanhtoan { get; set; }

        [Required]
        [StringLength(10)]
        public string nv_id { get; set; }

        [Required]
        [StringLength(10)]
        public string kh_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_HOA_DON> CHI_TIET_HOA_DON { get; set; }

        public virtual KHACH_HANG KHACH_HANG { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
