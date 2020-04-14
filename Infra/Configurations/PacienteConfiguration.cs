using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Configurations
{
    public class PacienteConfiguration : EntityTypeConfiguration<Paciente>
    {
        public PacienteConfiguration()
        {
            ToTable("Paciente");

            HasKey(p => p.Id);

            Property(p => p.Cpf)
                .HasMaxLength(11)
                .IsRequired();

            Property(p => p.Nome)
                .HasMaxLength(35)
                .IsRequired();

            Property(p => p.Sexo)
                .HasMaxLength(1)
                .IsRequired();

            Property(p => p.Cor)
                .HasMaxLength(10)
                .IsRequired();

            Property(p => p.Nascimento)
                .HasColumnType("date")
                .IsRequired();
        }
    }
}
