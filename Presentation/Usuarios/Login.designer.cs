namespace Tela
{
    partial class Login
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.fechar = new FontAwesome.Sharp.IconButton();
            this.caixaUserAdm = new System.Windows.Forms.TextBox();
            this.caixaSenhaAdm = new System.Windows.Forms.TextBox();
            this.EntrarLogin = new System.Windows.Forms.Button();
            this.Senha = new System.Windows.Forms.Label();
            this.Usuário = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.fechar);
            this.panelDesktop.Controls.Add(this.caixaUserAdm);
            this.panelDesktop.Controls.Add(this.caixaSenhaAdm);
            this.panelDesktop.Controls.Add(this.EntrarLogin);
            this.panelDesktop.Controls.Add(this.Senha);
            this.panelDesktop.Controls.Add(this.Usuário);
            this.panelDesktop.Controls.Add(this.iconPictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(462, 593);
            this.panelDesktop.TabIndex = 6;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // fechar
            // 
            this.fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.fechar.FlatAppearance.BorderSize = 0;
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.fechar.ForeColor = System.Drawing.SystemColors.Control;
            this.fechar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.fechar.IconColor = System.Drawing.Color.Gainsboro;
            this.fechar.IconSize = 16;
            this.fechar.Location = new System.Drawing.Point(428, 0);
            this.fechar.Name = "fechar";
            this.fechar.Rotation = 0D;
            this.fechar.Size = new System.Drawing.Size(34, 23);
            this.fechar.TabIndex = 7;
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // caixaUserAdm
            // 
            this.caixaUserAdm.Location = new System.Drawing.Point(133, 263);
            this.caixaUserAdm.Name = "caixaUserAdm";
            this.caixaUserAdm.Size = new System.Drawing.Size(232, 22);
            this.caixaUserAdm.TabIndex = 16;
            // 
            // caixaSenhaAdm
            // 
            this.caixaSenhaAdm.Location = new System.Drawing.Point(133, 365);
            this.caixaSenhaAdm.Name = "caixaSenhaAdm";
            this.caixaSenhaAdm.Size = new System.Drawing.Size(232, 22);
            this.caixaSenhaAdm.TabIndex = 15;
            // 
            // EntrarLogin
            // 
            this.EntrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntrarLogin.Location = new System.Drawing.Point(177, 460);
            this.EntrarLogin.Name = "EntrarLogin";
            this.EntrarLogin.Size = new System.Drawing.Size(98, 31);
            this.EntrarLogin.TabIndex = 14;
            this.EntrarLogin.Text = "Entrar";
            this.EntrarLogin.UseVisualStyleBackColor = true;
            this.EntrarLogin.Click += new System.EventHandler(this.EntrarLogin_Click);
            // 
            // Senha
            // 
            this.Senha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.ForeColor = System.Drawing.Color.Gainsboro;
            this.Senha.Location = new System.Drawing.Point(48, 365);
            this.Senha.MaximumSize = new System.Drawing.Size(100, 100);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(70, 25);
            this.Senha.TabIndex = 20;
            this.Senha.Text = "Senha";
            // 
            // Usuário
            // 
            this.Usuário.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Usuário.AutoSize = true;
            this.Usuário.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuário.ForeColor = System.Drawing.Color.Gainsboro;
            this.Usuário.Location = new System.Drawing.Point(48, 263);
            this.Usuário.Name = "Usuário";
            this.Usuário.Size = new System.Drawing.Size(79, 25);
            this.Usuário.TabIndex = 12;
            this.Usuário.Text = "Usuário";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Heartbeat;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconSize = 190;
            this.iconPictureBox1.Location = new System.Drawing.Point(133, 3);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(190, 212);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 593);
            this.Controls.Add(this.panelDesktop);
            this.Name = "Login";
            this.Text = "Login";
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox caixaUserAdm;
        private System.Windows.Forms.TextBox caixaSenhaAdm;
        private System.Windows.Forms.Button EntrarLogin;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label Usuário;
        private FontAwesome.Sharp.IconButton fechar;
    }
}