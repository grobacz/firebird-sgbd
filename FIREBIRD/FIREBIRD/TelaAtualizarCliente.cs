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

namespace FIREBIRD
{
    public partial class TelaAtualizarCliente : Form
    {
        ClienteDAO clienteDao;
        String cpfAntigo;

        public TelaAtualizarCliente(Cliente cliente)
        {
            InitializeComponent();
            this.clienteDao = new ClienteDAO();
            cpfAntigo = cliente.Cpf;

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

                clienteDao.Atualizar(cpfAntigo, cpf, nome, endereco, telefone, dataNascimento);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
