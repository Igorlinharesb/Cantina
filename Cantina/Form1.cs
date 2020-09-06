using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Cantina
{
    public partial class TelaInicial : Form
    {

        pedido novopedido = new pedido();

        public TelaInicial()
        {
            InitializeComponent();

        }

        
        // Função que limpa os campos de entrada
        void Clear()
        {
            ncliente.Text = "";
            quentp.Value = quentm.Value = quentg.Value = taxaentrega.Value = 0;
            excluipedido.Enabled = false;
            finalizapedido.Text = "Salvar Pedido";
            novopedido.Id = 0; 
        }


        // Função que povoa o Data Grid
        void PovoaDataGrid()
        {
            using (cantinaDBEntities db = new cantinaDBEntities())
            {
                dgvPedido.DataSource = db.pedidos.OrderByDescending(p=>p.Id).ToList<pedido>();
                int tot = db.pedidos.ToList<pedido>().Count();
                totalvendas.Text = String.Format("Total de Vendas: {0}", tot);
            }
        }


        // Tela Inicial
        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            PovoaDataGrid();
        }


        //Tela de Relatório
        private void Relatorio(object sender, EventArgs e)
        {
            TelaRelatorio relatorio = new TelaRelatorio();
            relatorio.Show();
        }


        private void finalizapedido_Click(object sender, EventArgs e)
        {
            string c = ncliente.Text.Trim();
            int qp = (int) quentp.Value;
            int qm = (int) quentm.Value;
            int qg = (int) quentg.Value;
            int ent = (int) taxaentrega.Value;
            double total = 7 * qp + 9 * qm + 11 * qg + ent;

            if (qp + qm + qg > 5)
            {
                total = total * 0.9875;
            }

            total = Math.Round(total, 2);


            if (c == "")
            {
                MessageBox.Show("O nome do cliente não pode ficar vazio!", "Aviso");
            }

            else
            {
                if(qp + qm + qg == 0)
                {
                    MessageBox.Show("É necessário adicionar pelo menos uma quentinha para concluir o pedido!", "Aviso!");
                }
                else
                {
                    string message = String.Format("Deseja confirmar este pedido:\n\n" +
                "Cliente: {0}\n" +
                "Quentinhas P: {1}\n" +
                "Quentinhas M: {2}\n" +
                "Quentinhas G: {3}\n" +
                "Taxa de Entrega: R$ {4:C}\n" +
                "Total: R$ {5:C}",
                c, qp, qm, qg, ent, total);


                    if (MessageBox.Show(message, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (cantinaDBEntities db = new cantinaDBEntities())
                        {
                            novopedido.cliente = c;
                            novopedido.quentinhasp = qp;
                            novopedido.quentinhasm = qm;
                            novopedido.quentinhasg = qg;
                            novopedido.entrega = ent;
                            novopedido.total = (decimal)total;

                            if (novopedido.Id == 0) // Para inserção 
                            {
                                db.pedidos.Add(novopedido);
                            }
                            else // Para atualização
                            {
                                db.Entry(novopedido).State = EntityState.Modified;
                            }
                            db.SaveChanges();

                        }
                        Clear();
                        MessageBox.Show("Pedido salvo com sucesso!!!", "Salvo com sucesso");
                        PovoaDataGrid();
                    }
                }
            }
        }

        private void dgvPedido_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPedido.CurrentRow.Index != -1)
            {
                novopedido.Id = Convert.ToInt32(dgvPedido.CurrentRow.Cells["Id"].Value);

                using (cantinaDBEntities db = new cantinaDBEntities())
                {
                    novopedido = db.pedidos.Where(x => x.Id == novopedido.Id).FirstOrDefault();
                    ncliente.Text = novopedido.cliente;
                    quentp.Value = novopedido.quentinhasp;
                    quentm.Value = novopedido.quentinhasm; 
                    quentg.Value = novopedido.quentinhasg;
                    taxaentrega.Value = novopedido.entrega;
                }

                finalizapedido.Text = "Atualizar Pedido";
                excluipedido.Enabled = true;

            }
        }

        private void excluipedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja exluir este pedido?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==  DialogResult.Yes)
            {
                using (cantinaDBEntities db = new cantinaDBEntities())
                {
                    var entry = db.Entry(novopedido);
                    if (entry.State == EntityState.Detached)
                        db.pedidos.Attach(novopedido);
                    db.pedidos.Remove(novopedido);
                    db.SaveChanges();

                    PovoaDataGrid();
                    Clear();

                    MessageBox.Show("Pedido excluído com Sucesso", "Sucesso");
                }
            }
        }

        private void gerarelatorio_Click(object sender, EventArgs e)
        {
            TelaRelatorio rel = new TelaRelatorio();

            rel.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
        }
    }
}
