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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomeMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRMmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitUniMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnoResidenciaMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbasMedicos = new System.Windows.Forms.TabControl();
            this.NovoMedico = new System.Windows.Forms.TabPage();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.BoxSenha = new System.Windows.Forms.MaskedTextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.DocenteButton = new System.Windows.Forms.RadioButton();
            this.ResidenteButton = new System.Windows.Forms.RadioButton();
            this.CRM = new System.Windows.Forms.Label();
            this.TitUni = new System.Windows.Forms.Label();
            this.AnoResidencia = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCRM = new System.Windows.Forms.MaskedTextBox();
            this.TituloUni = new System.Windows.Forms.ComboBox();
            this.textNascimento = new System.Windows.Forms.MaskedTextBox();
            this.Detalhes.SuspendLayout();
            this.Medicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.AbasMedicos.SuspendLayout();
            this.NovoMedico.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // Detalhes
            // 
            this.Detalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.Detalhes.Controls.Add(this.textDetalhes);
            this.Detalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detalhes.Location = new System.Drawing.Point(4, 25);
            this.Detalhes.Margin = new System.Windows.Forms.Padding(2);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Padding = new System.Windows.Forms.Padding(2);
            this.Detalhes.Size = new System.Drawing.Size(779, 387);
            this.Detalhes.TabIndex = 2;
            this.Detalhes.Text = "Detalhes";
            // 
            // textDetalhes
            // 
            this.textDetalhes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textDetalhes.Dock = System.Windows.Forms.DockStyle.Top;
            this.textDetalhes.Location = new System.Drawing.Point(2, 2);
            this.textDetalhes.Margin = new System.Windows.Forms.Padding(2);
            this.textDetalhes.Multiline = true;
            this.textDetalhes.Name = "textDetalhes";
            this.textDetalhes.ReadOnly = true;
            this.textDetalhes.Size = new System.Drawing.Size(775, 305);
            this.textDetalhes.TabIndex = 0;
            // 
            // Medicos
            // 
            this.Medicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.Medicos.Controls.Add(this.iconPictureBox1);
            this.Medicos.Controls.Add(this.dataGridView1);
            this.Medicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicos.Location = new System.Drawing.Point(4, 25);
            this.Medicos.Margin = new System.Windows.Forms.Padding(2);
            this.Medicos.Name = "Medicos";
            this.Medicos.Padding = new System.Windows.Forms.Padding(2);
            this.Medicos.Size = new System.Drawing.Size(779, 387);
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
            this.iconPictureBox1.IconSize = 178;
            this.iconPictureBox1.Location = new System.Drawing.Point(599, 2);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(178, 383);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeMD,
            this.EmailMD,
            this.CRMmd,
            this.TitUniMed,
            this.AnoResidenciaMed});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 383);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // AbasMedicos
            // 
            this.AbasMedicos.Controls.Add(this.Medicos);
            this.AbasMedicos.Controls.Add(this.NovoMedico);
            this.AbasMedicos.Controls.Add(this.Detalhes);
            this.AbasMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AbasMedicos.ItemSize = new System.Drawing.Size(64, 21);
            this.AbasMedicos.Location = new System.Drawing.Point(0, 0);
            this.AbasMedicos.Margin = new System.Windows.Forms.Padding(2);
            this.AbasMedicos.Name = "AbasMedicos";
            this.AbasMedicos.SelectedIndex = 0;
            this.AbasMedicos.Size = new System.Drawing.Size(787, 416);
            this.AbasMedicos.TabIndex = 0;
            // 
            // NovoMedico
            // 
            this.NovoMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.NovoMedico.Controls.Add(this.lblErrorMessage);
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
            this.NovoMedico.Margin = new System.Windows.Forms.Padding(2);
            this.NovoMedico.Name = "NovoMedico";
            this.NovoMedico.Padding = new System.Windows.Forms.Padding(2);
            this.NovoMedico.Size = new System.Drawing.Size(779, 387);
            this.NovoMedico.TabIndex = 1;
            this.NovoMedico.Text = "Novo Medico";
            this.NovoMedico.Click += new System.EventHandler(this.NovoMedico_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblErrorMessage.Location = new System.Drawing.Point(105, 273);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(88, 20);
            this.lblErrorMessage.TabIndex = 26;
            this.lblErrorMessage.Text = "Mensagem";
            this.lblErrorMessage.Visible = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(69)))));
            this.panelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDesktop.Controls.Add(this.Email);
            this.panelDesktop.Controls.Add(this.textEndereco);
            this.panelDesktop.Controls.Add(this.Cadastrar);
            this.panelDesktop.Controls.Add(this.BoxSenha);
            this.panelDesktop.Controls.Add(this.Senha);
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(779, 126);
            this.panelDesktop.TabIndex = 25;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(69)))));
            this.Email.ForeColor = System.Drawing.Color.Gainsboro;
            this.Email.Location = new System.Drawing.Point(50, 22);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 20);
            this.Email.TabIndex = 15;
            this.Email.Text = "Email";
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(130, 19);
            this.textEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(354, 26);
            this.textEndereco.TabIndex = 11;
            // 
            // Cadastrar
            // 
            this.Cadastrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cadastrar.Location = new System.Drawing.Point(593, 36);
            this.Cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(98, 37);
            this.Cadastrar.TabIndex = 9;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click_1);
            // 
            // BoxSenha
            // 
            this.BoxSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxSenha.Location = new System.Drawing.Point(130, 68);
            this.BoxSenha.Margin = new System.Windows.Forms.Padding(2);
            this.BoxSenha.Name = "BoxSenha";
            this.BoxSenha.Size = new System.Drawing.Size(354, 26);
            this.BoxSenha.TabIndex = 5;
            // 
            // Senha
            // 
            this.Senha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Senha.AutoSize = true;
            this.Senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(69)))));
            this.Senha.ForeColor = System.Drawing.Color.Gainsboro;
            this.Senha.Location = new System.Drawing.Point(42, 68);
            this.Senha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(56, 20);
            this.Senha.TabIndex = 20;
            this.Senha.Text = "Senha";
            // 
            // SalvarButton
            // 
            this.SalvarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SalvarButton.Location = new System.Drawing.Point(257, 325);
            this.SalvarButton.Margin = new System.Windows.Forms.Padding(2);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(122, 37);
            this.SalvarButton.TabIndex = 24;
            this.SalvarButton.Text = "Salvar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // DocenteButton
            // 
            this.DocenteButton.AutoSize = true;
            this.DocenteButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.DocenteButton.Location = new System.Drawing.Point(617, 160);
            this.DocenteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DocenteButton.Name = "DocenteButton";
            this.DocenteButton.Size = new System.Drawing.Size(88, 24);
            this.DocenteButton.TabIndex = 23;
            this.DocenteButton.TabStop = true;
            this.DocenteButton.Text = "Docente";
            this.DocenteButton.UseVisualStyleBackColor = true;
            // 
            // ResidenteButton
            // 
            this.ResidenteButton.AutoSize = true;
            this.ResidenteButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ResidenteButton.Location = new System.Drawing.Point(615, 263);
            this.ResidenteButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResidenteButton.Name = "ResidenteButton";
            this.ResidenteButton.Size = new System.Drawing.Size(100, 24);
            this.ResidenteButton.TabIndex = 22;
            this.ResidenteButton.TabStop = true;
            this.ResidenteButton.Text = "Residente";
            this.ResidenteButton.UseVisualStyleBackColor = true;
            this.ResidenteButton.CheckedChanged += new System.EventHandler(this.ResidenteButton_CheckedChanged);
            // 
            // CRM
            // 
            this.CRM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CRM.AutoSize = true;
            this.CRM.ForeColor = System.Drawing.Color.Gainsboro;
            this.CRM.Location = new System.Drawing.Point(29, 243);
            this.CRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CRM.Name = "CRM";
            this.CRM.Size = new System.Drawing.Size(45, 20);
            this.CRM.TabIndex = 18;
            this.CRM.Text = "CRM";
            // 
            // TitUni
            // 
            this.TitUni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitUni.AutoSize = true;
            this.TitUni.ForeColor = System.Drawing.Color.Gainsboro;
            this.TitUni.Location = new System.Drawing.Point(-136, 292);
            this.TitUni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitUni.Name = "TitUni";
            this.TitUni.Size = new System.Drawing.Size(121, 20);
            this.TitUni.TabIndex = 16;
            this.TitUni.Text = "Tit. Universitária";
            this.TitUni.Click += new System.EventHandler(this.label2_Click);
            // 
            // AnoResidencia
            // 
            this.AnoResidencia.AutoSize = true;
            this.AnoResidencia.ForeColor = System.Drawing.Color.Gainsboro;
            this.AnoResidencia.Location = new System.Drawing.Point(478, 314);
            this.AnoResidencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnoResidencia.Name = "AnoResidencia";
            this.AnoResidencia.Size = new System.Drawing.Size(121, 20);
            this.AnoResidencia.TabIndex = 14;
            this.AnoResidencia.Text = "Ano Residência";
            this.AnoResidencia.Click += new System.EventHandler(this.Nascimento_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.ForeColor = System.Drawing.Color.Gainsboro;
            this.Nome.Location = new System.Drawing.Point(26, 176);
            this.Nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(51, 20);
            this.Nome.TabIndex = 13;
            this.Nome.Text = "Nome";
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancelar.Location = new System.Drawing.Point(69, 325);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(122, 37);
            this.Cancelar.TabIndex = 10;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click_1);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(105, 173);
            this.textNome.Margin = new System.Windows.Forms.Padding(2);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(354, 26);
            this.textNome.TabIndex = 8;
            // 
            // textCRM
            // 
            this.textCRM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textCRM.Location = new System.Drawing.Point(105, 241);
            this.textCRM.Margin = new System.Windows.Forms.Padding(2);
            this.textCRM.Name = "textCRM";
            this.textCRM.Size = new System.Drawing.Size(133, 26);
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
            this.TituloUni.Location = new System.Drawing.Point(617, 209);
            this.TituloUni.Margin = new System.Windows.Forms.Padding(2);
            this.TituloUni.Name = "TituloUni";
            this.TituloUni.Size = new System.Drawing.Size(110, 28);
            this.TituloUni.TabIndex = 6;
            this.TituloUni.SelectedIndexChanged += new System.EventHandler(this.TituloUni_SelectedIndexChanged);
            // 
            // textNascimento
            // 
            this.textNascimento.Location = new System.Drawing.Point(615, 308);
            this.textNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.textNascimento.Mask = "00/00/0000";
            this.textNascimento.Name = "textNascimento";
            this.textNascimento.Size = new System.Drawing.Size(112, 26);
            this.textNascimento.TabIndex = 4;
            this.textNascimento.ValidatingType = typeof(System.DateTime);
            this.textNascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textNascimento_MaskInputRejected);
            // 
            // AdmTelaMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 416);
            this.Controls.Add(this.AbasMedicos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdmTelaMed";
            this.Text = "telaMed";
            this.Detalhes.ResumeLayout(false);
            this.Detalhes.PerformLayout();
            this.Medicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.AbasMedicos.ResumeLayout(false);
            this.NovoMedico.ResumeLayout(false);
            this.NovoMedico.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label lblErrorMessage;
    }
}