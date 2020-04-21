using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;

namespace Domain.Interfaces.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Administrador> RepositoryAdministrador { get;}
        IRepository<Arquivo> RepositoryArquivo { get; }
        IRepository<Docente> RepositoryDocente { get; }
        IRepository<Exame> RepositoryExame { get; }
        IRepositoryMedico RepositoryMedico { get; }
        IRepository<Paciente> RepositoryPaciente { get; }
        IRepository<PedidoExame> RepositoryPedidoExame { get; }
        IRepository<Recepcionista> RepositoryRecepcionista { get; }
        IRepository<RegistroExame> RepositoryRegistroExame { get; }
        IRepository<Residente> RepositoryResidente { get; }
        IRepositoryUsuario RepositoryUsuario { get; }

        bool Commit();
    }
}
