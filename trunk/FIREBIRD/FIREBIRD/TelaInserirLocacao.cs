using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data;
using Data.Classes;

namespace FIREBIRD
{
    public partial class TelaInserirLocacao : Form
    {
        ClienteDAO clienteDao;
        FilmeDAO filmeDao;
        LocacaoDAO locacaoDao;
        Form principal;

        public TelaInserirLocacao(Form pai)
        {
            InitializeComponent();
            clienteDao = new ClienteDAO();
            filmeDao = new FilmeDAO();
            locacaoDao = new LocacaoDAO();
            principal = pai;

            IList<Cliente> clientes = clienteDao.Listar();
            IList<Filme> filmes = filmeDao.ListarNaoLocados();

            foreach (Cliente c in clientes)
            {
                cbClientes.Items.Add(c.Cpf + " - " + c.Nome);
            }

            foreach (Filme f in filmes)
            {
                lbTodosFilmes.Items.Add(f.Codigo + " - " + f.Nome);
            }
        }

        private void bSetaAdd_Click(object sender, EventArgs e)
        {
            if(this.lbTodosFilmes.SelectedItem != null)
            {
                this.lbFilmesLocar.Items.Add(lbTodosFilmes.SelectedItem);
                this.lbTodosFilmes.Items.Remove(lbTodosFilmes.SelectedItem);
            }
        }

        private void bSetaRemover_Click(object sender, EventArgs e)
        {
            if (this.lbFilmesLocar.SelectedItem != null)
            {
                this.lbTodosFilmes.Items.Add(lbFilmesLocar.SelectedItem);
                this.lbFilmesLocar.Items.Remove(lbFilmesLocar.SelectedItem);
            }
        }

        private void bInserirLocacao_Click(object sender, EventArgs e)
        {

            int indexCpf = cbClientes.Text.IndexOf('-');
            String cpf = cbClientes.Text.Substring(0, indexCpf - 1);

            List<int> filmesALocar = new List<int>();
            int nFilmes = lbFilmesLocar.Items.Count;

            for (int i = 0; i < nFilmes; i++)
            {
                int indexCodigo = lbFilmesLocar.Items[i].ToString().IndexOf('-');
                String codigo = lbFilmesLocar.Items[i].ToString().Substring(0, indexCodigo);
                filmesALocar.Add(Convert.ToInt32(codigo));
            }

            locacaoDao.Inserir(cpf, filmesALocar);

            MessageBox.Show("Locação inserida com sucesso!");

            this.Close();
            
        }

        private void TelaInserirLocacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)principal).CarregarLocacoes();
        }
    }
}
