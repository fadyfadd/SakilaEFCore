using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EfCore;


namespace EfCore.ContextConfiguration
{
    class CityConfiguration : IEntityTypeConfiguration<City>
    {

        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("city");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("city_id");
            builder.Property(p => p.Name).HasColumnName("city");
            builder.Property(p => p.CountryId).HasColumnName("country_id");
            builder.HasOne(c=>c.Country).WithMany(c=>c.Cities).HasForeignKey(c=> new { CountryId =c.CountryId} );
        

        }

    }

}