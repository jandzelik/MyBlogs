using System.Collections.Generic;
using System.Threading.Tasks;
using MyBlogs.Data.Models;

namespace MyBlogs.Service
{
    public interface IBlogService
    {
        IEnumerable<BlogMaster> GetAllBlogs();
        BlogMaster GetBlogById(int id);
        Task<BlogMaster> GetBlogByIdAsync(int id);
    }
}