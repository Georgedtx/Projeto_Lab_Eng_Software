using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Moq;
using Xunit;
namespace UnitTests.DomainTests.ControllersTests.AdministradoresControllerTests
{
    public class CadastrarTests
    {
        [Fact]
        public void CadastrarUmNovoAdministradorCorretamenteDadoUmObjetoAdministradorValido()
        {
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Administrador>> administradorRepositoryMock = new Mock<IRepository<Administrador>>();
            unitWorkMock.Setup(mock => mock.Commit()).Returns(true);
            administradorRepositoryMock.Setup(mock => mock.Adicionar(It.IsAny<Administrador>()));
            unitWorkMock.SetupGet(mock => mock.RepositoryAdministrador).Returns(administradorRepositoryMock.Object);
            string nome = "Elza Juliana Sandra Aparício";
            int idUsuario = 0;
            Administrador administrador = new Administrador(nome, idUsuario);
            AdministradoresController administradoresController = new AdministradoresController(unitWorkMock.Object);
            administradoresController.Cadastrar(administrador);
            unitWorkMock.Verify(mock => mock.Commit(), Times.Exactly(1));
        }
    }
}