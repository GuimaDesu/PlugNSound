namespace PlugNSound
{
    partial class FormDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelEstatisticas = new System.Windows.Forms.Panel();
            this.panelCard2 = new System.Windows.Forms.Panel();
            this.lblTotalCategorias = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCard1 = new System.Windows.Forms.Panel();
            this.lblTotalProdutos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProdutosDisponiveis = new System.Windows.Forms.Label();
            this.flowLayoutProdutos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEstatisticas.SuspendLayout();
            this.panelCard2.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(266, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "??? Nossa Loja";
            // 
            // panelEstatisticas
            // 
            this.panelEstatisticas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEstatisticas.Controls.Add(this.panelCard2);
            this.panelEstatisticas.Controls.Add(this.panelCard1);
            this.panelEstatisticas.Location = new System.Drawing.Point(30, 80);
            this.panelEstatisticas.Name = "panelEstatisticas";
            this.panelEstatisticas.Size = new System.Drawing.Size(900, 120);
            this.panelEstatisticas.TabIndex = 1;
            // 
            // panelCard2
            // 
            this.panelCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.panelCard2.Controls.Add(this.lblTotalCategorias);
            this.panelCard2.Controls.Add(this.label4);
            this.panelCard2.Location = new System.Drawing.Point(310, 0);
            this.panelCard2.Name = "panelCard2";
            this.panelCard2.Size = new System.Drawing.Size(280, 120);
            this.panelCard2.TabIndex = 1;
            // 
            // lblTotalCategorias
            // 
            this.lblTotalCategorias.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalCategorias.ForeColor = System.Drawing.Color.White;
            this.lblTotalCategorias.Location = new System.Drawing.Point(15, 60);
            this.lblTotalCategorias.Name = "lblTotalCategorias";
            this.lblTotalCategorias.Size = new System.Drawing.Size(250, 40);
            this.lblTotalCategorias.TabIndex = 1;
            this.lblTotalCategorias.Text = "0";
            this.lblTotalCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Categorias Disponíveis";
            // 
            // panelCard1
            // 
            this.panelCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.panelCard1.Controls.Add(this.lblTotalProdutos);
            this.panelCard1.Controls.Add(this.label1);
            this.panelCard1.Location = new System.Drawing.Point(10, 0);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Size = new System.Drawing.Size(280, 120);
            this.panelCard1.TabIndex = 0;
            // 
            // lblTotalProdutos
            // 
            this.lblTotalProdutos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalProdutos.ForeColor = System.Drawing.Color.White;
            this.lblTotalProdutos.Location = new System.Drawing.Point(15, 60);
            this.lblTotalProdutos.Name = "lblTotalProdutos";
            this.lblTotalProdutos.Size = new System.Drawing.Size(250, 40);
            this.lblTotalProdutos.TabIndex = 1;
            this.lblTotalProdutos.Text = "0";
            this.lblTotalProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos Disponíveis";
            // 
            // lblProdutosDisponiveis
            // 
            this.lblProdutosDisponiveis.AutoSize = true;
            this.lblProdutosDisponiveis.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblProdutosDisponiveis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.lblProdutosDisponiveis.Location = new System.Drawing.Point(30, 220);
            this.lblProdutosDisponiveis.Name = "lblProdutosDisponiveis";
            this.lblProdutosDisponiveis.Size = new System.Drawing.Size(208, 30);
            this.lblProdutosDisponiveis.TabIndex = 2;
            this.lblProdutosDisponiveis.Text = "Nossos Produtos ??";
            // 
            // flowLayoutProdutos
            // 
            this.flowLayoutProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutProdutos.AutoScroll = true;
            this.flowLayoutProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.flowLayoutProdutos.Location = new System.Drawing.Point(30, 260);
            this.flowLayoutProdutos.Name = "flowLayoutProdutos";
            this.flowLayoutProdutos.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutProdutos.Size = new System.Drawing.Size(900, 340);
            this.flowLayoutProdutos.TabIndex = 3;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.flowLayoutProdutos);
            this.Controls.Add(this.lblProdutosDisponiveis);
            this.Controls.Add(this.panelEstatisticas);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "Nossa Loja";
            this.panelEstatisticas.ResumeLayout(false);
            this.panelCard2.ResumeLayout(false);
            this.panelCard2.PerformLayout();
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelEstatisticas;
        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Label lblTotalProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Label lblTotalCategorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProdutosDisponiveis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutProdutos;
    }
}
