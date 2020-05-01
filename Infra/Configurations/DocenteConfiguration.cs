using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Configurations
{
    public class DocenteConfiguration : EntityTypeConfiguration<Docente>
    {
        public DocenteConfiguration()
        {
            ToTable("Docente");

            HasKey(d => d.Id);

            Property(d => d.TitUniversitaria)
                .HasMaxLength(10)
                .IsRequired();

            HasRequired(d => d.Medico)
                .WithOptional(m => m.Docente)
                .Map(config => config.MapKey("Medico_Id"));
        }
    }
}
