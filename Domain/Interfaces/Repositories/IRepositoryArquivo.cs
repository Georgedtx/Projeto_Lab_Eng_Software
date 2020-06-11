using Domain.Entities;
using System;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryArquivo : IRepository<Arquivo>
    {
        Arquivo ObterPorId(Guid id); 
    }
}