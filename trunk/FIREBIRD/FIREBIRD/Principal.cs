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

        public Principal()
        {
            InitializeComponent();

            filmeDao = new FilmeDAO();
            filmeDao.preencherDataGridView(this.dgvFilmes);

            
            
        }

        private void bLocInserir_Click(object sender, EventArgs e)
        {
            TelaInserirLocacao telaInserirLocacao = new TelaInserirLocacao();
            telaInserirLocacao.ShowDialog();
        }

        private void bLocRemover_Click(object sender, EventArgs e)
        {
            
        }

        private void bLocAtualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void bFilmesInserir_Click(object sender, EventArgs e)
        {
            TelaInserirFilme telaInserirFime = new TelaInserirFilme();
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
            TelaInserirCliente telaInserirCliente = new TelaInserirCliente();
            telaInserirCliente.ShowDialog();
        }

        private void bClientesAtualizar_Click(object sender, EventArgs e)
        {
            TelaAtualizarCliente telaAtualizarCliente = new TelaAtualizarCliente();
            telaAtualizarCliente.ShowDialog();
               
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
               
    }
}
