namespace Presentation.Médico
{
    partial class TelaMedPrincipal
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
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.painelTitulo = new System.Windows.Forms.Panel();
            this.minimizar = new FontAwesome.Sharp.IconButton();
            this.maximizar = new FontAwesome.Sharp.IconButton();
            this.fechar = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Exames = new FontAwesome.Sharp.IconButton();
            this.Sair = new FontAwesome.Sharp.IconButton();
            this.PedidoExames = new FontAwesome.Sharp.IconButton();
            this.logoPainel = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.Medico = new FontAwesome.Sharp.IconButton();
            this.CrmTelaPrincipal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeTelaPrincipal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.painelTitulo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.logoPainel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Heartbeat;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconSize = 95;
            this.iconPictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconPictureBox2.Size = new System.Drawing.Size(232, 95);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 9;
            this.iconPictureBox2.TabStop = false;
            // 
            // painelTitulo
            // 
            this.painelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.painelTitulo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.painelTitulo.Controls.Add(this.minimizar);
            this.painelTitulo.Controls.Add(this.maximizar);
            this.painelTitulo.Controls.Add(this.fechar);
            this.painelTitulo.Controls.Add(this.lblTitleChildForm);
            this.painelTitulo.Location = new System.Drawing.Point(224, 0);
            this.painelTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.painelTitulo.Name = "painelTitulo";
            this.painelTitulo.Size = new System.Drawing.Size(1220, 95);
            this.painelTitulo.TabIndex = 10;
            this.painelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.painelTitulo_MouseDown_1);
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
            this.minimizar.Location = new System.Drawing.Point(1077, 2);
            this.minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Rotation = 0D;
            this.minimizar.Size = new System.Drawing.Size(40, 23);
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
            this.maximizar.Location = new System.Drawing.Point(1128, 2);
            this.maximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Rotation = 0D;
            this.maximizar.Size = new System.Drawing.Size(40, 23);
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
            this.fechar.Location = new System.Drawing.Point(1179, 2);
            this.fechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechar.Name = "fechar";
            this.fechar.Rotation = 0D;
            this.fechar.Size = new System.Drawing.Size(40, 23);
            this.fechar.TabIndex = 2;
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(32, 36);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(58, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelMenu.Controls.Add(this.Exames);
            this.panelMenu.Controls.Add(this.Sair);
            this.panelMenu.Controls.Add(this.PedidoExames);
            this.panelMenu.Controls.Add(this.logoPainel);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 752);
            this.panelMenu.TabIndex = 11;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
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
            this.Exames.Location = new System.Drawing.Point(0, 184);
            this.Exames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exames.Name = "Exames";
            this.Exames.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Exames.Rotation = 0D;
            this.Exames.Size = new System.Drawing.Size(220, 89);
            this.Exames.TabIndex = 5;
            this.Exames.Text = "Lista de Exames";
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
            this.Sair.Location = new System.Drawing.Point(0, 663);
            this.Sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sair.Name = "Sair";
            this.Sair.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Sair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sair.Rotation = 0D;
            this.Sair.Size = new System.Drawing.Size(220, 89);
            this.Sair.TabIndex = 4;
            this.Sair.Text = "Sair";
            this.Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // PedidoExames
            // 
            this.PedidoExames.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PedidoExames.Dock = System.Windows.Forms.DockStyle.Top;
            this.PedidoExames.FlatAppearance.BorderSize = 0;
            this.PedidoExames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PedidoExames.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PedidoExames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PedidoExames.ForeColor = System.Drawing.Color.Gainsboro;
            this.PedidoExames.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.PedidoExames.IconColor = System.Drawing.Color.Gainsboro;
            this.PedidoExames.IconSize = 50;
            this.PedidoExames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PedidoExames.Location = new System.Drawing.Point(0, 95);
            this.PedidoExames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PedidoExames.Name = "PedidoExames";
            this.PedidoExames.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PedidoExames.Rotation = 0D;
            this.PedidoExames.Size = new System.Drawing.Size(220, 89);
            this.PedidoExames.TabIndex = 3;
            this.PedidoExames.Text = "Pedido de Exames";
            this.PedidoExames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PedidoExames.UseVisualStyleBackColor = false;
            this.PedidoExames.Click += new System.EventHandler(this.Recepcionista_Click);
            // 
            // logoPainel
            // 
            this.logoPainel.Controls.Add(this.iconPictureBox1);
            this.logoPainel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPainel.Location = new System.Drawing.Point(0, 0);
            this.logoPainel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoPainel.Name = "logoPainel";
            this.logoPainel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.logoPainel.Size = new System.Drawing.Size(220, 95);
            this.logoPainel.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Heartbeat;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconSize = 95;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(220, 95);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconPictureBox1_MouseDown);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelDesktop.Controls.Add(this.Medico);
            this.panelDesktop.Controls.Add(this.CrmTelaPrincipal);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.NomeTelaPrincipal);
            this.panelDesktop.Location = new System.Drawing.Point(219, 95);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1225, 657);
            this.panelDesktop.TabIndex = 12;
            // 
            // Medico
            // 
            this.Medico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Medico.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Medico.FlatAppearance.BorderSize = 0;
            this.Medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Medico.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medico.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Medico.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.Medico.IconColor = System.Drawing.Color.LightSeaGreen;
            this.Medico.IconSize = 150;
            this.Medico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Medico.Location = new System.Drawing.Point(524, 89);
            this.Medico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Medico.Name = "Medico";
            this.Medico.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Medico.Rotation = 0D;
            this.Medico.Size = new System.Drawing.Size(161, 201);
            this.Medico.TabIndex = 24;
            this.Medico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Medico.UseVisualStyleBackColor = false;
            // 
            // CrmTelaPrincipal
            // 
            this.CrmTelaPrincipal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CrmTelaPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrmTelaPrincipal.Enabled = false;
            this.CrmTelaPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrmTelaPrincipal.Location = new System.Drawing.Point(524, 447);
            this.CrmTelaPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CrmTelaPrincipal.Name = "CrmTelaPrincipal";
            this.CrmTelaPrincipal.Size = new System.Drawing.Size(161, 29);
            this.CrmTelaPrincipal.TabIndex = 23;
            this.CrmTelaPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(568, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "CRM :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(568, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome :";
            // 
            // NomeTelaPrincipal
            // 
            this.NomeTelaPrincipal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.NomeTelaPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NomeTelaPrincipal.Enabled = false;
            this.NomeTelaPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeTelaPrincipal.Location = new System.Drawing.Point(524, 332);
            this.NomeTelaPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NomeTelaPrincipal.Name = "NomeTelaPrincipal";
            this.NomeTelaPrincipal.Size = new System.Drawing.Size(161, 29);
            this.NomeTelaPrincipal.TabIndex = 20;
            this.NomeTelaPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TelaMedPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 752);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.painelTitulo);
            this.Controls.Add(this.iconPictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaMedPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.painelTitulo.ResumeLayout(false);
            this.painelTitulo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.logoPainel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel painelTitulo;
        private FontAwesome.Sharp.IconButton minimizar;
        private FontAwesome.Sharp.IconButton maximizar;
        private FontAwesome.Sharp.IconButton fechar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton Exames;
        private FontAwesome.Sharp.IconButton Sair;
        private FontAwesome.Sharp.IconButton PedidoExames;
        private System.Windows.Forms.Panel logoPainel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox NomeTelaPrincipal;
        protected System.Windows.Forms.TextBox CrmTelaPrincipal;
        private FontAwesome.Sharp.IconButton Medico;
    }
}