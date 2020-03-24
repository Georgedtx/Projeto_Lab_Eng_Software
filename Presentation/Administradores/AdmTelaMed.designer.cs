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
            this.ListarMedicos = new System.Windows.Forms.DataGridView();
            this.NomeMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexoMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbasMedicos = new System.Windows.Forms.TabControl();
            this.NovoMedico = new System.Windows.Forms.TabPage();
            this.Area = new System.Windows.Forms.Label();
            this.UF = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.Label();
            this.Endereco = new System.Windows.Forms.Label();
            this.Nascimento = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.textUF = new System.Windows.Forms.ComboBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.textSexo = new System.Windows.Forms.ComboBox();
            this.textCEP = new System.Windows.Forms.MaskedTextBox();
            this.textNascimento = new System.Windows.Forms.MaskedTextBox();
            this.textTel = new System.Windows.Forms.MaskedTextBox();
            this.AreaMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Detalhes.SuspendLayout();
            this.Medicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListarMedicos)).BeginInit();
            this.AbasMedicos.SuspendLayout();
            this.NovoMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
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
            // ListarMedicos
            // 
            this.ListarMedicos.AllowUserToAddRows = false;
            this.ListarMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListarMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeMD,
            this.TelefoneMD,
            this.CPFmd,
            this.SexoMD,
            this.AreaMed});
            this.ListarMedicos.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListarMedicos.Location = new System.Drawing.Point(3, 3);
            this.ListarMedicos.Name = "ListarMedicos";
            this.ListarMedicos.RowHeadersWidth = 51;
            this.ListarMedicos.RowTemplate.Height = 24;
            this.ListarMedicos.Size = new System.Drawing.Size(679, 563);
            this.ListarMedicos.TabIndex = 2;
            this.ListarMedicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NomeMD
            // 
            this.NomeMD.HeaderText = "Nome";
            this.NomeMD.MinimumWidth = 6;
            this.NomeMD.Name = "NomeMD";
            this.NomeMD.Width = 125;
            // 
            // TelefoneMD
            // 
            this.TelefoneMD.HeaderText = "Tell";
            this.TelefoneMD.MinimumWidth = 6;
            this.TelefoneMD.Name = "TelefoneMD";
            this.TelefoneMD.Width = 125;
            // 
            // CPFmd
            // 
            this.CPFmd.HeaderText = "CPF";
            this.CPFmd.MinimumWidth = 6;
            this.CPFmd.Name = "CPFmd";
            this.CPFmd.Width = 125;
            // 
            // SexoMD
            // 
            this.SexoMD.HeaderText = "Sexo";
            this.SexoMD.MinimumWidth = 6;
            this.SexoMD.Name = "SexoMD";
            this.SexoMD.Width = 125;
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
            this.NovoMedico.Controls.Add(this.Area);
            this.NovoMedico.Controls.Add(this.UF);
            this.NovoMedico.Controls.Add(this.CPF);
            this.NovoMedico.Controls.Add(this.Telefone);
            this.NovoMedico.Controls.Add(this.Sexo);
            this.NovoMedico.Controls.Add(this.Endereco);
            this.NovoMedico.Controls.Add(this.Nascimento);
            this.NovoMedico.Controls.Add(this.Nome);
            this.NovoMedico.Controls.Add(this.textUF);
            this.NovoMedico.Controls.Add(this.textEndereco);
            this.NovoMedico.Controls.Add(this.Cancelar);
            this.NovoMedico.Controls.Add(this.Cadastrar);
            this.NovoMedico.Controls.Add(this.textNome);
            this.NovoMedico.Controls.Add(this.textCPF);
            this.NovoMedico.Controls.Add(this.textSexo);
            this.NovoMedico.Controls.Add(this.textCEP);
            this.NovoMedico.Controls.Add(this.textNascimento);
            this.NovoMedico.Controls.Add(this.textTel);
            this.NovoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoMedico.Location = new System.Drawing.Point(4, 25);
            this.NovoMedico.Name = "NovoMedico";
            this.NovoMedico.Padding = new System.Windows.Forms.Padding(3);
            this.NovoMedico.Size = new System.Drawing.Size(1250, 569);
            this.NovoMedico.TabIndex = 1;
            this.NovoMedico.Text = "Novo Medico";
            this.NovoMedico.Click += new System.EventHandler(this.NovoMedico_Click);
            // 
            // Area
            // 
            this.Area.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Area.AutoSize = true;
            this.Area.ForeColor = System.Drawing.Color.Gainsboro;
            this.Area.Location = new System.Drawing.Point(921, 359);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(54, 25);
            this.Area.TabIndex = 20;
            this.Area.Text = "Area";
            // 
            // UF
            // 
            this.UF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UF.AutoSize = true;
            this.UF.ForeColor = System.Drawing.Color.Gainsboro;
            this.UF.Location = new System.Drawing.Point(921, 268);
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(38, 25);
            this.UF.TabIndex = 19;
            this.UF.Text = "UF";
            // 
            // CPF
            // 
            this.CPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CPF.AutoSize = true;
            this.CPF.ForeColor = System.Drawing.Color.Gainsboro;
            this.CPF.Location = new System.Drawing.Point(921, 160);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(52, 25);
            this.CPF.TabIndex = 18;
            this.CPF.Text = "CPF";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.ForeColor = System.Drawing.Color.Gainsboro;
            this.Telefone.Location = new System.Drawing.Point(32, 365);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(89, 25);
            this.Telefone.TabIndex = 17;
            this.Telefone.Text = "Telefone";
            // 
            // Sexo
            // 
            this.Sexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sexo.AutoSize = true;
            this.Sexo.ForeColor = System.Drawing.Color.Gainsboro;
            this.Sexo.Location = new System.Drawing.Point(921, 63);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(58, 25);
            this.Sexo.TabIndex = 16;
            this.Sexo.Text = "Sexo";
            this.Sexo.Click += new System.EventHandler(this.label2_Click);
            // 
            // Endereco
            // 
            this.Endereco.AutoSize = true;
            this.Endereco.ForeColor = System.Drawing.Color.Gainsboro;
            this.Endereco.Location = new System.Drawing.Point(32, 269);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(96, 25);
            this.Endereco.TabIndex = 15;
            this.Endereco.Text = "Endereco";
            // 
            // Nascimento
            // 
            this.Nascimento.AutoSize = true;
            this.Nascimento.ForeColor = System.Drawing.Color.Gainsboro;
            this.Nascimento.Location = new System.Drawing.Point(32, 163);
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.Size = new System.Drawing.Size(115, 25);
            this.Nascimento.TabIndex = 14;
            this.Nascimento.Text = "Nascimento";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.ForeColor = System.Drawing.Color.Gainsboro;
            this.Nome.Location = new System.Drawing.Point(32, 69);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(64, 25);
            this.Nome.TabIndex = 13;
            this.Nome.Text = "Nome";
            // 
            // textUF
            // 
            this.textUF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textUF.FormattingEnabled = true;
            this.textUF.Items.AddRange(new object[] {
            "BA",
            "SE",
            "RJ"});
            this.textUF.Location = new System.Drawing.Point(1002, 263);
            this.textUF.Name = "textUF";
            this.textUF.Size = new System.Drawing.Size(121, 33);
            this.textUF.TabIndex = 12;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(207, 269);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(470, 30);
            this.textEndereco.TabIndex = 11;
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancelar.Location = new System.Drawing.Point(397, 488);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(131, 31);
            this.Cancelar.TabIndex = 10;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // Cadastrar
            // 
            this.Cadastrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cadastrar.Location = new System.Drawing.Point(662, 488);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(131, 31);
            this.Cadastrar.TabIndex = 9;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(207, 66);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(470, 30);
            this.textNome.TabIndex = 8;
            // 
            // textCPF
            // 
            this.textCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textCPF.Location = new System.Drawing.Point(1002, 160);
            this.textCPF.Mask = "000.009.999-99";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(176, 30);
            this.textCPF.TabIndex = 7;
            // 
            // textSexo
            // 
            this.textSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSexo.FormattingEnabled = true;
            this.textSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.textSexo.Location = new System.Drawing.Point(1002, 60);
            this.textSexo.Name = "textSexo";
            this.textSexo.Size = new System.Drawing.Size(121, 33);
            this.textSexo.TabIndex = 6;
            // 
            // textCEP
            // 
            this.textCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textCEP.Location = new System.Drawing.Point(1002, 359);
            this.textCEP.Name = "textCEP";
            this.textCEP.Size = new System.Drawing.Size(176, 30);
            this.textCEP.TabIndex = 5;
            // 
            // textNascimento
            // 
            this.textNascimento.Location = new System.Drawing.Point(207, 163);
            this.textNascimento.Mask = "00/00/0000";
            this.textNascimento.Name = "textNascimento";
            this.textNascimento.Size = new System.Drawing.Size(176, 30);
            this.textNascimento.TabIndex = 4;
            this.textNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(207, 362);
            this.textTel.Mask = "(99) 0000-0000";
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(176, 30);
            this.textTel.TabIndex = 3;
            // 
            // AreaMed
            // 
            this.AreaMed.HeaderText = "Area";
            this.AreaMed.MinimumWidth = 6;
            this.AreaMed.Name = "AreaMed";
            this.AreaMed.Width = 125;
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
            ((System.ComponentModel.ISupportInitialize)(this.ListarMedicos)).EndInit();
            this.AbasMedicos.ResumeLayout(false);
            this.NovoMedico.ResumeLayout(false);
            this.NovoMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Detalhes;
        private System.Windows.Forms.TabPage Medicos;
        private System.Windows.Forms.TabControl AbasMedicos;
        private System.Windows.Forms.TabPage NovoMedico;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Label UF;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.Label Endereco;
        private System.Windows.Forms.Label Nascimento;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.ComboBox textUF;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.MaskedTextBox textCPF;
        private System.Windows.Forms.ComboBox textSexo;
        private System.Windows.Forms.MaskedTextBox textCEP;
        private System.Windows.Forms.MaskedTextBox textNascimento;
        private System.Windows.Forms.MaskedTextBox textTel;
        private System.Windows.Forms.TextBox textDetalhes;
        private System.Windows.Forms.DataGridView ListarMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneMD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexoMD;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaMed;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}