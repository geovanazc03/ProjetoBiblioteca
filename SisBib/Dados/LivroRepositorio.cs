using System.Collections.Generic;
using SisBib.Models;

namespace SisBib.Data
{
    public class LivroRepository
    {
        private static List<Livro> _tabelaLivros = new List<Livro>();
        private static int proximoId = 1;

        public void Adicionar(Livro livro)
        {
            livro.Id = proximoId++;
            _tabelaLivros.Add(livro);
        }

        public List<Livro> ObterTodos()
        {
            return _tabelaLivros;
        }
    }
}