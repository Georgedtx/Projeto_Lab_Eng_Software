using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System;
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

        public Recepcionista ObterPorId(Guid id)
        {
            return _projectContext.Recepcionistas.Include("Usuario").Where(r => r.Id == id).FirstOrDefault();
        }
    }

}