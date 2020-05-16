using App.ViewModels.PedidosExames;
using Domain.Entities;
using Domain.Interfaces.Uow;
using Domain.Relatorios;
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

            pedidoExame.Validation = new PedidoExameVerification(_unitOfWork).Validate(pedidoExame);

            if (!pedidoExame.Validation.IsValid) return pedidoExame.Validation;

            var medico = BuscarMedicoPorCrm(pedidoExame.Crm);

            var pedido = new PedidoExame(pedidoExame.DataEmissao,
                                         pedidoExame.DataRealizacao,
                                         pedidoExame.Hipotese,
                                         pedidoExame.IdPaciente,
                                         pedidoExame.IdExame,
                                         medico.Id);

            _unitOfWork.RepositoryPedidoExame.Adicionar(pedido);

            if (_unitOfWork.Commit())
            {
                GerarRelatorio.Gerar(new Relatorio
                {
                    Nome = pedidoExame.NomePaciente,
                    Idade = pedidoExame.IdadePaciente,
                    Sexo = pedidoExame.SexoPaciente,
                    Exame = pedidoExame.Exame,
                    DataRealizacao = pedidoExame.DataRealizacao,
                    DataEmissao = pedido.DataEmissao,
                    Recomendacoes = pedidoExame.Recomendacoes
                }
                );
            }

            return pedidoExame.Validation;
        }

        private Medico BuscarMedicoPorCrm(string crm)
        {
            return _unitOfWork.RepositoryMedico.ObterPorCrm(crm);
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
