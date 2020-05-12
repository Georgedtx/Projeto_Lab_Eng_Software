using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryPedidoExame : IRepository<PedidoExame>
    {
        PedidoExame ObterPorId(Guid id);
        List<PedidoExame> ObterPedidosPorCpfDoCliente(string cpf);
    }
}