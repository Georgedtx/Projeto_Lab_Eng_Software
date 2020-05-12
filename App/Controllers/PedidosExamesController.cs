using App.ViewModels.PedidosExames;
using Domain.Entities;
using Domain.Interfaces.Uow;
using FluentValidation.Results;
using Ninject;
using System;
using System.Collections.Generic;

namespace App.Controllers
{
    public class PedidosExamesController
    {
        private readonly IUnitOfWork _unitOfWork;

        [Inject()]
        public PedidosExamesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ValidationResult EmitirPedidoExame(PedidoExameAdicionar pedidoExame)
        {
            if (!pedidoExame.IsValid()) return pedidoExame.Validation;

            var pedido = new PedidoExame(pedidoExame.DataRealizacao,
                                         pedidoExame.Hipotese,
                                         pedidoExame.IdPaciente,
                                         pedidoExame.IdExame,
                                         pedidoExame.IdMedico);

            _unitOfWork.RepositoryPedidoExame.Adicionar(pedido);
            _unitOfWork.Commit();
            return pedidoExame.Validation;
        }

        public Paciente BuscarPacientePorCpf(string cpf)
        {
            var paciente = _unitOfWork.RepositoryPaciente.ObterPorCpf(cpf);

            if (paciente == null) throw new Exception("Paciente sem registro ou Cpf inválido!");

            return paciente;
        }

        public List<PedidoExame> ObterPedidosExamesDoPaciente(string cpf)
        {
            return _unitOfWork.RepositoryPedidoExame.ObterPedidosPorCpfDoCliente(cpf);
        }

        public bool RemarcarConsulta(Guid pedidoExameId, DateTime novaData)
        {
            var pedido = _unitOfWork.RepositoryPedidoExame.ObterPorId(pedidoExameId);

            if (pedido == null || novaData == new DateTime()) return false;

            pedido.Remarcar(novaData);
            _unitOfWork.RepositoryPedidoExame.Atualizar(pedido);
            _unitOfWork.Commit();
            return true;
        }
    }
}
