using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;
namespace UnitTests.DomainTests.ControllersTests.UsuariosControllerTests
{
    public class ObterPorIdTests
    {
        [Fact]
        public void ObetemUmUsuarioDadoUmIdDeUmUsuarioCadastrado()
        {
            string Email = "iagobrunoheitoraraujo_@pig.com.br";
            string Senha = "GRS0UT32Ek";
            Usuario expectedUsuario = new Usuario(Email, Senha);
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Usuario>> usuarioRepositoryMock = new Mock<IRepository<Usuario>>();
            usuarioRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Usuario>() { expectedUsuario }.AsQueryable());
            unitWorkMock.SetupGet(mock => mock.RepositoryUsuario).Returns(usuarioRepositoryMock.Object);
            UsuariosController usuariosController = new UsuariosController(unitWorkMock.Object);
            Usuario returnedValue = usuariosController.ObterPorId(0);
            Assert.Equal(expectedUsuario.Email, returnedValue.Email);
            Assert.Equal(expectedUsuario.Senha, returnedValue.Senha);
        }
        [Fact]
        public void RetornaNuloDadoQueNaoEncontraNenhumUsuarioCadastradoParaOIdPassado()
        {
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Usuario>> usuarioRepositoryMock = new Mock<IRepository<Usuario>>();
            usuarioRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Usuario>().AsQueryable());
            unitWorkMock.SetupGet(mock => mock.RepositoryUsuario).Returns(usuarioRepositoryMock.Object);
            UsuariosController usuariosController = new UsuariosController(unitWorkMock.Object);
            Usuario returnedValue = usuariosController.ObterPorId(0);
            Assert.Null(returnedValue);
        }
    }
}