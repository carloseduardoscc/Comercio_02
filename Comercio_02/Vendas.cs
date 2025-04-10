using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio_02
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            SelecionarCliente form = new SelecionarCliente();

            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                txtIdCliente.Text = form.id.ToString();
                txtNomeCliente.Text = form.nome.ToString();
            }
        }

        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            SelecionarProduto form = new SelecionarProduto();

            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                txtIdProduto.Text = form.id.ToString();
                txtNomeProduto.Text = form.produto.ToString();
            }
        }
    }
}
