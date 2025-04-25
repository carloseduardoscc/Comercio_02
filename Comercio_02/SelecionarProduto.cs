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
    public partial class SelecionarProduto : Form
    {
        public ConectaProd conectaProd = new ConectaProd();
        public int id { get; set; }
        public string produto { get; set; }

        public SelecionarProduto()
        {
            InitializeComponent();
            conectaProd.AtualizaGride(dtgProdutos);
            if (dtgProdutos.Columns.Contains("Preco"))
            {
                dtgProdutos.Columns["Preco"].DefaultCellStyle.Format = "C2";
                dtgProdutos.Columns["Preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dtgProdutos.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dtgProdutos.SelectedRows[0];

                id = Convert.ToInt32(linhaSelecionada.Cells["id"].Value);
                produto = linhaSelecionada.Cells["Produto"].Value.ToString();

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
