using Domain.Entities;
using System;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryDocente : IRepository<Docente>
    {
        Docente ObterPorId(Guid id);
    }
}