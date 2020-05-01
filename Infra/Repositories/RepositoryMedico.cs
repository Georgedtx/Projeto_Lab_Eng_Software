using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryMedico : Repository<Medico>, IRepositoryMedico
    {
        private readonly ProjectContext _projectContext;

        public RepositoryMedico(ProjectContext projectContext) : base(projectContext)
        {
            _projectContext = projectContext;
        }

        public Medico ObterPorCrm(string crm)
        {
            return _projectContext.Medicos
                .Include("Usuario")
                .Include("Residente")
                .Include("Docente")
                .Where(m => m.Crm.Equals(crm))
                .FirstOrDefault();
        }

        public Medico ObterPorId(Guid id)
        {
            return _projectContext.Medicos
                .Include("Usuario")
                .Include("Residente")
                .Include("Docente")
                .Where(m => m.Id == id)
                .FirstOrDefault();
        }
    }
}
