namespace W5_cafe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("find")]
    public partial class find
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string tel { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string email { get; set; }

        [StringLength(150)]
        public string open_hours { get; set; }
    }
}
