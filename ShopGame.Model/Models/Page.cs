namespace ShopGame.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Page
    {
        public int id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string content { get; set; }

        [StringLength(250)]
        public string makekeyword { get; set; }

        [StringLength(250)]
        public string makedesiption { get; set; }

        public bool? status { get; set; }
    }
}
