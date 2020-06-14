using Domain.Entities;
using FluentValidation.Results;
using Infra.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Infra.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext() : base() { }

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
        public DbSet<Arquivo> Arquivos { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();

            modelBuilder.ApplyConfiguration(new AdministradorConfiguration());
            modelBuilder.ApplyConfiguration(new ArquivoConfiguration());
            modelBuilder.ApplyConfiguration(new DocenteConfiguration());
            modelBuilder.ApplyConfiguration(new ExameConfiguration());
            modelBuilder.ApplyConfiguration(new MedicoConfiguration());
            modelBuilder.ApplyConfiguration(new PacienteConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoExameConfiguration());
            modelBuilder.ApplyConfiguration(new RecepcionistaConfiguration());
            modelBuilder.ApplyConfiguration(new ResidenteConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            modelBuilder.BuildDefaultData();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=13057122;database=DbHospital");
        }
    }
}
