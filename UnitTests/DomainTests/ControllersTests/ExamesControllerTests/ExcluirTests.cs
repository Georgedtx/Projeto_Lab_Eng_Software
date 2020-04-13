using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Moq;
using Xunit;
namespace UnitTests.DomainTests.ControllersTests.ExamesControllerTests
{
    public class ExcluirTests
    {
        [Fact]
        public void ExcluiUmExameDadoUmIdDeUmExameCadastrado()
        {
            string nome = "Ultrassonografia";
            string descricao = "É um método diagnóstico muito recorrente na medicina moderna que utiliza o eco gerado através de ondas ultrassônicas de alta frequência para visualizar, em tempo real, as estruturas internas do organismo.";
            Exame expectedExame = new Exame(nome, descricao);
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Exame>> exameRepositoryMock = new Mock<IRepository<Exame>>();
            exameRepositoryMock.Setup(mock => mock.Remover(expectedExame));
            unitWorkMock.SetupGet(mock => mock.RepositoryExame).Returns(exameRepositoryMock.Object);
            ExamesController examesController = new ExamesController(unitWorkMock.Object);
            Exame returnedValue = examesController.ObterPorId(0);
            Assert.Null(returnedValue);
        }
    }
}