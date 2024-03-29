﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Classes;
using System.Windows.Forms;

namespace Data
{
    public interface ILocacaoDAO
    {
        void Atualizar(int codigo, int status);
        void Inserir(string cpfCliente, IList<int> codigoFilmes);
        IList<Locacao> Listar();
        Locacao Recuperar(int codigo);
        void Remover(int codigo);
        void preencherDataGridView(DataGridView dgvLocacao);
    }
}
