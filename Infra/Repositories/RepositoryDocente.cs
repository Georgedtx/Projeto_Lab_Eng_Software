using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryDocente : Repository<Docente>, IRepositoryDocente
    {
        public RepositoryDocente(ProjectContext _context) : base(_context) { }

        public Docente ObterPorId(Guid id)
        {
            return _context.Docentes
                .Include("Usuario")
                .Include("Docente")
                .Where(d => d.Id == id)
                .FirstOrDefault();
        }
    } 
}