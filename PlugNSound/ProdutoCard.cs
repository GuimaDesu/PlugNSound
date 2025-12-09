using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PlugNSound
{
    public partial class ProdutoCard : UserControl
    {
        private Produto produto;

        public ProdutoCard(Produto prod)
        {
            InitializeComponent();
            
            // Enable double buffering to prevent flickering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | 
                          ControlStyles.AllPaintingInWmPaint | 
                          ControlStyles.UserPaint, true);
            
            produto = prod;
            ConfigurarCard();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            int radius = 15;
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            
            using (GraphicsPath path = GetRoundedRectangle(rect, radius))
            {
                // Fill the rounded rectangle with white background
                using (SolidBrush brush = new SolidBrush(Color.White))
                {
                    e.Graphics.FillPath(brush, path);
                }
                
                // Draw border
                using (Pen borderPen = new Pen(Color.FromArgb(230, 230, 230), 1))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        private void ConfigurarCard()
        {
            lblNome.Text = produto.Nome;
            lblPreco.Text = $"€ {produto.Preco:F2}";
            lblCategoria.Text = produto.Categoria;
            
            // Não mostrar estoque para clientes
            lblEstoque.Visible = false;
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            
            return path;
        }

        private void panelCard_MouseEnter(object sender, EventArgs e)
        {
            // No hover effect
        }

        private void panelCard_MouseLeave(object sender, EventArgs e)
        {
            // No hover effect
        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {
            // Custom paint handled in OnPaint
        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            CarrinhoManager.AdicionarProduto(produto, 1);
            MessageBox.Show($"{produto.Nome} foi adicionado ao carrinho!", "Produto Adicionado", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picBoxProduto_Click(object sender, EventArgs e)
        {
            // Show product details or expand image
            MessageBox.Show($"{produto.Nome}\n\n{produto.Descricao}\n\nPreço: € {produto.Preco:F2}", 
                "Detalhes do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
