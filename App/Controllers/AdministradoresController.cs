using App.ViewModels.Administradores;
using Domain.Entities;
using Domain.Interfaces.Uow;
using FluentValidation.Results;
using Ninject;
using System;
using System.Collections.Generic;

namespace App.Controllers
{
    public class AdministradoresController
    {
        private readonly IUnitOfWork _unitOfWork;

        [Inject()]
        public AdministradoresController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ValidationResult Cadastrar(AdministradorAdicionar administradorAdicionar)
        {
            if (!administradorAdicionar.IsValid()) return administradorAdicionar.Validation;

            administradorAdicionar.Validation = new AdministradorVerification(_unitOfWork).Validate(administradorAdicionar);

            if (administradorAdicionar.Validation.IsValid)
            {
                var usuario = new Usuario(administradorAdicionar.Email, administradorAdicionar.Senha);
                _unitOfWork.RepositoryUsuario.Adicionar(usuario);

                var administrador = new Administrador(administradorAdicionar.Nome, usuario.Id);
                _unitOfWork.RepositoryAdministrador.Adicionar(administrador);

                 _unitOfWork.Commit();
            }

            return administradorAdicionar.Validation;
        }

        public List<Administrador> ObterTodos()
        {
            return _unitOfWork.RepositoryAdministrador.ObterTodos();
        }

        public Administrador ObterPorId(Guid id)
        {
            return _unitOfWork.RepositoryAdministrador.ObterPorId(id);
        }

        public bool Excluir(Guid id)
        {
            var administrador = ObterPorId(id);
            if (administrador != null)
            {
                _unitOfWork.RepositoryAdministrador.Remover(administrador);
                _unitOfWork.Commit();
                return true;
            }
            return false;
        }
    }
}