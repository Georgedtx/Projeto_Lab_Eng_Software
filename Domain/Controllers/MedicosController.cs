using Domain.Entities;
using Domain.Interfaces.Uow;
using Domain.Validations.Medicos;
using Ninject;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Controllers
{
    public class MedicosController
    {
        private readonly IUnitOfWork _unitOfWork;

        [Inject()]
        public MedicosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Medico Cadastrar(Medico medico)
        {
            medico.Validation = new MedicosValidarCadastro(_unitOfWork.RepositoryMedico).Validate(medico);

            if (medico.Validation.IsValid)
            {
                _unitOfWork.RepositoryMedico.Adicionar(medico);
                _unitOfWork.Commit();
            }

            return medico;
        }

        public void AdicionarDocente(Docente docente)
        {
            _unitOfWork.RepositoryDocente.Adicionar(docente);
            _unitOfWork.Commit();
        }

        public void AdicionarResidente(Residente residente)
        {
            _unitOfWork.RepositoryResidente.Adicionar(residente);
            _unitOfWork.Commit();
        }

        public IEnumerable<Medico> ObterTodos()
        {
            return _unitOfWork.RepositoryMedico.Obter().ToList();
        }

        
    }
}
