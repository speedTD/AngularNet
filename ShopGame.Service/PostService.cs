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

    public interface IpostService
    {
        void Add(Post entity);

        void Update(Post entity);

        void Delete(Post entity);

        Post GetSingleByid(int id);

        IEnumerable<Post> getAll();

        IEnumerable<Post> getllPaging(int page,int Pagesize,out int totalrow);
        IEnumerable<Post> getllPagingByPostCategory(int categoryid, int page, int Pagesize, out int totalrow);
        IEnumerable<Post> getllPagingByTag(String tag,int page, int Pagesize, out int totalrow);
        void SaveChange();


    }
    public class PostService : IpostService
    {

        PostRepository _postrepository;
        UnitOfWork _unitofwork;
        public PostService(PostRepository postRepository, UnitOfWork unitofwork)
        {
            _postrepository = postRepository;
            _unitofwork = unitofwork;
            
        }
        public void Add(Post entity)
        {
            _postrepository.Add(entity);
        }

        public void Delete(Post entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            _postrepository.Delete(id);
        }

        public IEnumerable<Post> getAll()
        {
            return _postrepository.getAll(new string[] { "PostCateGory" });
        }

        public IEnumerable<Post> getllPaging(int page, int Pagesize, out int totalrow)
        {
            return _postrepository.GetMultiPaging(x=>x.status, out totalrow, page, Pagesize);
            
        }
        public IEnumerable<Post> getllPagingByPostCategory(int categoryid, int page, int Pagesize, out int totalrow)
        {
            return _postrepository.GetMultiPaging(x => x.status&&x.categoryid==categoryid, out totalrow,page, Pagesize,new string[] { "PostCateGory" });

        }
        // repo nay tu viet them
        public IEnumerable<Post> getllPagingByTag(String tag,int page, int Pagesize, out int totalrow)
        {
            return _postrepository.GetAllByTag(tag, page, Pagesize, out totalrow);
        }

        public Post GetSingleByid(int id)
        {
            return _postrepository.GetSingleByid(id);
        }

        public void SaveChange()
        {
            _unitofwork.Commit();
        }

        public void Update(Post entity)
        {
            _postrepository.Update(entity);
        }
    }
}
