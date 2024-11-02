namespace WindowsFormsApp1.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHACH_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH_HANG()
        {
            HOA_DON = new HashSet<HOA_DON>();
        }

        [Key]
        [StringLength(10)]
        public string kh_id { get; set; }

        [StringLength(50)]
        public string kh_ten { get; set; }

        [StringLength(50)]
        public string kh_gioitinh { get; set; }

        public int? kh_sdt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }
    }
}
