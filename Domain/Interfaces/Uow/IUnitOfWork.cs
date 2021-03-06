﻿using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;

namespace Domain.Interfaces.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryAdministrador RepositoryAdministrador { get;}
        IRepositoryArquivo RepositoryArquivo { get; }
        IRepositoryDocente RepositoryDocente { get; }
        IRepositoryExame RepositoryExame { get; }
        IRepositoryMedico RepositoryMedico { get; }
        IRepositoryPaciente RepositoryPaciente { get; }
        IRepositoryPedidoExame RepositoryPedidoExame { get; }
        IRepositoryRecepcionista RepositoryRecepcionista { get; }
        IRepositoryRegistroExame RepositoryRegistroExame { get; }
        IRepositoryResidente RepositoryResidente { get; }
        IRepositoryUsuario RepositoryUsuario { get; }

        bool Commit();
    }
}
