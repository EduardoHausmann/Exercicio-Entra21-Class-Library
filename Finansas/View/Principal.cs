using System;
using System.Windows.Forms;

namespace View
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.ShowDialog();
        }

        private void btnContaPagar_Click(object sender, EventArgs e)
        {
            ContasPagar pagar = new ContasPagar();
            pagar.ShowDialog();
        }

        private void btnContaReceber_Click(object sender, EventArgs e)
        {
            ContasReceber receber = new ContasReceber();
            receber.ShowDialog();
        }
    }
}
