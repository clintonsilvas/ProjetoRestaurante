using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRestaurante
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }

        static public List<Pedido> ListaPedidos = new List<Pedido>();
        static public int numeroPedido=1;

        static public void SalvarPedidoEmArquivo(Pedido pedido)
        {
            string caminhoArquivo = @"C:\Unifenas\FerramentasDesenvolvimento\ProjetoRestaurante\ProjetoRestaurante\PedidosTXT\pedido" + Program.numeroPedido + ".txt";
            using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
            {
                writer.WriteLine("Pedido Número: " + pedido.Numero);
                writer.WriteLine("Data do Pedido: " + pedido.DataPedido);
                writer.WriteLine("Cliente: " + pedido.Cliente);
                writer.WriteLine("Telefone: " + pedido.Telefone);
                writer.WriteLine("Endereço: " + pedido.Endereço.Logradouro + ", " + pedido.Endereço.Endereco + ", " + pedido.Endereço.Numero + ", " + pedido.Endereço.Bairro + ", " + pedido.Endereço.Cidade);
                writer.WriteLine("Itens do Pedido:");
                foreach (var item in pedido.ListaItens)
                {
                    writer.WriteLine("- " + item);
                }
                writer.WriteLine("Tipo de Borda: " + pedido.TipoBorda);
                writer.WriteLine("Forma de Pagamento: " + pedido.FormaPagamento);
                writer.WriteLine("Valor Total: " + pedido.ValorTotal.ToString("R$0.00"));
                writer.WriteLine("Pedido Realizado em: "+ pedido.TempoRealizarPedido.ToString("00"));
                writer.WriteLine("-------------------------------");
            }
        }

    }
   
}
