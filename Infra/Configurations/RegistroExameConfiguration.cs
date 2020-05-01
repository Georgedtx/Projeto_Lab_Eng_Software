using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Configurations
{
    public class RegistroExameConfiguration : EntityTypeConfiguration<RegistroExame>
    {
        public RegistroExameConfiguration()
        {
            ToTable("RegistroExame");

            HasKey(re => re.Id);

            Property(re => re.Data)
                .HasColumnType("date")
                .IsRequired();

            Property(re => re.Status)
                .IsRequired();

            HasRequired(re => re.PedidoExame)
                .WithRequiredPrincipal(pe => pe.RegistroExame)
                .Map(config => config.MapKey("PedidoExame_Id"));

            HasRequired(re => re.Residente)
                .WithMany(r => r.RegistrosExames)
                .HasForeignKey(re => re.IdResidente);

            HasRequired(re => re.Docente)
                .WithMany(d => d.RegistrosExames)
                .HasForeignKey(re => re.IdDocente);
        }
    }
}
