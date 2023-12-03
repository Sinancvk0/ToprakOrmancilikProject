using Bussiness.Services;
using Data.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Content
{
    public class BlogManager : IGenericService<Blog>, IBlogService
    {
        private readonly IBlogDal _Blog;

        public BlogManager(IBlogDal blog)
        {
            _Blog = blog;
        }

        public void TAdd(Blog t)
        {
         _Blog.Insert(t);   
        }

        public void TDelete(Blog t)
        {
           _Blog.Delete(t); 
        }

        public Blog TGetById(int id)
        {
           return _Blog.GetById(id);
        }

        public List<Blog> TGetList()
        {
            return _Blog.GetList();
        }

        public void TUpdate(Blog t)
        {
            _Blog.Update(t);    
        }
    }
}
