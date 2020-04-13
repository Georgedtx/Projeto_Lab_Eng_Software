using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Moq;
using Xunit;
namespace UnitTests.DomainTests.ControllersTests.ExamesControllerTests
{
    public class CadastrarTests
    {
        [Fact]
        public void CadastraUmNovoExameCorretamenteDadoUmObjetoExameValido()
        {
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Exame>> exameRepositoryMock = new Mock<IRepository<Exame>>();
            unitWorkMock.Setup(mock => mock.Commit()).Returns(true);
            exameRepositoryMock.Setup(mock => mock.Adicionar(It.IsAny<Exame>()));
            unitWorkMock.SetupGet(mock => mock.RepositoryExame).Returns(exameRepositoryMock.Object);
            string nome = "Mamografia";
            string descricao = "Exame de rastreio por imagem, que tem como finalidade estudar o tecido mamário.";
            Exame exame = new Exame(nome, descricao);
            ExamesController examesController = new ExamesController(unitWorkMock.Object);
            examesController.Cadastrar(exame);
            unitWorkMock.Verify(mock => mock.Commit(), Times.Exactly(1));
        }
    }
}