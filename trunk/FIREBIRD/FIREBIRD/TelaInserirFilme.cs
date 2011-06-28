using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data;
using System.IO;

namespace FIREBIRD
{
    public partial class TelaInserirFilme : Form
    {

        FilmeDAO filmeDao;
        Form principal;

        public TelaInserirFilme(Form pai)
        {
            InitializeComponent();

            filmeDao = new FilmeDAO();

            principal = pai;

            foreach (string genero in Data.Classes.Genero.Generos)
            {
                this.cbGeneroFilme.Items.Add(genero);   
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

        private void bInserirFilme_Click(object sender, EventArgs e)
        {
            try
            {
                String nome = tbNomeFilme.Text;
                String genero = cbGeneroFilme.SelectedItem.ToString();
                int anoLancamento = Convert.ToInt32(tbAnoLancamentoFilme.Text);
                byte[] imagem = this.convertImagemParaArrayByte(tbUrlImagemFilme.Text);
                decimal preco = Convert.ToDecimal(tbPreco.Text);

                filmeDao.Inserir(nome, preco, genero, anoLancamento, imagem);
                this.Close();
                MessageBox.Show("Filme inserido com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TelaInserirFilme_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)principal).CarregarFilmes();
        }

        private byte[] convertImagemParaArrayByte(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] imageData = new byte[fs.Length];
            fs.Read(imageData, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return imageData;
        }
    }
}
