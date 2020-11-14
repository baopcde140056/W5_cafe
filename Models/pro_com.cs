namespace W5_cafe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pro_com
    {
        [StringLength(5)]
        public string id { get; set; }

        [Required]
        [StringLength(5)]
        public string id_pro { get; set; }

        [Required]
        [StringLength(5)]
        public string id_com { get; set; }
    }
}
