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

namespace Comercio_02
{
    public partial class CadClientes : Form
    {

        public string conec = @"Data Source=JUN0675611W11-1\BDSENAC;
                              Initial Catalog=BD_Comercio_02;
                              Persist Security Info=True;
                              User ID=senaclivre;Password=senaclivre";

        public SqlConnection con = null;
        SqlDataAdapter da = null;

        //Replica tabelas
        public int id { get; set; }
        public string Cliente { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime dataCadCli { get; set; }

        public CadClientes()
        {
            InitializeComponent();
        }

        private void txtidcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conec);
            sql = "INSERT INTO CadClientes (Cliente, Sobrenome, Telefone, Email, dataCadCli) " +
                "VALUES (@Cliente, @Sobrenome, @Telefone, @Email, @dataCadCli)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Cliente", txtcliente.Text);
            cmd.Parameters.AddWithValue("@Sobrenome", txtsobrenome.Text);
            cmd.Parameters.AddWithValue("@Telefone", txttelefone.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@dataCadCli", txtdata.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro adicionado!");
            con.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conec);
            sql = "update CadClientes set Cliente = @Cliente, Sobrenome = @Sobrenome, " +
                "Telefone=@Telefone, Email=@Email, dataCadCli=@dataCadCli where id = @id";

            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", txtidcliente.Text);
            cmd.Parameters.AddWithValue("@Cliente", txtcliente.Text);
            cmd.Parameters.AddWithValue("@Sobrenome", txtsobrenome.Text);
            cmd.Parameters.AddWithValue("@Telefone", txttelefone.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@dataCadCli", txtdata.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Alterado!");
            con.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conec);
            sql = "DELETE FROM CadClientes WHERE id=@id";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", txtidcliente.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Excluido!");
            con.Close();
        }

        private void dgCadClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisaCadCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtidcliente.Clear();
            txtsobrenome.Clear();
            txtemail.Clear();
            txtcliente.Clear();
            txttelefone.Clear();
            txtdata.Clear();
            txttelefone.Clear();
        }
    }
}
