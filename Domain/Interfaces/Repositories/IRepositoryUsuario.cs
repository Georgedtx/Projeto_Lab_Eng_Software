using Domain.Entities;

namespace Domain.Interfaces.Repositories 
{
    public interface IRepositoryUsuario : IRepository<Usuario> {

        Usuario ObterPorId(int id);
        Usuario ObterPorEmail(string email);

    }

}