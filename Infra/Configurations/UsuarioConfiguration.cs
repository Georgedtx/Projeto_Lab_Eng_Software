using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Configurations
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            ToTable("Usuario");

            HasKey(u => u.Id);

            Property(u => u.Email)
                .IsRequired();

            Property(u => u.Senha)
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
