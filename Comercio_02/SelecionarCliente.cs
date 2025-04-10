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
    public partial class SelecionarCliente : Form
    {

        public ConectaCli conectaCli = new ConectaCli();
        public int id { get; set; }
        public string nome { get; set; }


        public SelecionarCliente()
        {
            InitializeComponent();
            conectaCli.AtualizaGride(dtgClientes);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Selecionar_Click(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dtgClientes.SelectedRows[0];

                id = Convert.ToInt32(linhaSelecionada.Cells["id"].Value);
                nome = linhaSelecionada.Cells["cliente"].Value.ToString() + " " + linhaSelecionada.Cells["sobrenome"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um cliente da lista.");
            }
        }
    }
}
