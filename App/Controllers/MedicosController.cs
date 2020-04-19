using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Uow;
using Domain.Validations.Medicos;
using Domain.ViewModels.Medicos;
using Ninject;
using System.Collections.Generic;
using System.Linq;

namespace App.Controllers
{
    public class MedicosController
    {
        private readonly IUnitOfWork _unitOfWork;

        [Inject()]
        public MedicosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Medico Cadastrar(MedicoViewModel medicoViewModel)
        {
            var config = new MapperConfiguration(c =>
            {
                c.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                c.CreateMap<MedicoViewModel, Medico>();
            });

            var medico = config.CreateMapper().Map<MedicoViewModel, Medico>(medicoViewModel);

            medico.Validation = new MedicosValidarCadastro(_unitOfWork.RepositoryMedico).Validate(medico);

            if (medico.Validation.IsValid)
            {
                _unitOfWork.RepositoryMedico.Adicionar(medico);
                _unitOfWork.Commit();

                if (!string.IsNullOrEmpty(medicoViewModel.TitUniversitaria))
                {
                    AdicionarDocente(new Docente(medicoViewModel.TitUniversitaria, medico.Id));
                }
                else if (medicoViewModel.AnoResidencia != null)
                {
                    AdicionarResidente(new Residente(medicoViewModel.AnoResidencia, medico.Id));
                }
            }

            return medico;
        }

        private void AdicionarDocente(Docente docente)
        {
            _unitOfWork.RepositoryDocente.Adicionar(docente);
            _unitOfWork.Commit();
        }

        private void AdicionarResidente(Residente residente)
        {
            _unitOfWork.RepositoryResidente.Adicionar(residente);
            _unitOfWork.Commit();
        }

        public IEnumerable<Medico> ObterTodos()
        {
            return _unitOfWork.RepositoryMedico.Obter().ToList();
        }

        public MedicoViewModel ObterPorId(int id)
        {
            var medico = (from m in _unitOfWork.RepositoryMedico.Obter()
                          where m.Id == id
                          join d in _unitOfWork.RepositoryDocente.Obter() on m.Id equals d.IdMedico
                          join r in _unitOfWork.RepositoryResidente.Obter() on m.Id equals r.IdMedico
                          select new MedicoViewModel
                          {
                              Nome = m.Nome,
                              Crm = m.Crm,
                              TitUniversitaria = d.TitUniversitaria,
                              AnoResidencia = r.AnoResidencia
                          }).FirstOrDefault();

            return medico;
        }

        public MedicoViewModel ObterPorCrm(string crm)
        {
            var medico = (from m in _unitOfWork.RepositoryMedico.Obter()
                          where m.Crm.Equals(crm)
                          join d in _unitOfWork.RepositoryDocente.Obter() on m.Id equals d.IdMedico
                          join r in _unitOfWork.RepositoryResidente.Obter() on m.Id equals r.IdMedico
                          select new MedicoViewModel
                          {
                              Nome = m.Nome,
                              Crm = m.Crm,
                              TitUniversitaria = d.TitUniversitaria,
                              AnoResidencia = r.AnoResidencia
                          }).FirstOrDefault();

            return medico;
        }
    }
}
