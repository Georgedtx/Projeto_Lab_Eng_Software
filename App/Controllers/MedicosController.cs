using App.Mappers;
using App.ViewModels;
using App.ViewModels.Medicos;
using Domain.Entities;
using Domain.Interfaces.Uow;
using Domain.Validations.Medicos;
using Ninject;
using System;
using System.Collections.Generic;

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

        public void EspecializarMedico(AddEspecializacao especializacao)
        {
            if (especializacao.AnoResidencia != null)
            {
                var residente = MapperConfig<Residente, AddEspecializacao>.ConvertToEntity(especializacao);
                _unitOfWork.RepositoryResidente.Adicionar(residente);
            }
            else
            {
                var docente = MapperConfig<Docente, AddEspecializacao>.ConvertToEntity(especializacao);
                _unitOfWork.RepositoryDocente.Adicionar(docente);
            }

            _unitOfWork.Commit();
        }

        public List<Medico> ObterTodos()
        {
            return _unitOfWork.RepositoryMedico.ObterTodos();
        }

        public MedicoDetalhes ObterPorId(int id)
        {
            var medico = _unitOfWork.RepositoryMedico.ObterPorId(id);

            if (medico != null)
            {
                return new MedicoDetalhes
                {
                    Id = medico.Id,
                    Nome = medico.Nome,
                    Crm = medico.Crm,
                    Email = medico.Usuario.Email,

                    IdDocente = medico.Docente != null ? medico.Docente.Id : 0,
                    TitUniversitaria = medico.Docente != null ? medico.Docente.TitUniversitaria : null,

                    IdResidente = medico.Residente != null ? medico.Residente.Id : 0,
                    AnoResidencia = medico.Residente != null ? medico.Residente.AnoResidencia : new DateTime()
                };
            }

            return null;
        }

        public MedicoDetalhes ObterPorCrm(string crm)
        {
            var medico = _unitOfWork.RepositoryMedico.ObterPorCrm(crm);

            if (medico != null)
            {
                return new MedicoDetalhes
                {
                    Id = medico.Id,
                    Nome = medico.Nome,
                    Crm = medico.Crm,
                    Email = medico.Usuario.Email,

                    IdDocente = medico.Docente != null ? medico.Docente.Id : 0,
                    TitUniversitaria = medico.Docente != null ? medico.Docente.TitUniversitaria : null,

                    IdResidente = medico.Residente != null ? medico.Residente.Id : 0,
                    AnoResidencia = medico.Residente != null ? medico.Residente.AnoResidencia : new DateTime()
                };
            }

            return null;
        }
    }
}
