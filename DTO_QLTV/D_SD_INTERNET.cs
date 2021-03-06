namespace DTO_QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_SD_INTERNET
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string MaSD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MaMayTinh { get; set; }

        public DateTime? ThoiGianSD { get; set; }

        [StringLength(8)]
        public string MaThe { get; set; }

        public virtual HOSODOCGIA HOSODOCGIA { get; set; }

        public virtual MAYTINH MAYTINH { get; set; }
    }
}
