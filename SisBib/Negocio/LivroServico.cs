using System;
using SisBib.Data;
using SisBib.Models;

namespace SisBib.Negocio
{
    public class LivroService
    {
        private LivroRepository _repository = new LivroRepository();

        public bool CadastrarLivro(string titulo, string autor, out string mensagemErro)
        {
            // Regra 1: Titulo não pode ser vazio
            if (string.IsNullOrWhiteSpace(titulo))
            {
                mensagemErro = "O titulo do livro é obrigatório.";
                return false;
            }

            // Regra 2: Titulo deve ter pelo menos 3 caracteres
            if (titulo.Length < 3)
            {
                mensagemErro = "O titulo deve ter pelo menos 3 caracteres.";
                return false;
            }

            Livro novoLivro = new Livro
            {
                Titulo = titulo,
                Autor = autor,
                Emprestado = false
            };

            _repository.Adicionar(novoLivro);
            mensagemErro = string.Empty;
            return true;
        }

        public List<Livro> ListarAcervo()
        {
            return _repository.ObterTodos();
        }
    }
}