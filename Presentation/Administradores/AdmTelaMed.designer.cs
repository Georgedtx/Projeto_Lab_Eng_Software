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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Medicos = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.ComboBox();
            this.txtAnoResidencia = new System.Windows.Forms.TextBox();
            this.checkResidente = new System.Windows.Forms.CheckBox();
            this.checkDocente = new System.Windows.Forms.CheckBox();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtMesmaSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listaMedicos = new System.Windows.Forms.DataGridView();
            this.NomeMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRMmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbasMedicos = new System.Windows.Forms.TabControl();
            this.Medicos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicos)).BeginInit();
            this.AbasMedicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Medicos
            // 
            this.Medicos.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Medicos.Controls.Add(this.groupBox1);
            this.Medicos.Controls.Add(this.listaMedicos);
            this.Medicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicos.Location = new System.Drawing.Point(4, 25);
            this.Medicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Medicos.Name = "Medicos";
            this.Medicos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Medicos.Size = new System.Drawing.Size(1196, 580);
            this.Medicos.TabIndex = 0;
            this.Medicos.Text = "Medicos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.txtAnoResidencia);
            this.groupBox1.Controls.Add(this.checkResidente);
            this.groupBox1.Controls.Add(this.checkDocente);
            this.groupBox1.Controls.Add(this.txtCrm);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtMesmaSenha);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(544, 576);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Médico";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(284, 527);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 44);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(73, 527);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(143, 44);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.FormattingEnabled = true;
            this.txtTitulo.ItemHeight = 18;
            this.txtTitulo.Items.AddRange(new object[] {
            "Bacharel",
            "Mestre",
            "Doutor"});
            this.txtTitulo.Location = new System.Drawing.Point(311, 446);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(160, 26);
            this.txtTitulo.TabIndex = 18;
            // 
            // txtAnoResidencia
            // 
            this.txtAnoResidencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnoResidencia.Enabled = false;
            this.txtAnoResidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoResidencia.Location = new System.Drawing.Point(39, 446);
            this.txtAnoResidencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnoResidencia.Name = "txtAnoResidencia";
            this.txtAnoResidencia.Size = new System.Drawing.Size(153, 29);
            this.txtAnoResidencia.TabIndex = 19;
            // 
            // checkResidente
            // 
            this.checkResidente.AutoSize = true;
            this.checkResidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkResidente.Location = new System.Drawing.Point(41, 369);
            this.checkResidente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkResidente.Name = "checkResidente";
            this.checkResidente.Size = new System.Drawing.Size(115, 24);
            this.checkResidente.TabIndex = 15;
            this.checkResidente.Text = "Residente";
            this.checkResidente.UseVisualStyleBackColor = true;
            this.checkResidente.CheckedChanged += new System.EventHandler(this.checkResidente_CheckedChanged);
            // 
            // checkDocente
            // 
            this.checkDocente.AutoSize = true;
            this.checkDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDocente.Location = new System.Drawing.Point(313, 369);
            this.checkDocente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkDocente.Name = "checkDocente";
            this.checkDocente.Size = new System.Drawing.Size(101, 24);
            this.checkDocente.TabIndex = 16;
            this.checkDocente.Text = "Docente";
            this.checkDocente.UseVisualStyleBackColor = true;
            this.checkDocente.CheckedChanged += new System.EventHandler(this.checkDocente_CheckedChanged);
            // 
            // txtCrm
            // 
            this.txtCrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrm.Location = new System.Drawing.Point(176, 309);
            this.txtCrm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(295, 29);
            this.txtCrm.TabIndex = 14;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(137, 249);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(334, 29);
            this.txtNome.TabIndex = 13;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(184, 116);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(287, 29);
            this.txtSenha.TabIndex = 11;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtMesmaSenha
            // 
            this.txtMesmaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMesmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesmaSenha.Location = new System.Drawing.Point(184, 185);
            this.txtMesmaSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMesmaSenha.Name = "txtMesmaSenha";
            this.txtMesmaSenha.Size = new System.Drawing.Size(287, 29);
            this.txtMesmaSenha.TabIndex = 12;
            this.txtMesmaSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(137, 49);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 29);
            this.txtEmail.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Repetir Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 409);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano Residência";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 409);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tit. Universitária";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 315);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "CRM:";
            // 
            // listaMedicos
            // 
            this.listaMedicos.AllowUserToAddRows = false;
            this.listaMedicos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeMD,
            this.CRMmd});
            this.listaMedicos.Dock = System.Windows.Forms.DockStyle.Right;
            this.listaMedicos.Location = new System.Drawing.Point(556, 2);
            this.listaMedicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaMedicos.Name = "listaMedicos";
            this.listaMedicos.RowHeadersWidth = 51;
            this.listaMedicos.RowTemplate.Height = 24;
            this.listaMedicos.Size = new System.Drawing.Size(637, 576);
            this.listaMedicos.TabIndex = 2;
            // 
            // NomeMD
            // 
            this.NomeMD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeMD.HeaderText = "Nome";
            this.NomeMD.MinimumWidth = 6;
            this.NomeMD.Name = "NomeMD";
            // 
            // CRMmd
            // 
            this.CRMmd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CRMmd.HeaderText = "CRM";
            this.CRMmd.MinimumWidth = 6;
            this.CRMmd.Name = "CRMmd";
            // 
            // AbasMedicos
            // 
            this.AbasMedicos.Controls.Add(this.Medicos);
            this.AbasMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AbasMedicos.ItemSize = new System.Drawing.Size(64, 21);
            this.AbasMedicos.Location = new System.Drawing.Point(0, 0);
            this.AbasMedicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AbasMedicos.Name = "AbasMedicos";
            this.AbasMedicos.SelectedIndex = 0;
            this.AbasMedicos.Size = new System.Drawing.Size(1204, 609);
            this.AbasMedicos.TabIndex = 0;
            // 
            // AdmTelaMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 609);
            this.Controls.Add(this.AbasMedicos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdmTelaMed";
            this.Text = "Médicos";
            this.Medicos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicos)).EndInit();
            this.AbasMedicos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Medicos;
        private System.Windows.Forms.TabControl AbasMedicos;
        private System.Windows.Forms.DataGridView listaMedicos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRMmd;
        private System.Windows.Forms.TextBox txtCrm;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtMesmaSenha;
        private System.Windows.Forms.ComboBox txtTitulo;
        private System.Windows.Forms.TextBox txtAnoResidencia;
        private System.Windows.Forms.CheckBox checkResidente;
        private System.Windows.Forms.CheckBox checkDocente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
    }
}