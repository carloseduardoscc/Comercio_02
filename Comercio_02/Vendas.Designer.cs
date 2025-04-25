namespace Comercio_02
{
    partial class Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalComDesconto = new System.Windows.Forms.TextBox();
            this.txtTotalSemDesconto = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.dtgProdutos = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.btnSelecionarProduto = new System.Windows.Forms.Button();
            this.dtDataCompra = new System.Windows.Forms.DateTimePicker();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.nudDesconto = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENDAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOTAL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "DataCompra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "IDCliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(274, 161);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(45, 20);
            this.txtIdCliente.TabIndex = 3;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(325, 161);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(244, 20);
            this.txtNomeCliente.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "IDProd";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(591, 161);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(45, 20);
            this.txtIdProduto.TabIndex = 5;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(642, 161);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(237, 20);
            this.txtNomeProduto.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotal.Location = new System.Drawing.Point(706, 67);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(133, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Preço Unitário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Desconto %";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(657, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total sem desconto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(778, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Total com desconto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "ID";
            // 
            // txtTotalComDesconto
            // 
            this.txtTotalComDesconto.Location = new System.Drawing.Point(781, 240);
            this.txtTotalComDesconto.Name = "txtTotalComDesconto";
            this.txtTotalComDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtTotalComDesconto.TabIndex = 9;
            this.txtTotalComDesconto.TextChanged += new System.EventHandler(this.txtTotalComDesconto_TextChanged);
            // 
            // txtTotalSemDesconto
            // 
            this.txtTotalSemDesconto.Location = new System.Drawing.Point(660, 240);
            this.txtTotalSemDesconto.Name = "txtTotalSemDesconto";
            this.txtTotalSemDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtTotalSemDesconto.TabIndex = 10;
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(425, 240);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoUnitario.TabIndex = 13;
            this.txtPrecoUnitario.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // dtgProdutos
            // 
            this.dtgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutos.Location = new System.Drawing.Point(17, 325);
            this.dtgProdutos.Name = "dtgProdutos";
            this.dtgProdutos.Size = new System.Drawing.Size(879, 266);
            this.dtgProdutos.TabIndex = 14;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdicionar.Location = new System.Drawing.Point(17, 277);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(89, 32);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExcluir.Location = new System.Drawing.Point(121, 277);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 32);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnConfirmarCompra.Location = new System.Drawing.Point(727, 597);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(169, 32);
            this.btnConfirmarCompra.TabIndex = 18;
            this.btnConfirmarCompra.Text = "Finalizar";
            this.btnConfirmarCompra.UseVisualStyleBackColor = false;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelecionarCliente.Location = new System.Drawing.Point(327, 132);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(26, 23);
            this.btnSelecionarCliente.TabIndex = 19;
            this.btnSelecionarCliente.Text = "..";
            this.btnSelecionarCliente.UseVisualStyleBackColor = false;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.btnSelecionarCliente_Click);
            // 
            // btnSelecionarProduto
            // 
            this.btnSelecionarProduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelecionarProduto.Location = new System.Drawing.Point(642, 132);
            this.btnSelecionarProduto.Name = "btnSelecionarProduto";
            this.btnSelecionarProduto.Size = new System.Drawing.Size(26, 23);
            this.btnSelecionarProduto.TabIndex = 20;
            this.btnSelecionarProduto.Text = "..";
            this.btnSelecionarProduto.UseVisualStyleBackColor = false;
            this.btnSelecionarProduto.Click += new System.EventHandler(this.btnSelecionarProduto_Click);
            // 
            // dtDataCompra
            // 
            this.dtDataCompra.Location = new System.Drawing.Point(17, 240);
            this.dtDataCompra.Name = "dtDataCompra";
            this.dtDataCompra.Size = new System.Drawing.Size(244, 20);
            this.dtDataCompra.TabIndex = 21;
            // 
            // cbId
            // 
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(17, 128);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(118, 21);
            this.cbId.TabIndex = 23;
            this.cbId.SelectedIndexChanged += new System.EventHandler(this.cbId_SelectedIndexChanged);
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(308, 240);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(102, 20);
            this.nudQuantidade.TabIndex = 24;
            this.nudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // nudDesconto
            // 
            this.nudDesconto.Location = new System.Drawing.Point(543, 240);
            this.nudDesconto.Name = "nudDesconto";
            this.nudDesconto.Size = new System.Drawing.Size(99, 20);
            this.nudDesconto.TabIndex = 25;
            this.nudDesconto.ValueChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(17, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Última venda";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudDesconto);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.dtDataCompra);
            this.Controls.Add(this.btnSelecionarProduto);
            this.Controls.Add(this.btnSelecionarCliente);
            this.Controls.Add(this.btnConfirmarCompra);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dtgProdutos);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.txtTotalSemDesconto);
            this.Controls.Add(this.txtTotalComDesconto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Vendas";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalComDesconto;
        private System.Windows.Forms.TextBox txtTotalSemDesconto;
        private System.Windows.Forms.DataGridView dtgProdutos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Button btnSelecionarCliente;
        private System.Windows.Forms.Button btnSelecionarProduto;
        private System.Windows.Forms.DateTimePicker dtDataCompra;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.NumericUpDown nudDesconto;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Button button1;
    }
}