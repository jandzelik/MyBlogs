using MyBlogs.Data.Models;
using MyBlogs.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBlogs.Service
{
    public class BlogService : IBlogService
    {
        private IBlogMasterRepository repository;

        public BlogService(BlogDb_DevContext context)
        {
            repository = new BlogMasterRepository(context);
        }

        public IEnumerable<BlogMaster> GetAllBlogs()
        {
            return repository.GetBlogs();
        }

        public BlogMaster GetBlogById(int id)
        {
            return repository.GetBlogById(id);
        }

        public async Task<BlogMaster> GetBlogByIdAsync(int id)
        {
            return await repository.GetBlogsByIdAsync(id);
        }
    }
}
