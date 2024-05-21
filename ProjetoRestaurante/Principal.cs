using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRestaurante
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        private int numeroPedido = 1; 

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MontarPedido montarPedido = new MontarPedido();
            montarPedido.ShowDialog();
            numeroPedido++;
        }

        private void ToolStripMenuItemPedidos_Click(object sender, EventArgs e)
        {
            PedidosRealizados pedidosRealizados = new PedidosRealizados();
            pedidosRealizados.ShowDialog();
        }

        private void segundaFeiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscolherPizzas escolherPizzas = new EscolherPizzas();
            escolherPizzas.ShowDialog();
        }
    }
}
