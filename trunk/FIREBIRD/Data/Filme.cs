using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Classes
{
    public class Filme
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
        public byte[] Imagem { get; set; }
    }
}
