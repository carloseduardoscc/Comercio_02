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
        ConectaCli cli = new ConectaCli();

        public CadClientes()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            cli.Cliente = txtcliente.Text;
            cli.Sobrenome = txtsobrenome.Text;
            cli.Telefone = txttelefone.Text;
            cli.Email = txtemail.Text;
            cli.dataCadCli = DateTime.Parse(txtdata.Text);
            cli.InserirCadcli();
            cli.AtualizaGride(dgCadClientes);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            cli.id = Int32.Parse(txtidcliente.Text);
            cli.Cliente = txtcliente.Text;
            cli.Sobrenome = txtsobrenome.Text;
            cli.Telefone = txttelefone.Text;
            cli.Email = txtemail.Text;
            cli.dataCadCli = DateTime.Parse(txtdata.Text);
            cli.AlterarCadcli();
            cli.AtualizaGride(dgCadClientes);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cli.id = Int32.Parse(txtidcliente.Text);
            cli.ExcluirCadcli();
            cli.AtualizaGride(dgCadClientes);
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
