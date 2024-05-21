using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestaurante
{
    internal class TEndereco
    {
        private string logradouro;
        private string endereco;
        private int numero;
        private string bairro;
        private string cidade;

        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
    }
}
