using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Classes;

namespace FIREBIRD
{
    public partial class TelaExibirLocacao : Form
    {
        public TelaExibirLocacao(Locacao locacao)
        {
            InitializeComponent();
            this.lCliente.Text = locacao.Cliente.Nome.ToUpper();
            this.lCodigo.Text = locacao.Codigo.ToString();
            
            foreach(Filme f in locacao.Filmes){
                lbFilmes.Items.Add(f.Nome + " - " + locacao.Status);
            }
        }

        private void bFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
