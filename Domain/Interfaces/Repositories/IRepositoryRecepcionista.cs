using Domain.Entities;
using System;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryRecepcionista : IRepository<Recepcionista>
    {
        Recepcionista ObterPorId(Guid id);
    }   
}