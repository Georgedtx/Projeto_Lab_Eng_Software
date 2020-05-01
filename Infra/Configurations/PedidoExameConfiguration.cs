using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Configurations
{
    public class PedidoExameConfiguration : EntityTypeConfiguration<PedidoExame>
    {
        public PedidoExameConfiguration()
        {
            ToTable("PedidoExame");

            HasKey(pe => pe.Id);

            Property(pe => pe.DataEmissao)
                    .HasColumnType("date")
                    .IsRequired();

            Property(pe => pe.DataRealizacao)
                .HasColumnType("date")
                .IsRequired();

            Property(pe => pe.Hipotese)
                .IsRequired();

            HasRequired(pe => pe.Paciente)
                .WithMany(p => p.PedidosExames)
                .HasForeignKey(pe => pe.IdPaciente);

            HasRequired(pe => pe.Exame)
                .WithMany(e => e.PedidosExames)
                .HasForeignKey(pe => pe.IdExame);

            HasRequired(pe => pe.Medico)
                .WithMany(m => m.PedidosExames)
                .HasForeignKey(pe => pe.IdMedico);
        }
    }
}
