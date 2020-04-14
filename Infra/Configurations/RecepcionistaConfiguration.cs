using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Configurations
{
    public class RecepcionistaConfiguration : EntityTypeConfiguration<Recepcionista>
    {
        public RecepcionistaConfiguration()
        {
            ToTable("Recepcionista");

            HasKey(r => r.Id);

            Property(r => r.Nome)
                .HasMaxLength(30)
                .IsRequired();

            Property(r => r.Nascimento)
                .HasColumnType("date")
                .IsRequired();

            HasRequired(r => r.Usuario)
                .WithOptional(u => u.Recepcionista);
        }
    }
}
