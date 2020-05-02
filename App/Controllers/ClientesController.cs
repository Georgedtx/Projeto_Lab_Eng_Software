using Domain.Entities;
using Domain.Entities.Validations;
using App.ViewModels.Pacientes;
using Domain.Interfaces.Uow;
using FluentValidation.Results;
using Ninject;
using System;
using System.Collections.Generic;

namespace App.Controllers
{
    public class ClientesController
    {
        private readonly IUnitOfWork _unitOfWork;

        [Inject()]
        public ClientesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ValidationResult Cadastrar(PacienteAdicionar pacienteAdicionar) {

            if(!pacienteAdicionar.IsValid()) {
                return pacienteAdicionar.Validation;
            }

            pacienteAdicionar.Validation = new PacienteVerification(_unitOfWork).Validate(pacienteAdicionar);

            if (pacienteAdicionar.Validation.IsValid) {

                var paciente = new Paciente(pacienteAdicionar.Cpf, pacienteAdicionar.Nome, 
                pacienteAdicionar.Sexo, pacienteAdicionar.Cor, pacienteAdicionar.Nascimento);

                _unitOfWork.RepositoryPaciente.Adicionar(paciente);
                _unitOfWork.Commit();
            }

            return pacienteAdicionar.Validation;
        }

        public List<Paciente> ObterTodos()
        {
            return _unitOfWork.RepositoryPaciente.ObterTodos();
        } 

        public Paciente ObterPorCpf(String cpf) 
        {
            return _unitOfWork.RepositoryPaciente.ObterPorCpf(cpf);
        }

        public IEnumerable<PedidoExame> ObterPedidosPorIdCliente(Guid id) 
        {
            return _unitOfWork.RepositoryPaciente.ObterPedidosPorIdCliente(id);
        }

    }
}