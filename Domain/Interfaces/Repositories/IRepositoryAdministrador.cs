using Domain.Entities;
using System;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryAdministrador : IRepository<Administrador>
    {
        Administrador ObterPorId(Guid id);
        Administrador ObterPorEmail(string email);
    }
}