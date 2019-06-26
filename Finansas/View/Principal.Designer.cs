namespace View
{
    partial class Principal
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
            this.btnContaPagar = new System.Windows.Forms.Button();
            this.btnContaReceber = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContaPagar
            // 
            this.btnContaPagar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaPagar.Location = new System.Drawing.Point(12, 12);
            this.btnContaPagar.Name = "btnContaPagar";
            this.btnContaPagar.Size = new System.Drawing.Size(90, 52);
            this.btnContaPagar.TabIndex = 0;
            this.btnContaPagar.Text = "Contas Pagar";
            this.btnContaPagar.UseVisualStyleBackColor = true;
            this.btnContaPagar.Click += new System.EventHandler(this.btnContaPagar_Click);
            // 
            // btnContaReceber
            // 
            this.btnContaReceber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaReceber.Location = new System.Drawing.Point(145, 12);
            this.btnContaReceber.Name = "btnContaReceber";
            this.btnContaReceber.Size = new System.Drawing.Size(90, 52);
            this.btnContaReceber.TabIndex = 1;
            this.btnContaReceber.Text = "Contas Receber";
            this.btnContaReceber.UseVisualStyleBackColor = true;
            this.btnContaReceber.Click += new System.EventHandler(this.btnContaReceber_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(73, 99);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(90, 52);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(253, 163);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnContaReceber);
            this.Controls.Add(this.btnContaPagar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContaPagar;
        private System.Windows.Forms.Button btnContaReceber;
        private System.Windows.Forms.Button btnCliente;
    }
}

