namespace ShopGame.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tag
    {
        [StringLength(50)]
        public string id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string type { get; set; }
    }
}
