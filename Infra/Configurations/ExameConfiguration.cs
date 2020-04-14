using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Configurations
{
    public class ExameConfiguration : EntityTypeConfiguration<Exame>
    {
        public ExameConfiguration()
        {
            ToTable("Exame");

            HasKey(e => e.Id);

            Property(e => e.Nome)
                .HasMaxLength(25)
                .IsRequired();

            Property(e => e.Descricao)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
