using System;

namespace PlugNSound
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string Categoria { get; set; }
        public DateTime DataCadastro { get; set; }

        public Produto()
        {
            DataCadastro = DateTime.Now;
        }

        public Produto(int id, string nome, string descricao, decimal preco, int quantidadeEstoque, string categoria)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
            Categoria = categoria;
            DataCadastro = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Nome} - € {Preco:F2}";
        }
    }
}
