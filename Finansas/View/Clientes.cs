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
    public partial class Clientes : Form
    {
        public Clientes()
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
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = mtbCpf.Text;
            cliente.Rg = mtbRg.Text;

            ClienteRepositorio repositorio = new ClienteRepositorio();
            repositorio.Inserir(cliente);
        }

        private void Alterar()
        {
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(lblId.Text);
            cliente.Nome = txtNome.Text;
            cliente.Cpf = mtbCpf.Text;
            cliente.Rg = mtbRg.Text;

            ClienteRepositorio repositorio = new ClienteRepositorio();
            repositorio.Alterar(cliente);
        }

        private void LimparCampos()
        {
            lblId.Text = "";
            txtNome.Clear();
            mtbCpf.Clear();
            mtbRg.Clear();
        }

        private void AtualizarTabela()
        {
            ClienteRepositorio repositorio = new ClienteRepositorio();
            string busca = txtBusca.Text;

            List<Cliente> clientes = repositorio.ObterTodos(busca);
            dgvCliente.RowCount = 0;
            for (int i = 0; i < clientes.Count; i++)
            {
                Cliente cliente = clientes[i];
                dgvCliente.Rows.Add(new object[]
                {
                    cliente.Id, cliente.Nome, cliente.Cpf, cliente.Rg
                });
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
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
                int id = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
                ClienteRepositorio repositorio = new ClienteRepositorio();
                repositorio.Apagar(id);
                AtualizarTabela();
            }
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteRepositorio repositorio = new ClienteRepositorio();

            int id = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
            Cliente cliente = repositorio.ObterPeloId(id);
            if (lblId.Text != null)
            {
                lblId.Text = cliente.Id.ToString();
                txtNome.Text = cliente.Nome;
                mtbCpf.Text = cliente.Cpf;
                mtbRg.Text = cliente.Rg;
            }
        }
    }
}
