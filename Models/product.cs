namespace W5_cafe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product
    {
        [StringLength(5)]
        public string id { get; set; }

        [Required]
        public string image { get; set; }

        [Required]
        public string description { get; set; }

        public decimal price { get; set; }

        [Required]
        [StringLength(15)]
        public string name { get; set; }
    }
}
