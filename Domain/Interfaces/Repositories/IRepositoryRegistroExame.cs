using Domain.Entities;
using System;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryRegistroExame : IRepository<RegistroExame>
    {
        RegistroExame ObterPorId(Guid id);
        
    }
}