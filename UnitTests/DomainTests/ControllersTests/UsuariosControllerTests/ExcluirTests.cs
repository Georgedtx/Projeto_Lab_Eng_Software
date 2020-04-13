using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Moq;
using Xunit;
namespace UnitTests.DomainTests.ControllersTests.UsuariosControllerTests
{
    public class ExcluirTests
    {
        [Fact]
        public void ExcluiUmRecepcionistaDadoUmIdDeUmRecepcionistaCadastrado()
        {
            string Email = "maitevitoriaelianegalvao_@mtc.eng.br";
            string Senha = "A2821PrlWT";
            Usuario expectedUsuario = new Usuario(Email, Senha);
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Usuario>> usuarioRepositoryMock = new Mock<IRepository<Usuario>>();
            usuarioRepositoryMock.Setup(mock => mock.Remover(expectedUsuario));
            unitWorkMock.SetupGet(mock => mock.RepositoryUsuario).Returns(usuarioRepositoryMock.Object);
            UsuariosController usuariosController = new UsuariosController(unitWorkMock.Object);
            Usuario returnedValue = usuariosController.ObterPorId(0);
            Assert.Null(returnedValue);
        }
    }
}