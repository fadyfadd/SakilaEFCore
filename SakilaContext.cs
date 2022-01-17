using Microsoft.EntityFrameworkCore;
using efCore.ContextConfiguration;

namespace EfCore
{

    public class SakilaContext : DbContext
    {

        public DbSet<City> Cities { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             
            optionsBuilder.UseMySql(
                @"Server=127.0.0.1;Database=sakila;uid=root;pwd=quLRYP22" , ServerVersion.Parse("8.0.27")
                    , (a)=>{});  
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<City>(new CityConfiguration());
           
        }

    }

}
