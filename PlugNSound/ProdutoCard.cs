using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PlugNSound
{
    public partial class ProdutoCard : UserControl
    {
        private Produto produto;
        private bool isHovered = false;

        public ProdutoCard(Produto prod)
        {
            InitializeComponent();
            produto = prod;
            ConfigurarCard();
        }

        private void ConfigurarCard()
        {
            lblNome.Text = produto.Nome;
            lblPreco.Text = $"€ {produto.Preco:F2}";
            lblCategoria.Text = produto.Categoria;
            
            // Não mostrar estoque para clientes
            lblEstoque.Visible = false;
        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int radius = 15;
            
            // Anti-aliasing para bordas suaves
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            // Criar retângulo arredondado
            GraphicsPath path = GetRoundedRectangle(panel.ClientRectangle, radius);
            panel.Region = new Region(path);
            
            // Adicionar sombra
            if (isHovered)
            {
                using (Pen shadowPen = new Pen(Color.FromArgb(50, 90, 24, 154), 3))
                {
                    e.Graphics.DrawPath(shadowPen, path);
                }
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            
            rect = new Rectangle(rect.X + 1, rect.Y + 1, rect.Width - 3, rect.Height - 3);
            
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            
            return path;
        }

        private void panelCard_MouseEnter(object sender, EventArgs e)
        {
            isHovered = true;
            panelCard.BackColor = Color.FromArgb(248, 248, 248);
            this.Cursor = Cursors.Hand;
            panelCard.Invalidate();
        }

        private void panelCard_MouseLeave(object sender, EventArgs e)
        {
            isHovered = false;
            panelCard.BackColor = Color.White;
            this.Cursor = Cursors.Default;
            panelCard.Invalidate();
        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            CarrinhoManager.AdicionarProduto(produto, 1);
            MessageBox.Show($"{produto.Nome} foi adicionado ao carrinho!", "Produto Adicionado", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
