namespace ShopGame.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string name { get; set; }

        [Required]
        [StringLength(250)]
        public string alias { get; set; }

        public int? categoryid { get; set; }

        [StringLength(250)]
        public string desciption { get; set; }

        [Column(TypeName = "ntext")]
        public string content { get; set; }

        public decimal? promotion { get; set; }

        public int? warraly { get; set; }

        public decimal? price { get; set; }

        [Column(TypeName = "xml")]
        public string moreimage { get; set; }

        [StringLength(250)]
        public string image { get; set; }

        [StringLength(250)]
        public string metakeyword { get; set; }

        [StringLength(250)]
        public string metaDesciption { get; set; }

        public DateTime? createdat { get; set; }

        [StringLength(250)]
        public string createby { get; set; }

        public DateTime? updatedat { get; set; }

        [StringLength(250)]
        public string updateby { get; set; }

        public bool? status { get; set; }

        public bool? homeflag { get; set; }

        public bool? hotflag { get; set; }

        public long? viewcount { get; set; }
    }
}
