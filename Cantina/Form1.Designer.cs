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
            this.totalvendas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxaentrega)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.dgvPedido.Location = new System.Drawing.Point(12, 290);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.Size = new System.Drawing.Size(790, 299);
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
            this.label1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ncliente
            // 
            this.ncliente.Location = new System.Drawing.Point(10, 77);
            this.ncliente.Name = "ncliente";
            this.ncliente.Size = new System.Drawing.Size(117, 20);
            this.ncliente.TabIndex = 3;
            this.ncliente.TextChanged += new System.EventHandler(this.ncliente_TextChanged);
            // 
            // quentp
            // 
            this.quentp.Location = new System.Drawing.Point(163, 45);
            this.quentp.Name = "quentp";
            this.quentp.Size = new System.Drawing.Size(73, 20);
            this.quentp.TabIndex = 4;
            // 
            // quentm
            // 
            this.quentm.Location = new System.Drawing.Point(283, 45);
            this.quentm.Name = "quentm";
            this.quentm.Size = new System.Drawing.Size(70, 20);
            this.quentm.TabIndex = 5;
            // 
            // quentg
            // 
            this.quentg.Location = new System.Drawing.Point(163, 111);
            this.quentg.Name = "quentg";
            this.quentg.Size = new System.Drawing.Size(69, 20);
            this.quentg.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quentinhas M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quentinhas P";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quentinhas G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Taxa de Entrega";
            // 
            // finalizapedido
            // 
            this.finalizapedido.BackColor = System.Drawing.Color.SeaGreen;
            this.finalizapedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizapedido.ForeColor = System.Drawing.Color.White;
            this.finalizapedido.Location = new System.Drawing.Point(392, 22);
            this.finalizapedido.Name = "finalizapedido";
            this.finalizapedido.Size = new System.Drawing.Size(75, 37);
            this.finalizapedido.TabIndex = 12;
            this.finalizapedido.Text = "Salvar Pedido";
            this.finalizapedido.UseVisualStyleBackColor = false;
            this.finalizapedido.Click += new System.EventHandler(this.finalizapedido_Click);
            // 
            // gerarelatorio
            // 
            this.gerarelatorio.BackColor = System.Drawing.Color.Navy;
            this.gerarelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarelatorio.ForeColor = System.Drawing.Color.White;
            this.gerarelatorio.Location = new System.Drawing.Point(392, 108);
            this.gerarelatorio.Name = "gerarelatorio";
            this.gerarelatorio.Size = new System.Drawing.Size(75, 36);
            this.gerarelatorio.TabIndex = 13;
            this.gerarelatorio.Text = "Relatório de Vendas";
            this.gerarelatorio.UseVisualStyleBackColor = false;
            this.gerarelatorio.Click += new System.EventHandler(this.gerarelatorio_Click);
            // 
            // excluipedido
            // 
            this.excluipedido.BackColor = System.Drawing.Color.Red;
            this.excluipedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluipedido.ForeColor = System.Drawing.Color.White;
            this.excluipedido.Location = new System.Drawing.Point(392, 67);
            this.excluipedido.Margin = new System.Windows.Forms.Padding(0);
            this.excluipedido.Name = "excluipedido";
            this.excluipedido.Size = new System.Drawing.Size(75, 36);
            this.excluipedido.TabIndex = 14;
            this.excluipedido.Text = "Excluir Pedido";
            this.excluipedido.UseVisualStyleBackColor = false;
            this.excluipedido.Click += new System.EventHandler(this.excluipedido_Click);
            this.excluipedido.Paint += new System.Windows.Forms.PaintEventHandler(this.excluipedido_Paint);
            // 
            // taxaentrega
            // 
            this.taxaentrega.DecimalPlaces = 2;
            this.taxaentrega.Location = new System.Drawing.Point(285, 110);
            this.taxaentrega.Name = "taxaentrega";
            this.taxaentrega.Size = new System.Drawing.Size(69, 20);
            this.taxaentrega.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(222, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(366, 39);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cantina do Tio Bill";
            // 
            // totalvendas
            // 
            this.totalvendas.AutoSize = true;
            this.totalvendas.Location = new System.Drawing.Point(29, 592);
            this.totalvendas.Name = "totalvendas";
            this.totalvendas.Size = new System.Drawing.Size(88, 13);
            this.totalvendas.TabIndex = 17;
            this.totalvendas.Text = "Total de Vendas:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ncliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.excluipedido);
            this.panel1.Controls.Add(this.taxaentrega);
            this.panel1.Controls.Add(this.gerarelatorio);
            this.panel1.Controls.Add(this.quentp);
            this.panel1.Controls.Add(this.finalizapedido);
            this.panel1.Controls.Add(this.quentm);
            this.panel1.Controls.Add(this.quentg);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(314, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 160);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(339, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Novo Pedido";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(12, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 160);
            this.panel2.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 14);
            this.label14.TabIndex = 23;
            this.label14.Text = "**  Taxa de Entrega variável.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "*  Ao comprar mais de 4 quentinhas ganhe um desconto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Quentinhas G ..................... R$ 11,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Quentinhas M .................... R$ 9,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Quentinhas P ..................... R$ 7,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 14);
            this.label13.TabIndex = 22;
            this.label13.Text = "de 2,15%.";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 26);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nossos Preços";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(280, 136);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Limpar campos";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TelaInicial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(814, 613);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalvendas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cantina do Tio Bill";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxaentrega)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label totalvendas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

