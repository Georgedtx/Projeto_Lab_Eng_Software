using Domain.Entities;
using System;

namespace Domain.Interfaces.Repositories 
{
    public interface IRepositoryUsuario : IRepository<Usuario> {

        Usuario ObterPorId(Guid id);
        Usuario ObterPorEmail(string email);
    }
}