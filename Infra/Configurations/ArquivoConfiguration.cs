using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Configurations
{
    public class ArquivoConfiguration : IEntityTypeConfiguration<Arquivo>
    {
        public void Configure(EntityTypeBuilder<Arquivo> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome)
                .IsRequired();

            builder.Property(a => a.Caminho)
                .IsRequired();

            builder.HasOne(a => a.RegistroExame)
                .WithMany(re => re.Arquivos)
                .HasForeignKey(a => a.IdRegistroExame);
        }
    }
}
