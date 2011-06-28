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
    public partial class Principal : Form
    {
        FilmeDAO filmeDao;
        ClienteDAO clienteDao;
        LocacaoDAO locacaoDao;

        public Principal()
        {
            InitializeComponent();

            filmeDao = new FilmeDAO();
            clienteDao = new ClienteDAO();
            locacaoDao = new LocacaoDAO();

            filmeDao.preencherDataGridView(this.dgvFilmes);
            clienteDao.preencherDataGridView(this.dgvClientes);
            locacaoDao.preencherDataGridView(this.dgvLocacao);
            
        }

        public void CarregarFilmes()
        {
            this.dgvFilmes.Rows.Clear();
            this.dgvFilmes.Columns.Clear();
            filmeDao.preencherDataGridView(this.dgvFilmes);
        }

        public void CarregarLocacoes()
        {
            this.dgvLocacao.Rows.Clear();
            this.dgvLocacao.Columns.Clear();
            locacaoDao.preencherDataGridView(this.dgvLocacao);
        }

        public void CarregarClientes()
        {
            this.dgvClientes.Rows.Clear();
            this.dgvLocacao.Columns.Clear();
            clienteDao.preencherDataGridView(this.dgvClientes);
        }

        private void bLocInserir_Click(object sender, EventArgs e)
        {
            TelaInserirLocacao telaInserirLocacao = new TelaInserirLocacao(this);
            telaInserirLocacao.ShowDialog();
        }

        private void bLocRemover_Click(object sender, EventArgs e)
        {
            int celulasSelecionadasCount = dgvLocacao.GetCellCount(DataGridViewElementStates.Selected);

            if (celulasSelecionadasCount > 0)
            {
                String codigo = (String)dgvLocacao.Rows[dgvLocacao.SelectedCells[0].RowIndex].Cells[0].Value;

                if (codigo != null)
                {
                    locacaoDao.Remover(Convert.ToInt32(codigo));
                    MessageBox.Show("A locação foi removida com sucesso!");

                }
                else
                {
                    MessageBox.Show("Não há locação selecionada.");
                }
            }
            else
            {
                MessageBox.Show("Não há locação selecionada.");
            }

        }

        private void bLocAtualizar_Click(object sender, EventArgs e)
        {
            int celulasSelecionadasCount = dgvLocacao.GetCellCount(DataGridViewElementStates.Selected);

            if (celulasSelecionadasCount > 0)
            {
                String codigo = (String)dgvLocacao.Rows[dgvLocacao.SelectedCells[0].RowIndex].Cells[0].Value;

                if (codigo != null)
                {
                    Locacao locacao = locacaoDao.Recuperar(Convert.ToInt32(codigo));

                    if(dgvLocacao.Rows[dgvLocacao.SelectedCells[0].RowIndex].Cells[3].Value.ToString().Equals("Pendente")){

                        locacaoDao.Atualizar(Convert.ToInt32(codigo), 2);
                    }
                    else if(dgvLocacao.Rows[dgvLocacao.SelectedCells[0].RowIndex].Cells[3].Value.ToString().Equals("Disponivel")){

                        locacaoDao.Atualizar(Convert.ToInt32(codigo), 1);
                    }

                }
                else
                {
                    MessageBox.Show("Não há cliente selecionado.");
                }
            }
            else
            {
                MessageBox.Show("Não há cliente selecionado.");
            }
        }

        private void bFilmesInserir_Click(object sender, EventArgs e)
        {
            TelaInserirFilme telaInserirFime = new TelaInserirFilme(this);
            telaInserirFime.ShowDialog();
        }

        private void bFilmesAtualizar_Click(object sender, EventArgs e)
        {

            int celulasSelecionadasCount = dgvFilmes.GetCellCount(DataGridViewElementStates.Selected);

            if (celulasSelecionadasCount > 0)
            {
                String codigo = (String)dgvFilmes.Rows[dgvFilmes.SelectedCells[0].RowIndex].Cells[0].Value;

                if(codigo != null){
                 
                    Filme filme = filmeDao.Recuperar(Convert.ToInt32(codigo));
                    TelaAtualizarFilme telaAtualizarFilme = new TelaAtualizarFilme(filme);
                    telaAtualizarFilme.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Não há filmes selecionados.");
                }
            }
            else
            {
                MessageBox.Show("Não há filmes selecionados.");
            }
        }

        private void bClientesInserir_Click(object sender, EventArgs e)
        {
            TelaInserirCliente telaInserirCliente = new TelaInserirCliente(this);
            telaInserirCliente.ShowDialog();
        }

        private void bClientesAtualizar_Click(object sender, EventArgs e)
        {

            int celulasSelecionadasCount = dgvClientes.GetCellCount(DataGridViewElementStates.Selected);

            if (celulasSelecionadasCount > 0)
            {
                String cpf = (String)dgvClientes.Rows[dgvClientes.SelectedCells[0].RowIndex].Cells[0].Value;

                if (cpf != null)
                {
                    Cliente cliente = clienteDao.Recuperar(cpf);
                    TelaAtualizarCliente telaAtualizarCliente = new TelaAtualizarCliente(cliente);
                    telaAtualizarCliente.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Não há cliente selecionado.");
                }
            }
            else
            {
                MessageBox.Show("Não há cliente selecionado.");
            }

            
               
        }

        private void bFilmesRemover_Click(object sender, EventArgs e)
        {
            int celulasSelecionadasCount = dgvFilmes.GetCellCount(DataGridViewElementStates.Selected);

            if (celulasSelecionadasCount > 0)
            {
                String strAnterior = "";
                for (int i = 0; i < celulasSelecionadasCount; i++)
                {

                    String codigo = (String)dgvFilmes.Rows[dgvFilmes.SelectedCells[i].RowIndex].Cells[0].Value;

                    if (codigo != null)
                    {
                        if (!codigo.Equals(strAnterior))
                        {
                            filmeDao.Remover(Convert.ToInt32(codigo));
                            strAnterior = codigo;
                            MessageBox.Show("O filme foi removido com sucesso!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não há filmes selecionados.");
                        break;
                    }
                }

            }
            else
            {
                MessageBox.Show("Não há filmes selecionados.");
            }
        }

        private void bClientesRemover_Click(object sender, EventArgs e)
        {

            int celulasSelecionadasCount = dgvClientes.GetCellCount(DataGridViewElementStates.Selected);

            if (celulasSelecionadasCount > 0)
            {
                String cpf = (String)dgvClientes.Rows[dgvClientes.SelectedCells[0].RowIndex].Cells[0].Value;

                if (cpf != null)
                {
                    clienteDao.Remover(cpf);
                    MessageBox.Show("O cliente foi removido com sucesso!");

                }
                else
                {
                    MessageBox.Show("Não há clientes selecionados.");
                }
            }
            else
            {
                MessageBox.Show("Não há clientes selecionados.");
            }

        }
               
    }
}
