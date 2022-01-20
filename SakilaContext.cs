using Microsoft.EntityFrameworkCore;
using SakilaEFCore.ContextConfiguration;

namespace SakilaEFCore
{

    public class SakilaContext : DbContext
    {

        public DbSet<City> Cities { set; get; }
        public DbSet<Country> Countries {set; get;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             
            optionsBuilder.UseMySql(
                @"Server=127.0.0.1;Database=sakila;uid=root;pwd=quLRYP22" , ServerVersion.Parse("8.0.27")
                    , (a)=>{});  
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<City>(new CityConfiguration());
            modelBuilder.ApplyConfiguration<Country>(new CountryConfiguration());
           
        }

    }

}
