using System;
using System.Collections.Generic;

namespace MyBlogs.Data.Models
{
    public partial class BlogMaster
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public BlogCategories Category { get; set; }
    }
}
