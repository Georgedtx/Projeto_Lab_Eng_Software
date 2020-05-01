using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Configurations
{
    public class MedicoConfiguration : EntityTypeConfiguration<Medico>
    {
        public MedicoConfiguration()
        {
            ToTable("Medico");

            HasKey(m => m.Id);

            Property(m => m.Nome)
                .HasMaxLength(30)
                .IsRequired();

            HasIndex(m => m.Crm)
                .IsUnique();
            Property(m => m.Crm)
                .HasMaxLength(10)
                .IsRequired();

            HasRequired(m => m.Usuario)
                .WithOptional(u => u.Medico)
                .Map(config => config.MapKey("Usuario_Id"));
        }
    }
}
