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
    public class MedicosController
    {
        private readonly IUnitOfWork _unitOfWork;

        [Inject()]
        public MedicosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ValidationResult Cadastrar(MedicoAdicionar medicoAdicionar)
        {
            if (!medicoAdicionar.IsValid()) return medicoAdicionar.Validation;

            medicoAdicionar.Validation = new MedicoVerification(_unitOfWork).Validate(medicoAdicionar);

            if (medicoAdicionar.Validation.IsValid)
            {
                var usuario = new Usuario(medicoAdicionar.Email, medicoAdicionar.Senha);
                _unitOfWork.RepositoryUsuario.Adicionar(usuario);

                var medico = new Medico(medicoAdicionar.Nome, medicoAdicionar.Crm, usuario.Id);
                _unitOfWork.RepositoryMedico.Adicionar(medico);

                _unitOfWork.Commit();
            }

            return medicoAdicionar.Validation;
        }

        public ValidationResult CadastrarDocente(DocenteAdicionar docenteAdicionar)
        {
            if (!docenteAdicionar.IsValid()) return docenteAdicionar.Validation;

            docenteAdicionar.Validation = new DocenteVerification(_unitOfWork).Validate(docenteAdicionar);

            if (docenteAdicionar.Validation.IsValid)
            {
                var usuario = new Usuario(docenteAdicionar.Email, docenteAdicionar.Senha);
                _unitOfWork.RepositoryUsuario.Adicionar(usuario);

                var medico = new Medico(docenteAdicionar.Nome, docenteAdicionar.Crm, usuario.Id);
                _unitOfWork.RepositoryMedico.Adicionar(medico);

                var docente = new Docente(docenteAdicionar.TitUniversitaria, medico.Id);
                _unitOfWork.RepositoryDocente.Adicionar(docente);

                _unitOfWork.Commit();
            }

            return docenteAdicionar.Validation;
        }

        public ValidationResult CadastrarResidente(ResidenteAdicionar residenteAdicionar)
        {
            if (!residenteAdicionar.IsValid()) return residenteAdicionar.Validation;

            residenteAdicionar.Validation = new ResidenteVerification(_unitOfWork).Validate(residenteAdicionar);

            if (residenteAdicionar.Validation.IsValid)
            {
                var usuario = new Usuario(residenteAdicionar.Email, residenteAdicionar.Senha);
                _unitOfWork.RepositoryUsuario.Adicionar(usuario);

                var medico = new Medico(residenteAdicionar.Nome, residenteAdicionar.Crm, usuario.Id);
                _unitOfWork.RepositoryMedico.Adicionar(medico);

                var residente = new Residente(residenteAdicionar.AnoResidencia, medico.Id);
                _unitOfWork.RepositoryResidente.Adicionar(residente);

                _unitOfWork.Commit();
            }

            return residenteAdicionar.Validation;
        }

        public List<Medico> ObterTodos()
        {
            return _unitOfWork.RepositoryMedico.ObterTodos();
        }

        public MedicoDetalhes ObterPorId(Guid id)
        {
            var medico = _unitOfWork.RepositoryMedico.ObterPorId(id);

            if (medico == null) throw new Exception("Médico não encontrado!");

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

        public MedicoDetalhes ObterPorCrm(string crm)
        {
            var medico = _unitOfWork.RepositoryMedico.ObterPorCrm(crm);

            if (medico == null) throw new Exception("Médico não encontrado!");

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
    }
}
