using App.ViewModels.Exames;
using Domain.Entities;
using Domain.Interfaces.Uow;
using FluentValidation.Results;
using Ninject;
using System;
using System.Collections.Generic;

namespace App.Controllers
{
    public class ExamesController
    {
        private readonly IUnitOfWork _unitOfWork;

        [Inject()]
        public ExamesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ValidationResult Cadastrar(ExameAdicionar exameAdicionar)
        {
            if (!exameAdicionar.IsValid()) return exameAdicionar.Validation;

            exameAdicionar.Validation = new ExameVerification(_unitOfWork).Validate(exameAdicionar);

            if (exameAdicionar.Validation.IsValid)
            {
                var exame = new Exame(exameAdicionar.Nome, exameAdicionar.Descricao);
                _unitOfWork.RepositoryExame.Adicionar(exame);
                _unitOfWork.Commit();
            }

            return exameAdicionar.Validation;
        }

        public IEnumerable<Exame> ObterTodos()
        {
            return _unitOfWork.RepositoryExame.ObterTodos();
        }

        public Exame ObterPorId(Guid id)
        {
            return _unitOfWork.RepositoryExame.ObterPorId(id);
        }

        public bool AlterarDescricao(Guid id, string novaDescricao)
        {
            if (novaDescricao.Length > 200) throw new Exception("Descrição deve ter até 200 caracteres");

            var exame = ObterPorId(id);

            if (exame != null) throw new Exception("Exame não encontrado");

            exame.Atualizar(novaDescricao);
                _unitOfWork.RepositoryExame.Atualizar(exame);
                _unitOfWork.Commit();

            return true;
        }

        public bool Excluir(Guid id)
        {
            var exame = ObterPorId(id);

            if (exame != null)
            {
                _unitOfWork.RepositoryExame.Remover(exame);
                _unitOfWork.Commit();
                return true;
            }
            return false;
        }
    }
}
