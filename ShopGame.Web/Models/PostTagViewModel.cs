using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopGame.Web.Models
{
    public class PostTagViewModel
    {
        public int potsid { get; set; }
        public string tagid { get; set; }

        public virtual PostViewModel Post { set; get; }

        public virtual PostTagViewModel Tag { set; get; }
    }
}