using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            atualizarVendasDisponiveis();
        }

        private void atualizarVendasDisponiveis()
        {
            cbId.Items.Clear();
            SqlDataReader reader = conectaItensVendas.consultaPersonalizada("SELECT id FROM Vendas");
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                if(!cbId.Items.Contains(id)){
                    cbId.Items.Add(id);
                }

            }
            cbId.Items.Add("NOVA VENDA");
            cbId.SelectedIndex = cbId.Items.Count - 1;
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

            // Validação de campos obrigatórios
            if (string.IsNullOrEmpty(txtIdCliente.Text)||
                string.IsNullOrEmpty(txtIdProduto.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Interrompe a execução do código caso algum campo esteja vazio
            }

            // Validação de tipos numéricos
            if (!int.TryParse(txtIdCliente.Text, out int idCliente) ||
                !int.TryParse(txtIdProduto.Text, out int idProduto))
            {
                MessageBox.Show("Por favor, preencha os campos com valores válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Interrompe a execução do código caso algum valor não seja um número válido
            }

            // Se a venda ainda não foi registrada, cria uma nova venda
            if (cbId.SelectedValue == null)
            {
                conectaVendas.idCliente = idCliente;
                conectaVendas.DataCompra = dtDataCompra.Value;
                conectaVendas.InserirVenda();
                atualizarVendasDisponiveis();
            }

            // Preenche os dados do item da venda antes de esvaziar os campos trocando o id da venda
            conectaItensVendas.idProduto = idProduto; // ID do produto
            conectaItensVendas.Quantidade = ((int)nudQuantidade.Value); // Quantidade (substitua conforme necessário)
            conectaItensVendas.Desconto = nudDesconto.Value; // Desconto (substitua conforme necessário)
            //nudQuantidade.Value
            if (cbId.SelectedItem == "NOVA VENDA")
            {
                cbId.SelectedIndex = cbId.Items.Count - 2;
            }

            conectaItensVendas.idVenda = cbId.Text; // ID da venda
            conectaItensVendas.InserirItemVenda();

            // Atualiza a grid com os itens da venda
            conectaItensVendas.AtualizaGride(dtgProdutos, Int32.Parse(cbId.SelectedItem.ToString()));

            // Atualiza o total da venda
            txtTotal.Text = conectaItensVendas.CalcularTotalVenda().ToString();



        }

        //ATUALIZA OS DADOS
        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecoUnitario.Text != "")
            {
                decimal quantidade = nudQuantidade.Value;
                decimal desconto = nudDesconto.Value / 100;
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

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idVenda = cbId.SelectedItem.ToString();
            limparDados();
            if (cbId.SelectedItem.ToString() != "NOVA VENDA")
            {
                //SqlDataReader reader = conectaItensVendas.consultaPersonalizada("SELECT C.id, C.Cliente FROM ItensVendas I INNER JOIN Vendas V ON I.idVenda = V.id INNER JOIN CadClientes C ON V.idCliente = C.id WHERE I.idVenda = " + idVenda);
                SqlDataReader reader = conectaItensVendas.consultaPersonalizada("SELECT C.id, C.Cliente FROM Vendas V INNER JOIN CadClientes C ON V.idCliente = C.id WHERE V.id = " + idVenda);
                if (reader.Read())
                {
                    txtIdCliente.Text = reader.GetInt32(0).ToString();
                    txtNomeCliente.Text = reader.GetString(1).ToString();
                    conectaItensVendas.AtualizaGride(dtgProdutos, Int32.Parse(cbId.SelectedItem.ToString()));
                    conectaItensVendas.idVenda = cbId.Text; // ID da venda
                    txtTotal.Text = conectaItensVendas.CalcularTotalVenda().ToString();
                }
            }
        }

        public void limparDados()
        {
            txtIdProduto.Clear();
            txtNomeProduto.Clear();
            nudDesconto.Value = 0;
            txtPrecoUnitario.Clear();
            nudQuantidade.Value = 1;
            txtTotalSemDesconto.Clear();
            txtTotalComDesconto.Clear();
            txtIdCliente.Clear();
            txtNomeCliente.Clear();
            dtgProdutos.DataSource = null;
            dtgProdutos.Rows.Clear();
            dtgProdutos.Columns.Clear();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = dtgProdutos.SelectedRows[0];

            int id = Convert.ToInt32(linhaSelecionada.Cells["id"].Value);
            conectaItensVendas.id = id;
            conectaItensVendas.ExcluirItemVenda();
            conectaItensVendas.AtualizaGride(dtgProdutos, Int32.Parse(cbId.SelectedItem.ToString()));
            txtTotal.Text = conectaItensVendas.CalcularTotalVenda().ToString();
        }

        private void txtTotalComDesconto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                            cbId.SelectedIndex = cbId.Items.Count - 2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtDataCompra_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
