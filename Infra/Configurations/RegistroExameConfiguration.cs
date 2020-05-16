using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Configurations
{
    public class RegistroExameConfiguration : IEntityTypeConfiguration<RegistroExame>
    {
        public void Configure(EntityTypeBuilder<RegistroExame> builder)
        {
            builder.HasKey(re => re.Id);

            builder.Property(re => re.Data)
                .IsRequired();

            builder.Property(re => re.Status)
                .IsRequired();

            builder.HasOne(re => re.PedidoExame)
                .WithOne(p => p.RegistroExame)
                .HasForeignKey<RegistroExame>(re => re.IdPedidoExame);

            builder.HasOne(re => re.Residente)
                .WithMany(r => r.RegistrosExames)
                .HasForeignKey(re => re.IdResidente);

            builder.HasOne(re => re.Docente)
                .WithMany(d => d.RegistrosExames)
                .HasForeignKey(re => re.IdDocente);
        }
    }
}
