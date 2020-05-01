using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryPaciente : Repository<Paciente>, IRepositoryPaciente
    {
        public RepositoryPaciente(ProjectContext _context) : base(_context) { }

        public IEnumerable<PedidoExame> ObterPedidosPorIdCliente(Guid idCliente)
        {
            return _context.PedidosExames.Where(p => p.IdPaciente == idCliente).ToList();
        }

        public Paciente ObterPorCpf(string cpf)
        {
            return _context.Pacientes.FirstOrDefault(p => p.Cpf.Equals(cpf));
        }
    }
}
