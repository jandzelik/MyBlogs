using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlogs.Data.Models;
using MyBlogs.Service;

namespace MyBlogs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogMastersController : ControllerBase
    {
        private readonly BlogService service;

        public BlogMastersController(BlogDb_DevContext context)
        {
            service = new BlogService(context);
        }

        // GET: api/BlogMasters
        [HttpGet]
        public IEnumerable<BlogMaster> GetBlogMaster()
        {
            return service.GetAllBlogs();
        }

        // GET: api/BlogMasters/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogMaster([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var blogMaster = await service.GetBlogByIdAsync(id);

            if (blogMaster == null)
            {
                return NotFound();
            }

            return Ok(blogMaster);
        }
    }
}