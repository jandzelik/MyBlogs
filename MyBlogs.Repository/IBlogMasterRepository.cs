using System.Collections.Generic;
using System.Threading.Tasks;
using MyBlogs.Data.Models;

namespace MyBlogs.Repository
{
    public interface IBlogMasterRepository
    {
        BlogMaster GetBlogById(int id);
        IEnumerable<BlogMaster> GetBlogs();
        Task<BlogMaster> GetBlogsByIdAsync(int id);
    }
}