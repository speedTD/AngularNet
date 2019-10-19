namespace ShopGame.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PostCateGory
    {
        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string name { get; set; }

        [Required]
        [StringLength(250)]
        public string alias { get; set; }

        public int? parentid { get; set; }

        public int? displayoder { get; set; }

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

        public bool status { get; set; }

        public bool? homeflag { get; set; }

        
        public virtual PostCateGory PostCateGory { set; get; }

        public virtual IEnumerable<PostTag> PostTags { set; get; }
    }
}
