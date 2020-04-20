using Domain.Interfaces.Repositories;
using Infra.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Infra.Repositories
{
    public class Repository<Entity> : IRepository<Entity>
        where Entity : class
    {
        private readonly ProjectContext _context;

        public Repository(ProjectContext context)
        {
            _context = context;
        }

        public void Adicionar(Entity entity)
        {
            _context.Set<Entity>().Add(entity);
        }

        public void Atualizar(Entity entity)
        {
            var temp = _context.Entry(entity);
            temp.State = EntityState.Modified;
        }

        public List<Entity> ObterTodos()
        {
            return _context.Set<Entity>().ToList();
        }

        public void Remover(Entity entity)
        {
            _context.Set<Entity>().Remove(entity);
        }
    }
}
