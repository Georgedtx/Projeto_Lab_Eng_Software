namespace Presentation.Administradores
{
    partial class Form1
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
            this.listaExames = new System.Windows.Forms.DataGridView();
            this.Exame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Emitir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CampoNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CampoData2 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CampoExame2 = new System.Windows.Forms.TextBox();
            this.CampoRecomendacoes = new System.Windows.Forms.TextBox();
            this.hipoteseD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaExames)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaExames
            // 
            this.listaExames.AllowUserToAddRows = false;
            this.listaExames.BackgroundColor = System.Drawing.Color.White;
            this.listaExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaExames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Exame});
            this.listaExames.Location = new System.Drawing.Point(550, 0);
            this.listaExames.Name = "listaExames";
            this.listaExames.RowHeadersWidth = 51;
            this.listaExames.Size = new System.Drawing.Size(354, 504);
            this.listaExames.TabIndex = 44;
            // 
            // Exame
            // 
            this.Exame.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Exame.DataPropertyName = "Nome";
            this.Exame.HeaderText = "Laudo";
            this.Exame.MinimumWidth = 6;
            this.Exame.Name = "Exame";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.hipoteseD);
            this.groupBox1.Controls.Add(this.CampoRecomendacoes);
            this.groupBox1.Controls.Add(this.CampoExame2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.CampoData2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Controls.Add(this.CampoNome);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Emitir);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 495);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laudo Médico";
            // 
            // Emitir
            // 
            this.Emitir.Cursor = System.Windows.Forms.Cursors.Default;
            this.Emitir.FlatAppearance.BorderSize = 0;
            this.Emitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Emitir.Location = new System.Drawing.Point(122, 422);
            this.Emitir.Margin = new System.Windows.Forms.Padding(2);
            this.Emitir.Name = "Emitir";
            this.Emitir.Size = new System.Drawing.Size(123, 43);
            this.Emitir.TabIndex = 7;
            this.Emitir.Text = "Emitir";
            this.Emitir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(335, 422);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 43);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(28, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Nome :";
            // 
            // CampoNome
            // 
            this.CampoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoNome.Location = new System.Drawing.Point(89, 58);
            this.CampoNome.Margin = new System.Windows.Forms.Padding(2);
            this.CampoNome.Name = "CampoNome";
            this.CampoNome.ReadOnly = true;
            this.CampoNome.Size = new System.Drawing.Size(434, 24);
            this.CampoNome.TabIndex = 34;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelNome.ForeColor = System.Drawing.Color.Black;
            this.labelNome.Location = new System.Drawing.Point(18, 121);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(67, 16);
            this.labelNome.TabIndex = 35;
            this.labelNome.Text = "Médico :";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox1.Location = new System.Drawing.Point(89, 121);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(434, 24);
            this.textBox1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Data :";
            // 
            // CampoData2
            // 
            this.CampoData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoData2.Location = new System.Drawing.Point(89, 190);
            this.CampoData2.Mask = "00/00/0000";
            this.CampoData2.Name = "CampoData2";
            this.CampoData2.Size = new System.Drawing.Size(156, 24);
            this.CampoData2.SkipLiterals = false;
            this.CampoData2.TabIndex = 62;
            this.CampoData2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CampoData2.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(283, 195);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 67;
            this.label13.Text = "Exame :";
            // 
            // CampoExame2
            // 
            this.CampoExame2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoExame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoExame2.Location = new System.Drawing.Point(367, 192);
            this.CampoExame2.Margin = new System.Windows.Forms.Padding(2);
            this.CampoExame2.Name = "CampoExame2";
            this.CampoExame2.ReadOnly = true;
            this.CampoExame2.Size = new System.Drawing.Size(156, 24);
            this.CampoExame2.TabIndex = 68;
            // 
            // CampoRecomendacoes
            // 
            this.CampoRecomendacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoRecomendacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CampoRecomendacoes.Location = new System.Drawing.Point(89, 269);
            this.CampoRecomendacoes.Margin = new System.Windows.Forms.Padding(2);
            this.CampoRecomendacoes.Multiline = true;
            this.CampoRecomendacoes.Name = "CampoRecomendacoes";
            this.CampoRecomendacoes.Size = new System.Drawing.Size(402, 136);
            this.CampoRecomendacoes.TabIndex = 69;
            // 
            // hipoteseD
            // 
            this.hipoteseD.AutoSize = true;
            this.hipoteseD.BackColor = System.Drawing.Color.PaleTurquoise;
            this.hipoteseD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.hipoteseD.ForeColor = System.Drawing.Color.Black;
            this.hipoteseD.Location = new System.Drawing.Point(221, 242);
            this.hipoteseD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hipoteseD.Name = "hipoteseD";
            this.hipoteseD.Size = new System.Drawing.Size(134, 16);
            this.hipoteseD.TabIndex = 70;
            this.hipoteseD.Text = "Recomendações :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaExames);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listaExames)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView listaExames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Emitir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CampoNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox CampoData2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CampoExame2;
        private System.Windows.Forms.TextBox CampoRecomendacoes;
        private System.Windows.Forms.Label hipoteseD;
    }
}