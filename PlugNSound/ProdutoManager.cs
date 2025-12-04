using System;
using System.Collections.Generic;

namespace PlugNSound
{
    public static class ProdutoManager
    {
        private static List<Produto> produtos = new List<Produto>();
        private static int proximoId = 1;

        static ProdutoManager()
        {
            CarregarProdutosIniciais();
        }

        private static void CarregarProdutosIniciais()
        {
            produtos.Add(new Produto(proximoId++, "Fone de Ouvido Bluetooth", "Fone sem fio com cancelamento de ruído", 49.90m, 15, "Áudio"));
            produtos.Add(new Produto(proximoId++, "Caixa de Som Portátil", "Caixa bluetooth resistente à água", 34.90m, 20, "Áudio"));
            produtos.Add(new Produto(proximoId++, "Microfone USB", "Microfone condensador para streaming", 59.90m, 10, "Áudio"));
            produtos.Add(new Produto(proximoId++, "Placa de Som USB", "Interface de áudio profissional", 149.90m, 5, "Áudio"));
            produtos.Add(new Produto(proximoId++, "Cabo XLR Premium", "Cabo balanceado de alta qualidade 3m", 24.90m, 30, "Acessórios"));
            produtos.Add(new Produto(proximoId++, "Suporte de Mesa para Microfone", "Braço articulado ajustável", 39.90m, 12, "Acessórios"));
        }

        public static List<Produto> ObterTodosProdutos()
        {
            return new List<Produto>(produtos);
        }

        public static void AdicionarProduto(Produto produto)
        {
            produto.Id = proximoId++;
            produtos.Add(produto);
        }

        public static void AtualizarProduto(Produto produto)
        {
            var index = produtos.FindIndex(p => p.Id == produto.Id);
            if (index >= 0)
            {
                produtos[index] = produto;
            }
        }

        public static void RemoverProduto(int id)
        {
            produtos.RemoveAll(p => p.Id == id);
        }

        public static int ObterProximoId()
        {
            return proximoId;
        }
    }
}
