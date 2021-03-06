﻿using App.Controllers;
using App.ExtensionsMethods;
using App.ViewModels.Medicos;
using FluentValidation.Results;
using Infra.IoC;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Presentation.Administradores
{
    public partial class AdmTelaMed : Form
    {
        private readonly MedicosController _medicosController;

        public AdmTelaMed()
        {
            InitializeComponent();
            _medicosController = DependenciesResolve.Resolve<MedicosController>();

            AtualizarDataGrid();
        }

        private void AtualizarDataGrid()
        {
            var data = from info in _medicosController.ObterTodos()
                       orderby info.Nome
                       select new
                       {
                           Nome = info.Nome,
                           CRM = info.Crm
                       };
            listaMedicos.DataSource = data.ToList();          
        }
        private void checkResidente_CheckedChanged(object sender, EventArgs e)
        {
            checkResidente.Checked = false;
            txtTitulo.Enabled = false;
            txtAnoResidencia.Enabled = true;
        }
        private void checkDocente_CheckedChanged(object sender, EventArgs e)
        {
            checkDocente.Checked = false;
            txtTitulo.Enabled = true;
            txtAnoResidencia.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ValidationResult validation;

            if (checkResidente.Checked && txtTitulo.SelectedItem != null)
            {
                validation = AdicionarDocente();
            }
            else if (checkResidente.Checked && txtAnoResidencia != null)
            {
                validation = AdicionarResidente();
            }
            else
            {
                validation = AdicionarMedico();
            }

            if (!validation.IsValid)
            {
                MessageBox.Show(validation.Errors.Select(v => v.ErrorMessage).Concatenar());
                return;
            }

            MessageBox.Show("Médico adicionado com sucesso");
            LimparCampos();
            AtualizarDataGrid();
        }
        private ValidationResult AdicionarMedico()
        {
            var medico = new MedicoAdicionar
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                RepetirSenha = txtMesmaSenha.Text,
                Nome = txtNome.Text,
                Crm = txtCrm.Text
            };

            var result = _medicosController.Cadastrar(medico);

            return result;
        }

        private ValidationResult AdicionarResidente()
        {
            var residente = new ResidenteAdicionar
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                RepetirSenha = txtMesmaSenha.Text,
                Nome = txtNome.Text,
                Crm = txtCrm.Text,
                AnoResidencia = Convert.ToInt32(txtAnoResidencia.Text)
            };

            var result = _medicosController.CadastrarResidente(residente);

            return result;
        }

        private ValidationResult AdicionarDocente()
        {
            var docente = new DocenteAdicionar
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                RepetirSenha = txtMesmaSenha.Text,
                Nome = txtNome.Text,
                Crm = txtCrm.Text,
                TitUniversitaria = txtTitulo.SelectedItem.ToString()
            };

            var result = _medicosController.CadastrarDocente(docente);

            return result;
        }

        private void LimparCampos()
        {
            txtEmail.Clear();
            txtSenha.Clear();
            txtMesmaSenha.Clear();
            txtNome.Clear();
            txtCrm.Clear();
            checkResidente.Checked = false;
            checkResidente.Checked = false;
            txtAnoResidencia.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
