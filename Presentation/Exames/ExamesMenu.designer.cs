namespace Presentation.Exames
{
    partial class ExamesMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CampoCor = new System.Windows.Forms.TextBox();
            this.CampoSexo = new System.Windows.Forms.TextBox();
            this.CampoIdade = new System.Windows.Forms.TextBox();
            this.CampoHipotese = new System.Windows.Forms.TextBox();
            this.hipoteseD = new System.Windows.Forms.Label();
            this.nomeExame = new System.Windows.Forms.Label();
            this.dataExame = new System.Windows.Forms.Label();
            this.CampoDataRealizacao = new System.Windows.Forms.MaskedTextBox();
            this.CampoExame = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CampoCrm = new System.Windows.Forms.MaskedTextBox();
            this.Emitir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CampoNome = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.CampoCPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listaExames = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CampoNome2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CampoHipotese2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CampoExame2 = new System.Windows.Forms.TextBox();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CampoData2 = new System.Windows.Forms.MaskedTextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CPF = new System.Windows.Forms.Label();
            this.BuscarCPF = new System.Windows.Forms.MaskedTextBox();
            this.ListaPedidosExame = new System.Windows.Forms.DataGridView();
            this.Nome1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu.SuspendLayout();
            this.logoPainel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.painelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaExames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CampoNome2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPedidosExame)).BeginInit();
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
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.listaExames);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(839, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pedido de Exame";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.CampoCor);
            this.groupBox1.Controls.Add(this.CampoSexo);
            this.groupBox1.Controls.Add(this.CampoIdade);
            this.groupBox1.Controls.Add(this.CampoHipotese);
            this.groupBox1.Controls.Add(this.hipoteseD);
            this.groupBox1.Controls.Add(this.nomeExame);
            this.groupBox1.Controls.Add(this.dataExame);
            this.groupBox1.Controls.Add(this.CampoDataRealizacao);
            this.groupBox1.Controls.Add(this.CampoExame);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CampoCrm);
            this.groupBox1.Controls.Add(this.Emitir);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CampoNome);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.CampoCPF);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 429);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido de Exame";
            // 
            // CampoCor
            // 
            this.CampoCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoCor.Location = new System.Drawing.Point(363, 116);
            this.CampoCor.Margin = new System.Windows.Forms.Padding(2);
            this.CampoCor.Name = "CampoCor";
            this.CampoCor.ReadOnly = true;
            this.CampoCor.Size = new System.Drawing.Size(157, 24);
            this.CampoCor.TabIndex = 63;
            // 
            // CampoSexo
            // 
            this.CampoSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoSexo.Location = new System.Drawing.Point(363, 28);
            this.CampoSexo.Margin = new System.Windows.Forms.Padding(2);
            this.CampoSexo.Name = "CampoSexo";
            this.CampoSexo.ReadOnly = true;
            this.CampoSexo.Size = new System.Drawing.Size(157, 24);
            this.CampoSexo.TabIndex = 62;
            // 
            // CampoIdade
            // 
            this.CampoIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoIdade.Location = new System.Drawing.Point(118, 119);
            this.CampoIdade.Margin = new System.Windows.Forms.Padding(2);
            this.CampoIdade.Name = "CampoIdade";
            this.CampoIdade.ReadOnly = true;
            this.CampoIdade.Size = new System.Drawing.Size(157, 24);
            this.CampoIdade.TabIndex = 61;
            // 
            // CampoHipotese
            // 
            this.CampoHipotese.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoHipotese.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoHipotese.Location = new System.Drawing.Point(117, 259);
            this.CampoHipotese.Margin = new System.Windows.Forms.Padding(2);
            this.CampoHipotese.Multiline = true;
            this.CampoHipotese.Name = "CampoHipotese";
            this.CampoHipotese.Size = new System.Drawing.Size(402, 103);
            this.CampoHipotese.TabIndex = 4;
            // 
            // hipoteseD
            // 
            this.hipoteseD.AutoSize = true;
            this.hipoteseD.BackColor = System.Drawing.Color.PaleTurquoise;
            this.hipoteseD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.hipoteseD.ForeColor = System.Drawing.Color.Black;
            this.hipoteseD.Location = new System.Drawing.Point(29, 259);
            this.hipoteseD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hipoteseD.Name = "hipoteseD";
            this.hipoteseD.Size = new System.Drawing.Size(79, 16);
            this.hipoteseD.TabIndex = 50;
            this.hipoteseD.Text = "Hipótese :";
            // 
            // nomeExame
            // 
            this.nomeExame.AutoSize = true;
            this.nomeExame.BackColor = System.Drawing.Color.PaleTurquoise;
            this.nomeExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.nomeExame.ForeColor = System.Drawing.Color.Black;
            this.nomeExame.Location = new System.Drawing.Point(45, 170);
            this.nomeExame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomeExame.Name = "nomeExame";
            this.nomeExame.Size = new System.Drawing.Size(63, 16);
            this.nomeExame.TabIndex = 48;
            this.nomeExame.Text = "Exame :";
            // 
            // dataExame
            // 
            this.dataExame.AutoSize = true;
            this.dataExame.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dataExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataExame.ForeColor = System.Drawing.Color.Black;
            this.dataExame.Location = new System.Drawing.Point(304, 172);
            this.dataExame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataExame.Name = "dataExame";
            this.dataExame.Size = new System.Drawing.Size(49, 16);
            this.dataExame.TabIndex = 47;
            this.dataExame.Text = "Data :";
            // 
            // CampoDataRealizacao
            // 
            this.CampoDataRealizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoDataRealizacao.Location = new System.Drawing.Point(363, 166);
            this.CampoDataRealizacao.Mask = "00/00/0000";
            this.CampoDataRealizacao.Name = "CampoDataRealizacao";
            this.CampoDataRealizacao.Size = new System.Drawing.Size(157, 24);
            this.CampoDataRealizacao.TabIndex = 2;
            this.CampoDataRealizacao.ValidatingType = typeof(System.DateTime);
            // 
            // CampoExame
            // 
            this.CampoExame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoExame.Location = new System.Drawing.Point(117, 166);
            this.CampoExame.Margin = new System.Windows.Forms.Padding(2);
            this.CampoExame.Name = "CampoExame";
            this.CampoExame.ReadOnly = true;
            this.CampoExame.Size = new System.Drawing.Size(158, 24);
            this.CampoExame.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "CRM :";
            // 
            // CampoCrm
            // 
            this.CampoCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoCrm.Location = new System.Drawing.Point(117, 212);
            this.CampoCrm.Margin = new System.Windows.Forms.Padding(2);
            this.CampoCrm.Name = "CampoCrm";
            this.CampoCrm.Size = new System.Drawing.Size(158, 24);
            this.CampoCrm.TabIndex = 3;
            this.CampoCrm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Emitir
            // 
            this.Emitir.Cursor = System.Windows.Forms.Cursors.Default;
            this.Emitir.FlatAppearance.BorderSize = 0;
            this.Emitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Emitir.Location = new System.Drawing.Point(117, 378);
            this.Emitir.Margin = new System.Windows.Forms.Padding(2);
            this.Emitir.Name = "Emitir";
            this.Emitir.Size = new System.Drawing.Size(123, 43);
            this.Emitir.TabIndex = 5;
            this.Emitir.Text = "Emitir";
            this.Emitir.UseVisualStyleBackColor = true;
            this.Emitir.Click += new System.EventHandler(this.Emitir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(60, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "CPF :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(51, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nome :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(53, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Idade :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(312, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Cor :";
            // 
            // CampoNome
            // 
            this.CampoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoNome.Location = new System.Drawing.Point(117, 75);
            this.CampoNome.Margin = new System.Windows.Forms.Padding(2);
            this.CampoNome.Name = "CampoNome";
            this.CampoNome.ReadOnly = true;
            this.CampoNome.Size = new System.Drawing.Size(402, 24);
            this.CampoNome.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(313, 378);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 43);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CampoCPF
            // 
            this.CampoCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoCPF.Location = new System.Drawing.Point(117, 28);
            this.CampoCPF.Margin = new System.Windows.Forms.Padding(2);
            this.CampoCPF.Mask = "000.000.000-00";
            this.CampoCPF.Name = "CampoCPF";
            this.CampoCPF.Size = new System.Drawing.Size(158, 24);
            this.CampoCPF.TabIndex = 1;
            this.CampoCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CampoCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CampoCPF_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(304, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Sexo :";
            // 
            // listaExames
            // 
            this.listaExames.AllowUserToAddRows = false;
            this.listaExames.BackgroundColor = System.Drawing.Color.White;
            this.listaExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaExames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.listaExames.Dock = System.Windows.Forms.DockStyle.Right;
            this.listaExames.Location = new System.Drawing.Point(550, 3);
            this.listaExames.Name = "listaExames";
            this.listaExames.RowHeadersWidth = 51;
            this.listaExames.Size = new System.Drawing.Size(286, 429);
            this.listaExames.TabIndex = 10;
            this.listaExames.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaExames_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Exames";
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
            this.CampoNome2.Controls.Add(this.ListaPedidosExame);
            this.CampoNome2.Location = new System.Drawing.Point(4, 22);
            this.CampoNome2.Name = "CampoNome2";
            this.CampoNome2.Padding = new System.Windows.Forms.Padding(3);
            this.CampoNome2.Size = new System.Drawing.Size(839, 435);
            this.CampoNome2.TabIndex = 2;
            this.CampoNome2.Text = "Atualizar Exame";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CampoHipotese2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.CampoExame2);
            this.panel2.Controls.Add(this.buttonAtualizar);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CampoData2);
            this.panel2.Controls.Add(this.labelNome);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.CPF);
            this.panel2.Controls.Add(this.BuscarCPF);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(548, 429);
            this.panel2.TabIndex = 18;
            // 
            // CampoHipotese2
            // 
            this.CampoHipotese2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoHipotese2.Enabled = false;
            this.CampoHipotese2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoHipotese2.Location = new System.Drawing.Point(117, 210);
            this.CampoHipotese2.Margin = new System.Windows.Forms.Padding(2);
            this.CampoHipotese2.Multiline = true;
            this.CampoHipotese2.Name = "CampoHipotese2";
            this.CampoHipotese2.ReadOnly = true;
            this.CampoHipotese2.Size = new System.Drawing.Size(402, 142);
            this.CampoHipotese2.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(292, 157);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 66;
            this.label13.Text = "Exame :";
            // 
            // CampoExame2
            // 
            this.CampoExame2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoExame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoExame2.Location = new System.Drawing.Point(364, 153);
            this.CampoExame2.Margin = new System.Windows.Forms.Padding(2);
            this.CampoExame2.Name = "CampoExame2";
            this.CampoExame2.ReadOnly = true;
            this.CampoExame2.Size = new System.Drawing.Size(156, 24);
            this.CampoExame2.TabIndex = 65;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAtualizar.FlatAppearance.BorderSize = 0;
            this.buttonAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAtualizar.Location = new System.Drawing.Point(117, 373);
            this.buttonAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(123, 43);
            this.buttonAtualizar.TabIndex = 4;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(313, 373);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Hipótese :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(59, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Data :";
            // 
            // CampoData2
            // 
            this.CampoData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoData2.Location = new System.Drawing.Point(117, 152);
            this.CampoData2.Mask = "00/00/0000";
            this.CampoData2.Name = "CampoData2";
            this.CampoData2.Size = new System.Drawing.Size(156, 24);
            this.CampoData2.SkipLiterals = false;
            this.CampoData2.TabIndex = 2;
            this.CampoData2.ValidatingType = typeof(System.DateTime);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelNome.ForeColor = System.Drawing.Color.Black;
            this.labelNome.Location = new System.Drawing.Point(56, 102);
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
            this.textBox2.Location = new System.Drawing.Point(117, 98);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(402, 24);
            this.textBox2.TabIndex = 18;
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.BackColor = System.Drawing.Color.Transparent;
            this.CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CPF.ForeColor = System.Drawing.Color.Black;
            this.CPF.Location = new System.Drawing.Point(64, 48);
            this.CPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(45, 16);
            this.CPF.TabIndex = 17;
            this.CPF.Text = "CPF :";
            // 
            // BuscarCPF
            // 
            this.BuscarCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarCPF.Location = new System.Drawing.Point(117, 42);
            this.BuscarCPF.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarCPF.Mask = "000.000.000-00";
            this.BuscarCPF.Name = "BuscarCPF";
            this.BuscarCPF.Size = new System.Drawing.Size(143, 26);
            this.BuscarCPF.TabIndex = 4;
            this.BuscarCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BuscarCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarCPF_KeyPress);
            // 
            // ListaPedidosExame
            // 
            this.ListaPedidosExame.AllowUserToAddRows = false;
            this.ListaPedidosExame.AllowUserToOrderColumns = true;
            this.ListaPedidosExame.BackgroundColor = System.Drawing.Color.White;
            this.ListaPedidosExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaPedidosExame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome1});
            this.ListaPedidosExame.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListaPedidosExame.Location = new System.Drawing.Point(550, 3);
            this.ListaPedidosExame.Name = "ListaPedidosExame";
            this.ListaPedidosExame.RowHeadersWidth = 51;
            this.ListaPedidosExame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaPedidosExame.Size = new System.Drawing.Size(286, 429);
            this.ListaPedidosExame.TabIndex = 1;
            this.ListaPedidosExame.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            this.ListaPedidosExame.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaPedidosExame_CellDoubleClick);
            // 
            // Nome1
            // 
            this.Nome1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome1.HeaderText = "Pedidos";
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
            // ExamesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(968, 526);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.painelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExamesMenu";
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaExames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CampoNome2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPedidosExame)).EndInit();
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
        private System.Windows.Forms.DataGridView ListaPedidosExame;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridView listaExames;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CampoNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox CampoCPF;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Emitir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.MaskedTextBox CampoDataRealizacao;
        private System.Windows.Forms.TextBox CampoExame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox CampoCrm;
        private System.Windows.Forms.Label dataExame;
        private System.Windows.Forms.Label nomeExame;
        private System.Windows.Forms.Label hipoteseD;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox CampoData2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CampoExame2;
        private System.Windows.Forms.TextBox CampoHipotese;
        private System.Windows.Forms.TextBox CampoHipotese2;
        private System.Windows.Forms.TextBox CampoCor;
        private System.Windows.Forms.TextBox CampoSexo;
        private System.Windows.Forms.TextBox CampoIdade;
    }
}

