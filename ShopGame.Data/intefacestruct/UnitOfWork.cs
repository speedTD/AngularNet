using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGame.Data.intefacestruct
{
    public class UnitOfWork : IUnitOfWork
    {
         readonly IDbFactory dbFactory;
          public  DbModelContext dbContext;

        public UnitOfWork(IDbFactory db)
        {
            this.dbFactory = db;
        }
        public DbModelContext Dbcontext
        {
            get { return dbContext ?? (dbContext =dbFactory.Init()); }
       
        }
    

        public void Commit()
        {
            Dbcontext.SaveChanges();
        }
    }
}
