using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartShop.Domain.Entities;

namespace SmartShop.Infra.Data.Mapping
{
    public class MappingCategory : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("categoria");

            builder.Property(x => x.Id)
              .HasColumnName("id_categoria");
                ;

            builder.Property(x => x.Description)
                   .HasColumnName("descricao");
        }
    }
}
