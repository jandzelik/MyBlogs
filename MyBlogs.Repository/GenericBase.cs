using MyBlogs.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlogs.Repository
{
    public class GenericBase
    {
        protected BlogDb_DevContext context;

        public GenericBase(BlogDb_DevContext context)
        {
            this.context = context;
        }
    }
}
