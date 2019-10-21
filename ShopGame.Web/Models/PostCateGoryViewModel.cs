using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopGame.Web.Models
{
    public class PostCateGoryViewModel
    {

        public int id { get; set; }

        public string name { get; set; }

        public string alias { get; set; }

        public int? parentid { get; set; }

        public int? displayoder { get; set; }

  
        public string image { get; set; }

   
        public string metakeyword { get; set; }

    
        public string metaDesciption { get; set; }

        public DateTime? createdat { get; set; }


        public string createby { get; set; }

        public DateTime? updatedat { get; set; }

        public string updateby { get; set; }

        public bool status { get; set; }

        public bool? homeflag { get; set; }
        public virtual IEnumerable<PostViewModel> Post { set; get; }

    }
}