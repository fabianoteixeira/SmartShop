using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartShop.Domain.Entities;

namespace SmartShop.Infra.Data.Mapping
{
    public class MappingCategoria : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categoria");

            builder.Property(x => x.Id)
              .HasColumnName("id_categoria");
                ;

            builder.Property(x => x.Descricao)
                   .HasColumnName("descricao");
        }
    }
}
