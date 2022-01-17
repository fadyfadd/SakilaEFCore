using Microsoft.EntityFrameworkCore;


namespace EfCore
{

    public class SakilaContext : DbContext
    {

        public DbSet<City> Cities { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             
            optionsBuilder.UseMySql(
                @"Server=127.0.0.1;Database=sakila;uid=root;pwd=quLRYP22" , ServerVersion.Parse("8.0.27")
                    , async (a)=>{});  
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().ToTable("city");
            modelBuilder.Entity<City>().HasKey(p=>p.Id);
            modelBuilder.Entity<City>().Property(p => p.Id).HasColumnName("city_id");
            modelBuilder.Entity<City>().Property(p => p.Name).HasColumnName("city");
            modelBuilder.Entity<City>().Property(p => p.CountryId).HasColumnName("country_id");
        }

    }

}
