using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryRecepcionista : IRepository<Recepcionista>
    {
        Recepcionista ObterPorId(int id);
          
    }
    
}