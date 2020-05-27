using App.Controllers;
using Infra.IoC;
using Presentation.Administradores;
using Presentation.Médico;
using Presentation.Recepcionista;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Presentation.Usuarios
{
    public partial class Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private readonly UsuariosController _usuariosController;
        private readonly MedicosController _medicosController;
        private readonly RecepcionistasController _recepcionistasController;
        private readonly AdministradoresController _administradoresController;
        public Login()
        {
            InitializeComponent();

            _usuariosController = DependenciesResolve.Resolve<UsuariosController>();
            _medicosController = DependenciesResolve.Resolve<MedicosController>();
            _recepcionistasController = DependenciesResolve.Resolve<RecepcionistasController>();
            _administradoresController = DependenciesResolve.Resolve<AdministradoresController>();

            //esconde barra
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EntrarLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != string.Empty && txtSenha.Text != string.Empty)
            {             
                try
                {
                    var usuario = _usuariosController.Autenticar(txtUsuario.Text, txtSenha.Text);
                    var recepcionista = _recepcionistasController.ObterPorEmail(txtUsuario.Text);
                    if (recepcionista != null)
                    {
                        new RecMenuPrincipal().Show();
                        this.Hide();
                    }
                    var medico = _medicosController.ObterPorEmail(txtUsuario.Text);
                    if (medico != null)
                    {
                        new TelaMedPrincipal().Show();
                        this.Hide();
                    }
                    var adm = _administradoresController.ObterPorEmail(txtUsuario.Text);
                    if (adm != null)
                    {
                        new AdmMenuPrincipal().Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtUsuario.Clear();
                txtSenha.Clear();
            }
            else
            {
                MessageBox.Show("Campo Usuáio e Senha são obrigatórios");
                txtUsuario.Clear();
                txtSenha.Clear();
            }
        }

        private void panelDesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
