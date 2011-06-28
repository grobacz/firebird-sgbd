using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Data.Classes;
using System.Windows.Forms;

namespace Control
{
    public class ControleFilme : IFilmeDAO
    {
        private FilmeDAO filmeDao;

        public ControleFilme()
        {
            filmeDao = new FilmeDAO();
        }

        public void Inserir(string nome, decimal preco, string genero, int ano, byte[] imagem)
        {
            filmeDao.Inserir(nome, preco, genero, ano, imagem);
        }

        public void Atualizar(int codigo, string nome, decimal preco, string genero, int ano, byte[] imagem)
        {
            filmeDao.Atualizar(codigo, nome, preco, genero, ano, imagem);
        }

        public IList<Filme> Listar()
        {
            return filmeDao.Listar();
        }

        public Filme Recuperar(int codigo)
        {
            return filmeDao.Recuperar(codigo);
        }

        public void Remover(int codigo)
        {
            filmeDao.Remover(codigo);
        }

        public void preencherDataGridView(DataGridView dgvFilmes)
        {
            filmeDao.preencherDataGridView(dgvFilmes);
        }

    }
}
