using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryRegistroExame : Repository<RegistroExame>, IRepositoryRegistroExame
    {
        public RepositoryRegistroExame(ProjectContext _context) : base(_context) { }

        public RegistroExame ObterPorId(Guid id)
        {
            return _context.RegistrosExames.Where(r => r.Id == id).FirstOrDefault();
        }
    }
}