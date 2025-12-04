using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace PlugNSound
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            // Limpar controles existentes
            flowLayoutProdutos.Controls.Clear();

            // Obter produtos
            var produtos = ProdutoManager.ObterTodosProdutos();

            // Adicionar card para cada produto
            foreach (var produto in produtos)
            {
                ProdutoCard card = new ProdutoCard(produto);
                card.Margin = new Padding(10);
                flowLayoutProdutos.Controls.Add(card);
            }

            // Atualizar informações da loja
            AtualizarInformacoes(produtos);
        }

        private void AtualizarInformacoes(System.Collections.Generic.List<Produto> produtos)
        {
            int totalProdutos = produtos.Count;
            var categorias = produtos.Select(p => p.Categoria).Distinct().Count();
            
            lblTotalProdutos.Text = totalProdutos.ToString();
            lblTotalCategorias.Text = categorias.ToString();
        }
    }
}
