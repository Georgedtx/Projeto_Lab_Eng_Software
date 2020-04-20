using Domain.Entities;
using Domain.Interfaces.Uow;
using Ninject;
using System.Collections.Generic;
using System.Linq;

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

        public void Cadastrar(Recepcionista recepcionista)
        {
            _unitOfWork.RepositoryRecepcionista.Adicionar(recepcionista);
            _unitOfWork.Commit();
        }

        public List<Recepcionista> ObterTodos()
        {
            // return _unitOfWork.RepositoryRecepcionista.Obter().ToList();
            return null;
        }

        public Recepcionista ObterPorId(int id)
        {
            //return _unitOfWork.RepositoryRecepcionista.Obter().Where(r => r.Id == id).FirstOrDefault();
            return null;
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