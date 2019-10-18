using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGame.Data.intefacestruct
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private DbModelContext dbContext;

        public UnitOfWork(IDbFactory db)
        {
            this.dbFactory = db;
        }
        public DbModelContext dbcontext
        {
            get { return dbContext ?? (dbContext =dbFactory.Init()); }
       
        }
    

        public void Commit()
        {
            dbContext.SaveChanges();
        }
    }
}
