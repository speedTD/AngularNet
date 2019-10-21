using ShopGame.Data.intefacestruct;
using ShopGame.Data.Repositories;
using ShopGame.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGame.Service
{
    public interface IPostCateGoryService
    {
        void Add(PostCateGory entity);

        void Update(PostCateGory entity);

        void Delete(PostCateGory entity);

        PostCateGory GetSingleByid(int id);

        IEnumerable<PostCateGory> getAll();

        IEnumerable<PostCateGory> getllPaging(int page, int Pagesize, out int totalrow);
      
        IEnumerable<PostCateGory> getllPagingByTag(String tag, int page, int Pagesize, out int totalrow);
        void SaveChange();
        void Delete(int entity);
    }
    public class PostCateGoryService : IPostCateGoryService
    {
        IPostCategoryRepository _postCategorrepository;
        IUnitOfWork _unitofwork;
        public PostCateGoryService(IPostCategoryRepository postCategorrepository, IUnitOfWork unitofwork)
        {
            _postCategorrepository = postCategorrepository;
            _unitofwork = unitofwork;
        }
        public void Add(PostCateGory entity)
        {
            _postCategorrepository.Add(entity);
            _unitofwork.Commit();

        }

        public void Delete(int id)
        {
            _postCategorrepository.Delete(id);
        }


        public void Delete(PostCateGory entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostCateGory> getAll()
        {
            return _postCategorrepository.getAll();
        }

        public IEnumerable<PostCateGory> getllPaging(int page, int Pagesize, out int totalrow)
        {
            return _postCategorrepository.GetMultiPaging(x => x.status, out totalrow, page, Pagesize);
        }

    

        public IEnumerable<PostCateGory> getllPagingByTag(string tag, int page, int Pagesize, out int totalrow)
        {
            return _postCategorrepository.GetMultiPaging(x => x.status, out totalrow, page, Pagesize);
        }

        public PostCateGory GetSingleByid(int id)
        {
            return _postCategorrepository.GetSingleByid(id);
        }

        public void SaveChange()
        {
            _unitofwork.Commit();
        }

        public void Update(PostCateGory entity)
        {
            _postCategorrepository.Update(entity);
        }
    }
}
