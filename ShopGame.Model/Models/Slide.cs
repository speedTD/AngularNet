namespace ShopGame.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slide")]
    public partial class Slide
    {
        public int id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [StringLength(250)]
        public string desciption { get; set; }

        [StringLength(250)]
        public string image { get; set; }

        [StringLength(250)]
        public string url { get; set; }

        public int? displayoder { get; set; }

        public bool? status { get; set; }
    }
}
