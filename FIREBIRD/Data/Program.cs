﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Classes;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            FilmeDAO filmeDao = new FilmeDAO();
            //filmeDao.Inserir("A volta dos que não foram", 1.23m, Genero.COMEDIA, 2009, null);
            //filmeDao.Inserir("Tempos complicados", 1.23m, Genero.COMEDIA, 2009, null);
            //filmeDao.Atualizar(1, "A bela caída", 12.87m, Genero.DOCUMENTARIO, 2010, null);
            
            filmeDao.Listar();
        }
    }
}
