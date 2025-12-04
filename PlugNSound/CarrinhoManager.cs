using System;
using System.Collections.Generic;
using System.Linq;

namespace PlugNSound
{
    public class ItemCarrinho
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        
        public decimal Subtotal
        {
            get { return Produto.Preco * Quantidade; }
        }
    }

    public static class CarrinhoManager
    {
        private static List<ItemCarrinho> itens = new List<ItemCarrinho>();

        public static List<ItemCarrinho> ObterItens()
        {
            return new List<ItemCarrinho>(itens);
        }

        public static void AdicionarProduto(Produto produto, int quantidade = 1)
        {
            var itemExistente = itens.FirstOrDefault(i => i.Produto.Id == produto.Id);
            
            if (itemExistente != null)
            {
                itemExistente.Quantidade += quantidade;
            }
            else
            {
                itens.Add(new ItemCarrinho
                {
                    Produto = produto,
                    Quantidade = quantidade
                });
            }
        }

        public static void RemoverProduto(int produtoId)
        {
            itens.RemoveAll(i => i.Produto.Id == produtoId);
        }

        public static void AtualizarQuantidade(int produtoId, int novaQuantidade)
        {
            var item = itens.FirstOrDefault(i => i.Produto.Id == produtoId);
            if (item != null)
            {
                if (novaQuantidade <= 0)
                {
                    RemoverProduto(produtoId);
                }
                else
                {
                    item.Quantidade = novaQuantidade;
                }
            }
        }

        public static void LimparCarrinho()
        {
            itens.Clear();
        }

        public static int ObterQuantidadeTotal()
        {
            return itens.Sum(i => i.Quantidade);
        }

        public static decimal ObterValorTotal()
        {
            return itens.Sum(i => i.Subtotal);
        }

        public static bool TemItens()
        {
            return itens.Count > 0;
        }
    }
}
