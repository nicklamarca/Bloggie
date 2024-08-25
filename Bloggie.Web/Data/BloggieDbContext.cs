using Bloggie.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Data
{
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<BlogPost> BlogPosts { get; set; }
        DbSet<Tag> Tags { get; set; }
    }
}
