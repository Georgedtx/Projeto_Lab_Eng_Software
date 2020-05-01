using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryUsuario : Repository<Usuario>, IRepositoryUsuario
    {
        private readonly ProjectContext _projectContext;

        public RepositoryUsuario(ProjectContext projectContext) : base(projectContext) {
            
            _projectContext = projectContext;
        }

        public Usuario ObterPorId(Guid id) {

            return _projectContext.Usuarios.Include("Usuario").Where(u => u.Id == id).FirstOrDefault();

        }

        public Usuario ObterPorEmail(string email) {

            return _projectContext.Usuarios.Where(u => u.Email.ToLower().Equals(email.ToLower())).FirstOrDefault();
        }
    }
}