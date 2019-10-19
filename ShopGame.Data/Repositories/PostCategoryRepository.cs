using System;
using System.Linq;
using ShopGame.Data.intefacestruct;
using ShopGame.Data.Repositories;
using ShopGame.Model.Models;
namespace ShopGame.Data.Repositories
{
    public interface IPostCategoryRepository: intefacestruct.IRepository<PostCateGory>
    {

    }
   public class PostCategoryRepository :RepositoryBase<PostCateGory> ,IPostCategoryRepository
    {

        public PostCategoryRepository(IDbFactory db) : base(db)
        {

        }
    }
}
