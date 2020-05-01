using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryExame : Repository<Exame>, IRepositoryExame
    {
        private readonly ProjectContext _projectContext;

        public RepositoryExame(ProjectContext projectContext) : base(projectContext)
        {
            _projectContext = projectContext;
        }

        public Exame ObterPorId(Guid id)
        {
            return _projectContext.Exames.Where(e => e.Id == id).FirstOrDefault();
        }

        public Exame ObterPorNome(string nome)
        {
            return _projectContext.Exames.Where(e => e.Nome.ToLower().Equals(nome.ToLower())).FirstOrDefault();
        }
    }
}