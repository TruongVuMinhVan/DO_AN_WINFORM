namespace WindowsFormsApp1.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_HOA_DON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string sp_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string hd_id { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        public int? soluong { get; set; }

        public virtual HOA_DON HOA_DON { get; set; }

        public virtual SAN_PHAM SAN_PHAM { get; set; }
    }
}
