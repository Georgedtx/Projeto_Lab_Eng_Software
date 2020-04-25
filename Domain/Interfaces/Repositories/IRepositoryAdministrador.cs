using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryAdministrador : IRepository<Administrador>
    {
        Administrador ObterPorId(int id);
       
    }
}