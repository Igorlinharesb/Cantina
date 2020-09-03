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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.relatórioDeVendasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVendaToolStripMenuItem,
            this.listarVendasToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.novaVendaToolStripMenuItem.Text = "Nova venda";
            this.novaVendaToolStripMenuItem.Click += new System.EventHandler(this.NovaVenda);
            // 
            // listarVendasToolStripMenuItem
            // 
            this.listarVendasToolStripMenuItem.Name = "listarVendasToolStripMenuItem";
            this.listarVendasToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.listarVendasToolStripMenuItem.Text = "Listar Vendas";
            this.listarVendasToolStripMenuItem.Click += new System.EventHandler(this.ListaVendas);
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            this.relatórioDeVendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatórioDeVendasToolStripMenuItem});
            this.relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            this.relatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.relatórioDeVendasToolStripMenuItem.Text = "Relatório de Vendas";
            // 
            // gerarRelatórioDeVendasToolStripMenuItem
            // 
            this.gerarRelatórioDeVendasToolStripMenuItem.Name = "gerarRelatórioDeVendasToolStripMenuItem";
            this.gerarRelatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.gerarRelatórioDeVendasToolStripMenuItem.Text = "Gerar Relatório de Vendas";
            this.gerarRelatórioDeVendasToolStripMenuItem.Click += new System.EventHandler(this.Relatorio);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 331);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaInicial";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioDeVendasToolStripMenuItem;
    }
}

