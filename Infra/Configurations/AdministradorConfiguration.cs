using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Configurations
{
    public class AdministradorConfiguration : EntityTypeConfiguration<Administrador>
    {
        public AdministradorConfiguration()
        {
            ToTable("Administrador");

            HasKey(a => a.Id);
            
            Property(a => a.Nome)
                .HasMaxLength(30)
                .IsRequired();

            HasRequired(a => a.Usuario)
                .WithOptional(u => u.Administrador)
                .Map(config => config.MapKey("Usuario_Id"));
        }
    }
}
