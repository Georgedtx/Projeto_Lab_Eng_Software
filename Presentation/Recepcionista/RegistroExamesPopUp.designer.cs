namespace Presentation.Recepcionista
{
    partial class RegistroExamesPopUp
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
            this.Status = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.caixaData = new System.Windows.Forms.MaskedTextBox();
            this.caixaStatus = new System.Windows.Forms.TextBox();
            this.fechar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(25, 47);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(48, 17);
            this.Status.TabIndex = 0;
            this.Status.Text = "Status";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(25, 100);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(38, 17);
            this.Data.TabIndex = 1;
            this.Data.Text = "Data";
            // 
            // caixaData
            // 
            this.caixaData.Location = new System.Drawing.Point(89, 97);
            this.caixaData.Mask = "00/00/0000 90:00";
            this.caixaData.Name = "caixaData";
            this.caixaData.Size = new System.Drawing.Size(100, 22);
            this.caixaData.TabIndex = 2;
            this.caixaData.ValidatingType = typeof(System.DateTime);
            // 
            // caixaStatus
            // 
            this.caixaStatus.Location = new System.Drawing.Point(89, 44);
            this.caixaStatus.Name = "caixaStatus";
            this.caixaStatus.Size = new System.Drawing.Size(100, 22);
            this.caixaStatus.TabIndex = 3;
            // 
            // fechar
            // 
            this.fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechar.BackColor = System.Drawing.Color.Transparent;
            this.fechar.FlatAppearance.BorderSize = 0;
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.fechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fechar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.fechar.IconColor = System.Drawing.Color.Black;
            this.fechar.IconSize = 16;
            this.fechar.Location = new System.Drawing.Point(190, -1);
            this.fechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechar.Name = "fechar";
            this.fechar.Rotation = 0D;
            this.fechar.Size = new System.Drawing.Size(35, 23);
            this.fechar.TabIndex = 4;
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // RegistroExamesPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 144);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.caixaStatus);
            this.Controls.Add(this.caixaData);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Status);
            this.Name = "RegistroExamesPopUp";
            this.Text = "RegistroExamesPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label Data;
        public System.Windows.Forms.MaskedTextBox caixaData;
        public System.Windows.Forms.TextBox caixaStatus;
        private FontAwesome.Sharp.IconButton fechar;
    }
}