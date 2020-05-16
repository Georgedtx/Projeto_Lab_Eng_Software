using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Configurations
{
    public class ResidenteConfiguration : IEntityTypeConfiguration<Residente>
    {
        public void Configure(EntityTypeBuilder<Residente> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.AnoResidencia)
                .IsRequired();

            builder.HasOne(r => r.Medico)
                .WithOne(m => m.Residente)
                .HasForeignKey<Residente>(r => r.IdMedico);
        }
    }
}
