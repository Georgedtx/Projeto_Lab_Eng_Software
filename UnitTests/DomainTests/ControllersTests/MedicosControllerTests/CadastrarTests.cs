using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Domain.ViewModels.Medicos;
using Moq;
using System;
using Xunit;
namespace UnitTests.DomainTests.ControllersTests.MedicosControllerTests
{
    public class CadastrarTests
    {
        [Fact]
        public void CadastrarUmNovoMedicoCorretamenteDadoUmObjetoMedocoValido()
        {
            MedicoViewModel medicoViewModel = new MedicoViewModel
            {
                Crm = "4017",
                Nome = "Teresinha Carolina Marlene Ferreira",
                IdUsuario = 0,
                TitUniversitaria = "Pós-Doutorado",
                AnoResidencia = new DateTime(year: 1957, month: 9, day: 27)
            };
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Medico>> medicoRepositoryMock = new Mock<IRepository<Medico>>();
            Mock<IRepository<Docente>> docenteRepositoryMock = new Mock<IRepository<Docente>>();
            unitWorkMock.Setup(mock => mock.Commit()).Returns(true);
            medicoRepositoryMock.Setup(mock => mock.Adicionar(It.IsAny<Medico>()));
            docenteRepositoryMock.Setup(mock => mock.Adicionar(It.IsAny<Docente>()));
            unitWorkMock.SetupGet(mock => mock.RepositoryMedico).Returns(medicoRepositoryMock.Object);
            unitWorkMock.SetupGet(mock => mock.RepositoryDocente).Returns(docenteRepositoryMock.Object);
            MedicosController medicosController = new MedicosController(unitWorkMock.Object);
            medicosController.Cadastrar(medicoViewModel);
            unitWorkMock.Verify(mock => mock.Commit(), Times.Exactly(2));
        }
    }
}