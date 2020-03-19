using Domain.Entities;
using Domain.Interfaces.Uow;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Domain.Controllers
{
    public class AdministradoresController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

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
            return _unitOfWork.RepositoryAdministrador.Obter().ToList();
        }

        public Administrador ObterPorId(int id)
        {
            return _unitOfWork.RepositoryAdministrador.Obter().Where(a => a.Id == id).FirstOrDefault();
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