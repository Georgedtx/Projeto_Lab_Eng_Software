using App.ViewModels;
using App.ViewModels.Medicos;
using Domain.Entities;
using Domain.Interfaces.Uow;
using FluentValidation.Results;
using Ninject;
using System;
using System.Collections.Generic;

namespace App.Controllers
{
    public class ResidentesController
    {
        private readonly IUnitOfWork _unitOfWork;

        [Inject()]
        public ResidentesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public MedicoDetalhes ObterPorId(Guid id)
        {
            var medico = _unitOfWork.RepositoryResidentes.ObterPorId(id);

            if (medico == null) throw new Exception("Residente não encontrado!");

            return new MedicoDetalhes
            {
                Id = medico.Id,
                Nome = medico.Nome,
                Crm = medico.Crm,
                Email = medico.Usuario.Email,

                IdDocente = medico.Docente != null ? medico.Docente.Id : Guid.Empty,
                TitUniversitaria = medico.Docente != null ? medico.Docente.TitUniversitaria : null,

                IdResidente = medico.Residente != null ? medico.Residente.Id : Guid.Empty,
                AnoResidencia = medico.Residente != null ? medico.Residente.AnoResidencia : 0
            };
        }

        public List<Residente> ObterTodos()
        {
            return _unitOfWork.RepositoryResidentes.ObterTodos();
        }
    }
}