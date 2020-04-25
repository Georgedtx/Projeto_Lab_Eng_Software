using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;

namespace Domain.Interfaces.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryAdministrador RepositoryAdministrador { get;}
        IRepository<Arquivo> RepositoryArquivo { get; }
        IRepository<Docente> RepositoryDocente { get; }
        IRepository<Exame> RepositoryExame { get; }
        IRepositoryMedico RepositoryMedico { get; }
        IRepository<Paciente> RepositoryPaciente { get; }
        IRepository<PedidoExame> RepositoryPedidoExame { get; }
        IRepositoryRecepcionista RepositoryRecepcionista { get; }
        IRepository<RegistroExame> RepositoryRegistroExame { get; }
        IRepository<Residente> RepositoryResidente { get; }
        IRepositoryUsuario RepositoryUsuario { get; }

        bool Commit();
    }
}
