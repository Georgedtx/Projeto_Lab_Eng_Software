using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Configurations
{
    public class AdministradorConfiguration : IEntityTypeConfiguration<Administrador>
    {
        public void Configure(EntityTypeBuilder<Administrador> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasOne(a => a.Usuario)
                .WithOne(u => u.Administrador)
                .HasForeignKey<Administrador>(a => a.IdUsuario);
        }
    }
}
