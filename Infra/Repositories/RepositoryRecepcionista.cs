using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System.Linq;

namespace Infra.Repositories 
{
    public class RepositoryRecepcionista : Repository<Recepcionista>, IRepositoryRecepcionista
    {
        private readonly ProjectContext _projectContext;

        public RepositoryRecepcionista(ProjectContext projectContext) : base(projectContext)
        {
            _projectContext = projectContext;
        }

        public Recepcionista ObterPorId(int id)
        {
            return _projectContext.Recepcionistas.Include("Recepcionista").Where(r => r.Id == id).FirstOrDefault();
        }
    }

}