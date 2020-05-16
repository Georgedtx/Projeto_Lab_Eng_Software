using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Configurations
{
    public class RecepcionistaConfiguration : IEntityTypeConfiguration<Recepcionista>
    {
        public void Configure(EntityTypeBuilder<Recepcionista> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Nome)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(r => r.Nascimento)
                .IsRequired();

            builder.HasOne(r => r.Usuario)
                .WithOne(u => u.Recepcionista)
                .HasForeignKey<Recepcionista>(r => r.IdUsuario);
        }
    }
}
