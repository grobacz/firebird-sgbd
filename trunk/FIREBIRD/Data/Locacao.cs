using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Classes
{
    public class Locacao
    {
        public int Codigo { get; set; }
        //public DateTime Data { get; set; }
        public IList<Filme> Filmes { get; set; }
        public Cliente Cliente { get; set; }
        public Status Status { get; set; }

        public override string ToString()
        {
            string filmes = "";

            foreach (var item in Filmes)
            {
                filmes += item.Codigo + " - " + item.Nome + " | ";
            }

            return string.Format("Código: {0}, Cliente: {1}, Status: {2}, Filmes: {3}", Codigo, Cliente.Cpf, Status, filmes);
        }
    }
}