using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryMedico : IRepository<Medico>
    {
        Medico ObterPorId(int id);
        Medico ObterPorCrm(string crm);
    }
}
