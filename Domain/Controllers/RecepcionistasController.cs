using Domain.Interfaces.Uow;
using Domain.Entities;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Domain.Controllers
{
    public class RecepcionistasController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public RecepcionistasController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Cadastrar(Recepcionista recepcionista)
        {
            _unitOfWork.RepositoryRecepcionista.Adicionar(recepcionista);
            _unitOfWork.Commit();
        }

        public List<Recepcionista> ObterTodos()
        {
            return _unitOfWork.RepositoryRecepcionista.Obter().ToList();
        }

        public Recepcionista ObterPorId(int id)
        {
            return _unitOfWork.RepositoryRecepcionista.Obter().Where(r => r.Id == id).FirstOrDefault();
        }

        public bool Excluir(int id)
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