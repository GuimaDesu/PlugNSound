using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace PlugNSound
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
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
                card.Margin = new Padding(15);
                flowLayoutProdutos.Controls.Add(card);
            }

            // Atualizar contagem
            lblContagem.Text = $"{produtos.Count} produtos disponíveis";
        }
    }
}
