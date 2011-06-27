using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data;

namespace FIREBIRD
{
    public partial class TelaInserirFilme : Form
    {

        FilmeDAO filmeDao;

        public TelaInserirFilme()
        {
            InitializeComponent();

            filmeDao = new FilmeDAO();

            this.cbGeneroFilme.Items.Add("Ação");
            this.cbGeneroFilme.Items.Add("Comédia");
            this.cbGeneroFilme.Items.Add("Desenho Animado");
            this.cbGeneroFilme.Items.Add("Romance");
            this.cbGeneroFilme.Items.Add("Terror");
            
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
                //TODO inserir imagem no banco com blob
                decimal preco = Convert.ToDecimal(tbPreco.Text);

                filmeDao.Inserir(nome, preco, genero, anoLancamento, null);
                this.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
