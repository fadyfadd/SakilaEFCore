using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SakilaEFCore;


namespace SakilaEFCore.ContextConfiguration
{

    class CountryConfiguration : IEntityTypeConfiguration<Country>
    {

        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("country");
            builder.HasKey(p => p.Id);
            builder.Property(p=>p.Id).HasColumnName("country_id");
            builder.Property(p => p.Name).HasColumnName("country");
            builder.Property(p => p.LastUpdate).HasColumnName("last_update");    

          
        }

    }

}