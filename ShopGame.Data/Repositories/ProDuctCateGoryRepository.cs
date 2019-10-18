using ShopGame.Data.intefacestruct;
using ShopGame.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ShopGame.Data.Repositories
{

    public interface IProductCateGoryRepository
    {
        IEnumerable<ProductCateGory> GetByAlias(String alias);
    }
    public class ProDuctCateGoryRepository :RepositoryBase<ProductCateGory>,IProductCateGoryRepository
    {
        public ProDuctCateGoryRepository(IDbFactory db) : base(db) { }

        public IEnumerable<ProductCateGory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCateGories.Where(x => x.alias == alias);
        }
    }
}
