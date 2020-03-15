using Domain.Entities;
using Domain.Interfaces.Uow;
using Domain.Validations.Usuarios;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Domain.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

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
            return _unitOfWork.RepositoryUsuario.Obter().Where(u => u.Email.Equals(email) && u.Senha.Equals(senha)).FirstOrDefault();
        }

        public List<Usuario> ObterTodos()
        {
            return _unitOfWork.RepositoryUsuario.Obter().ToList();
        }

        public Usuario ObterPorId(int id)
        {
            return _unitOfWork.RepositoryUsuario.Obter().Where(u => u.Id == id).FirstOrDefault();
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
