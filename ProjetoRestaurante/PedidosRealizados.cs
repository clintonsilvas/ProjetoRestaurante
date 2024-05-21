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
    public partial class PedidosRealizados : Form
    {
        public PedidosRealizados()
        {
            InitializeComponent();
        }

        private void PedidosRealizados_Load(object sender, EventArgs e)
        {
            foreach (Pedido item in Program.ListaPedidos)
            {
                dataGridViewPedido.Rows.Add(item.Numero, item.Cliente, item.FormaPagamento, item.DataPedido, item.TempoRealizarPedido);
            }
        }
    }
}
