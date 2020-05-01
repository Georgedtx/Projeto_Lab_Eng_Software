using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryExame : Repository<Exame>, IRepositoryExame
    {
        public RepositoryExame(ProjectContext _context) : base(_context) { }

        public Exame ObterPorId(Guid id)
        {
            return _context.Exames.Where(e => e.Id == id).FirstOrDefault();
        }

        public Exame ObterPorNome(string nome)
        {
            return _context.Exames.Where(e => e.Nome.ToLower().Equals(nome.ToLower())).FirstOrDefault();
        }
    }
}