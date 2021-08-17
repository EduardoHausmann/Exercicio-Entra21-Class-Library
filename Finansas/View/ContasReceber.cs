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
    public partial class ContasReceber : Form
    {
        public ContasReceber()
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

        private void Inserir()
        {
            ContaReceber contaReceber = new ContaReceber();
            contaReceber.Nome = txtNome.Text;
            contaReceber.Valor = Convert.ToDecimal(mtbValor.Text);
            contaReceber.ValorRecebido = Convert.ToDecimal(mtbValorRecebido.Text);

            ContaReceberRepository repositorio = new ContaReceberRepository();
            repositorio.Inserir(contaReceber);
        }

        private void Alterar()
        {
            ContaReceber contaReceber = new ContaReceber();
            contaReceber.Id = Convert.ToInt32(lblId.Text);
            contaReceber.Nome = txtNome.Text;
            contaReceber.Valor = Convert.ToDecimal(mtbValor.Text);
            contaReceber.ValorRecebido = Convert.ToDecimal(mtbValorRecebido.Text);

            ContaReceberRepository repositorio = new ContaReceberRepository();
            repositorio.Alterar(contaReceber);
        }

        private void LimparCampos()
        {
            lblId.Text = "";
            txtNome.Clear();
            mtbValor.Clear();
            mtbValorRecebido.Clear();
        }
        
        private void AtualizarTabela()
        {
            ContaReceberRepository repositorio = new ContaReceberRepository();

            string busca = txtBusca.Text;
            List<ContaReceber> contasReceber = repositorio.ObterTodos(busca);
            dgvContaReceber.RowCount = 0;
            for (int i = 0; i < contasReceber.Count; i++)
            {
                ContaReceber contaReceber = contasReceber[i];
                dgvContaReceber.Rows.Add(new object[]
                {
                    contaReceber.Id, contaReceber.Nome, contaReceber.Valor.ToString(), contaReceber.ValorRecebido.ToString()
                });

            }
        }

        private void ContasReceber_Load(object sender, EventArgs e)
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
            DialogResult resultado = MessageBox.Show("Deseja realmente Apagar?", "AVISO!", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvContaReceber.CurrentRow.Cells[0].Value);
                ContaReceberRepository repositorio = new ContaReceberRepository();
                repositorio.Apagar(id);
                AtualizarTabela();
            }
        }

        private void dgvContaReceber_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ContaReceberRepository repositorio = new ContaReceberRepository();

            int id = Convert.ToInt32(dgvContaReceber.CurrentRow.Cells[0].Value);
            ContaReceber contaReceber = repositorio.ObterPeloId(id);
            if (lblId != null)
            {
                lblId.Text = contaReceber.Id.ToString();
                txtNome.Text = contaReceber.Nome;
                mtbValor.Text = contaReceber.Valor.ToString("000.00");
                mtbValorRecebido.Text = contaReceber.ValorRecebido.ToString("000.00");
            }
        }
    }
}
