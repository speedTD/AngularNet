using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopGame.Data.intefacestruct
{
    public abstract class RepositoryBase<T> :IRepository<T> where T :class
    {
        #region Properties
        private DbModelContext dataContext;
        readonly DbSet<T> dbSet;
       
        protected IDbFactory dbFactory
        {
            set;
            get;
        }
        protected DbModelContext DbContext
        {
            get { return dataContext ?? (dataContext = dbFactory.Init()); }
        }

        #endregion
        protected RepositoryBase (IDbFactory db)
        {
            dbFactory = db;
            dbSet = DbContext.Set<T>();
        }

        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }
        

        public virtual void DeleteMulti(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach(T obj in objects)
            {
                dbSet.Remove(obj);
            }
        }

        public virtual T GetSingleByid(int id)
        {
            return dbSet.Find(id);
        }

        public virtual T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            return getAll(includes).FirstOrDefault(expression);
        }

        public  IQueryable<T> getAll(string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                try
                {
                    var query = dataContext.Set<T>().Include(includes.First());
                    foreach (var i in includes.Skip(1))
                    {
                        query = query.Include(i);
                    }
                    return query.AsQueryable();
                }
                catch(Exception ex)
                {

                }
              
             
            }
            return dataContext.Set<T>().AsQueryable();
        }

       /* public virtual IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null)
        {

        }*/

        public virtual int Count(Expression<Func<T, bool>> where)
        {
            return dbSet.Count(where);
        }

        public bool CheckContains(Expression<Func<T, bool>> predicate)
        {
            return dataContext.Set<T>().Count<T>(predicate) > 0;
        }

        public IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null)
        {
            int skipcount = index * size;
            IQueryable<T> _resetSet=null;
            if (includes != null && includes.Count() > 0)
            {
                var query = dataContext.Set<T>().Include(includes.First());
                foreach(var include in includes.Skip(1)){
                    query = query.Include(include);
                    _resetSet = filter != null ? query.Where<T>(filter).AsQueryable() : query.AsQueryable();

                }
            }
            else
            {
                _resetSet = filter != null ? dataContext.Set<T>().Where<T>(filter).AsQueryable() :dataContext.Set<T>().AsQueryable();

            }
            _resetSet = skipcount == 0 ?_resetSet.Take(size) : _resetSet.Skip(skipcount).Take(size);
            total = _resetSet.Count();
            return _resetSet.AsQueryable(); 

        }

        int IRepository<T>.CheckContains(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            dbSet.Remove(GetSingleByid(id));
        }
      
  
    }
}


