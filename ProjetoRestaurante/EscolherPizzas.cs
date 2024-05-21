using System;
using System.IO;
using System.Windows.Forms;

namespace ProjetoRestaurante
{
    public partial class EscolherPizzas : Form
    {
        public EscolherPizzas()
        {
            InitializeComponent();
            timerTempoPedido.Enabled = true;
        }

        Pedido pedido = new Pedido();

        private double valorPedido;
        private int tempo;

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            Program.numeroPedido++;
            if (txtNomeCliente.Text != "") { } else { MessageBox.Show("O pedido deve ter um cliente."); }
            if (txtTelefoneCliente.Text != "") { } else { MessageBox.Show("O pedido deve ter um Telefone."); }
            if (comboBoxLogradouroCliente.SelectedItem != null) { } else { MessageBox.Show("Selecione um Logradouro"); }
            if (textBoxEnderecoCliente.Text != "") { } else { MessageBox.Show("Digite um endereço;"); }
            if (textBoxBairroCliente.Text != "") { } else { MessageBox.Show("Digite um Bairro;"); }
            if (textBoxNumeroCliente.Text != "") { } else { MessageBox.Show("Digite um Número do cliente."); }
            if (comboBoxCidadeCliente.SelectedItem != null) { } else { MessageBox.Show("Selecione uma cidade."); }

            if (checkBoxCalabresa.Checked == false && checkBoxFrango.Checked == false && checkBoxMussarela.Checked == false && checkBoxPalmito.Checked == false && checkBoxPresunto.Checked == false) { MessageBox.Show("Selecione ao menos um ingrediente."); }

            if (!radioButtonSemRecheio.Checked && !radioButtonCatupiry.Checked && !radioButtonChedar.Checked) { MessageBox.Show("Selecione ao menos uma borda."); }

            if (!radioButtonDinheiro.Checked && !radioButtonCartao.Checked && !radioButtonPix.Checked) { MessageBox.Show("Selecione uma forma de pagamento");  }

            pedido.Numero = Program.numeroPedido;
            pedido.DataPedido = dateTimePickerDataPedido.Value.ToString("dd/MM/yyyy");
            pedido.Cliente = txtNomeCliente.Text;
            pedido.Telefone = txtTelefoneCliente.Text;
            pedido.Endereço.Logradouro = comboBoxLogradouroCliente.SelectedItem.ToString();
            pedido.Endereço.Endereco = textBoxEnderecoCliente.Text;
            pedido.Endereço.Numero = int.Parse(textBoxNumeroCliente.Text);
            pedido.Endereço.Bairro = textBoxBairroCliente.Text;
            pedido.Endereço.Cidade = comboBoxCidadeCliente.Text;
            pedido.ValorTotal = valorPedido;            
            pedido.TempoRealizarPedido = tempo;
            timerTempoPedido.Enabled = false;
            Program.ListaPedidos.Add(pedido);
            Program.SalvarPedidoEmArquivo(pedido);

            MessageBox.Show("Pedido registrado");
            this.Close();
        }
        private void EscolherPizzas_Load(object sender, EventArgs e)
        {
            labelNumeroPedido.Text = Program.numeroPedido.ToString();
        }

