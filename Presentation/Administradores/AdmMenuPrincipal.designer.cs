namespace Presentation.Administradores
{
    partial class AdmMenuPrincipal
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
            this.Exames = new FontAwesome.Sharp.IconButton();
            this.Sair = new FontAwesome.Sharp.IconButton();
            this.Recepcionista = new FontAwesome.Sharp.IconButton();
            this.Medico = new FontAwesome.Sharp.IconButton();
            this.Administrador = new FontAwesome.Sharp.IconButton();
            this.logoPainel = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.painelTitulo = new System.Windows.Forms.Panel();
            this.minimizar = new FontAwesome.Sharp.IconButton();
            this.maximizar = new FontAwesome.Sharp.IconButton();
            this.fechar = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.logoPainel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.painelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.Exames);
            this.panelMenu.Controls.Add(this.Sair);
            this.panelMenu.Controls.Add(this.Recepcionista);
            this.panelMenu.Controls.Add(this.Medico);
            this.panelMenu.Controls.Add(this.Administrador);
            this.panelMenu.Controls.Add(this.logoPainel);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 647);
            this.panelMenu.TabIndex = 2;
            // 
            // Exames
            // 
            this.Exames.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exames.FlatAppearance.BorderSize = 0;
            this.Exames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exames.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Exames.ForeColor = System.Drawing.Color.Gainsboro;
            this.Exames.IconChar = FontAwesome.Sharp.IconChar.Vial;
            this.Exames.IconColor = System.Drawing.Color.Gainsboro;
            this.Exames.IconSize = 50;
            this.Exames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exames.Location = new System.Drawing.Point(0, 412);
            this.Exames.Name = "Exames";
            this.Exames.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Exames.Rotation = 0D;
            this.Exames.Size = new System.Drawing.Size(220, 104);
            this.Exames.TabIndex = 5;
            this.Exames.Text = "Exames";
            this.Exames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exames.UseVisualStyleBackColor = true;
            this.Exames.Click += new System.EventHandler(this.Exames_Click);
            // 
            // Sair
            // 
            this.Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sair.FlatAppearance.BorderSize = 0;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Sair.ForeColor = System.Drawing.Color.Gainsboro;
            this.Sair.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.Sair.IconColor = System.Drawing.Color.Gainsboro;
            this.Sair.IconSize = 50;
            this.Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sair.Location = new System.Drawing.Point(0, 498);
            this.Sair.Name = "Sair";
            this.Sair.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Sair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sair.Rotation = 0D;
            this.Sair.Size = new System.Drawing.Size(220, 104);
            this.Sair.TabIndex = 4;
            this.Sair.Text = "Sair";
            this.Sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Recepcionista
            // 
            this.Recepcionista.Dock = System.Windows.Forms.DockStyle.Top;
            this.Recepcionista.FlatAppearance.BorderSize = 0;
            this.Recepcionista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recepcionista.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Recepcionista.ForeColor = System.Drawing.Color.Gainsboro;
            this.Recepcionista.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.Recepcionista.IconColor = System.Drawing.Color.Gainsboro;
            this.Recepcionista.IconSize = 50;
            this.Recepcionista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Recepcionista.Location = new System.Drawing.Point(0, 308);
            this.Recepcionista.Name = "Recepcionista";
            this.Recepcionista.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Recepcionista.Rotation = 0D;
            this.Recepcionista.Size = new System.Drawing.Size(220, 104);
            this.Recepcionista.TabIndex = 3;
            this.Recepcionista.Text = "Recepcionistas";
            this.Recepcionista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Recepcionista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Recepcionista.UseVisualStyleBackColor = true;
            this.Recepcionista.Click += new System.EventHandler(this.Recepcionista_Click_1);
            // 
            // Medico
            // 
            this.Medico.Dock = System.Windows.Forms.DockStyle.Top;
            this.Medico.FlatAppearance.BorderSize = 0;
            this.Medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Medico.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Medico.ForeColor = System.Drawing.Color.Gainsboro;
            this.Medico.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.Medico.IconColor = System.Drawing.Color.Gainsboro;
            this.Medico.IconSize = 50;
            this.Medico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Medico.Location = new System.Drawing.Point(0, 204);
            this.Medico.Name = "Medico";
            this.Medico.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Medico.Rotation = 0D;
            this.Medico.Size = new System.Drawing.Size(220, 104);
            this.Medico.TabIndex = 2;
            this.Medico.Text = "Medicos";
            this.Medico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Medico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Medico.UseVisualStyleBackColor = true;
            this.Medico.Click += new System.EventHandler(this.Medico_Click_1);
            // 
            // Administrador
            // 
            this.Administrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Administrador.FlatAppearance.BorderSize = 0;
            this.Administrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Administrador.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Administrador.ForeColor = System.Drawing.Color.Gainsboro;
            this.Administrador.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.Administrador.IconColor = System.Drawing.Color.Gainsboro;
            this.Administrador.IconSize = 50;
            this.Administrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Administrador.Location = new System.Drawing.Point(0, 100);
            this.Administrador.Name = "Administrador";
            this.Administrador.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Administrador.Rotation = 0D;
            this.Administrador.Size = new System.Drawing.Size(220, 104);
            this.Administrador.TabIndex = 1;
            this.Administrador.Text = "Administradores";
            this.Administrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Administrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Administrador.UseVisualStyleBackColor = true;
            this.Administrador.Click += new System.EventHandler(this.Administrador_Click_1);
            // 
            // logoPainel
            // 
            this.logoPainel.Controls.Add(this.iconPictureBox1);
            this.logoPainel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPainel.Location = new System.Drawing.Point(0, 0);
            this.logoPainel.Name = "logoPainel";
            this.logoPainel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.logoPainel.Size = new System.Drawing.Size(220, 100);
            this.logoPainel.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Heartbeat;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconSize = 100;
            this.iconPictureBox1.Location = new System.Drawing.Point(5, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(210, 100);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // painelTitulo
            // 
            this.painelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.painelTitulo.Controls.Add(this.minimizar);
            this.painelTitulo.Controls.Add(this.maximizar);
            this.painelTitulo.Controls.Add(this.fechar);
            this.painelTitulo.Controls.Add(this.lblTitleChildForm);
            this.painelTitulo.Controls.Add(this.iconCurrentChildForm);
            this.painelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTitulo.Location = new System.Drawing.Point(220, 0);
            this.painelTitulo.Name = "painelTitulo";
            this.painelTitulo.Size = new System.Drawing.Size(1070, 80);
            this.painelTitulo.TabIndex = 3;
            this.painelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.painelTitulo_MouseDown);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.minimizar.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizar.IconColor = System.Drawing.Color.Gainsboro;
            this.minimizar.IconSize = 16;
            this.minimizar.Location = new System.Drawing.Point(942, 0);
            this.minimizar.Name = "minimizar";
            this.minimizar.Rotation = 0D;
            this.minimizar.Size = new System.Drawing.Size(36, 23);
            this.minimizar.TabIndex = 4;
            this.minimizar.UseVisualStyleBackColor = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.maximizar.ForeColor = System.Drawing.SystemColors.Control;
            this.maximizar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.maximizar.IconColor = System.Drawing.Color.Gainsboro;
            this.maximizar.IconSize = 16;
            this.maximizar.Location = new System.Drawing.Point(984, 0);
            this.maximizar.Name = "maximizar";
            this.maximizar.Rotation = 0D;
            this.maximizar.Size = new System.Drawing.Size(45, 23);
            this.maximizar.TabIndex = 3;
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // fechar
            // 
            this.fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.fechar.FlatAppearance.BorderSize = 0;
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.fechar.ForeColor = System.Drawing.SystemColors.Control;
            this.fechar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.fechar.IconColor = System.Drawing.Color.Gainsboro;
            this.fechar.IconSize = 16;
            this.fechar.Location = new System.Drawing.Point(1035, 0);
            this.fechar.Name = "fechar";
            this.fechar.Rotation = 0D;
            this.fechar.Size = new System.Drawing.Size(34, 23);
            this.fechar.TabIndex = 2;
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(61, 31);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(45, 17);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.BlueViolet;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.BlueViolet;
            this.iconCurrentChildForm.IconSize = 39;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 21);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(39, 41);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 8);
            this.panel1.TabIndex = 4;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 88);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1070, 559);
            this.panelDesktop.TabIndex = 5;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 647);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.painelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.logoPainel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.painelTitulo.ResumeLayout(false);
            this.painelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton Recepcionista;
        private FontAwesome.Sharp.IconButton Medico;
        private FontAwesome.Sharp.IconButton Administrador;
        private System.Windows.Forms.Panel logoPainel;
        private System.Windows.Forms.Panel painelTitulo;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton minimizar;
        private FontAwesome.Sharp.IconButton maximizar;
        private FontAwesome.Sharp.IconButton fechar;
        private FontAwesome.Sharp.IconButton Sair;
        private FontAwesome.Sharp.IconButton Exames;
    }
}

