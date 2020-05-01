using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System;
using System.Linq;

namespace Infra.Repositories 
{
    public class RepositoryRecepcionista : Repository<Recepcionista>, IRepositoryRecepcionista
    {
        public RepositoryRecepcionista(ProjectContext _context) : base(_context) { }

        public Recepcionista ObterPorId(Guid id)
        {
            return _context.Recepcionistas.Include("Usuario").Where(r => r.Id == id).FirstOrDefault();
        }
    }

}