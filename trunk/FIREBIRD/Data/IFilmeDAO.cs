using System;
using Data.Classes;
using System.Collections.Generic;
namespace Data
{
    public interface IFilmeDAO
    {
        void Atualizar(int codigo, string nome, decimal preco, string genero, int ano, byte[] imagem);
        void Inserir(string nome, decimal preco, string genero, int ano, byte[] imagem);
        IList<Filme> Listar();
        Filme Recuperar(int codigo);
        void Remover(int codigo);
    }
}
