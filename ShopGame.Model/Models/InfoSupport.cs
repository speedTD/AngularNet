namespace ShopGame.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InfoSupport")]
    public partial class InfoSupport
    {
        public int id { get; set; }

        [Column(TypeName = "ntext")]
        public string name { get; set; }

        [Column(TypeName = "ntext")]
        public string department { get; set; }

        [StringLength(50)]
        public string skype { get; set; }

        [StringLength(50)]
        public string mobile { get; set; }

        [StringLength(50)]
        public string emaill { get; set; }

        [StringLength(50)]
        public string facebook { get; set; }

        [Column(TypeName = "ntext")]
        public string address { get; set; }

        public bool? status { get; set; }
    }
}
