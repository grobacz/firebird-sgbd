using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Classes
{
    public class Cliente
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
