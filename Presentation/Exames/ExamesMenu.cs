using App.Controllers;
using App.ExtensionsMethods;
using App.ViewModels.PedidosExames;
using FontAwesome.Sharp;
using Infra.IoC;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation.Exames

{
    public partial class ExamesMenu : Form
    {
        // campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private readonly PedidosExamesController _pedidosExamesController;
        private readonly PacientesController _pacientesController;
        private readonly ExamesController _examesController;
        private Guid IdPaciente;
        private Guid IdExame;

        public ExamesMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //esconde barra
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            _pedidosExamesController = DependenciesResolve.Resolve<PedidosExamesController>();
            _pacientesController = DependenciesResolve.Resolve<PacientesController>();
            _examesController = DependenciesResolve.Resolve<ExamesController>();
            AtualizarDataGrid();
        }

        private void AtualizarDataGrid()
        {
            //listaExames.DataSource = _exameController.ObterTodos()
            //    .Select(e => new { Id = e.Id, Nome = e.Nome });
            //ListaPedidosExame.DataSource = _pedidosExamesController.ObterPedidosExamesDoPaciente(BuscarCPF.Text)
            //.Select(m => new { Exame = m.Exame , Hipótese = m.Hipotese}); 
        }
        private void Emitir_Click(object sender, EventArgs e)
        {
            var pedido = new PedidoExameAdicionar
            {
                DataEmissao = DateTime.Now,
                DataRealizacao = ObterData(),
                IdExame = IdExame,
                Exame = CampoExame.Text,

                Crm = CampoCrm.Text,
                Hipotese = CampoRecomendacoes.Text,
                Recomendacoes = CampoRecomendacoes.Text,

                IdPaciente = IdPaciente,
                NomePaciente = CampoNome.Text,
                IdadePaciente = Convert.ToInt32(CampoIdade.Text),
                SexoPaciente = CampoSexo.Text,
            };

            var result = _pedidosExamesController.EmitirPedidoExame(pedido);

            if (!result.IsValid)
            {
                MessageBox.Show(result.Errors.Select(v =>
                                v.ErrorMessage).Concatenar());
                return;
            }

            LimparCampos();
            AtualizarDataGrid();
            MessageBox.Show("Pedido cadastrado com sucesso");
        }
        private void CampoCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            string campCPF = removerMascaraCPF(CampoCPF.Text);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (campCPF != string.Empty)
                {
                    try
                    {
                        var paciente = _pacientesController.ObterPorCpf(campCPF);
                        CampoNome.Text = paciente.Nome.ToString();
                        CampoSexo.Text = paciente.Sexo;
                        CampoIdade.Text = IdadePaciente(paciente.Nascimento);
                        CampoCor.Text = paciente.Cor;
                        IdPaciente = paciente.Id;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Digite o CPF");
                }
            }           
        }
        private void listaExames_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listaExames.SelectedRows.Count > 0)
            {
                CampoExame.Text = listaExames.CurrentRow.Cells["Nome"].Value.ToString();
                string stringGuid = listaExames.CurrentRow.Cells["Id"].Value.ToString();
                IdExame = Guid.Parse(stringGuid);
            }
            else
            {
                MessageBox.Show("Selecione uma linha.");
            }
        }
        private string removerMascaraCPF(string cpf)
        {
            if (cpf.Length == 14)
            {
                cpf = cpf.Remove(3, 1);
                cpf = cpf.Remove(6, 1);
                cpf = cpf.Remove(9, 1);
                return cpf;

            }
            else
            {
                cpf = string.Empty;
                return cpf;
            }
        }
        private string IdadePaciente(DateTime nascimento)
        {
            int idade = DateTime.Now.Year - nascimento.Year;
            if (DateTime.Now.DayOfYear < nascimento.DayOfYear) idade--;
            return idade.ToString();
        }
        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (BuscarCPF.Text != string.Empty)
            {
                if (CampoData2.Text != string.Empty)
                {
                    _pedidosExamesController.RemarcarConsulta(IdExame, NovaData());
                    LimparCampos2();
                    AtualizarDataGrid();
                    MessageBox.Show("Pedido atualizado com sucesso");
                }
                else MessageBox.Show("Digite a Data");

            }
            else MessageBox.Show("Digite o CPF");
        }
        private void BuscarCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            string campCPF = removerMascaraCPF(BuscarCPF.Text);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (campCPF != string.Empty)
                {
                    try
                    {
                        var paciente = _pacientesController.ObterPorCpf(BuscarCPF.Text);
                        CampoNome.Text = paciente.Nome.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Digite o CPF");
                }
            }           
        }
        private void ListaPedidosExame_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListaPedidosExame.SelectedRows.Count > 0)
            {
                CampoExame2.Text = ListaPedidosExame.CurrentRow.Cells["Exame"].Value.ToString();
                CampoHipotese2.Text = ListaPedidosExame.CurrentRow.Cells["Hipótese"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecione uma linha.");
            }
        }
        private DateTime NovaData()
        {
            if (CampoData2.Text.Length == 10)
            {
                var dia = Convert.ToInt16(CampoData2.Text.Substring(0, 2));
                var mes = Convert.ToInt16(CampoData2.Text.Substring(3, 2));
                var ano = Convert.ToInt16(CampoData2.Text.Substring(6, 4));

                return new DateTime(ano, mes, dia);
            }

            return new DateTime();
        }
        private DateTime ObterData()
        {
            if (CampoDataRealizacao.Text.Length == 10)
            {
                var dia = Convert.ToInt16(CampoDataRealizacao.Text.Substring(0, 2));
                var mes = Convert.ToInt16(CampoDataRealizacao.Text.Substring(3, 2));
                var ano = Convert.ToInt16(CampoDataRealizacao.Text.Substring(6, 4));

                return new DateTime(ano, mes, dia);
            }

            return new DateTime();
        }
        private void LimparCampos()
        {
            CampoCPF.Clear();
            CampoCor.Clear();
            CampoSexo.Clear();
            CampoNome.Clear();
            CampoIdade.Clear();
            CampoExame.Clear();
            CampoDataRealizacao.Clear();
            CampoCrm.Clear();
            CampoRecomendacoes.Clear();
        }
        private void LimparCampos2()
        {
            CampoCPF.Clear();
            CampoNome.Clear();
            CampoExame.Clear();
            CampoData2.Clear();
            CampoRecomendacoes.Clear();
        }
        // estrutura
        private struct CorRGB
        {
            public static Color cor1 = Color.FromArgb(172, 126, 241);
            public static Color cor2 = Color.FromArgb(249, 118, 176);
            public static Color cor3 = Color.FromArgb(253, 138, 114);
            public static Color cor4 = Color.FromArgb(95, 77, 221);
            public static Color cor5 = Color.FromArgb(249, 88, 155);
            public static Color cor6 = Color.FromArgb(24, 161, 251);
        }

        // metodos
        private void ActivateButton(object senderBtn, Color cor)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = cor;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = cor;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // borda esquerda butao
                leftBorderBtn.BackColor = cor;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icone do filho atual
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = cor;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.BlueViolet;
            lblTitleChildForm.Text = "Home";
        }

        //logo
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        // funcao arrastar janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void painelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exames_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, CorRGB.cor6);
            //    OpenChildForm(new AdmTelaExames());
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //   RegistroExamesPopUp reg = new RegistroExamesPopUp();
            //   reg.caixaStatus.Text =
            //   reg.caixaData.Mask =
            //    reg.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparCampos2();
        }
    }
}
