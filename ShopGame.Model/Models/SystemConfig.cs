namespace ShopGame.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemConfig")]
    public partial class SystemConfig
    {
        public int id { get; set; }

        [Column(TypeName = "ntext")]
        public string code { get; set; }

        [Column(TypeName = "ntext")]
        public string valuestring { get; set; }

        public int? valueInt { get; set; }
    }
}
