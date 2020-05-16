using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context
{
    public static class DefaultData
    {
        public static void BuildDefaultData(this ModelBuilder modelBuilder)
        {
            Usuario usuario = new Usuario("admin@hotmail.com", "Admin2020");
            Administrador admin = new Administrador("Administrador", usuario.Id);

            modelBuilder.Entity<Usuario>().HasData(usuario);
            modelBuilder.Entity<Administrador>().HasData(admin);
        }
    }
}
