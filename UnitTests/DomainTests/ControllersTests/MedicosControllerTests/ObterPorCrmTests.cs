﻿using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Domain.ViewModels.Medicos;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
namespace UnitTests.DomainTests.ControllersTests.MedicosControllerTests
{
    public class ObterPorCrmTests
    {
        [Fact]
        public void ObeterUmMedicoDadoUmIdDeUmMedicoCadastrado()
        {
            string nome = "Marcela Beatriz Assis";
            string crm = "1973";
            int idUsuario = 0;
            Medico expectedMedico = new Medico(nome, crm, idUsuario);
            Docente expectedDocente = new Docente(titUniversitaria: "Mestrado", idMedico: 0);
            Residente expectedResidente = new Residente(anoResidencia: new DateTime(year: 2005, month: 5, day: 25), idMedico: 0);
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Medico>> medicoRepositoryMock = new Mock<IRepository<Medico>>();
            Mock<IRepository<Docente>> docenteRepositoryMock = new Mock<IRepository<Docente>>();
            Mock<IRepository<Residente>> residenteRepositoryMock = new Mock<IRepository<Residente>>();
            medicoRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Medico>() { expectedMedico }.AsQueryable());
            docenteRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Docente>() { expectedDocente }.AsQueryable());
            residenteRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Residente>() { expectedResidente }.AsQueryable());
            unitWorkMock.SetupGet(mock => mock.RepositoryMedico).Returns(medicoRepositoryMock.Object);
            unitWorkMock.SetupGet(mock => mock.RepositoryDocente).Returns(docenteRepositoryMock.Object);
            unitWorkMock.SetupGet(mock => mock.RepositoryResidente).Returns(residenteRepositoryMock.Object);
            MedicosController medicosController = new MedicosController(unitWorkMock.Object);
            MedicoViewModel returnedValue = medicosController.ObterPorCrm("1973");
            Assert.Equal(expectedMedico.Nome, returnedValue.Nome);
            Assert.Equal(expectedMedico.Crm, returnedValue.Crm);
            Assert.Equal(expectedMedico.IdUsuario, returnedValue.IdUsuario);
        }
        [Fact]
        public void RetornarNuloDadoQueNaoEncontraNenhumMedicoCadastradoParaOIdPassado()
        {
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Medico>> medicoRepositoryMock = new Mock<IRepository<Medico>>();
            Mock<IRepository<Docente>> docenteRepositoryMock = new Mock<IRepository<Docente>>();
            Mock<IRepository<Residente>> residenteRepositoryMock = new Mock<IRepository<Residente>>();
            medicoRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Medico>().AsQueryable());
            docenteRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Docente>().AsQueryable());
            residenteRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Residente>().AsQueryable());
            unitWorkMock.SetupGet(mock => mock.RepositoryMedico).Returns(medicoRepositoryMock.Object);
            unitWorkMock.SetupGet(mock => mock.RepositoryDocente).Returns(docenteRepositoryMock.Object);
            unitWorkMock.SetupGet(mock => mock.RepositoryResidente).Returns(residenteRepositoryMock.Object);
            MedicosController medicosController = new MedicosController(unitWorkMock.Object);
            MedicoViewModel returnedValue = medicosController.ObterPorCrm("1020");
            Assert.Null(returnedValue);
        }
    }
}