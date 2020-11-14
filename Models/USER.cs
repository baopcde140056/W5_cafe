namespace W5_cafe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        [Key]
        [StringLength(10)]
        public string name { get; set; }

        [Required]
        [StringLength(5)]
        public string pass { get; set; }

        [Required]
        [StringLength(50)]
        public string brand { get; set; }

        [Required]
        [StringLength(5)]
        public string address { get; set; }

        [StringLength(255)]
        public string image { get; set; }

        [Required]
        public string content { get; set; }
    }
}
