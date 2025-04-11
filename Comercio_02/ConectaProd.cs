using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

public class ConectaProd
{
    // A string de conexão com o banco de dados
    string conexao = "Data Source = JUN0675611W11-1\\BDSENAC; Initial Catalog = BD_Comercio_02; User ID = senaclivre; Password=senaclivre";

    public SqlConnection con = null;
    SqlDataAdapter da = null;

    // Propriedades para os produtos
    public int id { get; set; }
    public string Produto { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public DateTime Data { get; set; }
    public decimal Preco { get; set; }

    // CRUD - Inserir produto
    public void InserirProduto()
    {
        string sql;
        SqlCommand cmd;
        con = new SqlConnection(conexao);
        // Adiciona a coluna Preco na instrução SQL
        sql = "INSERT INTO CadProdutos (Produto, Marca, Modelo, Data, Preco) VALUES (@Produto, @Marca, @Modelo, @Data, @Preco)";

        con.Open();
        cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@Produto", Produto);
        cmd.Parameters.AddWithValue("@Marca", Marca);
        cmd.Parameters.AddWithValue("@Modelo", Modelo);
        cmd.Parameters.AddWithValue("@Data", Data);
        cmd.Parameters.AddWithValue("@Preco", Preco);  // Parâmetro para o preço

        cmd.ExecuteNonQuery();
        MessageBox.Show("Produto adicionado!");
        con.Close();
    }

    // CRUD - Alterar produto
    public void AlterarProduto()
    {
        string sql;
        SqlCommand cmd;
        con = new SqlConnection(conexao);
        // Atualiza a coluna Preco no SQL
        sql = "UPDATE CadProdutos SET Produto = @Produto, Marca = @Marca, Modelo = @Modelo, Data = @Data, Preco = @Preco WHERE id = @id";

        con.Open();
        cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@Produto", Produto);
        cmd.Parameters.AddWithValue("@Marca", Marca);
        cmd.Parameters.AddWithValue("@Modelo", Modelo);
        cmd.Parameters.AddWithValue("@Data", Data);
        cmd.Parameters.AddWithValue("@Preco", Preco);  // Parâmetro para o preço

        cmd.ExecuteNonQuery();
        MessageBox.Show("Produto alterado!");
        con.Close();
    }

    // CRUD - Excluir produto
    public void ExcluirProduto()
    {
        string sql;
        SqlCommand cmd;
        con = new SqlConnection(conexao);
        sql = "DELETE FROM CadProdutos WHERE id = @id";

        con.Open();
        cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
        MessageBox.Show("Produto excluído!");
        con.Close();
    }

    // Atualizar o DataGridView com os produtos
    public DataTable AtualizaGride(DataGridView dataGridView)
    {
        string strSql;
        // Agora a consulta SQL inclui o campo Preco
        strSql = "SELECT id, Produto, Marca, Modelo, Data, Preco FROM CadProdutos";

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

    // Pesquisar produtos pelo nome
    public DataTable PesquisaProduto(DataTable x, string txtPes)
    {
        string strSql;
        // Agora a consulta SQL inclui o campo Preco
        strSql = "SELECT id, Produto, Marca, Modelo, Data, Preco FROM CadProdutos WHERE Produto LIKE '%" + txtPes + "%'";
        con = new SqlConnection(conexao);
        da = new SqlDataAdapter(strSql, con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        con.Open();
        x = dt;
        con.Close();
        return x;
    }

    public decimal PesquisaPreco()
    {
        string strSql = "SELECT Preco FROM CadProdutos WHERE id = @id";
        con = new SqlConnection(conexao);
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("@id", id);

      
        con.Open();
        object result = cmd.ExecuteScalar();
        return Convert.ToDecimal(result);
    }
}
