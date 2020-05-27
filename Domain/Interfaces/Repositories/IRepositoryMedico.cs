using Domain.Entities;
using System;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryMedico : IRepository<Medico>
    {
        Medico ObterPorId(Guid id);
        Medico ObterPorCrm(string crm);
        object ObterPorEmail(string email);
    }
}
