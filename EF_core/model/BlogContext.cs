using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace EF_core.model
{
    public class BlogContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=Blogging;Trusted_Connection=True;");
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Auther> Authers { get; set; }
        public virtual DbSet<PostImg> PostImgs { get; set; }
       



    }
}
