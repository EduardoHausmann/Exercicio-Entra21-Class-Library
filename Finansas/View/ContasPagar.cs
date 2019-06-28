using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void Alterar()
        {
            ContaPagar contaPagar = new ContaPagar();
            contaPagar.Id = Convert.ToInt32(lblId.Text);
            contaPagar.Nome = txtNome.Text;
            contaPagar.Valor = Convert.ToDecimal(mtbValor.Text);
            contaPagar.Tipo = cbTipo.SelectedItem.ToString();
            contaPagar.DataVencimento = Convert.ToDateTime(dtpData.Value);

            ContaPagarRepositorio repositorio = new ContaPagarRepositorio();
            repositorio.Alterar(contaPagar);
        }

        public void Inserir()
        {
            ContaPagar contaPagar = new ContaPagar();
            contaPagar.Nome = txtNome.Text;
            contaPagar.Valor = Convert.ToDecimal(mtbValor.Text);
            contaPagar.Tipo = cbTipo.SelectedItem.ToString();
            contaPagar.DataVencimento = dtpData.Value;

            ContaPagarRepositorio repositorio = new ContaPagarRepositorio();
            repositorio.Inserir(contaPagar);
        }

        public void LimparCampos()
        {
            lblId.Text = "";
            txtNome.Clear();
            dtpData.Value = DateTime.Now;
            mtbValor.Clear();
            cbTipo.SelectedIndex = -1;
        }

        public void AtualizarTabela()
        {
            ContaPagarRepositorio repositorio = new ContaPagarRepositorio();
            string busca = txtBusca.Text;
            List<ContaPagar> contasPagar = repositorio.ObterTodos(busca);
            dgvContaPagar.RowCount = 0;

            for (int i = 0; i < contasPagar.Count; i++)
            {
                ContaPagar contaPagar = contasPagar[i];
                dgvContaPagar.Rows.Add(new object[]
                {
                    contaPagar.Id, contaPagar.Nome, contaPagar.Valor.ToString(), contaPagar.Tipo, contaPagar.DataVencimento.ToString()
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ContaPagarRepositorio repositorio = new ContaPagarRepositorio();

            int id = Convert.ToInt32(dgvContaPagar.CurrentRow.Cells[0].Value);
            ContaPagar contaPagar = repositorio.ObterPeloId(id);
            if (lblId != null)
            {
                txtNome.Text = contaPagar.Nome;
                dtpData.Text = contaPagar.DataVencimento.ToString();
                mtbValor.Text = contaPagar.Valor.ToString("000.00");
                cbTipo.Text = contaPagar.Tipo.ToString();
                lblId.Text = contaPagar.Id.ToString();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desejá realmente Apagar?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvContaPagar.CurrentRow.Cells[0].Value);
                ContaPagarRepositorio repositorio = new ContaPagarRepositorio();
                repositorio.Apagar(id);
                AtualizarTabela();
            }            
        }
    }
}
