using Domain.Entities;
using Domain.Entities.Validations;
using Domain.Interfaces.Uow;
using Ninject;
using System;
using System.Collections.Generic;

namespace App.Controllers
{
    public class UsuariosController
    {
        private readonly IUnitOfWork _unitOfWork;

        [Inject()]
        public UsuariosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Usuario Autenticar(string email, string senha)
        {
            var usuario = _unitOfWork.RepositoryUsuario.ObterPorEmail(email);

            if (usuario == null) throw new Exception("ERRO! Email sem usuário definido");

            if (!usuario.Senha.Equals(senha)) throw new Exception("Senha incorreta!");

            return usuario;
        }

        public List<Usuario> ObterTodos()
        {
            return _unitOfWork.RepositoryUsuario.ObterTodos();
        }

        public Usuario ObterPorEmail(string email)
        {
            return _unitOfWork.RepositoryUsuario.ObterPorEmail(email);
        }

        public bool AlterarSenha(Guid id, string novaSenha)
        {
            var usuario = _unitOfWork.RepositoryUsuario.ObterPorId(id);

            if (usuario == null) throw new Exception("Usuário não encontrado");

            if (SenhaValidation.Validate(novaSenha))
            {
                usuario.AlterarSenha(novaSenha);
                _unitOfWork.RepositoryUsuario.Atualizar(usuario);
                _unitOfWork.Commit();
                return true;
            }

            return false;
        }
    }
}
