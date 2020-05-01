using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryPaciente : IRepository<Paciente>
    {
        Paciente ObterPorCpf(string cpf);
        IEnumerable<PedidoExame> ObterPedidosPorIdCliente(Guid idCliente);
    }
}
