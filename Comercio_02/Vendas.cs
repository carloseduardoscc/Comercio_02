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

        public ConectaVendas conectaVendas = new ConectaVendas();
        public ConectaItensVendas conectaItensVendas = new ConectaItensVendas();
        public ConectaProd conectaProd = new ConectaProd();

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
                conectaProd.id = form.id;
                txtNomeProduto.Text = form.produto.ToString();
                txtPrecoUnitario.Text = conectaProd.PesquisaPreco().ToString();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validação de campos obrigatórios
                if (string.IsNullOrEmpty(txtIdCliente.Text)||
                    string.IsNullOrEmpty(txtIdProduto.Text) || string.IsNullOrEmpty(txtDesconto.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Interrompe a execução do código caso algum campo esteja vazio
                }

                // Validação de tipos numéricos
                if (!int.TryParse(txtIdCliente.Text, out int idCliente) ||
                    !int.TryParse(txtIdProduto.Text, out int idProduto) ||
                    !int.TryParse(txtDesconto.Text, out int desconto))
                {
                    MessageBox.Show("Por favor, preencha os campos com valores válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Interrompe a execução do código caso algum valor não seja um número válido
                }

                // Se a venda ainda não foi registrada, cria uma nova venda
                if (txtId == null || string.IsNullOrEmpty(txtId.Text))
                {
                    conectaVendas.idCliente = idCliente;
                    conectaVendas.DataCompra = dtDataCompra.Value;
                    conectaVendas.InserirVenda();
                    txtId.Text = conectaVendas.id.ToString(); // Atualiza o campo txtId com o id da nova venda
                }

                // Preenche os dados do item da venda
                conectaItensVendas.idVenda = Int32.Parse(txtId.Text); // ID da venda
                conectaItensVendas.idProduto = idProduto; // ID do produto
                conectaItensVendas.Quantidade = Int32.Parse(txtQuantidade.Text); // Quantidade (substitua conforme necessário)
                conectaItensVendas.Desconto = desconto; // Desconto (substitua conforme necessário)
                conectaItensVendas.InserirItemVenda();

                // Atualiza a grid com os itens da venda
                conectaItensVendas.AtualizaGride(dtgProdutos, Int32.Parse(txtId.Text));

                // Atualiza o total da venda
                txtTotal.Text = conectaItensVendas.CalcularTotalVenda().ToString();


            }
            catch (Exception ex)
            {
                // Em caso de erro inesperado, exibe a mensagem de erro
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ATUALIZA OS DADOS
        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidade.Text != "" && txtPrecoUnitario.Text != "" && txtDesconto.Text != "")
            {
                int quantidade = Int32.Parse(txtQuantidade.Text);
                decimal desconto = Decimal.Parse(txtDesconto.Text) / 100;
                decimal precoUnitario = Decimal.Parse(txtPrecoUnitario.Text);
                decimal subtotal = quantidade * precoUnitario;
                decimal totalDesconto = subtotal - (subtotal * desconto);
                txtTotalSemDesconto.Text = subtotal.ToString();
                txtTotalComDesconto.Text = totalDesconto.ToString();
            }
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
