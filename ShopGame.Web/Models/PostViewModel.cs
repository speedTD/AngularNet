using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopGame.Web.Models
{
    public class PostViewModel
    {
        public int id { get; set; }

        public string name { get; set; }


        public string alias { get; set; }

        public int? categoryid { get; set; }


        public string desciption { get; set; }


        public string content { get; set; }


        public string image { get; set; }

        public string metakeyword { get; set; }

        public string metaDesciption { get; set; }

        public DateTime? createdat { get; set; }

     
        public string createby { get; set; }

        public DateTime? updatedat { get; set; }

 
        public string updateby { get; set; }

        public bool status { get; set; }

        public bool? homeflag { get; set; }

        public bool? hotflag { get; set; }

        public long? viewcount { get; set; }

        public virtual PostCateGoryViewModel PostCateGory { set; get; }

        public virtual IEnumerable<PostTagViewModel> PostTag { set; get; }

    }
}