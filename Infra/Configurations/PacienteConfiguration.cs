using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Configurations
{
    public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Cpf)
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(p => p.Nome)
                .HasMaxLength(35)
                .IsRequired();

            builder.Property(p => p.Sexo)
                .HasMaxLength(9)
                .IsRequired();

            builder.Property(p => p.Cor)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(p => p.Nascimento)
                .IsRequired();
        }
    }
}
