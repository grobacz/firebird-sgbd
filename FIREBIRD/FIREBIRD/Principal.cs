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
using Control;

namespace FIREBIRD
{
    public partial class Principal : Form
    {
        ControleFilme controleFilme;
        ControleCliente controleCliente;
        ControleLocacao controleLocacao;

        public Principal()
        {
            InitializeComponent();

            controleCliente = new ControleCliente();
            controleFilme = new ControleFilme();
            controleLocacao = new ControleLocacao();

            controleFilme.preencherDataGridView(this.dgvFilmes);
            controleCliente.preencherDataGridView(this.dgvClientes);
            controleLocacao.preencherDataGridView(this.dgvLocacao);
            
        }

        public void CarregarFilmes()
        {
            this.dgvFilmes.Rows.Clear();
            this.dgvFilmes.Columns.Clear();
            controleFilme.preencherDataGridView(this.dgvFilmes);
        }

        public void CarregarLocacoes()
        {
            this.dgvLocacao.Rows.Clear();
            this.dgvLocacao.Columns.Clear();
            controleLocacao.preencherDataGridView(this.dgvLocacao);
        }

        public void CarregarClientes()
        {
            this.dgvClientes.Rows.Clear();
            this.dgvClientes.Columns.Clear();
            controleCliente.preencherDataGridView(this.dgvClientes);
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
                    controleLocacao.Remover(Convert.ToInt32(codigo));
                    this.CarregarLocacoes();
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
                    Locacao locacao = controleLocacao.Recuperar(Convert.ToInt32(codigo));

                    if(dgvLocacao.Rows[dgvLocacao.SelectedCells[0].RowIndex].Cells[2].Value.ToString().Equals("Pendente")){

                        controleLocacao.Atualizar(Convert.ToInt32(codigo), 2);
                    }
                    else if(dgvLocacao.Rows[dgvLocacao.SelectedCells[0].RowIndex].Cells[2].Value.ToString().Equals("Disponível")){

                        controleLocacao.Atualizar(Convert.ToInt32(codigo), 1);
                    }

                    this.CarregarLocacoes();
                    MessageBox.Show("Status da locação atualizada com sucesso!");
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

                    Filme filme = controleFilme.Recuperar(Convert.ToInt32(codigo));
                    TelaAtualizarFilme telaAtualizarFilme = new TelaAtualizarFilme(filme, this);
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
                    Cliente cliente = controleCliente.Recuperar(cpf);
                    TelaAtualizarCliente telaAtualizarCliente = new TelaAtualizarCliente(cliente, this);
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
                String codigo = (String)dgvFilmes.Rows[dgvFilmes.SelectedCells[0].RowIndex].Cells[0].Value;

                if (codigo != null)
                {
                    controleFilme.Remover(Convert.ToInt32(codigo));
                    this.CarregarFilmes();
                    MessageBox.Show("O filme foi removido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não há filme selecionado.");
                }
            }
            else
            {
                MessageBox.Show("Não há filme selecionado.");
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
                    controleCliente.Remover(cpf);
                    this.CarregarClientes();
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

        private void dgvLocacao_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int celulasSelecionadasCount = dgvLocacao.GetCellCount(DataGridViewElementStates.Selected);

            if (celulasSelecionadasCount > 0)
            {
                String codigo = (String)dgvLocacao.Rows[dgvLocacao.SelectedCells[0].RowIndex].Cells[0].Value;

                if (codigo != null)
                {
                    Locacao locacao = controleLocacao.Recuperar(Convert.ToInt32(codigo));
                    TelaExibirLocacao telaExibirLocacao = new TelaExibirLocacao(locacao);
                    telaExibirLocacao.ShowDialog();
                    
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

        
               
    }
}
