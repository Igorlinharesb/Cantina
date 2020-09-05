namespace Cantina
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ncliente = new System.Windows.Forms.TextBox();
            this.quentp = new System.Windows.Forms.NumericUpDown();
            this.quentm = new System.Windows.Forms.NumericUpDown();
            this.quentg = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.finalizapedido = new System.Windows.Forms.Button();
            this.gerarelatorio = new System.Windows.Forms.Button();
            this.excluipedido = new System.Windows.Forms.Button();
            this.taxaentrega = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxaentrega)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cliente,
            this.qp,
            this.qm,
            this.qg,
            this.entrega,
            this.total});
            this.dgvPedido.Location = new System.Drawing.Point(12, 237);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.Size = new System.Drawing.Size(790, 315);
            this.dgvPedido.TabIndex = 1;
            this.dgvPedido.DoubleClick += new System.EventHandler(this.dgvPedido_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // qp
            // 
            this.qp.DataPropertyName = "quentinhasp";
            this.qp.HeaderText = "Quentinhas P";
            this.qp.Name = "qp";
            this.qp.ReadOnly = true;
            // 
            // qm
            // 
            this.qm.DataPropertyName = "quentinhasm";
            this.qm.HeaderText = "Quentinhas M";
            this.qm.Name = "qm";
            this.qm.ReadOnly = true;
            // 
            // qg
            // 
            this.qg.DataPropertyName = "quentinhasg";
            this.qg.HeaderText = "Quentinhas G";
            this.qg.Name = "qg";
            this.qg.ReadOnly = true;
            // 
            // entrega
            // 
            this.entrega.DataPropertyName = "entrega";
            this.entrega.HeaderText = "Taxa de Entrega";
            this.entrega.Name = "entrega";
            this.entrega.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // ncliente
            // 
            this.ncliente.Location = new System.Drawing.Point(16, 185);
            this.ncliente.Name = "ncliente";
            this.ncliente.Size = new System.Drawing.Size(124, 20);
            this.ncliente.TabIndex = 3;
            // 
            // quentp
            // 
            this.quentp.Location = new System.Drawing.Point(164, 185);
            this.quentp.Name = "quentp";
            this.quentp.Size = new System.Drawing.Size(73, 20);
            this.quentp.TabIndex = 4;
            // 
            // quentm
            // 
            this.quentm.Location = new System.Drawing.Point(257, 185);
            this.quentm.Name = "quentm";
            this.quentm.Size = new System.Drawing.Size(70, 20);
            this.quentm.TabIndex = 5;
            // 
            // quentg
            // 
            this.quentg.Location = new System.Drawing.Point(349, 185);
            this.quentg.Name = "quentg";
            this.quentg.Size = new System.Drawing.Size(69, 20);
            this.quentg.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quentinhas M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quentinhas P";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quentinhas G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Entrega";
            // 
            // finalizapedido
            // 
            this.finalizapedido.Location = new System.Drawing.Point(536, 168);
            this.finalizapedido.Name = "finalizapedido";
            this.finalizapedido.Size = new System.Drawing.Size(75, 37);
            this.finalizapedido.TabIndex = 12;
            this.finalizapedido.Text = "Salvar Pedido";
            this.finalizapedido.UseVisualStyleBackColor = true;
            this.finalizapedido.Click += new System.EventHandler(this.finalizapedido_Click);
            // 
            // gerarelatorio
            // 
            this.gerarelatorio.Location = new System.Drawing.Point(727, 168);
            this.gerarelatorio.Name = "gerarelatorio";
            this.gerarelatorio.Size = new System.Drawing.Size(75, 36);
            this.gerarelatorio.TabIndex = 13;
            this.gerarelatorio.Text = "Relatório de Vendas";
            this.gerarelatorio.UseVisualStyleBackColor = true;
            this.gerarelatorio.Click += new System.EventHandler(this.gerarelatorio_Click);
            // 
            // excluipedido
            // 
            this.excluipedido.Location = new System.Drawing.Point(633, 168);
            this.excluipedido.Name = "excluipedido";
            this.excluipedido.Size = new System.Drawing.Size(75, 36);
            this.excluipedido.TabIndex = 14;
            this.excluipedido.Text = "Excluir Pedido";
            this.excluipedido.UseVisualStyleBackColor = true;
            this.excluipedido.Click += new System.EventHandler(this.excluipedido_Click);
            this.excluipedido.Paint += new System.Windows.Forms.PaintEventHandler(this.excluipedido_Paint);
            // 
            // taxaentrega
            // 
            this.taxaentrega.Location = new System.Drawing.Point(444, 184);
            this.taxaentrega.Name = "taxaentrega";
            this.taxaentrega.Size = new System.Drawing.Size(69, 20);
            this.taxaentrega.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cantina do Tio Bill";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 564);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.taxaentrega);
            this.Controls.Add(this.excluipedido);
            this.Controls.Add(this.gerarelatorio);
            this.Controls.Add(this.finalizapedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quentg);
            this.Controls.Add(this.quentm);
            this.Controls.Add(this.quentp);
            this.Controls.Add(this.ncliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPedido);
            this.Name = "TelaInicial";
            this.Text = " Cantina do Tio Bill";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxaentrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn qp;
        private System.Windows.Forms.DataGridViewTextBoxColumn qm;
        private System.Windows.Forms.DataGridViewTextBoxColumn qg;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ncliente;
        private System.Windows.Forms.NumericUpDown quentp;
        private System.Windows.Forms.NumericUpDown quentm;
        private System.Windows.Forms.NumericUpDown quentg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button finalizapedido;
        private System.Windows.Forms.Button gerarelatorio;
        private System.Windows.Forms.Button excluipedido;
        private System.Windows.Forms.NumericUpDown taxaentrega;
        private System.Windows.Forms.Label label6;
    }
}

