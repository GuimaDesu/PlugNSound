using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlugNSound
{
    public partial class FormCarrinho : Form
    {
        public FormCarrinho()
        {
            InitializeComponent();
            CarregarCarrinho();
        }

        private void CarregarCarrinho()
        {
            listViewCarrinho.Items.Clear();
            var itens = CarrinhoManager.ObterItens();

            foreach (var item in itens)
            {
                var listItem = new ListViewItem(item.Produto.Nome);
                listItem.SubItems.Add($"€ {item.Produto.Preco:F2}");
                listItem.SubItems.Add(item.Quantidade.ToString());
                listItem.SubItems.Add($"€ {item.Subtotal:F2}");
                listItem.Tag = item;
                listViewCarrinho.Items.Add(listItem);
            }

            AtualizarTotais();
        }

        private void AtualizarTotais()
        {
            int quantidadeTotal = CarrinhoManager.ObterQuantidadeTotal();
            decimal valorTotal = CarrinhoManager.ObterValorTotal();

            lblQuantidadeTotal.Text = $"{quantidadeTotal} itens";
            lblValorTotal.Text = $"€ {valorTotal:F2}";

            btnFinalizar.Enabled = CarrinhoManager.TemItens();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listViewCarrinho.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para remover.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = (ItemCarrinho)listViewCarrinho.SelectedItems[0].Tag;
            var resultado = MessageBox.Show($"Deseja remover {item.Produto.Nome} do carrinho?", 
                "Confirmar Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                CarrinhoManager.RemoverProduto(item.Produto.Id);
                CarregarCarrinho();
                MessageBox.Show("Item removido do carrinho!", "Sucesso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (!CarrinhoManager.TemItens())
            {
                MessageBox.Show("O carrinho já está vazio.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var resultado = MessageBox.Show("Deseja limpar todo o carrinho?", 
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                CarrinhoManager.LimparCarrinho();
                CarregarCarrinho();
                MessageBox.Show("Carrinho limpo com sucesso!", "Sucesso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listViewCarrinho.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para adicionar mais unidades.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = (ItemCarrinho)listViewCarrinho.SelectedItems[0].Tag;
            CarrinhoManager.AtualizarQuantidade(item.Produto.Id, item.Quantidade + 1);
            CarregarCarrinho();
        }

        private void btnDiminuir_Click(object sender, EventArgs e)
        {
            if (listViewCarrinho.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para diminuir a quantidade.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = (ItemCarrinho)listViewCarrinho.SelectedItems[0].Tag;
            if (item.Quantidade > 1)
            {
                CarrinhoManager.AtualizarQuantidade(item.Produto.Id, item.Quantidade - 1);
                CarregarCarrinho();
            }
            else
            {
                MessageBox.Show("Quantidade mínima é 1. Use 'Remover' para excluir o item.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (!CarrinhoManager.TemItens())
            {
                MessageBox.Show("O carrinho está vazio!", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show(
                $"Finalizar compra no valor de € {CarrinhoManager.ObterValorTotal():F2}?\n\n" +
                "Esta é uma versão demo. A funcionalidade de pagamento será implementada futuramente.",
                "Finalizar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Pedido confirmado! ?\n\n" +
                    "Em breve você receberá um e-mail com os detalhes da compra.\n" +
                    "Obrigado por comprar na PlugNSound! ??",
                    "Compra Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                CarrinhoManager.LimparCarrinho();
                CarregarCarrinho();
            }
        }
    }
}
