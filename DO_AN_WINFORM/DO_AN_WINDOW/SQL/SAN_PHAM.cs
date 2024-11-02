namespace WindowsFormsApp1.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAN_PHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAN_PHAM()
        {
            CHI_TIET_HOA_DON = new HashSet<CHI_TIET_HOA_DON>();
        }

        [Key]
        [StringLength(10)]
        public string sp_id { get; set; }

        [StringLength(50)]
        public string sp_ten { get; set; }

        [Column(TypeName = "money")]
        public decimal? sp_gia { get; set; }

        [StringLength(50)]
        public string sp_gioitinh { get; set; }

        [StringLength(100)]
        public string sp_anh { get; set; }

        public int? soluongton { get; set; }

        [Required]
        [StringLength(10)]
        public string dm_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_HOA_DON> CHI_TIET_HOA_DON { get; set; }

        public virtual DANH_MUC DANH_MUC { get; set; }
    }
}
