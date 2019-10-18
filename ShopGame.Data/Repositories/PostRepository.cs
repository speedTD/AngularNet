using ShopGame.Data.intefacestruct;
using ShopGame.Data.Repositories;
using ShopGame.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGame.Data.Repositories
{
    interface IPostRepository
    {
        //cac ham viet them ngoai RepositoryBase 
        IEnumerable<Post> GetAllByTag(String tag, int pageIndex, int pagesize,out int totalrow);
       }
    }
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory db) : base(db)
        {
        }

    public IEnumerable<Post> GetAllByTag(string tag, int pageIndex,int pagesize, out int totalrow)
    {
        var query = from p in DbContext.Posts
                    join pt in DbContext.PostTags
                    on p.id equals pt.potsid
                    where pt.tagid == tag && p.status
                    orderby p.createdat descending
                    select p;

        totalrow = query.Count();
        query=query.Skip((pageIndex-1)*pagesize).Take(pagesize);
        return query;
    }
}


