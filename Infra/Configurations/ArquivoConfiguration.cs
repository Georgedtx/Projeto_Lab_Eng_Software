using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Configurations
{
    public class ArquivoConfiguration : EntityTypeConfiguration<Arquivo>
    {
        public ArquivoConfiguration()
        {
            ToTable("Arquivo");

            HasKey(a => a.Id);

            Property(a => a.Nome)
                .IsRequired();

            Property(a => a.Caminho)
                .IsRequired();

            HasRequired(a => a.RegistroExame)
                .WithMany(r => r.Arquivos)
                .HasForeignKey(a => a.IdRegistroExame);
        }
    }
}
