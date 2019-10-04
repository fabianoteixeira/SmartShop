using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartShop.Domain.Entities;

namespace SmartShop.Infra.Data.Mapping
{
    public class MappingCategory : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.Property(x => x.Id)
              .HasColumnName("id");
                ;

            builder.Property(x => x.Description)
                   .HasColumnName("descritpion");
        }
    }
}
