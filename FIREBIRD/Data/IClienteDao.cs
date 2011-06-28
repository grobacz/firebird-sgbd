using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Classes;
using System.Windows.Forms;

namespace Data
{
    public interface IClienteDAO
    {
        void Atualizar(string cpfAntigo, string cpfNovo, string nome, string endereco, string telefone, DateTime dataNascimento);
        void Inserir(string cpf, string nome, string endereco, string telefone, DateTime dataNascimento);
        IList<Cliente> Listar();
        Cliente Recuperar(string cpf);
        void Remover(string cpf);
        void preencherDataGridView(DataGridView dgvClientes);
    }
}
