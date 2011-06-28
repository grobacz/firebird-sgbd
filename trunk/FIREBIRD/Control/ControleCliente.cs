using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Classes;
using Data;

namespace Control
{
    public class ControleCliente
    {
        ClienteDAO clienteDao;

        public ControleCliente()
        {
            clienteDao = new ClienteDAO();
        }


        public void Atualizar(string cpfAntigo, string cpfNovo, string nome, string endereco, string telefone, DateTime dataNascimento)
        {
            this.clienteDao.Atualizar(cpfAntigo, cpfNovo, nome, endereco, telefone, dataNascimento);
        }

        public void Inserir(string cpf, string nome, string endereco, string telefone, DateTime dataNascimento)
        {
            this.clienteDao.Inserir(cpf, nome, endereco, telefone, dataNascimento);
        }

        public IList<Cliente> Listar()
        {
            return this.clienteDao.Listar();
        }

        public Cliente Recuperar(string cpf)
        {
            return this.clienteDao.Recuperar(cpf);
        }

        public void Remover(string cpf)
        {
            this.Remover(cpf);
        }

        public void preencherDataGridView(DataGridView dgvClientes)
        {
            this.clienteDao.preencherDataGridView(dgvClientes);
        }

    }
}
