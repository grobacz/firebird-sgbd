using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using System.Windows.Forms;
using Data.Classes;

namespace Control
{
    public class ControleLocacao
    {
        LocacaoDAO locacaoDao;

        public ControleLocacao()
        {
            locacaoDao = new LocacaoDAO();
        }

        public void Atualizar(int codigo, int status)
        {
            this.locacaoDao.Atualizar(codigo, status);
        }

        public void Inserir(string cpfCliente, IList<int> codigoFilmes)
        {
            this.locacaoDao.Inserir(cpfCliente, codigoFilmes);
        }

        public IList<Locacao> Listar()
        {
            return this.locacaoDao.Listar();
        }

        public Locacao Recuperar(int codigo)
        {
            return this.locacaoDao.Recuperar(codigo);
        }

        public void Remover(int codigo)
        {
            this.locacaoDao.Remover(codigo);
        }

        public void preencherDataGridView(DataGridView dgvLocacao)
        {
            this.locacaoDao.preencherDataGridView(dgvLocacao);
        }

    }
}
