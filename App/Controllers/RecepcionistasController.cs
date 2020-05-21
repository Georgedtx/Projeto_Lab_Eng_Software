using App.ViewModels.Recepcionistas;
using Domain.Entities;
using Domain.Interfaces.Uow;
using FluentValidation.Results;
using Ninject;
using System;
using System.Collections.Generic;

namespace App.Controllers
{
    public class RecepcionistasController
    {
        private readonly IUnitOfWork _unitOfWork;

        [Inject()]
        public RecepcionistasController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ValidationResult Cadastrar(RecepcionistaAdicionar recepcionistaAdicionar)
        {
            if (!recepcionistaAdicionar.IsValid()) return recepcionistaAdicionar.Validation;

            recepcionistaAdicionar.Validation = new RecepcionistaVerification(_unitOfWork).Validate(recepcionistaAdicionar);

            if (recepcionistaAdicionar.Validation.IsValid)
            {
                var usuario = new Usuario(recepcionistaAdicionar.Email, recepcionistaAdicionar.Senha);
                _unitOfWork.RepositoryUsuario.Adicionar(usuario);

                var recepcionista = new Recepcionista(recepcionistaAdicionar.Nome, recepcionistaAdicionar.Nascimento, usuario.Id);
                _unitOfWork.RepositoryRecepcionista.Adicionar(recepcionista);

                _unitOfWork.Commit();
            }

            return recepcionistaAdicionar.Validation;
        }

        public List<Recepcionista> ObterTodos()
        {
            return _unitOfWork.RepositoryRecepcionista.ObterTodos();
        }

        public Recepcionista ObterPorId(Guid id)
        {
            return _unitOfWork.RepositoryRecepcionista.ObterPorId(id);
        }

        public Recepcionista ObterPorEmail(string email)
        {
            return _unitOfWork.RepositoryRecepcionista.ObterPorEmail(email);
        }

        public bool Excluir(Guid id)
        {
            var recepcionista = ObterPorId(id);

            if (recepcionista != null)
            {
                _unitOfWork.RepositoryRecepcionista.Remover(recepcionista);
                _unitOfWork.Commit();
                return true;
            }

            return false;
        }
    }
}