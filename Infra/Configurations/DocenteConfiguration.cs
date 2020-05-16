using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Configurations
{
    public class DocenteConfiguration : IEntityTypeConfiguration<Docente>
    {
        public void Configure(EntityTypeBuilder<Docente> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.TitUniversitaria)
                .HasMaxLength(10)
                .IsRequired();

            builder.HasOne(d => d.Medico)
                .WithOne(m => m.Docente)
                .HasForeignKey<Docente>(d => d.IdMedico);
        }
    }
}
