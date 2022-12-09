using ETicaret.DataAccessLayer.Mappings;
using ETicaret.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Concretes.Contexts
{
    /// <summary>
    /// Ef  Db Process....
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        //DbSet<Category> Categories { get; set; }
        //DbSet<Brand> Brands { get; set; }
        //DbSet<Adress> Adresses { get; set; }


        // Enttiy ile veritabanı arasındaki ilişki sağlıyor
      //  DbSet<Customer> Customers { get; set; }
      //  DbSet<Category> Categories { get; set; }
      //  DbSet<Brand> Brands { get; set; }

        DbSet<SubCategory> SubCategories { get; set; }

      // DbSet<SubCategoryBrand> SubCategoryBrands { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public ApplicationDbContext()
        {

        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sql 
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-3DHQ8B6;database=DbETradeMvc22-23-Guz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new BrandMap());
            modelBuilder.ApplyConfiguration(new SubCategoryMap());
            modelBuilder.ApplyConfiguration(new SubCategoryBrandMap());


        }
    }
}
