using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PlugNSound
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
            AtualizarListView();
        }

        private void AtualizarListView()
        {
            listViewProdutos.Items.Clear();
            var produtos = ProdutoManager.ObterTodosProdutos();
            
            foreach (var produto in produtos)
            {
                var item = new ListViewItem(produto.Id.ToString());
                item.SubItems.Add(produto.Nome);
                item.SubItems.Add(produto.Categoria);
                item.SubItems.Add($"€ {produto.Preco:F2}");
                item.SubItems.Add(produto.QuantidadeEstoque.ToString());
                item.Tag = produto;
                listViewProdutos.Items.Add(item);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            var novoProduto = new Produto
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Preco = numPreco.Value,
                QuantidadeEstoque = (int)numQuantidade.Value,
                Categoria = txtCategoria.Text
            };

            ProdutoManager.AdicionarProduto(novoProduto);
            AtualizarListView();
            LimparCampos();
            MessageBox.Show("Produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listViewProdutos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um produto para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos())
                return;

            var produtoSelecionado = (Produto)listViewProdutos.SelectedItems[0].Tag;
            produtoSelecionado.Nome = txtNome.Text;
            produtoSelecionado.Descricao = txtDescricao.Text;
            produtoSelecionado.Preco = numPreco.Value;
            produtoSelecionado.QuantidadeEstoque = (int)numQuantidade.Value;
            produtoSelecionado.Categoria = txtCategoria.Text;

            ProdutoManager.AtualizarProduto(produtoSelecionado);
            AtualizarListView();
            LimparCampos();
            MessageBox.Show("Produto editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listViewProdutos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um produto para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show("Deseja realmente remover este produto?", "Confirmação", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var produtoSelecionado = (Produto)listViewProdutos.SelectedItems[0].Tag;
                ProdutoManager.RemoverProduto(produtoSelecionado.Id);
                AtualizarListView();
                LimparCampos();
                MessageBox.Show("Produto removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void listViewProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProdutos.SelectedItems.Count > 0)
            {
                var produto = (Produto)listViewProdutos.SelectedItems[0].Tag;
                txtNome.Text = produto.Nome;
                txtDescricao.Text = produto.Descricao;
                numPreco.Value = produto.Preco;
                numQuantidade.Value = produto.QuantidadeEstoque;
                txtCategoria.Text = produto.Categoria;
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome do produto é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            if (numPreco.Value <= 0)
            {
                MessageBox.Show("O preço deve ser maior que zero.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numPreco.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("A categoria é obrigatória.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoria.Focus();
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            numPreco.Value = 0;
            numQuantidade.Value = 0;
            txtCategoria.Clear();
            listViewProdutos.SelectedItems.Clear();
            txtNome.Focus();
        }
    }
}
