using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Moq;
using Xunit;
namespace UnitTests.DomainTests.ControllersTests.AdministradoresControllerTests
{
    public class ExcluirTests
    {
        [Fact]
        public void ExcluiUmAdministradorDadoUmIdDeUmAdministradorCadastrado()
        {
            string nome = "";
            int idUsuario = 0;
            Administrador expectedAdministrador = new Administrador(nome,idUsuario);
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Administrador>> administradorRepositoryMock = new Mock<IRepository<Administrador>>();
            administradorRepositoryMock.Setup(mock => mock.Remover(expectedAdministrador));
            unitWorkMock.SetupGet(mock => mock.RepositoryAdministrador).Returns(administradorRepositoryMock.Object);
            AdministradoresController administradoresController = new AdministradoresController(unitWorkMock.Object);
            Administrador returnedvalue = administradoresController.ObterPorId(0);
            Assert.Null(returnedvalue);
        }
    }
}