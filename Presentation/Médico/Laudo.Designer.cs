namespace Presentation.Médico
{
    partial class Laudo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Criar = new System.Windows.Forms.Button();
            this.Visualizar = new System.Windows.Forms.Button();
            this.Emitir = new System.Windows.Forms.Button();
            this.listaExames = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaExames)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleName = "";
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.Criar);
            this.groupBox1.Controls.Add(this.Visualizar);
            this.groupBox1.Controls.Add(this.Emitir);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 408);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1202, 200);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // Criar
            // 
            this.Criar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Criar.FlatAppearance.BorderSize = 0;
            this.Criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Criar.Location = new System.Drawing.Point(520, 69);
            this.Criar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Criar.Name = "Criar";
            this.Criar.Size = new System.Drawing.Size(164, 53);
            this.Criar.TabIndex = 65;
            this.Criar.Text = "Novo Laudo";
            this.Criar.UseVisualStyleBackColor = true;
            // 
            // Visualizar
            // 
            this.Visualizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Visualizar.FlatAppearance.BorderSize = 0;
            this.Visualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Visualizar.Location = new System.Drawing.Point(248, 69);
            this.Visualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.Size = new System.Drawing.Size(164, 53);
            this.Visualizar.TabIndex = 7;
            this.Visualizar.Text = "Visualizar";
            this.Visualizar.UseVisualStyleBackColor = true;
            // 
            // Emitir
            // 
            this.Emitir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Emitir.Cursor = System.Windows.Forms.Cursors.Default;
            this.Emitir.FlatAppearance.BorderSize = 0;
            this.Emitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Emitir.Location = new System.Drawing.Point(792, 69);
            this.Emitir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Emitir.Name = "Emitir";
            this.Emitir.Size = new System.Drawing.Size(164, 53);
            this.Emitir.TabIndex = 8;
            this.Emitir.Text = "Confirmar";
            this.Emitir.UseVisualStyleBackColor = true;
            // 
            // listaExames
            // 
            this.listaExames.AllowUserToAddRows = false;
            this.listaExames.BackgroundColor = System.Drawing.Color.White;
            this.listaExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaExames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.Id,
            this.Exame,
            this.Data,
            this.Estado});
            this.listaExames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaExames.Location = new System.Drawing.Point(0, 0);
            this.listaExames.Margin = new System.Windows.Forms.Padding(4);
            this.listaExames.Name = "listaExames";
            this.listaExames.RowHeadersWidth = 51;
            this.listaExames.Size = new System.Drawing.Size(1202, 408);
            this.listaExames.TabIndex = 44;
            // 
            // check
            // 
            this.check.HeaderText = "‪";
            this.check.MinimumWidth = 6;
            this.check.Name = "check";
            this.check.Width = 50;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 80;
            // 
            // Exame
            // 
            this.Exame.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Exame.DataPropertyName = "Nome";
            this.Exame.HeaderText = "Laudos";
            this.Exame.MinimumWidth = 6;
            this.Exame.Name = "Exame";
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 150;
            // 
            // Laudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 608);
            this.Controls.Add(this.listaExames);
            this.Controls.Add(this.groupBox1);
            this.Name = "Laudo";
            this.Text = "Laudo";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaExames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Visualizar;
        private System.Windows.Forms.Button Emitir;
        private System.Windows.Forms.DataGridView listaExames;
        private System.Windows.Forms.Button Criar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}