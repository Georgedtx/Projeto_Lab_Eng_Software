using Domain.Entities;
using System;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryResidente : IRepository<Residente>
    {
        Residente ObterPorId(Guid id); 
    }
}