using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryArquivo : Repository<Arquivo>, IRepositoryArquivo
    {
        public RepositoryArquivo(ProjectContext _context) : base(_context) { }

        public Arquivo obterPorId(Guid id)
        {
            return _context.Arquivos.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}