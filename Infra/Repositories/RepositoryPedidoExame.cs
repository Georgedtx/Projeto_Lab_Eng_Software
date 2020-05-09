using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryPedidoExame : Repository<PedidoExame>, IRepositoryPedidoExame
    {
        public RepositoryPedidoExame(ProjectContext _context) : base(_context) {}

        public PedidoExame ObterPorId(Guid id)
        {
            return _context.PedidosExames.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}