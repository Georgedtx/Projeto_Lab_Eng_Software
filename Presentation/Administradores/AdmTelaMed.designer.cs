namespace Presentation.Administradores
{
    partial class AdmTelaMed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detalhes = new System.Windows.Forms.TabPage();
            this.textDetalhes = new System.Windows.Forms.TextBox();
            this.Medicos = new System.Windows.Forms.TabPage();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ListarMedicos = new System.Windows.Forms.DataGridView();
            this.AbasMedicos = new System.Windows.Forms.TabControl();
            this.NovoMedico = new System.Windows.Forms.TabPage();
            this.Senha = new System.Windows.Forms.Label();
            this.CRM = new System.Windows.Forms.Label();
            this.TitUni = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.AnoResidencia = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCRM = new System.Windows.Forms.MaskedTextBox();
            this.TituloUni = new System.Windows.Forms.ComboBox();
            this.BoxSenha = new System.Windows.Forms.MaskedTextBox();
            this.textNascimento = new System.Windows.Forms.MaskedTextBox();
            this.ResidenteButton = new System.Windows.Forms.RadioButton();
            this.DocenteButton = new System.Windows.Forms.RadioButton();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.NomeMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRMmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitUniMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnoResidenciaMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalhes.SuspendLayout();
            this.Medicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListarMedicos)).BeginInit();
            this.AbasMedicos.SuspendLayout();
            this.NovoMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // Detalhes
            // 
            this.Detalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.Detalhes.Controls.Add(this.textDetalhes);
            this.Detalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detalhes.Location = new System.Drawing.Point(4, 25);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Padding = new System.Windows.Forms.Padding(3);
            this.Detalhes.Size = new System.Drawing.Size(1250, 569);
            this.Detalhes.TabIndex = 2;
            this.Detalhes.Text = "Detalhes";
            // 
            // textDetalhes
            // 
            this.textDetalhes.Dock = System.Windows.Forms.DockStyle.Top;
            this.textDetalhes.Location = new System.Drawing.Point(3, 3);
            this.textDetalhes.Multiline = true;
            this.textDetalhes.Name = "textDetalhes";
            this.textDetalhes.ReadOnly = true;
            this.textDetalhes.Size = new System.Drawing.Size(1244, 375);
            this.textDetalhes.TabIndex = 0;
            // 
            // Medicos
            // 
            this.Medicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.Medicos.Controls.Add(this.iconPictureBox1);
            this.Medicos.Controls.Add(this.ListarMedicos);
            this.Medicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicos.Location = new System.Drawing.Point(4, 25);
            this.Medicos.Name = "Medicos";
            this.Medicos.Padding = new System.Windows.Forms.Padding(3);
            this.Medicos.Size = new System.Drawing.Size(1250, 569);
            this.Medicos.TabIndex = 0;
            this.Medicos.Text = "Medicos";
            this.Medicos.Click += new System.EventHandler(this.Medicos_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Heartbeat;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconSize = 237;
            this.iconPictureBox1.Location = new System.Drawing.Point(1010, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(237, 563);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // ListarMedicos
            // 
            this.ListarMedicos.AllowUserToAddRows = false;
            this.ListarMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListarMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeMD,
            this.EmailMD,
            this.CRMmd,
            this.TitUniMed,
            this.AnoResidenciaMed});
            this.ListarMedicos.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListarMedicos.Location = new System.Drawing.Point(3, 3);
            this.ListarMedicos.Name = "ListarMedicos";
            this.ListarMedicos.RowHeadersWidth = 51;
            this.ListarMedicos.RowTemplate.Height = 24;
            this.ListarMedicos.Size = new System.Drawing.Size(1001, 563);
            this.ListarMedicos.TabIndex = 2;
            this.ListarMedicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AbasMedicos
            // 
            this.AbasMedicos.Controls.Add(this.Medicos);
            this.AbasMedicos.Controls.Add(this.NovoMedico);
            this.AbasMedicos.Controls.Add(this.Detalhes);
            this.AbasMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AbasMedicos.ItemSize = new System.Drawing.Size(64, 21);
            this.AbasMedicos.Location = new System.Drawing.Point(0, 0);
            this.AbasMedicos.Name = "AbasMedicos";
            this.AbasMedicos.SelectedIndex = 0;
            this.AbasMedicos.Size = new System.Drawing.Size(1258, 598);
            this.AbasMedicos.TabIndex = 0;
            // 
            // NovoMedico
            // 
            this.NovoMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.NovoMedico.Controls.Add(this.Email);
            this.NovoMedico.Controls.Add(this.textEndereco);
            this.NovoMedico.Controls.Add(this.Senha);
            this.NovoMedico.Controls.Add(this.BoxSenha);
            this.NovoMedico.Controls.Add(this.Cadastrar);
            this.NovoMedico.Controls.Add(this.panelDesktop);
            this.NovoMedico.Controls.Add(this.SalvarButton);
            this.NovoMedico.Controls.Add(this.DocenteButton);
            this.NovoMedico.Controls.Add(this.ResidenteButton);
            this.NovoMedico.Controls.Add(this.CRM);
            this.NovoMedico.Controls.Add(this.TitUni);
            this.NovoMedico.Controls.Add(this.AnoResidencia);
            this.NovoMedico.Controls.Add(this.Nome);
            this.NovoMedico.Controls.Add(this.Cancelar);
            this.NovoMedico.Controls.Add(this.textNome);
            this.NovoMedico.Controls.Add(this.textCRM);
            this.NovoMedico.Controls.Add(this.TituloUni);
            this.NovoMedico.Controls.Add(this.textNascimento);
            this.NovoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoMedico.Location = new System.Drawing.Point(4, 25);
            this.NovoMedico.Name = "NovoMedico";
            this.NovoMedico.Padding = new System.Windows.Forms.Padding(3);
            this.NovoMedico.Size = new System.Drawing.Size(1250, 569);
            this.NovoMedico.TabIndex = 1;
            this.NovoMedico.Text = "Novo Medico";
            this.NovoMedico.Click += new System.EventHandler(this.NovoMedico_Click);
            // 
            // Senha
            // 
            this.Senha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Senha.AutoSize = true;
            this.Senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(69)))));
            this.Senha.ForeColor = System.Drawing.Color.Gainsboro;
            this.Senha.Location = new System.Drawing.Point(739, 57);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(70, 25);
            this.Senha.TabIndex = 20;
            this.Senha.Text = "Senha";
            // 
            // CRM
            // 
            this.CRM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CRM.AutoSize = true;
            this.CRM.ForeColor = System.Drawing.Color.Gainsboro;
            this.CRM.Location = new System.Drawing.Point(739, 183);
            this.CRM.Name = "CRM";
            this.CRM.Size = new System.Drawing.Size(57, 25);
            this.CRM.TabIndex = 18;
            this.CRM.Text = "CRM";
            // 
            // TitUni
            // 
            this.TitUni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitUni.AutoSize = true;
            this.TitUni.ForeColor = System.Drawing.Color.Gainsboro;
            this.TitUni.Location = new System.Drawing.Point(28, 359);
            this.TitUni.Name = "TitUni";
            this.TitUni.Size = new System.Drawing.Size(151, 25);
            this.TitUni.TabIndex = 16;
            this.TitUni.Text = "Tit. Universitária";
            this.TitUni.Click += new System.EventHandler(this.label2_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(69)))));
            this.Email.ForeColor = System.Drawing.Color.Gainsboro;
            this.Email.Location = new System.Drawing.Point(28, 57);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(60, 25);
            this.Email.TabIndex = 15;
            this.Email.Text = "Email";
            // 
            // AnoResidencia
            // 
            this.AnoResidencia.AutoSize = true;
            this.AnoResidencia.ForeColor = System.Drawing.Color.Gainsboro;
            this.AnoResidencia.Location = new System.Drawing.Point(481, 359);
            this.AnoResidencia.Name = "AnoResidencia";
            this.AnoResidencia.Size = new System.Drawing.Size(149, 25);
            this.AnoResidencia.TabIndex = 14;
            this.AnoResidencia.Text = "Ano Residência";
            this.AnoResidencia.Click += new System.EventHandler(this.Nascimento_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.ForeColor = System.Drawing.Color.Gainsboro;
            this.Nome.Location = new System.Drawing.Point(28, 183);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(64, 25);
            this.Nome.TabIndex = 13;
            this.Nome.Text = "Nome";
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(185, 58);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(470, 30);
            this.textEndereco.TabIndex = 11;
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancelar.Location = new System.Drawing.Point(416, 488);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(131, 31);
            this.Cancelar.TabIndex = 10;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // Cadastrar
            // 
            this.Cadastrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cadastrar.Location = new System.Drawing.Point(1025, 58);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(131, 31);
            this.Cadastrar.TabIndex = 9;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(185, 183);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(470, 30);
            this.textNome.TabIndex = 8;
            // 
            // textCRM
            // 
            this.textCRM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textCRM.Location = new System.Drawing.Point(815, 183);
            this.textCRM.Name = "textCRM";
            this.textCRM.Size = new System.Drawing.Size(176, 30);
            this.textCRM.TabIndex = 7;
            // 
            // TituloUni
            // 
            this.TituloUni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TituloUni.FormattingEnabled = true;
            this.TituloUni.Items.AddRange(new object[] {
            "Bacharel",
            "Licenciado",
            "Mestre",
            "Doutor"});
            this.TituloUni.Location = new System.Drawing.Point(185, 356);
            this.TituloUni.Name = "TituloUni";
            this.TituloUni.Size = new System.Drawing.Size(146, 33);
            this.TituloUni.TabIndex = 6;
            // 
            // BoxSenha
            // 
            this.BoxSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxSenha.Location = new System.Drawing.Point(815, 57);
            this.BoxSenha.Name = "BoxSenha";
            this.BoxSenha.Size = new System.Drawing.Size(176, 30);
            this.BoxSenha.TabIndex = 5;
            // 
            // textNascimento
            // 
            this.textNascimento.Location = new System.Drawing.Point(636, 354);
            this.textNascimento.Mask = "00/00/0000";
            this.textNascimento.Name = "textNascimento";
            this.textNascimento.Size = new System.Drawing.Size(148, 30);
            this.textNascimento.TabIndex = 4;
            this.textNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // ResidenteButton
            // 
            this.ResidenteButton.AutoSize = true;
            this.ResidenteButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ResidenteButton.Location = new System.Drawing.Point(486, 294);
            this.ResidenteButton.Name = "ResidenteButton";
            this.ResidenteButton.Size = new System.Drawing.Size(120, 29);
            this.ResidenteButton.TabIndex = 22;
            this.ResidenteButton.TabStop = true;
            this.ResidenteButton.Text = "Residente";
            this.ResidenteButton.UseVisualStyleBackColor = true;
            this.ResidenteButton.CheckedChanged += new System.EventHandler(this.ResidenteButton_CheckedChanged);
            // 
            // DocenteButton
            // 
            this.DocenteButton.AutoSize = true;
            this.DocenteButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.DocenteButton.Location = new System.Drawing.Point(33, 285);
            this.DocenteButton.Name = "DocenteButton";
            this.DocenteButton.Size = new System.Drawing.Size(106, 29);
            this.DocenteButton.TabIndex = 23;
            this.DocenteButton.TabStop = true;
            this.DocenteButton.Text = "Docente";
            this.DocenteButton.UseVisualStyleBackColor = true;
            // 
            // SalvarButton
            // 
            this.SalvarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SalvarButton.Location = new System.Drawing.Point(665, 488);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(131, 31);
            this.SalvarButton.TabIndex = 24;
            this.SalvarButton.Text = "Salvar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(69)))));
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1256, 126);
            this.panelDesktop.TabIndex = 25;
            // 
            // NomeMD
            // 
            this.NomeMD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeMD.HeaderText = "Nome";
            this.NomeMD.MinimumWidth = 6;
            this.NomeMD.Name = "NomeMD";
            // 
            // EmailMD
            // 
            this.EmailMD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailMD.HeaderText = "Email";
            this.EmailMD.MinimumWidth = 6;
            this.EmailMD.Name = "EmailMD";
            // 
            // CRMmd
            // 
            this.CRMmd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CRMmd.HeaderText = "CRM";
            this.CRMmd.MinimumWidth = 6;
            this.CRMmd.Name = "CRMmd";
            // 
            // TitUniMed
            // 
            this.TitUniMed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TitUniMed.HeaderText = "Tit. Universitária";
            this.TitUniMed.MinimumWidth = 6;
            this.TitUniMed.Name = "TitUniMed";
            // 
            // AnoResidenciaMed
            // 
            this.AnoResidenciaMed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnoResidenciaMed.HeaderText = "Ano Residência";
            this.AnoResidenciaMed.MinimumWidth = 6;
            this.AnoResidenciaMed.Name = "AnoResidenciaMed";
            // 
            // AdmTelaMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 598);
            this.Controls.Add(this.AbasMedicos);
            this.Name = "AdmTelaMed";
            this.Text = "telaMed";
            this.Detalhes.ResumeLayout(false);
            this.Detalhes.PerformLayout();
            this.Medicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListarMedicos)).EndInit();
            this.AbasMedicos.ResumeLayout(false);
            this.NovoMedico.ResumeLayout(false);
            this.NovoMedico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Detalhes;
        private System.Windows.Forms.TabPage Medicos;
        private System.Windows.Forms.TabControl AbasMedicos;
        private System.Windows.Forms.TabPage NovoMedico;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label CRM;
        private System.Windows.Forms.Label TitUni;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label AnoResidencia;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.MaskedTextBox textCRM;
        private System.Windows.Forms.ComboBox TituloUni;
        private System.Windows.Forms.MaskedTextBox BoxSenha;
        private System.Windows.Forms.MaskedTextBox textNascimento;
        private System.Windows.Forms.TextBox textDetalhes;
        private System.Windows.Forms.DataGridView ListarMedicos;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.RadioButton DocenteButton;
        private System.Windows.Forms.RadioButton ResidenteButton;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMD;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailMD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRMmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitUniMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnoResidenciaMed;
    }
}