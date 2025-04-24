using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio_02
{
    public class ConectaItensVendas
    {
        public ConectaItensVendas()
        {

        }

        string conexao = "Data Source = JUN0675611W11-1\\BDSENAC; Initial Catalog = BD_Comercio_02; User ID = senaclivre; Password=senaclivre";

        public SqlConnection con = null;
        SqlDataAdapter da = null;

        // Propriedades para a tabela ItensVendas
        public int id { get; set; }
        public int idVenda { get; set; }   // Chave estrangeira para Vendas
        public int idProduto { get; set; }  // Chave estrangeira para Produtos
        public int Quantidade { get; set; }
        public decimal Desconto { get; set; }

        // CRUD ItensVendas
        public void InserirItemVenda()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conexao);
            sql = "INSERT INTO ItensVendas (idVenda, idProduto, Quantidade, Desconto) VALUES (@idVenda, @idProduto, @Quantidade, @Desconto)";

            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idVenda", idVenda);
            cmd.Parameters.AddWithValue("@idProduto", idProduto);
            cmd.Parameters.AddWithValue("@Quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@Desconto", Desconto);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Item da venda registrado com sucesso!");
            con.Close();
        }

        public void AlterarItemVenda()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conexao);
            sql = "UPDATE ItensVendas SET idVenda = @idVenda, idProduto = @idProduto, Quantidade = @Quantidade, Desconto = @Desconto WHERE id = @id";

            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@idVenda", idVenda);
            cmd.Parameters.AddWithValue("@idProduto", idProduto);
            cmd.Parameters.AddWithValue("@Quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@Desconto", Desconto);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Item da venda alterado com sucesso!");
            con.Close();
        }

        public void ExcluirItemVenda()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conexao);
            sql = "DELETE FROM ItensVendas WHERE id = @id";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Item da venda excluído com sucesso!");
            con.Close();
        }

        public DataTable AtualizaGride(DataGridView dataGridView, int idVenda)
        {
            string strSql = @"
            SELECT 
                P.Produto, 
                I.Quantidade,
                I.Desconto,
                ((I.Quantidade * P.Preco) - ((P.Preco * I.Quantidade) * I.Desconto / 100)) AS TotalComDesconto
            FROM ItensVendas I
            INNER JOIN Vendas V ON I.idVenda = V.id
            INNER JOIN CadProdutos P ON I.idProduto = P.id
            WHERE V.id = "+idVenda;

            using (SqlConnection con = new SqlConnection(conexao))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView.DataSource = dt;

                return dt;
            }
        }


        public DataTable PesquisaItemVenda(DataTable x, string txtPes)
        {
            string strSql;
            strSql = "SELECT V.id AS idVenda, P.Produto, I.Quantidade, I.Desconto " +
                     "FROM ItensVendas I " +
                     "INNER JOIN Vendas V ON I.idVenda = V.id " +
                     "INNER JOIN CadProdutos P ON I.idProduto = P.id " +
                     "WHERE P.NomeProduto LIKE '%" + txtPes + "%'";

            con = new SqlConnection(conexao);
            da = new SqlDataAdapter(strSql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            x = dt;
            con.Close();
            return x;
        }

        public decimal CalcularTotalVenda()
        {
                string strSql = @"
            SELECT P.Preco, I.Quantidade, I.Desconto
            FROM ItensVendas I
            INNER JOIN CadProdutos P ON I.idProduto = P.id
            WHERE I.idVenda = @idVenda";

            con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(strSql, con);
            cmd.Parameters.AddWithValue("@idVenda", idVenda);

            decimal totalVenda = 0;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                decimal preco = reader.GetDecimal(0);  // Preço do produto
                int quantidade = reader.GetInt32(1);   // Quantidade
                decimal desconto = reader.GetInt32(2); // Desconto
                decimal subtotal = preco * quantidade;

                // Calcula o total do item (preço * quantidade - desconto)
                decimal totalItem = subtotal - (subtotal * (desconto/100));
                totalVenda += totalItem;  // Soma o total do item ao total da venda
            }
            reader.Close();
            con.Close();

            return totalVenda;
        }

        public SqlDataReader consultaPersonalizada(string strSql) {

            con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(strSql, con);
            con.Open();
            return cmd.ExecuteReader();
        }
    }
}
