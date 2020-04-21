using App.Controllers;
using Bogus;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
using FluentAssertions;
using Moq.AutoMock;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UnitTests.Usuarios
{
    public class UsuarioTestes
    {
        [Fact(DisplayName = "Cadastrar um usuário com email inválido")]
        [Trait("Usuarios", "Controller")]
        public void CadastrarUsuario_UsuarioDeveTerEmailValido_False()
        {
            // Arrenge
            var controller = new AutoMocker().CreateInstance<UsuariosController>();
            var usuario = new Usuario("abcd.abcd.com", "Abcd2020");

            // Action
            var result = controller.Cadastrar(usuario);

            // Assert
            result.Validation.Erros.Should().HaveCount(1);
            result.Validation.Erros.Select(v => v.Message).Should().Contain("Email inválido!");
        }

        [Fact(DisplayName = "Cadastrar um usuário com senha inválida")]
        [Trait("Usuarios", "Controller")]
        public void CadastrarUsuario_UsuarioDeveTerSenhaValida_False()
        {
            // Arrenge
            var controller = new AutoMocker().CreateInstance<UsuariosController>();
            var usuario = new Usuario("luis@hotmail.com", "1234567");

            // Action
            var result = controller.Cadastrar(usuario);

            // Arrenge
            result.Validation.Erros.Should().HaveCount(1);
            result.Validation.Erros.Select(v => v.Message).Should().Contain("Senha deve ter conter letras e números!");
        }

        [Fact(DisplayName = "Cadastrar um usuário com email já utilizado")]
        [Trait("Usuarios", "Controller")]
        public void CadastrarUsuario_UsuarioDeveTerEmailUnico_False()
        {
            // Arrenge
            var usuarios = ObterTodos();
            var emailExistente = usuarios.Where(u => u.Id == 5).FirstOrDefault().Email;
            var usuario = new Usuario(emailExistente, "Senha2020");
            var mocker = new AutoMocker();
            var controller = mocker.CreateInstance<UsuariosController>();
            mocker.GetMock<IUnitOfWork>().Setup(u => u.RepositoryUsuario).Returns(mocker.GetMock<IRepository<Usuario>>().Object);
            mocker.GetMock<IRepository<Usuario>>().Setup(r => r.ObterTodos()).Returns(usuarios);

            // Action
            var result = controller.Cadastrar(usuario);

            // Assert
            result.Validation.Erros.Should().HaveCount(1);
            result.Validation.Erros.Select(v => v.Message).Should().Contain("Email já utilizado por outro usuário!");
        }

        [Fact(DisplayName = "Cadastrar um usuário com email e senha válidos")]
        [Trait("Usuarios", "Controller")]
        public void CadastrarUsuario_UsuarioDeveTerEmailESenhaValidos_True()
        {
            // Arrenge
            var usuarios = ObterTodos();
            var usuario = new Usuario("luis@hotmail.com", "Luis2020");
            var mocker = new AutoMocker();
            var controller = mocker.CreateInstance<UsuariosController>();
            mocker.GetMock<IUnitOfWork>().Setup(u => u.RepositoryUsuario).Returns(mocker.GetMock<IRepository<Usuario>>().Object);
            mocker.GetMock<IRepository<Usuario>>().Setup(r => r.ObterTodos()).Returns(usuarios);

            // Action
            var result = controller.Cadastrar(usuario);

            // Assert
            result.Validation.Erros.Select(v => v.Message).Should().BeEmpty();
        }

        [Fact(DisplayName = "Alterar a senha de um usuário com senha inválida")]
        [Trait("Usuarios", "Controller")]
        public void AlterarSenha_UsuarioDeveTerSenhaValida_False()
        {
            // Arrenge

            // Action

            // Assert
        }

        [Fact(DisplayName = "Alterar a senha de um usuário com senha válida")]
        [Trait("Usuarios", "Controller")]
        public void AlterarSenha_UsuarioDeveTerSenhaValida_True()
        {
            // Arrenge

            // Action

            // Assert
        }

        public List<Usuario> ObterTodos()
        {
            var usuarios = new Faker<Usuario>("pt_BR")
                .CustomInstantiator(f =>
                new Usuario(
                    f.Internet.Email(),
                    f.Internet.Password(10, false, "", "20")
                    )).RuleFor(c => c.Id, (f, c) => f.IndexGlobal);
            
            return usuarios.Generate(10);
        }
    }
}
