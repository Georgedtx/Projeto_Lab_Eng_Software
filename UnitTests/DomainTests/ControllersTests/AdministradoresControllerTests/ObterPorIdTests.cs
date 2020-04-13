using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;
namespace UnitTests.DomainTests.ControllersTests.AdministradoresControllerTests
{
    public class ObterPorIdTests
    {
        [Fact]
        public void ObetemUmAdministradorDadoUmIdDeUmAdministradorCadastrado()
        {
            string nome = "Eliane Evelyn Emilly da Mata";
            int idUsuario = 0;
            Administrador expectedAdministrador = new Administrador(nome, idUsuario);
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Administrador>> administradorRepositoryMock = new Mock<IRepository<Administrador>>();
            administradorRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Administrador>() { expectedAdministrador }.AsQueryable());
            unitWorkMock.SetupGet(mock => mock.RepositoryAdministrador).Returns(administradorRepositoryMock.Object);
            AdministradoresController administradoresController = new AdministradoresController(unitWorkMock.Object);
            Administrador returnedValue = administradoresController.ObterPorId(0);
            Assert.Equal(expectedAdministrador.Nome, returnedValue.Nome);
            Assert.Equal(expectedAdministrador.IdUsuario, returnedValue.IdUsuario);
        }
        [Fact]
        public void RetornaNuloDadoQueNaoEncontraNenhumAdministradorCadastradoParaOIdPassado()
        {
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Administrador>> administradorRepositoryMock = new Mock<IRepository<Administrador>>();
            administradorRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Administrador>().AsQueryable());
            unitWorkMock.SetupGet(mock => mock.RepositoryAdministrador).Returns(administradorRepositoryMock.Object);
            AdministradoresController administradorController = new AdministradoresController(unitWorkMock.Object);
            Administrador returnedValue = administradorController.ObterPorId(0);
            Assert.Null(returnedValue);
        }
    }
}