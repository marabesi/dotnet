using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Fiap.PlataformaNet.Exercicio04Lib;

namespace Fiap.PlataformaNet.Exercicio04
{
    public partial class FormMovimentacao : Form
    {

        List<Cliente> listaCLientes = new List<Cliente>();

        public FormMovimentacao()
        {
            InitializeComponent();
        }

        private void incluirClienteButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Cpf = cpfTextBox.Text;
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;

            listaCLientes.Add(cliente);

            cpfTextBox.Clear();
            nomeTextBox.Clear();
            emailTextBox.Clear();
        }

        private void listarClientesButton_Click(object sender, EventArgs e)
        {
            foreach (var cliente in listaCLientes)
            {
                clienteComboBox.Items.Add(cliente);
            }
        }

        private void incluirContaButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente) clienteComboBox.SelectedItem;

            ContaCorrente conta = new ContaCorrente();

            if (especialRadioButton.Checked)
            {
                ((ContaEspecial) conta).Limite = double.Parse(limiteTextBox.Text);
            }

            conta.Banco = int.Parse(bancoTextBox.Text);
            conta.Agencia = int.Parse(AgenciaTextBox.Text);
            conta.NumeroConta = int.Parse(numContaTextBox.Text);
            conta.Correntista = cliente;

            cliente.Contas.Add(conta);
        }

        private void listarContasButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)clienteComboBox.SelectedItem;

            foreach (var conta in cliente.Contas)
            {
                contaComboBox.Items.Add(conta);
            }
        }
    }
}
