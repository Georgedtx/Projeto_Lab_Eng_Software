using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryMedico : Repository<Medico>, IRepositoryMedico
    {
        public RepositoryMedico(ProjectContext _context) : base(_context) { }

        public Medico ObterPorCrm(string crm)
        {
            return _context.Medicos
                .Include("Usuario")
                .Include("Residente")
                .Include("Docente")
                .Where(m => m.Crm.Equals(crm))
                .FirstOrDefault();
        }

        public Medico ObterPorId(Guid id)
        {
            return _context.Medicos
                .Include("Usuario")
                .Include("Residente")
                .Include("Docente")
                .Where(m => m.Id == id)
                .FirstOrDefault();
        }

        public Medico ObterPorEmail(string email)
        {
            return _context.Medicos
                .Include("Usuario")
                .Include("Residente")
                .Include("Docente")
                .Where(m => m.Email.ToLower().Equals(email.ToLower()))
                .FirstOrDefault();
        }
    }
}
