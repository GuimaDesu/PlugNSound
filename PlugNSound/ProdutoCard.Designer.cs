namespace PlugNSound
{
    partial class ProdutoCard
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
            this.panelCard = new System.Windows.Forms.Panel();
            this.btnAdicionarCarrinho = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.btnAdicionarCarrinho);
            this.panelCard.Controls.Add(this.lblCategoria);
            this.panelCard.Controls.Add(this.lblEstoque);
            this.panelCard.Controls.Add(this.lblPreco);
            this.panelCard.Controls.Add(this.lblNome);
            this.panelCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCard.Location = new System.Drawing.Point(0, 0);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(15);
            this.panelCard.Size = new System.Drawing.Size(220, 200);
            this.panelCard.TabIndex = 0;
            this.panelCard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCard_Paint);
            this.panelCard.MouseEnter += new System.EventHandler(this.panelCard_MouseEnter);
            this.panelCard.MouseLeave += new System.EventHandler(this.panelCard_MouseLeave);
            // 
            // btnAdicionarCarrinho
            // 
            this.btnAdicionarCarrinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnAdicionarCarrinho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCarrinho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdicionarCarrinho.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarCarrinho.Location = new System.Drawing.Point(15, 150);
            this.btnAdicionarCarrinho.Name = "btnAdicionarCarrinho";
            this.btnAdicionarCarrinho.Size = new System.Drawing.Size(190, 35);
            this.btnAdicionarCarrinho.TabIndex = 4;
            this.btnAdicionarCarrinho.Text = "?? Adicionar ao Carrinho";
            this.btnAdicionarCarrinho.UseVisualStyleBackColor = false;
            this.btnAdicionarCarrinho.Click += new System.EventHandler(this.btnAdicionarCarrinho_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(24)))), ((int)(((byte)(154)))));
            this.lblCategoria.Location = new System.Drawing.Point(15, 15);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.lblCategoria.Size = new System.Drawing.Size(69, 21);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstoque.ForeColor = System.Drawing.Color.Gray;
            this.lblEstoque.Location = new System.Drawing.Point(15, 145);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(80, 15);
            this.lblEstoque.TabIndex = 2;
            this.lblEstoque.Text = "Estoque: 0 un.";
            this.lblEstoque.Visible = false;
            // 
            // lblPreco
            // 
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.lblPreco.Location = new System.Drawing.Point(15, 105);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(190, 35);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "€ 0,00";
            this.lblPreco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.lblNome.Location = new System.Drawing.Point(15, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(190, 45);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Produto";
            // 
            // ProdutoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelCard);
            this.Name = "ProdutoCard";
            this.Size = new System.Drawing.Size(220, 200);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnAdicionarCarrinho;
    }
}
