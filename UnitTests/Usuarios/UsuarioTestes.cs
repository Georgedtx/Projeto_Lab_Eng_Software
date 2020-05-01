using App.Controllers;
using Bogus;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Uow;
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
            //var result = controller.Cadastrar(usuario);

            // Assert
            //result.Validation.Errors.Should().HaveCount(1);
            //result.Validation.Errors.Select(v => v.ErrorMessage).Should().Contain("Email válido deve ser informado");
        }

        [Fact(DisplayName = "Cadastrar um usuário com senha inválida")]
        [Trait("Usuarios", "Controller")]
        public void CadastrarUsuario_UsuarioDeveTerSenhaValida_False()
        {
            // Arrenge
            var controller = new AutoMocker().CreateInstance<UsuariosController>();
            var usuario = new Usuario("luis@hotmail.com", "1234567");

            // Action
            //var result = controller.Cadastrar(usuario);

            // Arrenge
            //result.Validation.Errors.Should().HaveCount(1);
            //result.Validation.Errors.Select(v => v.ErrorMessage).Should().Contain("Informe uma senha de 8 a 10 caracteres incluindo letras maiúsculas, minúsculas e números");
        }

        [Fact(DisplayName = "Cadastrar um usuário com email já utilizado")]
        [Trait("Usuarios", "Controller")]
        public void CadastrarUsuario_UsuarioDeveTerEmailUnico_False()
        {
            // Arrenge
            var usuarios = ObterTodos();
            var usuarioExistente = usuarios.FirstOrDefault();
            var usuario = new Usuario(usuarioExistente.Email, "Senha2020");
            var mocker = new AutoMocker();
            var controller = mocker.CreateInstance<UsuariosController>();
            mocker.GetMock<IUnitOfWork>().Setup(u => u.RepositoryUsuario).Returns(mocker.GetMock<IRepositoryUsuario>().Object);
            mocker.GetMock<IRepositoryUsuario>().Setup(r => r.ObterTodos()).Returns(usuarios);

            // Action
            //var result = controller.Cadastrar(usuario);

            // Assert
            //result.Validation.Errors.Should().HaveCount(1);
            //result.Validation.Errors.Select(v => v.ErrorMessage).Should().Contain("Email de usuário já utilizado");
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
            mocker.GetMock<IUnitOfWork>().Setup(u => u.RepositoryUsuario).Returns(mocker.GetMock<IRepositoryUsuario>().Object);
            mocker.GetMock<IRepositoryUsuario>().Setup(r => r.ObterTodos()).Returns(usuarios);

            // Action
            //var result = controller.Cadastrar(usuario);

            // Assert
            //result.Validation.Errors.Select(v => v.ErrorMessage).Should().BeEmpty();
        }

        [Fact(DisplayName = "Alterar a senha de um usuário com senha inválida")]
        [Trait("Usuarios", "Controller")]
        public void AlterarSenha_UsuarioDeveTerSenhaValida_False()
        {
            // Arrenge
            var usuarios = ObterTodos();
            var usuario = usuarios.FirstOrDefault();
            var mocker = new AutoMocker();
            var controller = mocker.CreateInstance<UsuariosController>();
            mocker.GetMock<IUnitOfWork>().Setup(u => u.RepositoryUsuario).Returns(mocker.GetMock<IRepositoryUsuario>().Object);
            mocker.GetMock<IRepositoryUsuario>().Setup(r => r.ObterPorId(usuario.Id)).Returns(usuario);

            // Action
            var result = controller.AlterarSenha(usuario.Id, "123luis");

            // Assert
            //result.Validation.Errors.Should().HaveCount(1);
            //result.Validation.Errors.Select(v => v.ErrorMessage).Should().Contain("Informe uma senha de 8 a 10 caracteres incluindo letras maiúsculas, minúsculas e números");
        }

        [Fact(DisplayName = "Alterar a senha de um usuário com senha válida")]
        [Trait("Usuarios", "Controller")]
        public void AlterarSenha_UsuarioDeveTerSenhaValida_True()
        {
            // Arrenge
            var usuarios = ObterTodos();
            var usuario = usuarios.FirstOrDefault();
            var mocker = new AutoMocker();
            var controller = mocker.CreateInstance<UsuariosController>();
            mocker.GetMock<IUnitOfWork>().Setup(u => u.RepositoryUsuario).Returns(mocker.GetMock<IRepositoryUsuario>().Object);
            mocker.GetMock<IRepositoryUsuario>().Setup(r => r.ObterPorId(usuario.Id)).Returns(usuario);

            // Action
            var result = controller.AlterarSenha(usuario.Id, "12345Luis");

            // Assert
            //result.Validation.Errors.Should().BeEmpty();
            Assert.Equal("12345Luis", usuario.Senha);
        }

        public List<Usuario> ObterTodos()
        {
            var usuarios = new Faker<Usuario>("pt_BR")
                .CustomInstantiator(f =>
                new Usuario(
                    f.Internet.Email(),
                    f.Internet.Password(10, false, "", "20")));
            
            return usuarios.Generate(10);
        }
    }
}
