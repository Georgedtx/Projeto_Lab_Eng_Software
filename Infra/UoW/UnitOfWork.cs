using Domain.Entities;
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

        private Repository<Administrador> repositoryAdministrador;
        private Repository<Arquivo> repositoryArquivo;
        private Repository<Docente> repositoryDocente;
        private Repository<Exame> repositoryExame;
        private RepositoryMedico repositoryMedico;
        private Repository<Paciente> repositoryPaciente;
        private Repository<PedidoExame> repositoryPedidoExame;
        private RepositoryRecepcionista repositoryRecepcionista;
        private Repository<RegistroExame> repositoryRegistroExame;
        private Repository<Residente> repositoryResidente;
        private RepositoryUsuario repositoryUsuario;

        public IRepository<Administrador> RepositoryAdministrador
        {
            get
            {
                if (repositoryAdministrador == null)
                {
                    repositoryAdministrador = new Repository<Administrador>(_context);
                }
                return repositoryAdministrador;
            }
        }

        public IRepository<Arquivo> RepositoryArquivo
        {
            get
            {
                if (repositoryArquivo == null)
                {
                    repositoryArquivo = new Repository<Arquivo>(_context);
                }
                return repositoryArquivo;
            }
        }

        public IRepository<Docente> RepositoryDocente
        {
            get
            {
                if (repositoryDocente == null)
                {
                    repositoryDocente = new Repository<Docente>(_context);
                }
                return repositoryDocente;
            }
        }

        public IRepository<Exame> RepositoryExame
        {
            get
            {
                if (repositoryExame == null)
                {
                    repositoryExame = new Repository<Exame>(_context);
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

        public IRepository<Paciente> RepositoryPaciente
        {
            get
            {
                if (repositoryPaciente == null)
                {
                    repositoryPaciente = new Repository<Paciente>(_context);
                }
                return repositoryPaciente;
            }
        }

        public IRepository<PedidoExame> RepositoryPedidoExame
        {
            get
            {
                if (repositoryPedidoExame == null)
                {
                    repositoryPedidoExame = new Repository<PedidoExame>(_context);
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

        public IRepository<RegistroExame> RepositoryRegistroExame
        {
            get
            {
                if (repositoryRegistroExame == null)
                {
                    repositoryRegistroExame = new Repository<RegistroExame>(_context);
                }
                return repositoryRegistroExame;
            }
        }

        public IRepository<Residente> RepositoryResidente
        {
            get
            {
                if (repositoryResidente == null)
                {
                    repositoryResidente = new Repository<Residente>(_context);
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
