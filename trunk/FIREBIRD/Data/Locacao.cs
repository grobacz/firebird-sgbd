using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Classes
{
    public class Locacao
    {
        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public IList<Filme> Filmes { get; set; }
        public Cliente Cliente { get; set; }
    }
}
