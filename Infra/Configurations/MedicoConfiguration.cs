using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Configurations
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Nome)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasIndex(m => m.Crm)
                .IsUnique();
            builder.Property(m => m.Crm)
                .HasMaxLength(10)
                .IsRequired();

            builder.HasOne(m => m.Usuario)
                .WithOne(u => u.Medico)
                .HasForeignKey<Medico>(m => m.IdUsuario);
        }
    }
}
