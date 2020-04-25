using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryExame : IRepository<Exame>
    {
        Exame ObterPorId(int id);
        
    }
}