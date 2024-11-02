namespace WindowsFormsApp1.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHAN_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAN_VIEN()
        {
            HOA_DON = new HashSet<HOA_DON>();
        }

        [Key]
        [StringLength(10)]
        public string nv_id { get; set; }

        [StringLength(50)]
        public string nv_ten { get; set; }

        public int? nv_sdt { get; set; }

        [StringLength(50)]
        public string nv_diachi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }
    }
}
