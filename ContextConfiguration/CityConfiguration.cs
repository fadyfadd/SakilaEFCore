using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using efCore;


namespace efCore.ContextConfiguration
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

        }

    }

}