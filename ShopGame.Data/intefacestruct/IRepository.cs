using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopGame.Data.intefacestruct
{
   public interface IRepository<T> where T:class
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(int id);

        void DeleteMulti(Expression <Func<T,bool>>where);

        T GetSingleByid(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IQueryable<T> getAll(string[] includes = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        int CheckContains(Expression<Func<T, bool>> predicate);

        void SaveChange();

    }
}
