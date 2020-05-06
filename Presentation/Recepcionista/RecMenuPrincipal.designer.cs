namespace Presentation.Recepcionista
{
    partial class RecMenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Sair = new FontAwesome.Sharp.IconButton();
            this.logoPainel = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.painelTitulo = new System.Windows.Forms.Panel();
            this.minimizar = new FontAwesome.Sharp.IconButton();
            this.maximizar = new FontAwesome.Sharp.IconButton();
            this.fechar = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CampoSexo = new System.Windows.Forms.ComboBox();
            this.CampoNasc = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CampoNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.CampoCPF = new System.Windows.Forms.MaskedTextBox();
            this.listaPacientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CampoNome2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CampoNasc2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CampoCor2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CampoSexo2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CPF = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.BuscarCPF = new System.Windows.Forms.MaskedTextBox();
            this.listaPacientes2 = new System.Windows.Forms.DataGridView();
            this.Nome1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampoCor = new System.Windows.Forms.ComboBox();
            this.panelMenu.SuspendLayout();
            this.logoPainel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.painelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CampoNome2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientes2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelMenu.Controls.Add(this.Sair);
            this.panelMenu.Controls.Add(this.logoPainel);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(121, 526);
            this.panelMenu.TabIndex = 2;
            // 
            // Sair
            // 
            this.Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sair.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Sair.FlatAppearance.BorderSize = 0;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Sair.ForeColor = System.Drawing.Color.Gainsboro;
            this.Sair.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.Sair.IconColor = System.Drawing.Color.Gainsboro;
            this.Sair.IconSize = 50;
            this.Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sair.Location = new System.Drawing.Point(0, 442);
            this.Sair.Margin = new System.Windows.Forms.Padding(2);
            this.Sair.Name = "Sair";
            this.Sair.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sair.Rotation = 0D;
            this.Sair.Size = new System.Drawing.Size(121, 84);
            this.Sair.TabIndex = 4;
            this.Sair.Text = "Sair";
            this.Sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // logoPainel
            // 
            this.logoPainel.Controls.Add(this.iconPictureBox2);
            this.logoPainel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPainel.Location = new System.Drawing.Point(0, 0);
            this.logoPainel.Margin = new System.Windows.Forms.Padding(2);
            this.logoPainel.Name = "logoPainel";
            this.logoPainel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoPainel.Size = new System.Drawing.Size(121, 81);
            this.logoPainel.TabIndex = 0;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Heartbeat;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconSize = 81;
            this.iconPictureBox2.Location = new System.Drawing.Point(0, 2);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iconPictureBox2.Size = new System.Drawing.Size(121, 81);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 8;
            this.iconPictureBox2.TabStop = false;
            // 
            // painelTitulo
            // 
            this.painelTitulo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.painelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelTitulo.Controls.Add(this.minimizar);
            this.painelTitulo.Controls.Add(this.maximizar);
            this.painelTitulo.Controls.Add(this.fechar);
            this.painelTitulo.Controls.Add(this.lblTitleChildForm);
            this.painelTitulo.Controls.Add(this.iconCurrentChildForm);
            this.painelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTitulo.Location = new System.Drawing.Point(121, 0);
            this.painelTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.painelTitulo.Name = "painelTitulo";
            this.painelTitulo.Size = new System.Drawing.Size(847, 65);
            this.painelTitulo.TabIndex = 3;
            this.painelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.painelTitulo_MouseDown);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.minimizar.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizar.IconColor = System.Drawing.Color.Gainsboro;
            this.minimizar.IconSize = 16;
            this.minimizar.Location = new System.Drawing.Point(749, 0);
            this.minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Rotation = 0D;
            this.minimizar.Size = new System.Drawing.Size(27, 19);
            this.minimizar.TabIndex = 4;
            this.minimizar.UseVisualStyleBackColor = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.maximizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maximizar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.maximizar.IconColor = System.Drawing.Color.Gainsboro;
            this.maximizar.IconSize = 16;
            this.maximizar.Location = new System.Drawing.Point(780, 0);
            this.maximizar.Margin = new System.Windows.Forms.Padding(2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Rotation = 0D;
            this.maximizar.Size = new System.Drawing.Size(34, 19);
            this.maximizar.TabIndex = 3;
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // fechar
            // 
            this.fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.fechar.FlatAppearance.BorderSize = 0;
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.fechar.ForeColor = System.Drawing.SystemColors.Control;
            this.fechar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.fechar.IconColor = System.Drawing.Color.Gainsboro;
            this.fechar.IconSize = 16;
            this.fechar.Location = new System.Drawing.Point(818, 0);
            this.fechar.Margin = new System.Windows.Forms.Padding(2);
            this.fechar.Name = "fechar";
            this.fechar.Rotation = 0D;
            this.fechar.Size = new System.Drawing.Size(26, 19);
            this.fechar.TabIndex = 2;
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(46, 25);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.LightSeaGreen;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconSize = 29;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(12, 17);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(29, 33);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.tabControl1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(121, 65);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(847, 461);
            this.panelDesktop.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.CampoNome2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 461);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.CampoCor);
            this.tabPage1.Controls.Add(this.CampoSexo);
            this.tabPage1.Controls.Add(this.CampoNasc);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.CampoNome);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnCadastrar);
            this.tabPage1.Controls.Add(this.CampoCPF);
            this.tabPage1.Controls.Add(this.listaPacientes);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(839, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pacientes";
            // 
            // CampoSexo
            // 
            this.CampoSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoSexo.FormattingEnabled = true;
            this.CampoSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.CampoSexo.Location = new System.Drawing.Point(118, 293);
            this.CampoSexo.Name = "CampoSexo";
            this.CampoSexo.Size = new System.Drawing.Size(143, 26);
            this.CampoSexo.TabIndex = 5;
            // 
            // CampoNasc
            // 
            this.CampoNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoNasc.Location = new System.Drawing.Point(118, 187);
            this.CampoNasc.Mask = "00/00/0000";
            this.CampoNasc.Name = "CampoNasc";
            this.CampoNasc.Size = new System.Drawing.Size(142, 24);
            this.CampoNasc.TabIndex = 3;
            this.CampoNasc.ValidatingType = typeof(System.DateTime);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(240, 365);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 43);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Novo Paciente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(66, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Cor :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(55, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Sexo :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Nascimento :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(49, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nome :";
            // 
            // CampoNome
            // 
            this.CampoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoNome.Location = new System.Drawing.Point(117, 137);
            this.CampoNome.Margin = new System.Windows.Forms.Padding(2);
            this.CampoNome.Name = "CampoNome";
            this.CampoNome.Size = new System.Drawing.Size(256, 24);
            this.CampoNome.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(61, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "CPF :";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.Location = new System.Drawing.Point(52, 365);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(123, 43);
            this.btnCadastrar.TabIndex = 28;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CampoCPF
            // 
            this.CampoCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoCPF.Location = new System.Drawing.Point(117, 79);
            this.CampoCPF.Margin = new System.Windows.Forms.Padding(2);
            this.CampoCPF.Mask = "000.000.000-00";
            this.CampoCPF.Name = "CampoCPF";
            this.CampoCPF.Size = new System.Drawing.Size(144, 24);
            this.CampoCPF.TabIndex = 1;
            this.CampoCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listaPacientes
            // 
            this.listaPacientes.AllowUserToAddRows = false;
            this.listaPacientes.BackgroundColor = System.Drawing.Color.White;
            this.listaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.listaPacientes.Location = new System.Drawing.Point(410, 0);
            this.listaPacientes.Name = "listaPacientes";
            this.listaPacientes.RowHeadersWidth = 51;
            this.listaPacientes.Size = new System.Drawing.Size(429, 428);
            this.listaPacientes.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(833, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // CampoNome2
            // 
            this.CampoNome2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CampoNome2.Controls.Add(this.panel2);
            this.CampoNome2.Controls.Add(this.listaPacientes2);
            this.CampoNome2.Location = new System.Drawing.Point(4, 22);
            this.CampoNome2.Name = "CampoNome2";
            this.CampoNome2.Padding = new System.Windows.Forms.Padding(3);
            this.CampoNome2.Size = new System.Drawing.Size(839, 435);
            this.CampoNome2.TabIndex = 2;
            this.CampoNome2.Text = "Detalhes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CampoNasc2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.CampoCor2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CampoSexo2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelNome);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.CPF);
            this.panel2.Controls.Add(this.Buscar);
            this.panel2.Controls.Add(this.BuscarCPF);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 429);
            this.panel2.TabIndex = 18;
            // 
            // CampoNasc2
            // 
            this.CampoNasc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoNasc2.Enabled = false;
            this.CampoNasc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoNasc2.Location = new System.Drawing.Point(116, 220);
            this.CampoNasc2.Margin = new System.Windows.Forms.Padding(2);
            this.CampoNasc2.Name = "CampoNasc2";
            this.CampoNasc2.Size = new System.Drawing.Size(143, 24);
            this.CampoNasc2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(64, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cor :";
            // 
            // CampoCor2
            // 
            this.CampoCor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoCor2.Enabled = false;
            this.CampoCor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoCor2.Location = new System.Drawing.Point(116, 278);
            this.CampoCor2.Margin = new System.Windows.Forms.Padding(2);
            this.CampoCor2.Name = "CampoCor2";
            this.CampoCor2.Size = new System.Drawing.Size(143, 24);
            this.CampoCor2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(56, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sexo :";
            // 
            // CampoSexo2
            // 
            this.CampoSexo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoSexo2.Enabled = false;
            this.CampoSexo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoSexo2.Location = new System.Drawing.Point(116, 335);
            this.CampoSexo2.Margin = new System.Windows.Forms.Padding(2);
            this.CampoSexo2.Name = "CampoSexo2";
            this.CampoSexo2.Size = new System.Drawing.Size(143, 24);
            this.CampoSexo2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nascimento :";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelNome.ForeColor = System.Drawing.Color.Black;
            this.labelNome.Location = new System.Drawing.Point(51, 167);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(57, 16);
            this.labelNome.TabIndex = 19;
            this.labelNome.Text = "Nome :";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox2.Location = new System.Drawing.Point(116, 163);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(289, 24);
            this.textBox2.TabIndex = 18;
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.BackColor = System.Drawing.Color.Transparent;
            this.CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CPF.ForeColor = System.Drawing.Color.Black;
            this.CPF.Location = new System.Drawing.Point(39, 66);
            this.CPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(45, 16);
            this.CPF.TabIndex = 17;
            this.CPF.Text = "CPF :";
            // 
            // Buscar
            // 
            this.Buscar.Cursor = System.Windows.Forms.Cursors.No;
            this.Buscar.FlatAppearance.BorderSize = 0;
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Buscar.Location = new System.Drawing.Point(304, 55);
            this.Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(101, 36);
            this.Buscar.TabIndex = 5;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // BuscarCPF
            // 
            this.BuscarCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarCPF.Location = new System.Drawing.Point(87, 60);
            this.BuscarCPF.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarCPF.Mask = "000.000.000-00";
            this.BuscarCPF.Name = "BuscarCPF";
            this.BuscarCPF.Size = new System.Drawing.Size(172, 26);
            this.BuscarCPF.TabIndex = 4;
            this.BuscarCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listaPacientes2
            // 
            this.listaPacientes2.AllowUserToAddRows = false;
            this.listaPacientes2.AllowUserToOrderColumns = true;
            this.listaPacientes2.BackgroundColor = System.Drawing.Color.White;
            this.listaPacientes2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPacientes2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome1});
            this.listaPacientes2.Dock = System.Windows.Forms.DockStyle.Right;
            this.listaPacientes2.Location = new System.Drawing.Point(442, 3);
            this.listaPacientes2.Name = "listaPacientes2";
            this.listaPacientes2.RowHeadersWidth = 51;
            this.listaPacientes2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaPacientes2.Size = new System.Drawing.Size(394, 429);
            this.listaPacientes2.TabIndex = 1;
            this.listaPacientes2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // Nome1
            // 
            this.Nome1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome1.HeaderText = "Nome";
            this.Nome1.MinimumWidth = 6;
            this.Nome1.Name = "Nome1";
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            // 
            // CampoCor
            // 
            this.CampoCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoCor.FormattingEnabled = true;
            this.CampoCor.Items.AddRange(new object[] {
            "Clara",
            "Bege",
            "Rosada",
            "Morena",
            "Morena Escura",
            "Mulata",
            "Mulata Escura",
            "Negra",
            "Negra Escura"});
            this.CampoCor.Location = new System.Drawing.Point(118, 239);
            this.CampoCor.Name = "CampoCor";
            this.CampoCor.Size = new System.Drawing.Size(142, 26);
            this.CampoCor.TabIndex = 4;
            // 
            // RecMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(968, 526);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.painelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RecMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.logoPainel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.painelTitulo.ResumeLayout(false);
            this.painelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CampoNome2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientes2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel logoPainel;
        private System.Windows.Forms.Panel painelTitulo;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton minimizar;
        private FontAwesome.Sharp.IconButton maximizar;
        private FontAwesome.Sharp.IconButton fechar;
        private FontAwesome.Sharp.IconButton Sair;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CampoNome2;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.MaskedTextBox BuscarCPF;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.DataGridView listaPacientes2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridView listaPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CampoCor2;
        private System.Windows.Forms.TextBox CampoNasc2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CampoNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox CampoCPF;
        private System.Windows.Forms.TextBox CampoSexo2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CampoSexo;
        private System.Windows.Forms.MaskedTextBox CampoNasc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox CampoCor;
    }
}

