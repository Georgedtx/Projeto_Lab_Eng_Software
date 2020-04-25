using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryAdministrador : Repository<Administrador>, IRepositoryAdministrador
    {
        private readonly ProjectContext _projectContext;

        public RepositoryAdministrador(ProjectContext projectContext) : base(projectContext)
        {
            _projectContext = projectContext;
        }

        public Administrador ObterPorId(int id)
        {
            return _projectContext.Administradores.Include("Administrador").Where(a => a.Id == id).FirstOrDefault();
        }
    }
}