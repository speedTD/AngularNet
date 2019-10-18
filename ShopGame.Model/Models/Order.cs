namespace ShopGame.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int id { get; set; }

        [StringLength(250)]
        public string custormername { get; set; }

        [StringLength(250)]
        public string custormeradress { get; set; }

        [StringLength(250)]
        public string custormeremail { get; set; }

        [StringLength(250)]
        public string custormerphone { get; set; }

        public DateTime? createdat { get; set; }

        [StringLength(50)]
        public string createby { get; set; }

        [StringLength(250)]
        public string paymethod { get; set; }

        [StringLength(250)]
        public string paystatus { get; set; }

        public bool? status { get; set; }
    }
}
