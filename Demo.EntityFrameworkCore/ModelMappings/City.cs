using Demo.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.EntityFrameworkCore.Configurations
{
    public class CityModelMapping : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(c => c.Title).HasMaxLength(255).IsRequired();

            //builder.HasOne(a => a.Province).WithMany(a => a.Cities)
            //    .HasForeignKey(a => a.ProvinceId).IsRequired();

            builder.HasQueryFilter(a => !a.IsDeleted);
        }
    }
}