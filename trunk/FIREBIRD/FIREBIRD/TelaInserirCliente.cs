using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data;

namespace FIREBIRD
{
    public partial class TelaInserirCliente : Form
    {
        ClienteDAO clienteDao;

        public TelaInserirCliente()
        {
            InitializeComponent();
            clienteDao = new ClienteDAO();
            
        }

        private void bInserirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                String nome = tbNomeCliente.Text;
                String endereco = tbEnderecaoCliente.Text;
                DateTime dataNascimento = Convert.ToDateTime(tbDataNasc.Text);
                String cpf = tbCpfCliente.Text;
                String telefone = tbTelefoneCliente.Text;

                clienteDao.Inserir(cpf, nome, endereco, telefone, dataNascimento);

                this.Close();
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
