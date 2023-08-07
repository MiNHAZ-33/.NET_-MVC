using Ecommerce.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "History", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Novel", DisplayOrder = 1 },
                new Category { Id = 3, Name = "Story", DisplayOrder = 2 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "One Piece",
                    Author = "Eichirio Oda",
                    Description = "Can be summed up in one line. The boy with strawhat wanna become the king of the pirates",
                    ISBN = "XDE23234",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = " "
                },
                new Product
                {
                    Id = 2,
                    Title = "Deyal",
                    Author = "Humayun Ahmed",
                    Description = "An unseen look at the event that is unfolding in the year 1975 in Bangladeshi politics",
                    ISBN = "ZXDH24XC",
                    ListPrice = 200,
                    Price = 180,
                    Price50 = 170,
                    Price100 = 150,
                    CategoryId = 3,
                    ImageUrl = " "
                }
                );
        }

    }
}
