using Domain.Entities;
using Domain.Interfaces.Uow;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Controllers
{
    public class ExamesController
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExamesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Cadastrar(Exame exame)
        {
            _unitOfWork.RepositoryExame.Adicionar(exame);
            _unitOfWork.Commit();
        }

        public IEnumerable<Exame> ObterTodos()
        {
            return _unitOfWork.RepositoryExame.Obter().ToList();
        }

        public Exame ObterPorId(int id)
        {
            return _unitOfWork.RepositoryExame.Obter().Where(e => e.Id == id).FirstOrDefault();
        }

        public bool AlterarDescricao(int id, string novaDescricao)
        {
            var exame = ObterPorId(id);

            if (exame != null)
            {
                exame.Atualizar(novaDescricao);
                _unitOfWork.RepositoryExame.Atualizar(exame);
                _unitOfWork.Commit();
                return true;
            }
            return false;
        }

        public bool Excluir(int id)
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
