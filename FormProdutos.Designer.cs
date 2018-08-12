namespace LojaTCC
{
    partial class FormProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedbarra = new System.Windows.Forms.MaskedTextBox();
            this.comboetaria = new System.Windows.Forms.ComboBox();
            this.lbletaria = new System.Windows.Forms.Label();
            this.comboFornecedor = new System.Windows.Forms.ComboBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.lblcod_barra = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcod_categoria = new System.Windows.Forms.Label();
            this.lblcod_fornecedor = new System.Windows.Forms.Label();
            this.txtcod_produtos = new System.Windows.Forms.TextBox();
            this.lblcod_produtos = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedbarra);
            this.groupBox1.Controls.Add(this.comboetaria);
            this.groupBox1.Controls.Add(this.lbletaria);
            this.groupBox1.Controls.Add(this.comboFornecedor);
            this.groupBox1.Controls.Add(this.comboCategoria);
            this.groupBox1.Controls.Add(this.comboMarca);
            this.groupBox1.Controls.Add(this.lblcod_barra);
            this.groupBox1.Controls.Add(this.txtvalor);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.lblvalor);
            this.groupBox1.Controls.Add(this.lblmarca);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Controls.Add(this.lblcod_categoria);
            this.groupBox1.Controls.Add(this.lblcod_fornecedor);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(27, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Produto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maskedbarra
            // 
            this.maskedbarra.Location = new System.Drawing.Point(423, 70);
            this.maskedbarra.Name = "maskedbarra";
            this.maskedbarra.Size = new System.Drawing.Size(112, 22);
            this.maskedbarra.TabIndex = 26;
            this.maskedbarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedbarra_KeyDown);
            // 
            // comboetaria
            // 
            this.comboetaria.FormattingEnabled = true;
            this.comboetaria.Items.AddRange(new object[] {
            "0 - 6 meses",
            "6 meses - 1 ano",
            "1 ano - 2 anos",
            "2 anos - 3 anos",
            "3 anos - 4 anos",
            "4 anos - 6 anos",
            "6 anos - 9 anos",
            "9 anos - 12 anos"});
            this.comboetaria.Location = new System.Drawing.Point(109, 155);
            this.comboetaria.Name = "comboetaria";
            this.comboetaria.Size = new System.Drawing.Size(172, 23);
            this.comboetaria.TabIndex = 25;
            // 
            // lbletaria
            // 
            this.lbletaria.AutoSize = true;
            this.lbletaria.Location = new System.Drawing.Point(5, 163);
            this.lbletaria.Name = "lbletaria";
            this.lbletaria.Size = new System.Drawing.Size(83, 15);
            this.lbletaria.TabIndex = 24;
            this.lbletaria.Text = "Faixa Etária:";
            // 
            // comboFornecedor
            // 
            this.comboFornecedor.FormattingEnabled = true;
            this.comboFornecedor.Location = new System.Drawing.Point(109, 201);
            this.comboFornecedor.Name = "comboFornecedor";
            this.comboFornecedor.Size = new System.Drawing.Size(251, 23);
            this.comboFornecedor.TabIndex = 23;
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(109, 113);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(172, 23);
            this.comboCategoria.TabIndex = 21;
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(109, 69);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(172, 23);
            this.comboMarca.TabIndex = 20;
            // 
            // lblcod_barra
            // 
            this.lblcod_barra.AutoSize = true;
            this.lblcod_barra.BackColor = System.Drawing.Color.Transparent;
            this.lblcod_barra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcod_barra.Location = new System.Drawing.Point(301, 73);
            this.lblcod_barra.Name = "lblcod_barra";
            this.lblcod_barra.Size = new System.Drawing.Size(116, 15);
            this.lblcod_barra.TabIndex = 16;
            this.lblcod_barra.Text = "Código de Barra:";
            this.lblcod_barra.Click += new System.EventHandler(this.lblcod_barra_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(109, 27);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(354, 22);
            this.txtnome.TabIndex = 10;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.ForeColor = System.Drawing.Color.Black;
            this.lblvalor.Location = new System.Drawing.Point(42, 253);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(46, 15);
            this.lblvalor.TabIndex = 8;
            this.lblvalor.Text = "Valor:";
            this.lblvalor.Click += new System.EventHandler(this.lblvalor_Click);
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.ForeColor = System.Drawing.Color.Black;
            this.lblmarca.Location = new System.Drawing.Point(39, 73);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(49, 15);
            this.lblmarca.TabIndex = 7;
            this.lblmarca.Text = "Marca:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.ForeColor = System.Drawing.Color.Black;
            this.lblnome.Location = new System.Drawing.Point(39, 30);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(49, 15);
            this.lblnome.TabIndex = 5;
            this.lblnome.Text = "Nome:";
            // 
            // lblcod_categoria
            // 
            this.lblcod_categoria.AutoSize = true;
            this.lblcod_categoria.ForeColor = System.Drawing.Color.Black;
            this.lblcod_categoria.Location = new System.Drawing.Point(14, 116);
            this.lblcod_categoria.Name = "lblcod_categoria";
            this.lblcod_categoria.Size = new System.Drawing.Size(74, 15);
            this.lblcod_categoria.TabIndex = 4;
            this.lblcod_categoria.Text = "Categoria:";
            this.lblcod_categoria.Click += new System.EventHandler(this.lblcod_categoria_Click);
            // 
            // lblcod_fornecedor
            // 
            this.lblcod_fornecedor.AutoSize = true;
            this.lblcod_fornecedor.ForeColor = System.Drawing.Color.Black;
            this.lblcod_fornecedor.Location = new System.Drawing.Point(6, 204);
            this.lblcod_fornecedor.Name = "lblcod_fornecedor";
            this.lblcod_fornecedor.Size = new System.Drawing.Size(88, 15);
            this.lblcod_fornecedor.TabIndex = 2;
            this.lblcod_fornecedor.Text = "Fornecedor:";
            // 
            // txtcod_produtos
            // 
            this.txtcod_produtos.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod_produtos.Location = new System.Drawing.Point(254, 25);
            this.txtcod_produtos.Name = "txtcod_produtos";
            this.txtcod_produtos.Size = new System.Drawing.Size(72, 22);
            this.txtcod_produtos.TabIndex = 1;
            // 
            // lblcod_produtos
            // 
            this.lblcod_produtos.AutoSize = true;
            this.lblcod_produtos.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_produtos.Location = new System.Drawing.Point(133, 28);
            this.lblcod_produtos.Name = "lblcod_produtos";
            this.lblcod_produtos.Size = new System.Drawing.Size(115, 15);
            this.lblcod_produtos.TabIndex = 0;
            this.lblcod_produtos.Text = "Código produto:";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(622, 55);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(84, 40);
            this.btnsalvar.TabIndex = 14;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(622, 120);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(84, 40);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(599, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 166);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(109, 250);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(120, 22);
            this.txtvalor.TabIndex = 13;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblcod_produtos);
            this.Controls.Add(this.txtcod_produtos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Cadastrar Produtos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcod_categoria;
        private System.Windows.Forms.Label lblcod_fornecedor;
        private System.Windows.Forms.Label lblcod_produtos;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblcod_barra;
        public System.Windows.Forms.TextBox txtnome;
        public System.Windows.Forms.TextBox txtcod_produtos;
        public System.Windows.Forms.Button btnsalvar;
        public System.Windows.Forms.ComboBox comboCategoria;
        public System.Windows.Forms.ComboBox comboMarca;
        public System.Windows.Forms.ComboBox comboFornecedor;
        private System.Windows.Forms.Label lbletaria;
        public System.Windows.Forms.ComboBox comboetaria;
        public System.Windows.Forms.MaskedTextBox maskedbarra;
        public System.Windows.Forms.TextBox txtvalor;
    }
}