using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
        }

        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<PedidoExame> PedidosExames { get; set; }
        public DbSet<Recepcionista> Recepcionistas { get; set; }
        public DbSet<RegistroExame> RegistrosExames { get; set; }
        public DbSet<Residente> Residentes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
