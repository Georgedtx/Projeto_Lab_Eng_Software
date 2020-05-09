using Domain.Entities;
using System;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryPedidoExame : IRepositoryPedidoExame<PedidoExame>
    {
        PedidoExame ObterPorId(Guid id);

    }
}