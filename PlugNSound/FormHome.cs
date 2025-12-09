using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using FontAwesome.Sharp;

namespace PlugNSound
{
    public partial class FormHome : Form
    {
        private Timer animationTimer;
        private List<Panel> statCards;
        private List<int> targetValues;
        private List<int> currentValues;
        private decimal valorEstoqueReal;

        public FormHome()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetupAnimations();
            CarregarDashboard();
        }

        private void SetupAnimations()
        {
            statCards = new List<Panel> { panelCard1, panelCard2, panelCard3, panelCard4 };
            targetValues = new List<int>();
            currentValues = new List<int> { 0, 0, 0 };

            // Add rounded corners to cards
            foreach (var card in statCards)
            {
                card.Paint += StatCard_Paint;
                AddHoverEffect(card);
            }

            // Add rounded corners to welcome panel
            panelWelcome.Paint += WelcomePanel_Paint;

            // Setup animation timer
            animationTimer = new Timer();
            animationTimer.Interval = 20;
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void AddHoverEffect(Panel panel)
        {
            int originalTop = panel.Top;
            bool isHovered = false;
            
            panel.MouseEnter += (s, e) =>
            {
                if (!isHovered)
                {
                    isHovered = true;
                    panel.Top = originalTop - 5;
                    panel.Cursor = Cursors.Hand;
                }
            };
            panel.MouseLeave += (s, e) =>
            {
                if (isHovered && !panel.ClientRectangle.Contains(panel.PointToClient(Cursor.Position)))
                {
                    isHovered = false;
                    panel.Top = originalTop;
                }
            };

            foreach (Control child in panel.Controls)
            {
                child.MouseEnter += (s, e) =>
                {
                    if (!isHovered)
                    {
                        isHovered = true;
                        panel.Top = originalTop - 5;
                        panel.Cursor = Cursors.Hand;
                    }
                };
                child.MouseLeave += (s, e) =>
                {
                    if (isHovered && !panel.ClientRectangle.Contains(panel.PointToClient(Cursor.Position)))
                    {
                        isHovered = false;
                        panel.Top = originalTop;
                    }
                };
            }
        }

        private void StatCard_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 20;
            Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
            GraphicsPath path = GetRoundedRectangle(rect, radius);

            Color startColor, endColor;
            int index = statCards.IndexOf(panel);

            switch (index)
            {
                case 0:
                    startColor = Color.FromArgb(172, 126, 241);
                    endColor = Color.FromArgb(138, 85, 247);
                    break;
                case 1:
                    startColor = Color.FromArgb(249, 118, 176);
                    endColor = Color.FromArgb(236, 72, 153);
                    break;
                case 2:
                    startColor = Color.FromArgb(56, 189, 248);
                    endColor = Color.FromArgb(14, 165, 233);
                    break;
                case 3:
                    startColor = Color.FromArgb(129, 140, 248);
                    endColor = Color.FromArgb(99, 102, 241);
                    break;
                default:
                    startColor = Color.FromArgb(172, 126, 241);
                    endColor = Color.FromArgb(138, 85, 247);
                    break;
            }

            using (LinearGradientBrush brush = new LinearGradientBrush(rect, startColor, endColor, 45f))
            {
                e.Graphics.FillPath(brush, path);
            }

            using (Pen shadowPen = new Pen(Color.FromArgb(30, 0, 0, 0), 2))
            {
                e.Graphics.DrawPath(shadowPen, path);
            }

            path.Dispose();
        }

        private void WelcomePanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 25;
            Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
            GraphicsPath path = GetRoundedRectangle(rect, radius);

            using (LinearGradientBrush brush = new LinearGradientBrush(rect,
                Color.FromArgb(250, 245, 255), Color.White, 135f))
            {
                e.Graphics.FillPath(brush, path);
            }

            using (Pen borderPen = new Pen(Color.FromArgb(40, 90, 24, 154), 2))
            {
                e.Graphics.DrawPath(borderPen, path);
            }

            path.Dispose();
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

        private void CarregarDashboard()
        {
            var produtos = ProdutoManager.ObterTodosProdutos();
            int totalProdutos = produtos.Count;
            int totalCategorias = produtos.Select(p => p.Categoria).Distinct().Count();
            int itensCarrinho = CarrinhoManager.ObterQuantidadeTotal();
            valorEstoqueReal = produtos.Sum(p => p.Preco * p.QuantidadeEstoque);

            targetValues.Clear();
            targetValues.Add(totalProdutos);
            targetValues.Add(totalCategorias);
            targetValues.Add(itensCarrinho);

            // Valor em stock - show immediately without animation
            lblValorEstoque.Text = $"€ {valorEstoqueReal:N2}";

            // Start animation for other values
            animationTimer.Start();

            UpdateGreeting();
        }

        private void UpdateGreeting()
        {
            int hour = DateTime.Now.Hour;
            string greeting;

            if (hour < 12)
                greeting = "Bom dia";
            else if (hour < 18)
                greeting = "Boa tarde";
            else
                greeting = "Boa noite";

            lblWelcomeTitle.Text = $"{greeting}! Bem-vindo à PlugNSound";
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            bool allComplete = true;

            // Only animate first 3 values (not valor estoque)
            for (int i = 0; i < 3; i++)
            {
                if (currentValues[i] < targetValues[i])
                {
                    int increment = Math.Max(1, (targetValues[i] - currentValues[i]) / 10);
                    currentValues[i] = Math.Min(currentValues[i] + increment, targetValues[i]);
                    allComplete = false;
                }
            }

            lblTotalProdutos.Text = currentValues[0].ToString();
            lblTotalCategorias.Text = currentValues[1].ToString();
            lblItensCarrinho.Text = currentValues[2].ToString();

            if (allComplete)
            {
                animationTimer.Stop();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            animationTimer?.Stop();
            animationTimer?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
