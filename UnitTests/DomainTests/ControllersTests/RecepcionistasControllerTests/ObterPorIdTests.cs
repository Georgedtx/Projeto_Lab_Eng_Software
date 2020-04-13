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
    public class ObterPorIdTests
    {
        [Fact]
        public void ObetemUmRecepcionistaDadoUmIdDeUmRecepcionistaCadastrado()
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
            Recepcionista returnedValue = recepcionistasController.ObterPorId(0);
            Assert.Equal(expectedRecepcionista.Nome, returnedValue.Nome);
            Assert.Equal(expectedRecepcionista.Nascimento, returnedValue.Nascimento);
            Assert.Equal(expectedRecepcionista.IdUsuario, returnedValue.IdUsuario);
        }
        [Fact]
        public void RetornaNuloDadoQueNaoEncontraNenhumRecepcionistaCadastradoParaOIdPassado()
        {
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Recepcionista>> recepcionistaRepositoryMock = new Mock<IRepository<Recepcionista>>();
            recepcionistaRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Recepcionista>().AsQueryable());
            unitWorkMock.SetupGet(mock => mock.RepositoryRecepcionista).Returns(recepcionistaRepositoryMock.Object);
            RecepcionistasController recepcionistasController = new RecepcionistasController(unitWorkMock.Object);
            Recepcionista returnedValue = recepcionistasController.ObterPorId(0);
            Assert.Null(returnedValue);
        }
    }
}