using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGame.Model.Models
{
    [Table("Errors")]
    public class Errorr
    {

        public int id { set; get; }
        public String message { set; get; }
        public String stacktrace {set;get;}
        public DateTime createdat { set; get; }
    }
}
