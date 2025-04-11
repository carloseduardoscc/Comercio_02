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
    public class ConectaVendas
    {
        public ConectaVendas()
        {

        }

        string conexao = "Data Source = JUN0675611W11-1\\BDSENAC; Initial Catalog = BD_Comercio_02; User ID = senaclivre; Password=senaclivre";

        public SqlConnection con = null;
        SqlDataAdapter da = null;

        //Replica tabelas
        public int id { get; set; }
        public int idCliente { get; set; } // A chave estrangeira para a tabela CadClientes
        public DateTime DataCompra { get; set; }

        //CRUD VENDAS
        public void InserirVenda()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conexao);
            sql = "INSERT INTO Vendas (idCliente, DataCompra) VALUES (@idCliente, @DataCompra); SELECT SCOPE_IDENTITY();";

            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            cmd.Parameters.AddWithValue("@DataCompra", DataCompra);

            // A execução do comando agora retorna o último ID gerado
            id = Convert.ToInt32(cmd.ExecuteScalar()); // Atualiza o parâmetro id com o novo idVenda gerado

            con.Close();
        }

        public void AlterarVenda()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conexao);
            sql = "UPDATE Vendas SET idCliente = @idCliente, DataCompra = @DataCompra WHERE id = @id";

            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            cmd.Parameters.AddWithValue("@DataCompra", DataCompra);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Venda alterada com sucesso!");
            con.Close();
        }

        public void ExcluirVenda()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conexao);
            sql = "DELETE FROM Vendas WHERE id = @id";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Venda excluída com sucesso!");
            con.Close();
        }

        public DataTable AtualizaGride(DataGridView dataGridView)
        {
            string strSql;
            strSql = "SELECT V.id, C.Cliente, V.DataCompra FROM Vendas V INNER JOIN CadClientes C ON V.idCliente = C.id";

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

        public DataTable PesquisaVendaPorCliente(DataTable x, string txtPes)
        {
            string strSql;
            strSql = "SELECT V.id, C.Cliente, V.DataCompra FROM Vendas V INNER JOIN CadClientes C ON V.idCliente = C.id WHERE C.Cliente LIKE '%" + txtPes + "%'";
            con = new SqlConnection(conexao);
            da = new SqlDataAdapter(strSql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            x = dt;
            con.Close();
            return x;
        }


    }
}
