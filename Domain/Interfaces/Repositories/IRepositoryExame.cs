using Domain.Entities;
using System;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryExame : IRepository<Exame>
    {
        Exame ObterPorId(Guid id);
        Exame ObterPorNome(string nome);
    }
}