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
            this.lblContagem = new System.Windows.Forms.Label();
            this.flowLayoutProdutos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.lblTitulo.Location = new System.Drawing.Point(40, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(340, 51);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "?? Nossos Produtos";
            // 
            // lblContagem
            // 
            this.lblContagem.AutoSize = true;
            this.lblContagem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblContagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblContagem.Location = new System.Drawing.Point(45, 85);
            this.lblContagem.Name = "lblContagem";
            this.lblContagem.Size = new System.Drawing.Size(168, 20);
            this.lblContagem.TabIndex = 1;
            this.lblContagem.Text = "0 produtos disponíveis";
            // 
            // flowLayoutProdutos
            // 
            this.flowLayoutProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutProdutos.AutoScroll = true;
            this.flowLayoutProdutos.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutProdutos.Location = new System.Drawing.Point(40, 120);
            this.flowLayoutProdutos.Name = "flowLayoutProdutos";
            this.flowLayoutProdutos.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutProdutos.Size = new System.Drawing.Size(1120, 750);
            this.flowLayoutProdutos.TabIndex = 2;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.flowLayoutProdutos);
            this.Controls.Add(this.lblContagem);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblContagem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutProdutos;
    }
}