        private void checkBoxCalabresa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCalabresa.Checked)
            {
                valorPedido += 45;
                pedido.ListaItens.Add(checkBoxCalabresa.Text);
            }
            else
            {
                valorPedido -= 45;
                pedido.ListaItens.Remove(checkBoxCalabresa.Text);
            }
            labelTotalPedido.Text = valorPedido.ToString("R$0.00");
        }

        private void checkBoxFrango_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFrango.Checked)
            {
                valorPedido += 55;
                pedido.ListaItens.Add(checkBoxFrango.Text);
            }
            else
            {
                valorPedido -= 55;
                pedido.ListaItens.Remove(checkBoxFrango.Text);
            }
            labelTotalPedido.Text = valorPedido.ToString("R$0.00");
        }

        private void checkBoxMussarela_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMussarela.Checked)
            {
                valorPedido += 58;
                pedido.ListaItens.Add(checkBoxMussarela.Text);
            }
            else
            {
                valorPedido -= 58;
                pedido.ListaItens.Remove(checkBoxMussarela.Text);
            }
            labelTotalPedido.Text = valorPedido.ToString("R$0.00");
        }

        private void checkBoxPalmito_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPalmito.Checked)
            {
                valorPedido += 59;
                pedido.ListaItens.Add(checkBoxPalmito.Text);
            }
            else
            {
                valorPedido -= 59;
                pedido.ListaItens.Remove(checkBoxPalmito.Text);
            }
            labelTotalPedido.Text = valorPedido.ToString("R$0.00");
        }

        private void checkBoxPresunto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPresunto.Checked)
            {
                valorPedido += 7;
                pedido.ListaItens.Add(checkBoxPresunto.Text);
            }
            else
            {
                valorPedido -= 7;
                pedido.ListaItens.Remove(checkBoxPresunto.Text);
            }
            labelTotalPedido.Text = valorPedido.ToString("R$0.00");
        }
               
        private void radioButtonSemRecheio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCatupiry_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCatupiry.Checked)
            {
                valorPedido += 5.60;
                pedido.TipoBorda = radioButtonSemRecheio.Text;
                labelTotalPedido.Text = valorPedido.ToString("R$0.00");
            }
            else
            {
                valorPedido -= 5.60;
                pedido.TipoBorda = "";
                labelTotalPedido.Text = valorPedido.ToString("R$0.00");
            }

        }

        private void radioButtonChedar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonChedar.Checked)
            {
                valorPedido += 5.60;
                pedido.TipoBorda = radioButtonSemRecheio.Text;
                labelTotalPedido.Text = valorPedido.ToString("R$0.00");
            }
            else
            {
                valorPedido -= 5.60;
                pedido.TipoBorda = "";
                labelTotalPedido.Text = valorPedido.ToString("R$0.00");
            }
        }

        private void radioButtonCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCocaCola.Checked)
            {
                groupBoxTamanhoRefri.Visible = true;
                pedido.ListaItens.Add(radioButtonCocaCola.Text);
            }
            else
            {
                groupBoxTamanhoRefri.Visible = false;
                pedido.ListaItens.Remove(radioButtonCocaCola.Text);
            }
        }

        private void radioButtonGuarana_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGuarana.Checked)
            {
                groupBoxTamanhoRefri.Visible = true;
                pedido.ListaItens.Add(radioButtonGuarana.Text);
            }
            else
            {
                groupBoxTamanhoRefri.Visible = false;
                pedido.ListaItens.Remove(radioButtonGuarana.Text);
            }
        }

        private void radioButtonSprite_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSprite.Checked)
            {
                groupBoxTamanhoRefri.Visible = true;
                pedido.ListaItens.Add(radioButtonSprite.Text);
            }
            else
            {
                groupBoxTamanhoRefri.Visible = false;
                pedido.ListaItens.Remove(radioButtonSprite.Text);
            }
        }

        private void radioButtonLata350_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLata350.Checked)
            {
                valorPedido += (radioButtonLata350.Checked) ? 4.00 : -4.00;
                pedido.ListaItens.Add(radioButtonLata350.Text);
                labelTotalPedido.Text = valorPedido.ToString("R$0.00");
            }
            else
            {
                pedido.ListaItens.Remove(radioButtonLata350.Text);
            }
        }

        private void radioButton1Litro_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1Litro.Checked)
            {
                valorPedido += (radioButton1Litro.Checked) ? 8.00 : -8.00;
                pedido.ListaItens.Add(radioButton1Litro.Text);
                labelTotalPedido.Text = valorPedido.ToString("R$0.00");
            }
            else
            {
                pedido.ListaItens.Remove(radioButton1Litro.Text);
            }
        }

        private void radioButton2Litros_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2Litros.Checked)
            {
                valorPedido += (radioButton2Litros.Checked) ? 12.00 : -12.00;
                pedido.ListaItens.Add(radioButton2Litros.Text);
                labelTotalPedido.Text = valorPedido.ToString("R$0.00");
            }
            else
            {
                pedido.ListaItens.Remove(radioButton2Litros.Text);
            }
        }

        private void radioButtonPix_CheckedChanged(object sender, EventArgs e)
        {
            pedido.FormaPagamento = radioButtonPix.Text;
        }

        private void radioButtonDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            pedido.FormaPagamento = radioButtonDinheiro.Text;
        }

        private void radioButtonCartao_CheckedChanged(object sender, EventArgs e)
        {
            pedido.FormaPagamento = radioButtonCartao.Text;
        }

        private void timerTempoPedido_Tick(object sender, EventArgs e)
        {
            tempo++;
        }
    }
}
