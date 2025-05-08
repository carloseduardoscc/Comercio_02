using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio_02
{
    public partial class CadProdutos : Form
    {
        ConectaProd prod = new ConectaProd();
        public CadProdutos()
        {
            InitializeComponent();
            prod.AtualizaGride(dgCadClientes);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            prod.id = Int32.Parse(txtidCadproduto.Text);
            prod.Produto = txtProduto.Text;
            prod.Marca = txtmarca.Text;
            prod.Modelo = txtmodelo.Text;
            prod.Preco = decimal.Parse(txtPreco.Text);
            prod.Data = DateTime.Parse(txtdatacadproduto.Text);
            prod.AlterarProduto();
            prod.AtualizaGride(dgCadClientes);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            prod.Produto = txtProduto.Text;
            prod.Marca = txtmarca.Text;
            prod.Modelo = txtmodelo.Text;
            prod.Preco = decimal.Parse(txtPreco.Text);
            prod.Data = DateTime.Parse(txtdatacadproduto.Text);
            prod.InserirProduto();
            prod.AtualizaGride(dgCadClientes);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtidCadproduto.Clear();
            txtProduto.Clear();
            txtmarca.Clear();
            txtmodelo.Clear();
            txtPreco.Clear();
            txtdatacadproduto.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            prod.id = Int32.Parse(txtidCadproduto.Text);
            prod.ExcluirProduto();
            prod.AtualizaGride(dgCadClientes);
        }
    }
}
