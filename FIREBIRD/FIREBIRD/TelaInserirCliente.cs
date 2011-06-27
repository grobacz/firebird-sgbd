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
        public TelaInserirCliente()
        {
            InitializeComponent();

            
        }

        private void bInserirCliente_Click(object sender, EventArgs e)
        {
            String nome = tbNomeCliente.Text;
            String endereco = tbEnderecaoCliente.Text;
            DateTime dataNascimento = Convert.ToDateTime(tbDataNasc.Text);
            String cpf = tbCpfCliente.Text;
            String telefone = tbTelefoneCliente.Text;

            
        }
    }
}
