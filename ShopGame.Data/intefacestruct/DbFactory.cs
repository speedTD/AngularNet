using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGame.Data.intefacestruct
{
    public class DbFactory : Disposable, IDbFactory
    {

        DbModelContext dbcontext;
        public DbModelContext Init()
        {
            return dbcontext ?? (dbcontext = new DbModelContext());
        }
        protected override void DisposeCore()
        {
            if (dbcontext != null)
            {
                dbcontext.Dispose();
            }
          
        }
    }
}
