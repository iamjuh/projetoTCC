namespace LojaTCC
{
    partial class Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedcnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtie = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblie = new System.Windows.Forms.Label();
            this.lblcnpj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrepresentante = new System.Windows.Forms.TextBox();
            this.maskedtel = new System.Windows.Forms.MaskedTextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblRepresentante = new System.Windows.Forms.Label();
            this.txtcod_fornecedor = new System.Windows.Forms.TextBox();
            this.lblcod_fornecedor = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedcnpj);
            this.groupBox1.Controls.Add(this.txtie);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.lblie);
            this.groupBox1.Controls.Add(this.lblcnpj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(36, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Fornecedor";
            // 
            // maskedcnpj
            // 
            this.maskedcnpj.Location = new System.Drawing.Point(104, 72);
            this.maskedcnpj.Name = "maskedcnpj";
            this.maskedcnpj.Size = new System.Drawing.Size(140, 22);
            this.maskedcnpj.TabIndex = 29;
            this.maskedcnpj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedcnpj_KeyDown);
            // 
            // txtie
            // 
            this.txtie.Location = new System.Drawing.Point(312, 72);
            this.txtie.Name = "txtie";
            this.txtie.Size = new System.Drawing.Size(100, 22);
            this.txtie.TabIndex = 12;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(104, 26);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(340, 22);
            this.txtnome.TabIndex = 11;
            // 
            // lblie
            // 
            this.lblie.AutoSize = true;
            this.lblie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblie.Location = new System.Drawing.Point(266, 77);
            this.lblie.Name = "lblie";
            this.lblie.Size = new System.Drawing.Size(22, 15);
            this.lblie.TabIndex = 4;
            this.lblie.Text = "IE:";
            // 
            // lblcnpj
            // 
            this.lblcnpj.AutoSize = true;
            this.lblcnpj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcnpj.Location = new System.Drawing.Point(36, 77);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(43, 15);
            this.lblcnpj.TabIndex = 2;
            this.lblcnpj.Text = "CNPJ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(35, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtrepresentante
            // 
            this.txtrepresentante.Location = new System.Drawing.Point(164, 30);
            this.txtrepresentante.Name = "txtrepresentante";
            this.txtrepresentante.Size = new System.Drawing.Size(280, 22);
            this.txtrepresentante.TabIndex = 33;
            // 
            // maskedtel
            // 
            this.maskedtel.Location = new System.Drawing.Point(164, 72);
            this.maskedtel.Mask = "00000-9999";
            this.maskedtel.Name = "maskedtel";
            this.maskedtel.Size = new System.Drawing.Size(144, 22);
            this.maskedtel.TabIndex = 32;
            this.maskedtel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedFoneComercial_MaskInputRejected);
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltel.Location = new System.Drawing.Point(72, 80);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(73, 15);
            this.lbltel.TabIndex = 31;
            this.lbltel.Text = "Telefone :";
            // 
            // lblRepresentante
            // 
            this.lblRepresentante.AutoSize = true;
            this.lblRepresentante.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRepresentante.Location = new System.Drawing.Point(35, 38);
            this.lblRepresentante.Name = "lblRepresentante";
            this.lblRepresentante.Size = new System.Drawing.Size(106, 15);
            this.lblRepresentante.TabIndex = 30;
            this.lblRepresentante.Text = "Representante:";
            // 
            // txtcod_fornecedor
            // 
            this.txtcod_fornecedor.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod_fornecedor.Location = new System.Drawing.Point(289, 16);
            this.txtcod_fornecedor.Name = "txtcod_fornecedor";
            this.txtcod_fornecedor.Size = new System.Drawing.Size(55, 22);
            this.txtcod_fornecedor.TabIndex = 7;
            // 
            // lblcod_fornecedor
            // 
            this.lblcod_fornecedor.AutoSize = true;
            this.lblcod_fornecedor.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_fornecedor.Location = new System.Drawing.Point(144, 19);
            this.lblcod_fornecedor.Name = "lblcod_fornecedor";
            this.lblcod_fornecedor.Size = new System.Drawing.Size(139, 15);
            this.lblcod_fornecedor.TabIndex = 0;
            this.lblcod_fornecedor.Text = "Código Fornecedor:";
            this.lblcod_fornecedor.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(597, 62);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(88, 38);
            this.btnsalvar.TabIndex = 31;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedtel);
            this.groupBox2.Controls.Add(this.txtrepresentante);
            this.groupBox2.Controls.Add(this.lbltel);
            this.groupBox2.Controls.Add(this.lblRepresentante);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(36, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 118);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contato";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(577, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 156);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtcod_fornecedor);
            this.Controls.Add(this.lblcod_fornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.Fornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblie;
        private System.Windows.Forms.Label lblcnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcod_fornecedor;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblRepresentante;
        public System.Windows.Forms.TextBox txtie;
        public System.Windows.Forms.TextBox txtnome;
        public System.Windows.Forms.TextBox txtcod_fornecedor;
        public System.Windows.Forms.MaskedTextBox maskedcnpj;
        public System.Windows.Forms.Button btnsalvar;
        public System.Windows.Forms.TextBox txtrepresentante;
        public System.Windows.Forms.MaskedTextBox maskedtel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}