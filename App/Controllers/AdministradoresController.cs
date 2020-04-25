using Domain.Entities;
using Domain.Interfaces.Uow;
using Ninject;
using System.Collections.Generic;
using System.Linq;

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

        public void Cadastrar(Administrador administrador)
        {
            _unitOfWork.RepositoryAdministrador.Adicionar(administrador);
            _unitOfWork.Commit();
        }

        public List<Administrador> ObterTodos()
        {
            return _unitOfWork.RepositoryAdministrador.ObterTodos();
        }

        public Administrador ObterPorId(int id)
        {
            return _unitOfWork.RepositoryAdministrador.ObterPorId(id);
        }

        public bool Excluir(int id)
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