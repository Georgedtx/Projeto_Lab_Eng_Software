using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Configurations
{
    public class PedidoExameConfiguration : IEntityTypeConfiguration<PedidoExame>
    {
        public void Configure(EntityTypeBuilder<PedidoExame> builder)
        {
            builder.HasKey(pe => pe.Id);

            builder.Property(pe => pe.DataEmissao)
                .IsRequired();

            builder.Property(pe => pe.DataRealizacao)
                .IsRequired();

            builder.Property(pe => pe.Hipotese)
                .IsRequired();

            builder.HasOne(pe => pe.Paciente)
                .WithMany(p => p.PedidosExames)
                .HasForeignKey(pe => pe.IdPaciente);

            builder.HasOne(pe => pe.Exame)
            .WithMany(e => e.PedidosExames)
            .HasForeignKey(pe => pe.IdExame);

            builder.HasOne(pe => pe.Medico)
            .WithMany(m => m.PedidosExames)
            .HasForeignKey(pe => pe.IdMedico);
        }
    }
}
