using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryExame : RepositoryExame<Exame>, IRepositoryExame
    {
        private readonly ProjectContext _projectContext;

        public RepositoryExame(ProjectContext projectContext) : base(projectContext)
        {
            _projectContext = projectContext;
        }

        public Exame ObterPorId(int id)
        {
            return _projectContext.Exames.Include("Exame").Where(e => e.Id == id).FirstOrDefault();
        }
    }
}