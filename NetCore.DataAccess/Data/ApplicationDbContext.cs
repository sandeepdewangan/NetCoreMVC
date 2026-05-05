using Microsoft.EntityFrameworkCore;
using NetCore.Models;

namespace NetCore.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1, Name="Horror", DisplayOrder=2},
                new Category { Id=2, Name="Sci-Fi", DisplayOrder=1},
                new Category { Id=3, Name="Comedy", DisplayOrder=3}
                );
        }
    }
}
