using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestaurante
{
    internal class Pedido
    {
        private int numero;
        private string cliente;
        private string telefone;
        private TEndereco endereço;
        private string formaPagamento;
        private List<string> listaItens;
        private string tipoBorda;
        private string dataPedido;
        private double valorTotal;
        private int tempoRealizarPedido;

        public Pedido()
        {
            endereço = new TEndereco();
            listaItens = new List<string>();
        }

        public int Numero { get => numero; set => numero = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public TEndereco Endereço { get => endereço; set => endereço = value; }
        public string FormaPagamento { get => formaPagamento; set => formaPagamento = value; }
        public List<string> ListaItens { get => listaItens; set => listaItens = value; }
        public string TipoBorda { get => tipoBorda; set => tipoBorda = value; }
        public string DataPedido { get => dataPedido; set => dataPedido = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
        public int TempoRealizarPedido { get => tempoRealizarPedido; set => tempoRealizarPedido = value; }
    }
}
