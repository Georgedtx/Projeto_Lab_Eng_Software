using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Configurations
{
    public class ResidenteConfiguration : EntityTypeConfiguration<Residente>
    {
        public ResidenteConfiguration()
        {
            ToTable("Residente");

            HasKey(r => r.Id);

            Property(r => r.AnoResidencia)
                .IsRequired();

            HasRequired(r => r.Medico)
                .WithOptional(m => m.Residente)
                .Map(config => config.MapKey("Medico_Id"));

        }
    }
}
