using Domain.Entities;
using DomainValidation.Validation;
using Infra.Configurations;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace Infra.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext() : base("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\luisz\\OneDrive\\Documentos\\Faculdade\\LabEngSoftware\\DbHospital.mdf;Integrated Security=True;Connect Timeout=30")
        {
            var instance = SqlProviderServices.Instance;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<ValidationError>();

            modelBuilder.Configurations.Add(new AdministradorConfiguration());
            modelBuilder.Configurations.Add(new ArquivoConfiguration());
            modelBuilder.Configurations.Add(new DocenteConfiguration());
            modelBuilder.Configurations.Add(new ExameConfiguration());
            modelBuilder.Configurations.Add(new MedicoConfiguration());
            modelBuilder.Configurations.Add(new PacienteConfiguration());
            modelBuilder.Configurations.Add(new PedidoExameConfiguration());
            modelBuilder.Configurations.Add(new RecepcionistaConfiguration());
            modelBuilder.Configurations.Add(new ResidenteConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
