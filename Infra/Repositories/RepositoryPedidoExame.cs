using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryPedidoExame : Repository<PedidoExame>, IRepositoryPedidoExame
    {
        public RepositoryPedidoExame(ProjectContext _context) : base(_context) {}

        public List<PedidoExame> ObterPedidosPorCpfDoCliente(string cpf)
        {
            var pedidos = (from paciente in _context.Pacientes
                           where paciente.Cpf.Equals(cpf)
                           join pedido in _context.PedidosExames on paciente.Id equals pedido.IdPaciente
                           select pedido).ToList();

            return pedidos;
        }

        public PedidoExame ObterPorId(Guid id)
        {
            return _context.PedidosExames.Where(p => p.Id == id).FirstOrDefault();
        }

    }
}