using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Configurations
{
    public class ExameConfiguration : IEntityTypeConfiguration<Exame>
    {
        public void Configure(EntityTypeBuilder<Exame> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(e => e.Descricao)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
