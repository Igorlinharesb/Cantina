using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NovaVenda(object sender, EventArgs e)
        {
            TelaNovaVenda novavenda = new TelaNovaVenda();
            novavenda.Show();
        }

        private void ListaVendas(object sender, EventArgs e)
        {
            TelaListaVendas listavendas = new TelaListaVendas();
            listavendas.Show();
        }

        private void Relatorio(object sender, EventArgs e)
        {
            TelaRelatorio relatorio = new TelaRelatorio();
            relatorio.Show();
        }
    }
}
