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
    public class DocentesController
    {
        private readonly IUnitOfWork _unitOfWork;

        [Inject()]
        public DocentesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork  = unitOfWork;
        }

        public List<Docente> ObterTodos()
        {
            return _unitOfWork.RepositoryDocente.ObterTodos();
        }
    }
}