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
using System.IO;

namespace FIREBIRD
{
    public partial class TelaAtualizarFilme : Form
    {
        ControleFilme controleFilme;
        int codigo;
        Form principal;


        public TelaAtualizarFilme(Filme filmeSelecionado, Form pai)
        {
            this.controleFilme = new ControleFilme();
            InitializeComponent();
            this.principal = pai;

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

                controleFilme.Atualizar(codigo, nome, preco, genero, anoLancamento, null);

                this.Close();

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

        private void TelaAtualizarFilme_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)principal).CarregarFilmes();
        }

        private FileStream convertArrayByteToFile(byte[] imageByte)
        {
            return null;
        }

    }
}
