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
            contaReceber.DataRecebimento = dtpDataRecebimento.Value;
            contaReceber.Recebido = rbSim.Checked;

            ContaReceberRepositorio repositorio = new ContaReceberRepositorio();
            repositorio.Inserir(contaReceber);
        }

        private void Alterar()
        {
            ContaReceber contaReceber = new ContaReceber();
            contaReceber.Id = Convert.ToInt32(lblId.Text);
            contaReceber.Nome = txtNome.Text;
            contaReceber.Valor = Convert.ToDecimal(mtbValor.Text);
            contaReceber.ValorRecebido = Convert.ToDecimal(mtbValorRecebido.Text);
            contaReceber.DataRecebimento = Convert.ToDateTime(dtpDataRecebimento.Value);
            contaReceber.Recebido = rbSim.Checked;

            ContaReceberRepositorio repositorio = new ContaReceberRepositorio();
            repositorio.Alterar(contaReceber);
        }

        private void LimparCampos()
        {
            lblId.Text = "";
            txtNome.Clear();
            mtbValor.Clear();
            mtbValorRecebido.Clear();
            dtpDataRecebimento.Value = DateTime.Now;
            rbNao.Checked = false;
            rbSim.Checked = false;
        }

        private void AtualizarTabela()
        {
            ContaReceberRepositorio repositorio = new ContaReceberRepositorio();
            string busca = txtBusca.Text;
            List<ContaReceber> contasReceber = repositorio.ObterTodos(busca);
            for (int i = 0; i < contasReceber.Count; i++)
            {
                ContaReceber contaReceber = contasReceber[i];
                dgvContaReceber.Rows.Add(new object[]
                {
                    contaReceber.Id, contaReceber.Nome, contaReceber.Valor.ToString(), contaReceber.ValorRecebido.ToString(), contaReceber.DataRecebimento.ToString(), contaReceber.Recebido.ToString()
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

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

        }
    }
}
