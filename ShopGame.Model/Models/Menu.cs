namespace ShopGame.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Menu
    {
        public int id { get; set; }

        [StringLength(520)]
        public string name { get; set; }

        [StringLength(520)]
        public string url { get; set; }

        public int? displayoder { get; set; }

        [StringLength(50)]
        public string taget { get; set; }

        public bool? status { get; set; }

        public int? groupid { get; set; }
    }
}
