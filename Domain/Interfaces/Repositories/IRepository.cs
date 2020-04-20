using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface IRepository<Entity>
    {
        void Adicionar(Entity entity);
        List<Entity> ObterTodos();
        void Atualizar(Entity entity);
        void Remover(Entity entity);
    }
}
