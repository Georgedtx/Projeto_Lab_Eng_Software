using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryResidente : RepositoryResidente<Residente>, IRepositoryResidente
    {
        public RepositoryResidente(ProjectContext _context) : base(_context) { }

        public Residente ObterPorId(Guid id)
        {
            return _context.Residentes
                .Include("Usuario")
                .Include("Residente")
                .Where(r => r.Id == id)
                .FirstOrDefaul();
        }
    }
}