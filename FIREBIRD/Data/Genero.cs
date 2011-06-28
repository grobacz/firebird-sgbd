using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Classes
{
    public static class Genero
    {
        private static IList<string> _generos = new List<string> 
        { 
            ACAO,
            ANIMACAO, 
            AVENTURA, 
            COMEDIA, 
            DOCUMENTARIO, 
            DRAMA,
            FICCAO,
            MUSICAL, 
            ROMANCE,
            SUSPENSE,
            TERROR
        };

        public static IList<string> Generos { get { return _generos; } }

        public const string ACAO = "Ação";
        public const string ANIMACAO = "Animação";
        public const string AVENTURA = "Aventura";
        public const string COMEDIA = "Comédia";
        public const string DOCUMENTARIO = "Documentário";
        public const string DRAMA = "Drama";
        public const string FICCAO = "Ficção Científica";
        public const string MUSICAL = "Musical";
        public const string ROMANCE = "Romance";
        public const string SUSPENSE = "Suspense";
        public const string TERROR = "Terror";
    }
}
