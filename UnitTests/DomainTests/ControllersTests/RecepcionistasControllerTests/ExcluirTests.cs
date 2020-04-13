using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Moq;
using System;
using Xunit;

namespace UnitTests.DomainTests.ControllersTests.RecepcionistasControllerTests
{
    public class ExcluirTests
    {
        [Fact]
        public void ExcluiUmRecepcionistaDadoUmIdDeUmRecepcionistaCadastrado()
        {
            string nome = "Isabela Flávia Almada";
            DateTime nascimento = new DateTime(year: 1960, month: 10, day: 4);
            int idUsuario = 0;
            Recepcionista expectedRecepcionista = new Recepcionista(nome, nascimento, idUsuario);
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Recepcionista>> recepcionistaRepositoryMock = new Mock<IRepository<Recepcionista>>();
            recepcionistaRepositoryMock.Setup(mock => mock.Remover(expectedRecepcionista));
            unitWorkMock.SetupGet(mock => mock.RepositoryRecepcionista).Returns(recepcionistaRepositoryMock.Object);
            RecepcionistasController recepcionistasController = new RecepcionistasController(unitWorkMock.Object);
            Recepcionista returnedValue = recepcionistasController.ObterPorId(0);
            Assert.Null(returnedValue);
        }
    }
}
