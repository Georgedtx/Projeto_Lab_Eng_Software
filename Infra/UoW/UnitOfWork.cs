﻿using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Infra.Context;
using Infra.Repositories;
using System;

namespace Infra.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjectContext _context;

        public UnitOfWork()
        {
            _context = new ProjectContext();
        }

        private RepositoryAdministrador repositoryAdministrador;
        private RepositoryArquivo repositoryArquivo;
        private RepositoryDocente repositoryDocente;
        private RepositoryExame repositoryExame;
        private RepositoryMedico repositoryMedico;
        private RepositoryPaciente repositoryPaciente;
        private RepositoryPedidoExame repositoryPedidoExame;
        private RepositoryRecepcionista repositoryRecepcionista;
        private RepositoryRegistroExame repositoryRegistroExame;
        private RepositoryResidente repositoryResidente;
        private RepositoryUsuario repositoryUsuario;

        public IRepositoryAdministrador RepositoryAdministrador
        {
            get
            {
                if (repositoryAdministrador == null)
                {
                    repositoryAdministrador = new RepositoryAdministrador(_context);
                }
                return repositoryAdministrador;
            }
        }

        public IRepositoryArquivo RepositoryArquivo
        {
            get
            {
                if (repositoryArquivo == null)
                {
                    repositoryArquivo = new RepositoryArquivo(_context);
                }
                return repositoryArquivo;
            }
        }

        public IRepositoryDocente RepositoryDocente
        {
            get
            {
                if (repositoryDocente == null)
                {
                    repositoryDocente = new RepositoryDocente(_context);
                }
                return repositoryDocente;
            }
        }

        public IRepositoryExame RepositoryExame
        {
            get
            {
                if (repositoryExame == null)
                {
                    repositoryExame = new RepositoryExame(_context);
                }
                return repositoryExame;
            }
        }

        public IRepositoryMedico RepositoryMedico
        {
            get
            {
                if (repositoryMedico == null)
                {
                    repositoryMedico = new RepositoryMedico(_context);
                }
                return repositoryMedico;
            }
        }

        public IRepositoryPaciente RepositoryPaciente
        {
            get
            {
                if (repositoryPaciente == null)
                {
                    repositoryPaciente = new RepositoryPaciente(_context);
                }
                return repositoryPaciente;
            }
        }

        public IRepositoryPedidoExame RepositoryPedidoExame
        {
            get
            {
                if (repositoryPedidoExame == null)
                {
                    repositoryPedidoExame = new RepositoryPedidoExame(_context);
                }
                return repositoryPedidoExame;
            }
        }

        public IRepositoryRecepcionista RepositoryRecepcionista
        {
            get
            {
                if (repositoryRecepcionista == null)
                {
                    repositoryRecepcionista = new RepositoryRecepcionista(_context);
                }
                return repositoryRecepcionista;
            }
        }

        public IRepositoryRegistroExame RepositoryRegistroExame
        {
            get
            {
                if (repositoryRegistroExame == null)
                {
                    repositoryRegistroExame = new RepositoryRegistroExame(_context);
                }
                return repositoryRegistroExame;
            }
        }

        public IRepositoryResidente RepositoryResidente
        {
            get
            {
                if (repositoryResidente == null)
                {
                    repositoryResidente = new RepositoryResidente(_context);
                }
                return repositoryResidente;
            }
        }

        public IRepositoryUsuario RepositoryUsuario
        {
            get
            {
                if (repositoryUsuario == null)
                {
                    repositoryUsuario = new RepositoryUsuario(_context);
                }
                return repositoryUsuario;
            }
        }

        public bool Commit()
        {
            return _context.SaveChanges() == 1;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
