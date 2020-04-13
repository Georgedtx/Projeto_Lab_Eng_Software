using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Moq;
using System;
using Xunit;
namespace UnitTests.DomainTests.ControllersTests.RecepcionistasControllerTests
{
    public class CadastrarTests
    {
        [Fact]
        public void CadastraUmNovoRecepcionistaCorretamenteDadoUmObjetoRecepcionistaValido()
        {
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Recepcionista>> recepcionistaRepositoryMock = new Mock<IRepository<Recepcionista>>();
            unitWorkMock.Setup(mock => mock.Commit()).Returns(true);
            recepcionistaRepositoryMock.Setup(mock => mock.Adicionar(It.IsAny<Recepcionista>()));
            unitWorkMock.SetupGet(mock => mock.RepositoryRecepcionista).Returns(recepcionistaRepositoryMock.Object);
            string nome = "Juliana Carolina Nogueira";
            DateTime nascimento = new DateTime(year: 1990, month: 1, day: 12);
            int idUsuario = 0;
            Recepcionista recepcionista = new Recepcionista(nome, nascimento, idUsuario);
            RecepcionistasController recepcionistasController = new RecepcionistasController(unitWorkMock.Object);
            recepcionistasController.Cadastrar(recepcionista);
            unitWorkMock.Verify(mock => mock.Commit(), Times.Exactly(1));
        }
    }
}