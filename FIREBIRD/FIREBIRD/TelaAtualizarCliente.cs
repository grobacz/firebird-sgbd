using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Classes;
using Data;
using Control;

namespace FIREBIRD
{
    public partial class TelaAtualizarCliente : Form
    {
        ControleCliente controleCliente;
        String cpfAntigo;
        Form principal;

        public TelaAtualizarCliente(Cliente cliente, Form pai)
        {
            InitializeComponent();
            this.controleCliente = new ControleCliente();
            cpfAntigo = cliente.Cpf;
            principal = pai;

            this.tbNomeCliente.Text = cliente.Nome;
            this.tbCpfCliente.Text = cliente.Cpf;
            this.tbDataNasc.Text = cliente.DataNascimento.ToString().Substring(0,10);
            this.tbEnderecaoCliente.Text = cliente.Endereco;
            this.tbTelefoneCliente.Text = cliente.Telefone;

        }

        private void bAtualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                String nome = this.tbNomeCliente.Text;
                String cpf = this.tbCpfCliente.Text;
                DateTime dataNascimento = Convert.ToDateTime(this.tbDataNasc.Text);
                String endereco = this.tbEnderecaoCliente.Text;
                String telefone = this.tbTelefoneCliente.Text;
                //TODO foto

                controleCliente.Atualizar(cpfAntigo, cpf, nome, endereco, telefone, dataNascimento);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TelaAtualizarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)principal).CarregarClientes();
        }


    }
}
