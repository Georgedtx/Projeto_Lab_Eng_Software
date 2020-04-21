using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System.Linq;

namespace Infra.Repositories
{


    public class RepositoryUsuario : Repository<Usuario>, IRepositoryUsuario
    {
        private readonly ProjectContext _projectContext;

        public RepositoryUsuario(ProjectContext projectContext) : base(projectContext) {
            
            _projectContext = projectContext;
        }

        public Usuario ObterPorId(int id) {

            return _projectContext.Usuarios.Include("Usuario").Where(u => u.ID == id).FirstOrDefault();

        }

        public Usuario ObterPorEmail(string email) {

            return _projectContext.Usuarios.Include("Usuario").Where(u => u.Email.Equals(email)).FirstOrDefault();
        }
    }
}