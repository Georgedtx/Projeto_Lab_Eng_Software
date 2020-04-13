using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Moq;
using Xunit;
namespace UnitTests.DomainTests.ControllersTests.UsuariosControllerTests
{
    public class AlterarSenhaTests
    {
        [Fact]
        public void DadoIdDeUsuarioCadastradoQuandoAlterarSenhaEntaoRetornaVerdadeiro()
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
            string novaSenha = "1qa2w2s3edc4r4f4v";
            int idUsuario = 0;
            usuariosController.AlterarSenha(idUsuario, novaSenha);
        }
    }
}