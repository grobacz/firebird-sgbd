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
    public partial class TelaAtualizarFilme : Form
    {
        FilmeDAO filmeDao;
        int codigo;

        public TelaAtualizarFilme(Filme filmeSelecionado)
        {
            this.filmeDao = new FilmeDAO();
            InitializeComponent();

            this.cbGeneroFilme.Items.Add("Ação");
            this.cbGeneroFilme.Items.Add("Comédia");
            this.cbGeneroFilme.Items.Add("Desenho Animado");
            this.cbGeneroFilme.Items.Add("Romance");
            this.cbGeneroFilme.Items.Add("Terror");

            this.tbNomeFilme.Text = filmeSelecionado.Nome;
            this.tbAnoLancamentoFilme.Text = filmeSelecionado.Ano.ToString();
            this.tbPreco.Text = filmeSelecionado.Preco.ToString();
            this.cbGeneroFilme.Text = filmeSelecionado.Genero;
            this.codigo = filmeSelecionado.Codigo;
        }

        private void bAtualizarFilme_Click(object sender, EventArgs e)
        {
            try
            {
                String nome = this.tbNomeFilme.Text;
                int anoLancamento = Convert.ToInt32(this.tbAnoLancamentoFilme.Text);
                Decimal preco = Convert.ToDecimal(this.tbPreco.Text);
                String genero = cbGeneroFilme.SelectedItem.ToString();
                //TODO foto

                filmeDao.Atualizar(codigo, nome, preco, genero, anoLancamento, null);

                this.Close();

                Principal principal = new Principal();

            }catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        private void bBrowser_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tbUrlImagemFilme.Text = this.openFileDialog1.FileName;
                this.pictureBoxCapa.ImageLocation = this.openFileDialog1.FileName;
            }
        }

    }
}
