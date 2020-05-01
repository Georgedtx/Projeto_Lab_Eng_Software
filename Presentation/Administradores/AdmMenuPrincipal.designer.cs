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
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.painelTitulo = new System.Windows.Forms.Panel();
            this.minimizar = new FontAwesome.Sharp.IconButton();
            this.maximizar = new FontAwesome.Sharp.IconButton();
            this.fechar = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnGerenciar = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.logoPainel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.painelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelMenu.Controls.Add(this.btnGerenciar);
            this.panelMenu.Controls.Add(this.Exames);
            this.panelMenu.Controls.Add(this.Sair);
            this.panelMenu.Controls.Add(this.Recepcionista);
            this.panelMenu.Controls.Add(this.Medico);
            this.panelMenu.Controls.Add(this.Administrador);
            this.panelMenu.Controls.Add(this.logoPainel);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 611);
            this.panelMenu.TabIndex = 2;
            // 
            // Exames
            // 
            this.Exames.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Exames.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exames.FlatAppearance.BorderSize = 0;
            this.Exames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exames.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Exames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exames.ForeColor = System.Drawing.Color.Gainsboro;
            this.Exames.IconChar = FontAwesome.Sharp.IconChar.Vial;
            this.Exames.IconColor = System.Drawing.Color.Gainsboro;
            this.Exames.IconSize = 50;
            this.Exames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exames.Location = new System.Drawing.Point(0, 287);
            this.Exames.Margin = new System.Windows.Forms.Padding(2);
            this.Exames.Name = "Exames";
            this.Exames.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exames.Rotation = 0D;
            this.Exames.Size = new System.Drawing.Size(165, 72);
            this.Exames.TabIndex = 5;
            this.Exames.Text = "Exames";
            this.Exames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exames.UseVisualStyleBackColor = false;
            this.Exames.Click += new System.EventHandler(this.Exames_Click);
            // 
            // Sair
            // 
            this.Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sair.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Sair.FlatAppearance.BorderSize = 0;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.ForeColor = System.Drawing.Color.Gainsboro;
            this.Sair.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.Sair.IconColor = System.Drawing.Color.Gainsboro;
            this.Sair.IconSize = 50;
            this.Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sair.Location = new System.Drawing.Point(0, 539);
            this.Sair.Margin = new System.Windows.Forms.Padding(2);
            this.Sair.Name = "Sair";
            this.Sair.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sair.Rotation = 0D;
            this.Sair.Size = new System.Drawing.Size(165, 72);
            this.Sair.TabIndex = 4;
            this.Sair.Text = "Sair";
            this.Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Recepcionista
            // 
            this.Recepcionista.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Recepcionista.Dock = System.Windows.Forms.DockStyle.Top;
            this.Recepcionista.FlatAppearance.BorderSize = 0;
            this.Recepcionista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recepcionista.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Recepcionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recepcionista.ForeColor = System.Drawing.Color.Gainsboro;
            this.Recepcionista.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.Recepcionista.IconColor = System.Drawing.Color.Gainsboro;
            this.Recepcionista.IconSize = 50;
            this.Recepcionista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Recepcionista.Location = new System.Drawing.Point(0, 215);
            this.Recepcionista.Margin = new System.Windows.Forms.Padding(2);
            this.Recepcionista.Name = "Recepcionista";
            this.Recepcionista.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Recepcionista.Rotation = 0D;
            this.Recepcionista.Size = new System.Drawing.Size(165, 72);
            this.Recepcionista.TabIndex = 3;
            this.Recepcionista.Text = "Recepcionistas";
            this.Recepcionista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Recepcionista.UseVisualStyleBackColor = false;
            this.Recepcionista.Click += new System.EventHandler(this.Recepcionista_Click_1);
            // 
            // Medico
            // 
            this.Medico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Medico.Dock = System.Windows.Forms.DockStyle.Top;
            this.Medico.FlatAppearance.BorderSize = 0;
            this.Medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Medico.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medico.ForeColor = System.Drawing.Color.Gainsboro;
            this.Medico.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.Medico.IconColor = System.Drawing.Color.Gainsboro;
            this.Medico.IconSize = 50;
            this.Medico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Medico.Location = new System.Drawing.Point(0, 143);
            this.Medico.Margin = new System.Windows.Forms.Padding(2);
            this.Medico.Name = "Medico";
            this.Medico.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Medico.Rotation = 0D;
            this.Medico.Size = new System.Drawing.Size(165, 72);
            this.Medico.TabIndex = 2;
            this.Medico.Text = "Médicos";
            this.Medico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Medico.UseVisualStyleBackColor = false;
            this.Medico.Click += new System.EventHandler(this.Medico_Click_1);
            // 
            // Administrador
            // 
            this.Administrador.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Administrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Administrador.FlatAppearance.BorderSize = 0;
            this.Administrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Administrador.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Administrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrador.ForeColor = System.Drawing.Color.Gainsboro;
            this.Administrador.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.Administrador.IconColor = System.Drawing.Color.Gainsboro;
            this.Administrador.IconSize = 50;
            this.Administrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Administrador.Location = new System.Drawing.Point(0, 77);
            this.Administrador.Margin = new System.Windows.Forms.Padding(2);
            this.Administrador.Name = "Administrador";
            this.Administrador.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Administrador.Rotation = 0D;
            this.Administrador.Size = new System.Drawing.Size(165, 66);
            this.Administrador.TabIndex = 1;
            this.Administrador.Text = "Administradores";
            this.Administrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Administrador.UseVisualStyleBackColor = false;
            this.Administrador.Click += new System.EventHandler(this.Administrador_Click_1);
            // 
            // logoPainel
            // 
            this.logoPainel.Controls.Add(this.iconPictureBox2);
            this.logoPainel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPainel.Location = new System.Drawing.Point(0, 0);
            this.logoPainel.Margin = new System.Windows.Forms.Padding(2);
            this.logoPainel.Name = "logoPainel";
            this.logoPainel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoPainel.Size = new System.Drawing.Size(165, 77);
            this.logoPainel.TabIndex = 0;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Heartbeat;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconSize = 77;
            this.iconPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iconPictureBox2.Size = new System.Drawing.Size(165, 77);
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
            this.painelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTitulo.Location = new System.Drawing.Point(165, 0);
            this.painelTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.painelTitulo.Name = "painelTitulo";
            this.painelTitulo.Size = new System.Drawing.Size(919, 77);
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
            this.minimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimizar.Location = new System.Drawing.Point(810, 2);
            this.minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Rotation = 0D;
            this.minimizar.Size = new System.Drawing.Size(30, 19);
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
            this.maximizar.Location = new System.Drawing.Point(848, 2);
            this.maximizar.Margin = new System.Windows.Forms.Padding(2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Rotation = 0D;
            this.maximizar.Size = new System.Drawing.Size(30, 19);
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
            this.fechar.Location = new System.Drawing.Point(886, 2);
            this.fechar.Margin = new System.Windows.Forms.Padding(2);
            this.fechar.Name = "fechar";
            this.fechar.Rotation = 0D;
            this.fechar.Size = new System.Drawing.Size(30, 19);
            this.fechar.TabIndex = 2;
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(24, 29);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(49, 16);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(165, 77);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(919, 534);
            this.panelDesktop.TabIndex = 5;
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGerenciar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerenciar.FlatAppearance.BorderSize = 0;
            this.btnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGerenciar.IconChar = FontAwesome.Sharp.IconChar.Vial;
            this.btnGerenciar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGerenciar.IconSize = 50;
            this.btnGerenciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerenciar.Location = new System.Drawing.Point(0, 359);
            this.btnGerenciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnGerenciar.Rotation = 0D;
            this.btnGerenciar.Size = new System.Drawing.Size(165, 72);
            this.btnGerenciar.TabIndex = 6;
            this.btnGerenciar.Text = "Gerenciar Usuários";
            this.btnGerenciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerenciar.UseVisualStyleBackColor = false;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // AdmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.painelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.logoPainel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.painelTitulo.ResumeLayout(false);
            this.painelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton Recepcionista;
        private FontAwesome.Sharp.IconButton Medico;
        private FontAwesome.Sharp.IconButton Administrador;
        private System.Windows.Forms.Panel logoPainel;
        private System.Windows.Forms.Panel painelTitulo;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton minimizar;
        private FontAwesome.Sharp.IconButton maximizar;
        private FontAwesome.Sharp.IconButton fechar;
        private FontAwesome.Sharp.IconButton Sair;
        private FontAwesome.Sharp.IconButton Exames;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton btnGerenciar;
    }
}

