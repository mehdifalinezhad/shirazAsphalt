using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OtherWise.Models
{
    public class AplicationDbContext : IdentityDbContext<User, Role, Guid>
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        


        }
          public DbSet<Product> productdb { set; get; } 
          public DbSet<AboutUs> aboutUsdb { set; get; }
          public DbSet<News> newsdb { set; get; }
          


    }
}
