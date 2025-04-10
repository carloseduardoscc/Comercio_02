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

    // CRUD - Inserir produto
    public void InserirProduto()
    {
        string sql;
        SqlCommand cmd;
        con = new SqlConnection(conexao);
        sql = "INSERT INTO Produtos (Produto, Marca, Modelo, Data) VALUES (@Produto, @Marca, @Modelo, @Data)";

        con.Open();
        cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@Produto", Produto);
        cmd.Parameters.AddWithValue("@Marca", Marca);
        cmd.Parameters.AddWithValue("@Modelo", Modelo);
        cmd.Parameters.AddWithValue("@Data", Data);

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
        sql = "UPDATE Produtos SET Produto = @Produto, Marca = @Marca, Modelo = @Modelo, Data = @Data WHERE id = @id";

        con.Open();
        cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@Produto", Produto);
        cmd.Parameters.AddWithValue("@Marca", Marca);
        cmd.Parameters.AddWithValue("@Modelo", Modelo);
        cmd.Parameters.AddWithValue("@Data", Data);

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
        sql = "DELETE FROM Produtos WHERE id = @id";

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
        strSql = "SELECT * FROM Produtos";

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
        strSql = "SELECT * FROM Produtos WHERE Produto LIKE '%" + txtPes + "%'";
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
