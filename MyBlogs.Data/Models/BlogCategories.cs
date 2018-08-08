using System;
using System.Collections.Generic;

namespace MyBlogs.Data.Models
{
    public partial class BlogCategories
    {
        public BlogCategories()
        {
            BlogMaster = new HashSet<BlogMaster>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<BlogMaster> BlogMaster { get; set; }
    }
}
