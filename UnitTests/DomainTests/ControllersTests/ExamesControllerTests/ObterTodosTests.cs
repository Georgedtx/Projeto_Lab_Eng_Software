﻿using Domain.Controllers;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;
namespace UnitTests.DomainTests.ControllersTests.ExamesControllerTests
{
    public class ObterTodosTests
    {
        [Fact]
        public void ObetemUmExameDadoUmConjuntoDeExamesCadastrado()
        {
            string nome = "Ressonância Magnética";
            string descricao = "Técnica de imagem médica usada em radiologia para formar imagens da anatomia e dos processos fisiológicos do corpo, tanto na saúde como na doença.";
            Exame expectedExame = new Exame(nome, descricao);
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Exame>> exameRepositoryMock = new Mock<IRepository<Exame>>();
            exameRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Exame>() { expectedExame }.AsQueryable());
            unitWorkMock.SetupGet(mock => mock.RepositoryExame).Returns(exameRepositoryMock.Object);
            ExamesController examesController = new ExamesController(unitWorkMock.Object);
            IEnumerable<Exame> returnedValues = examesController.ObterTodos();
            Assert.Contains(expectedExame, returnedValues);
        }
        [Fact]
        public void RetornaNuloDadoQueNaoEncontraNenhumExameCadastradoNoConjuntoDeExame()
        {
            Mock<IUnitOfWork> unitWorkMock = new Mock<IUnitOfWork>();
            Mock<IRepository<Exame>> exameRepositoryMock = new Mock<IRepository<Exame>>();
            exameRepositoryMock.Setup(mock => mock.Obter()).Returns(new List<Exame>().AsQueryable());
            unitWorkMock.SetupGet(mock => mock.RepositoryExame).Returns(exameRepositoryMock.Object);
            ExamesController examesController = new ExamesController(unitWorkMock.Object);
            IEnumerable<Exame> returnedValues = examesController.ObterTodos();
            Assert.Empty(returnedValues);
        }
    }
}