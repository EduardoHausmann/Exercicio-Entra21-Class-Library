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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Visible = true;
        }

        private void btnContaPagar_Click(object sender, EventArgs e)
        {
            ContaPagar pagar = new ContaPagar();
            pagar.Visible = true;
        }

        private void btnContaReceber_Click(object sender, EventArgs e)
        {
            ContaReceber receber = new ContaReceber();
            receber.Visible = true;
        }
    }
}
