using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void BlogAdd(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void BlogRemove(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public List<Blog> GetAllBlogs()
        {
            return _blogDal.GetListAll();
        }

        public Blog GetBlogById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogsById(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }
    }
}
