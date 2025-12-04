namespace PlugNSound
{
    partial class FormCarrinho
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
            this.groupBoxCarrinho = new System.Windows.Forms.GroupBox();
            this.listViewCarrinho = new System.Windows.Forms.ListView();
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAcoes = new System.Windows.Forms.GroupBox();
            this.btnDiminuir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuantidadeTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCarrinho.SuspendLayout();
            this.groupBoxAcoes.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(330, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "?? Carrinho de Compras";
            // 
            // groupBoxCarrinho
            // 
            this.groupBoxCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCarrinho.BackColor = System.Drawing.Color.White;
            this.groupBoxCarrinho.Controls.Add(this.listViewCarrinho);
            this.groupBoxCarrinho.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxCarrinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.groupBoxCarrinho.Location = new System.Drawing.Point(30, 80);
            this.groupBoxCarrinho.Name = "groupBoxCarrinho";
            this.groupBoxCarrinho.Size = new System.Drawing.Size(800, 300);
            this.groupBoxCarrinho.TabIndex = 1;
            this.groupBoxCarrinho.TabStop = false;
            this.groupBoxCarrinho.Text = "Itens no Carrinho";
            // 
            // listViewCarrinho
            // 
            this.listViewCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCarrinho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNome,
            this.columnPreco,
            this.columnQuantidade,
            this.columnSubtotal});
            this.listViewCarrinho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listViewCarrinho.FullRowSelect = true;
            this.listViewCarrinho.GridLines = true;
            this.listViewCarrinho.HideSelection = false;
            this.listViewCarrinho.Location = new System.Drawing.Point(20, 30);
            this.listViewCarrinho.MultiSelect = false;
            this.listViewCarrinho.Name = "listViewCarrinho";
            this.listViewCarrinho.Size = new System.Drawing.Size(760, 250);
            this.listViewCarrinho.TabIndex = 0;
            this.listViewCarrinho.UseCompatibleStateImageBehavior = false;
            this.listViewCarrinho.View = System.Windows.Forms.View.Details;
            // 
            // columnNome
            // 
            this.columnNome.Text = "Produto";
            this.columnNome.Width = 350;
            // 
            // columnPreco
            // 
            this.columnPreco.Text = "Preço Unitário";
            this.columnPreco.Width = 120;
            // 
            // columnQuantidade
            // 
            this.columnQuantidade.Text = "Quantidade";
            this.columnQuantidade.Width = 100;
            // 
            // columnSubtotal
            // 
            this.columnSubtotal.Text = "Subtotal";
            this.columnSubtotal.Width = 120;
            // 
            // groupBoxAcoes
            // 
            this.groupBoxAcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAcoes.BackColor = System.Drawing.Color.White;
            this.groupBoxAcoes.Controls.Add(this.btnDiminuir);
            this.groupBoxAcoes.Controls.Add(this.btnAdicionar);
            this.groupBoxAcoes.Controls.Add(this.btnLimpar);
            this.groupBoxAcoes.Controls.Add(this.btnRemover);
            this.groupBoxAcoes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxAcoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.groupBoxAcoes.Location = new System.Drawing.Point(30, 390);
            this.groupBoxAcoes.Name = "groupBoxAcoes";
            this.groupBoxAcoes.Size = new System.Drawing.Size(800, 80);
            this.groupBoxAcoes.TabIndex = 2;
            this.groupBoxAcoes.TabStop = false;
            this.groupBoxAcoes.Text = "Ações";
            // 
            // btnDiminuir
            // 
            this.btnDiminuir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnDiminuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiminuir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDiminuir.ForeColor = System.Drawing.Color.White;
            this.btnDiminuir.Location = new System.Drawing.Point(220, 30);
            this.btnDiminuir.Name = "btnDiminuir";
            this.btnDiminuir.Size = new System.Drawing.Size(150, 35);
            this.btnDiminuir.TabIndex = 3;
            this.btnDiminuir.Text = "? Diminuir";
            this.btnDiminuir.UseVisualStyleBackColor = false;
            this.btnDiminuir.Click += new System.EventHandler(this.btnDiminuir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(30, 30);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(150, 35);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "? Adicionar +1";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(24)))), ((int)(((byte)(154)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(610, 30);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(170, 35);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "??? Limpar Carrinho";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(410, 30);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(150, 35);
            this.btnRemover.TabIndex = 0;
            this.btnRemover.Text = "? Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // panelTotal
            // 
            this.panelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.panelTotal.Controls.Add(this.btnFinalizar);
            this.panelTotal.Controls.Add(this.lblValorTotal);
            this.panelTotal.Controls.Add(this.label2);
            this.panelTotal.Controls.Add(this.lblQuantidadeTotal);
            this.panelTotal.Controls.Add(this.label1);
            this.panelTotal.Location = new System.Drawing.Point(30, 480);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(800, 100);
            this.panelTotal.TabIndex = 3;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(570, 25);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(210, 50);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "? Finalizar Compra";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblValorTotal.ForeColor = System.Drawing.Color.White;
            this.lblValorTotal.Location = new System.Drawing.Point(250, 50);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(200, 35);
            this.lblValorTotal.TabIndex = 3;
            this.lblValorTotal.Text = "€ 0,00";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(250, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Total:";
            // 
            // lblQuantidadeTotal
            // 
            this.lblQuantidadeTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblQuantidadeTotal.ForeColor = System.Drawing.Color.White;
            this.lblQuantidadeTotal.Location = new System.Drawing.Point(20, 50);
            this.lblQuantidadeTotal.Name = "lblQuantidadeTotal";
            this.lblQuantidadeTotal.Size = new System.Drawing.Size(200, 35);
            this.lblQuantidadeTotal.TabIndex = 1;
            this.lblQuantidadeTotal.Text = "0 itens";
            this.lblQuantidadeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Produtos:";
            // 
            // FormCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(860, 600);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.groupBoxAcoes);
            this.Controls.Add(this.groupBoxCarrinho);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCarrinho";
            this.Text = "Carrinho de Compras";
            this.groupBoxCarrinho.ResumeLayout(false);
            this.groupBoxAcoes.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxCarrinho;
        private System.Windows.Forms.ListView listViewCarrinho;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.ColumnHeader columnPreco;
        private System.Windows.Forms.ColumnHeader columnQuantidade;
        private System.Windows.Forms.ColumnHeader columnSubtotal;
        private System.Windows.Forms.GroupBox groupBoxAcoes;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblQuantidadeTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnDiminuir;
    }
}
