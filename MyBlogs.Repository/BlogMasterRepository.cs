using MyBlogs.Data.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyBlogs.Repository
{
    public class BlogMasterRepository :
        GenericBase, IGenericBase<BlogMaster>, IBlogMasterRepository
    {
        public BlogMasterRepository(BlogDb_DevContext context) : base(context)
        {

        }

        public IEnumerable<BlogMaster> GetBlogs()
        {
            return context.BlogMaster.ToList(); 
        }

        public BlogMaster GetBlogById(int id)
        {
            return context.BlogMaster.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<BlogMaster> GetBlogsByIdAsync(int id)
        {
            return await context.BlogMaster.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
