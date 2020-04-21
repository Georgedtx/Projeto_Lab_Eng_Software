using Domain.Entities;
using Domain.Interfaces.Uow;
using Domain.Validations.Usuarios;
using Ninject;
using System.Collections.Generic;
using System.Linq;

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

        public Usuario Cadastrar(Usuario usuario)
        {
            if (!usuario.IsValid())
            {
                return usuario;
            }

            usuario.Validation = new UsuarioValidarCadastro(_unitOfWork.RepositoryUsuario).Validate(usuario);

            if (usuario.Validation.IsValid)
            {
                _unitOfWork.RepositoryUsuario.Adicionar(usuario);
                _unitOfWork.Commit();
            }

            return usuario;
        }

        public Usuario Autenticar(string email, string senha)
        {
            var usuario = _unitOfWork.RepositoryUsuario.ObterPorEmail(email);

            if (usuario != null) {

                if (usuario.Senha.Equals(senha)) {
                    return usuario;
                } else {
                    throw new System.Exception("Senha Incorreta");
                }
            }
            throw new System.Exception("Email não encontrado");
        }

        public List<Usuario> ObterTodos()
        {
            return _unitOfWork.RepositoryUsuario.ObterTodos();
        }

        public Usuario ObterPorId(int id)
        {
            return _unitOfWork.RepositoryUsuario.ObterPorId(id);
        }

        public bool AlterarSenha(int id, string novaSenha)
        {
            var usuario = ObterPorId(id);

            if (usuario != null && SenhaValidation.Validate(novaSenha))
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
