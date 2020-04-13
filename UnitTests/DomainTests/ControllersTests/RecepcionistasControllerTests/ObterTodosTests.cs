using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UnitTests.DomainTests.ControllersTests.RecepcionistasControllerTests
{
    public class ObterTodosTests
    {
        [Fact]
        public void ObetemUmRecepcionistaDadoUmConjuntoDeRecepcionistasCadastrado()
        {
            string nome = "Kevin Calebe da Mata";
            DateTime nascimento = new DateTime(year: 1940, month: 2, day: 12);
            int idUsuario = 0;
            Recepcionista expectedRecepcionista = new Recepcionista(nome, nascimento, idUsuario);
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Recepcionista>> recepcionistaRepositoryMock = new Mock<IRepository<Recepcionista>>();
            recepcionistaRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Recepcionista>() { expectedRecepcionista }.AsQueryable());
            unitWorkMock.SetupGet(mock => mock.RepositoryRecepcionista).Returns(recepcionistaRepositoryMock.Object);
            RecepcionistasController recepcionistasController = new RecepcionistasController(unitWorkMock.Object);
            List<Recepcionista> returnedValues = recepcionistasController.ObterTodos();
            Assert.Contains(expectedRecepcionista, returnedValues);
        }
        [Fact]
        public void RetornaNuloDadoQueNaoEncontraNenhumRecepcionistaCadastradoNoConjuntoDeRecepcionista()
        {
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Recepcionista>> recepcionistaRepositoryMock = new Mock<IRepository<Recepcionista>>();
            recepcionistaRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Recepcionista>().AsQueryable());
            unitWorkMock.SetupGet(mock => mock.RepositoryRecepcionista).Returns(recepcionistaRepositoryMock.Object);
            RecepcionistasController recepcionistasController = new RecepcionistasController(unitWorkMock.Object);
            List<Recepcionista> returnedValues = recepcionistasController.ObterTodos();
            Assert.Empty(returnedValues);
        }
    }
}
