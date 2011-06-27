using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FIREBIRD
{
    public partial class TelaInserirLocacao : Form
    {
        public TelaInserirLocacao()
        {
            InitializeComponent();

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
    }
}
