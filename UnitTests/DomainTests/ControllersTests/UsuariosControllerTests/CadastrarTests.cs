using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Moq;
using Xunit;
namespace UnitTests.DomainTests.ControllersTests.UsuariosControllerTests
{
    public class CadastrarTests
    {
        [Fact]
        public void CadastrarUmNovoUsuarioCorretamenteDadoUmObjetoUsuarioValido()
        {
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Usuario>> usuarioRepositoryMock = new Mock<IRepository<Usuario>>();
            unitWorkMock.Setup(mock => mock.Commit()).Returns(true);
            usuarioRepositoryMock.Setup(mock => mock.Adicionar(It.IsAny<Usuario>()));
            unitWorkMock.SetupGet(mock => mock.RepositoryUsuario).Returns(usuarioRepositoryMock.Object);
            string Email = "vicenterodrigodossantos..vicenterodrigodossantos@superig.com.br";
            string Senha = "oKRMNO4mKP";
            Usuario usuario = new Usuario(Email, Senha);
            UsuariosController usuariosController = new UsuariosController(unitWorkMock.Object);
            usuariosController.Cadastrar(usuario);
            unitWorkMock.Verify(mock => mock.Commit(), Times.Exactly(0));
        }
    }
}