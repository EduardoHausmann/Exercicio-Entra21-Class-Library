namespace View
{
    partial class ContasReceber
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblValorRecebido = new System.Windows.Forms.Label();
            this.mtbValorRecebido = new System.Windows.Forms.MaskedTextBox();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblBusca = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvContaReceber = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorRecebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContaReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(15, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(79, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 19);
            this.lblId.TabIndex = 1;
            this.lblId.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(149, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(12, 72);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 19);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor";
            // 
            // lblValorRecebido
            // 
            this.lblValorRecebido.AutoSize = true;
            this.lblValorRecebido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorRecebido.Location = new System.Drawing.Point(12, 129);
            this.lblValorRecebido.Name = "lblValorRecebido";
            this.lblValorRecebido.Size = new System.Drawing.Size(103, 19);
            this.lblValorRecebido.TabIndex = 4;
            this.lblValorRecebido.Text = "Valor Recebido";
            // 
            // mtbValorRecebido
            // 
            this.mtbValorRecebido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbValorRecebido.Location = new System.Drawing.Point(12, 151);
            this.mtbValorRecebido.Mask = "999.99";
            this.mtbValorRecebido.Name = "mtbValorRecebido";
            this.mtbValorRecebido.Size = new System.Drawing.Size(149, 26);
            this.mtbValorRecebido.TabIndex = 3;
            // 
            // mtbValor
            // 
            this.mtbValor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbValor.Location = new System.Drawing.Point(12, 99);
            this.mtbValor.Mask = "999.99";
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(149, 26);
            this.mtbValor.TabIndex = 2;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(546, 27);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(73, 26);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Refresh";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(88, 194);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(73, 26);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(9, 194);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(73, 26);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(175, 30);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(51, 19);
            this.lblBusca.TabIndex = 15;
            this.lblBusca.Text = "Buscar";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(226, 27);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(314, 26);
            this.txtBusca.TabIndex = 8;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dgvContaReceber
            // 
            this.dgvContaReceber.AllowUserToAddRows = false;
            this.dgvContaReceber.AllowUserToDeleteRows = false;
            this.dgvContaReceber.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvContaReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContaReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnValor,
            this.ColumnValorRecebido});
            this.dgvContaReceber.Location = new System.Drawing.Point(175, 67);
            this.dgvContaReceber.Name = "dgvContaReceber";
            this.dgvContaReceber.ReadOnly = true;
            this.dgvContaReceber.RowHeadersVisible = false;
            this.dgvContaReceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContaReceber.Size = new System.Drawing.Size(444, 153);
            this.dgvContaReceber.TabIndex = 17;
            this.dgvContaReceber.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContaReceber_CellDoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 50;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 150;
            // 
            // ColumnValor
            // 
            this.ColumnValor.HeaderText = "Valor";
            this.ColumnValor.Name = "ColumnValor";
            this.ColumnValor.ReadOnly = true;
            this.ColumnValor.Width = 120;
            // 
            // ColumnValorRecebido
            // 
            this.ColumnValorRecebido.HeaderText = "Valor Recebido";
            this.ColumnValorRecebido.Name = "ColumnValorRecebido";
            this.ColumnValorRecebido.ReadOnly = true;
            this.ColumnValorRecebido.Width = 120;
            // 
            // ContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 227);
            this.Controls.Add(this.dgvContaReceber);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.mtbValor);
            this.Controls.Add(this.mtbValorRecebido);
            this.Controls.Add(this.lblValorRecebido);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContasReceber";
            this.Text = "Conta Receber";
            this.Load += new System.EventHandler(this.ContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContaReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblValorRecebido;
        private System.Windows.Forms.MaskedTextBox mtbValorRecebido;
        private System.Windows.Forms.MaskedTextBox mtbValor;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvContaReceber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorRecebido;
    }
}