using Domain.Entities;
using Domain.Interfaces.Uow;
using Domain.Validations.Verifications;
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

        public Exame Cadastrar(Exame exame)
        {
            if (!exame.IsValid()) return exame;

            exame.Validation = new ExameVerification(_unitOfWork.RepositoryExame).Validate(exame);

            if (exame.Validation.IsValid)
            {
                _unitOfWork.RepositoryExame.Adicionar(exame);
                _unitOfWork.Commit();
            }

            return exame;
        }

        public IEnumerable<Exame> ObterTodos()
        {
            return _unitOfWork.RepositoryExame.ObterTodos();
        }

        public Exame ObterPorId(Guid id)
        {
            return _unitOfWork.RepositoryExame.ObterPorId(id);
        }

        public Exame AlterarDescricao(Guid id, string novaDescricao)
        {
            var exame = ObterPorId(id);

            if (exame != null) throw new Exception("Exame não encontrado");

            exame.Atualizar(novaDescricao);

            if (exame.IsValid())
            {
                _unitOfWork.RepositoryExame.Atualizar(exame);
                _unitOfWork.Commit();
            }

            return exame;
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
