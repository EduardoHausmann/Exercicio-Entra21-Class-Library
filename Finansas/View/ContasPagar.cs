using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class ContasPagar : Form
    {
        public ContasPagar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "")
            {
                Inserir();
            }
            else
            {
                Alterar();
            }
            LimparCampos();
            AtualizarTabela();
        }

        public void Inserir()
        {
            ContaPagar contaPagar = new ContaPagar();
            contaPagar.Nome = txtNome.Text;
            contaPagar.Valor = Convert.ToDecimal(mtbValor.Text);
            contaPagar.Tipo = cbTipo.SelectedItem.ToString();

            ContaPagarRepository repositorio = new ContaPagarRepository();
            repositorio.Inserir(contaPagar);
        }

        public void Alterar()
        {
            ContaPagar contaPagar = new ContaPagar();
            contaPagar.Id = Convert.ToInt32(lblId.Text);
            contaPagar.Nome = txtNome.Text;
            contaPagar.Valor = Convert.ToDecimal(mtbValor.Text);
            contaPagar.Tipo = cbTipo.SelectedItem.ToString();

            ContaPagarRepository repositorio = new ContaPagarRepository();
            repositorio.Alterar(contaPagar);
        }

        public void LimparCampos()
        {
            lblId.Text = "";
            txtNome.Clear();
            mtbValor.Clear();
            cbTipo.SelectedIndex = -1;
        }

        public void AtualizarTabela()
        {
            ContaPagarRepository repositorio = new ContaPagarRepository();
            string busca = txtBusca.Text;
            List<ContaPagar> contasPagar = repositorio.ObterTodos(busca);
            dgvContaPagar.RowCount = 0;

            for (int i = 0; i < contasPagar.Count; i++)
            {
                ContaPagar contaPagar = contasPagar[i];
                dgvContaPagar.Rows.Add(new object[]
                {
                    contaPagar.Id, contaPagar.Nome, contaPagar.Valor.ToString(), contaPagar.Tipo
                });
            }
        }

        private void ContasPagar_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desejá realmente Apagar?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvContaPagar.CurrentRow.Cells[0].Value);
                ContaPagarRepository repositorio = new ContaPagarRepository();
                repositorio.Apagar(id);
                AtualizarTabela();
            }
        }

        private void dgvContaPagar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ContaPagarRepository repositorio = new ContaPagarRepository();

            int id = Convert.ToInt32(dgvContaPagar.CurrentRow.Cells[0].Value);
            ContaPagar contaPagar = repositorio.ObterPeloId(id);
            if (lblId != null)
            {
                txtNome.Text = contaPagar.Nome;
                mtbValor.Text = contaPagar.Valor.ToString("000.00");
                cbTipo.Text = contaPagar.Tipo.ToString();
                lblId.Text = contaPagar.Id.ToString();
            }
        }
    }
}
