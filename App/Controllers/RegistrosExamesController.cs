using App.ViewModels.RegistrosExames;
using Domain.Entities;
using Domain.Interfaces.Uow;
using Domain.Relatorios;
using FluentValidation.Results;
using Ninject;
using System;
using System.Collections.Generic;

namespace App.Controllers
{
    public class RegistrosExamesController
    {
        private readonly IUnitOfWork _unitOfWork;

        [Inject()]
        public RegistrosExamesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ValidationResult RegistrarExame(RegistrosExamesAdicionar registroExame)
        {
            if (!registroExame.IsValid()) return registroExame.Validation;

            registroExame.Validation = new RegistroExameVerification(_unitOfWork).Validate(registroExame);

            if (registroExame.Validation.IsValid)
            {
                //var registro = new PedidoExame (registroExame.Id);
                //registro.IdResidente = registroExame.IdResidente;
                //registro.Laudo = registroExame.Laudo;
                //_unitOfWork.RepositoryRegistroExame.Adicionar(registro);
                //_unitOfWork.Commit();
            }

            return registroExame.Validation;


        }

        public RegistroExame EmitirLaudo(string CrmMedico, Guid IdExame, string laudo)
        {
            var exame = BuscarPedidoExamePorId(IdExame);

            if (exame == null) throw new Exception("Exame não Encontrado");

            var medico = BuscarMedicoPorCrm(CrmMedico);

            if (medico == null) throw new Exception("Médico não encontrado"); 

            var registro = new RegistroExame(IdExame);
            
            registro.EmitirLaudo(medico.Id, laudo);

            return registro;

        }

        private Medico BuscarMedicoPorCrm(string crm)
        {
            return _unitOfWork.RepositoryMedico.ObterPorCrm(crm);
        }

        private PedidoExame BuscarPedidoExamePorId(Guid id)
        {
            return _unitOfWork.RepositoryPedidoExame.ObterPorId(id);
        }

        //private string AddImagem(IFormFile arquivo)
        //{
        //    string nomeArquivo = "";
        //    var caminho = "~/Uploads/Imagens/";

        //    if (arquivo != null && arquivo.Length > 0)
        //    {
        //        if (!Directory.Exists(caminho))
        //        {
        //            Directory.CreateDirectory(caminho);
        //        }

        //        nomeArquivo = Guid.NewGuid().ToString() + Path.GetExtension(arquivo.FileName);
        //        caminho = caminho + nomeArquivo;

        //        using (var stream = new FileStream(caminho, FileMode.Create))
        //        {
        //            arquivo.CopyTo(stream);
        //        }
        //    }
        //    return nomeArquivo;
        //}


        //public void adicionarImagem(IFormFileCollection arquivos, Guid idExame)
        //{
        //    var exame = BuscarPedidoExamePorId(IdExame);

        //    if (exame == null) throw new Exception("Exame não Encontrado");

        //    var caminho = "~/Uploads/Imagens/";

        //    foreach (var arquivo in arquivos)
        //    {
        //        var nomeArquivo = AddImagem(arquivo);

        //        var arquivo = new Arquivo(nomeArquivo, caminho + nomeArquivo, exame.Id);

        //        _unitOfWork.RepositoryArquivo.Adicionar(arquivo);
        //        _unitOfWork.Commit();
        //    }

        //    var registro = new RegistroExame(exame.Id);

        //    registro.Arquivo = arquivos;

        //    _unitOfWork.RepositoryRegistroExame.Adicionar(registro);
        //    _unitOfWork.Commit();
        //}
    }
}