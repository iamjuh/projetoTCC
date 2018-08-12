namespace LojaTCC
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskeddt_nasc = new System.Windows.Forms.MaskedTextBox();
            this.maskedcpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedrg = new System.Windows.Forms.MaskedTextBox();
            this.combosexo = new System.Windows.Forms.ComboBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lbldt_nasc = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtcod_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtuf = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtlogradouro = new System.Windows.Forms.TextBox();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.maskedcep = new System.Windows.Forms.MaskedTextBox();
            this.lbluf = new System.Windows.Forms.Label();
            this.lblnum_resid = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblbairro = new System.Windows.Forms.Label();
            this.lblcep = new System.Windows.Forms.Label();
            this.lblcomplemento = new System.Windows.Forms.Label();
            this.lbllogradouro = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedcel = new System.Windows.Forms.MaskedTextBox();
            this.maskedtel = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcel = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.maskeddt_nasc);
            this.groupBox1.Controls.Add(this.maskedcpf);
            this.groupBox1.Controls.Add(this.maskedrg);
            this.groupBox1.Controls.Add(this.combosexo);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblsexo);
            this.groupBox1.Controls.Add(this.lbldt_nasc);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(28, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maskeddt_nasc
            // 
            this.maskeddt_nasc.Location = new System.Drawing.Point(171, 69);
            this.maskeddt_nasc.Mask = "00/00/0000";
            this.maskeddt_nasc.Name = "maskeddt_nasc";
            this.maskeddt_nasc.Size = new System.Drawing.Size(132, 22);
            this.maskeddt_nasc.TabIndex = 14;
            this.maskeddt_nasc.ValidatingType = typeof(System.DateTime);
            // 
            // maskedcpf
            // 
            this.maskedcpf.Location = new System.Drawing.Point(355, 110);
            this.maskedcpf.Mask = "000.000.000-00";
            this.maskedcpf.Name = "maskedcpf";
            this.maskedcpf.Size = new System.Drawing.Size(144, 22);
            this.maskedcpf.TabIndex = 13;
            // 
            // maskedrg
            // 
            this.maskedrg.Location = new System.Drawing.Point(351, 69);
            this.maskedrg.Mask = "000-000-000,00";
            this.maskedrg.Name = "maskedrg";
            this.maskedrg.Size = new System.Drawing.Size(148, 22);
            this.maskedrg.TabIndex = 12;
            // 
            // combosexo
            // 
            this.combosexo.FormattingEnabled = true;
            this.combosexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.combosexo.Location = new System.Drawing.Point(171, 109);
            this.combosexo.Name = "combosexo";
            this.combosexo.Size = new System.Drawing.Size(121, 23);
            this.combosexo.TabIndex = 11;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(171, 32);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(324, 22);
            this.txtnome.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(305, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "CPF:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(310, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "RG:*";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblsexo.Location = new System.Drawing.Point(127, 113);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(38, 15);
            this.lblsexo.TabIndex = 3;
            this.lblsexo.Text = "Sexo";
            // 
            // lbldt_nasc
            // 
            this.lbldt_nasc.AutoSize = true;
            this.lbldt_nasc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbldt_nasc.Location = new System.Drawing.Point(19, 72);
            this.lbldt_nasc.Name = "lbldt_nasc";
            this.lbldt_nasc.Size = new System.Drawing.Size(146, 15);
            this.lbldt_nasc.TabIndex = 1;
            this.lbldt_nasc.Text = "Data de Nascimento:*";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblnome.Location = new System.Drawing.Point(111, 35);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(54, 15);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:*";
            // 
            // txtcod_cliente
            // 
            this.txtcod_cliente.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod_cliente.Location = new System.Drawing.Point(232, 19);
            this.txtcod_cliente.Name = "txtcod_cliente";
            this.txtcod_cliente.Size = new System.Drawing.Size(100, 22);
            this.txtcod_cliente.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código Cliente:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtuf);
            this.groupBox2.Controls.Add(this.txtcidade);
            this.groupBox2.Controls.Add(this.txtn);
            this.groupBox2.Controls.Add(this.txtlogradouro);
            this.groupBox2.Controls.Add(this.txtcomplemento);
            this.groupBox2.Controls.Add(this.txtbairro);
            this.groupBox2.Controls.Add(this.maskedcep);
            this.groupBox2.Controls.Add(this.lbluf);
            this.groupBox2.Controls.Add(this.lblnum_resid);
            this.groupBox2.Controls.Add(this.lblcidade);
            this.groupBox2.Controls.Add(this.lblbairro);
            this.groupBox2.Controls.Add(this.lblcep);
            this.groupBox2.Controls.Add(this.lblcomplemento);
            this.groupBox2.Controls.Add(this.lbllogradouro);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(28, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // txtuf
            // 
            this.txtuf.Location = new System.Drawing.Point(505, 66);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(100, 22);
            this.txtuf.TabIndex = 14;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(355, 112);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(131, 22);
            this.txtcidade.TabIndex = 13;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(355, 66);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 22);
            this.txtn.TabIndex = 12;
            // 
            // txtlogradouro
            // 
            this.txtlogradouro.Location = new System.Drawing.Point(354, 24);
            this.txtlogradouro.Name = "txtlogradouro";
            this.txtlogradouro.Size = new System.Drawing.Size(215, 22);
            this.txtlogradouro.TabIndex = 11;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(130, 66);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(109, 22);
            this.txtcomplemento.TabIndex = 10;
            this.txtcomplemento.TextChanged += new System.EventHandler(this.txtcomplemento_TextChanged);
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(130, 115);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(152, 22);
            this.txtbairro.TabIndex = 9;
            // 
            // maskedcep
            // 
            this.maskedcep.Location = new System.Drawing.Point(130, 27);
            this.maskedcep.Name = "maskedcep";
            this.maskedcep.Size = new System.Drawing.Size(132, 22);
            this.maskedcep.TabIndex = 8;
            this.maskedcep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedcep_KeyDown);
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbluf.Location = new System.Drawing.Point(476, 73);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(23, 15);
            this.lbluf.TabIndex = 6;
            this.lbluf.Text = "UF";
            // 
            // lblnum_resid
            // 
            this.lblnum_resid.AutoSize = true;
            this.lblnum_resid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblnum_resid.Location = new System.Drawing.Point(325, 73);
            this.lblnum_resid.Name = "lblnum_resid";
            this.lblnum_resid.Size = new System.Drawing.Size(20, 15);
            this.lblnum_resid.TabIndex = 2;
            this.lblnum_resid.Text = "N°";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcidade.Location = new System.Drawing.Point(301, 115);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(52, 15);
            this.lblcidade.TabIndex = 5;
            this.lblcidade.Text = "Cidade";
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblbairro.Location = new System.Drawing.Point(68, 115);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(47, 15);
            this.lblbairro.TabIndex = 4;
            this.lblbairro.Text = "Bairro";
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcep.Location = new System.Drawing.Point(75, 34);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(40, 15);
            this.lblcep.TabIndex = 3;
            this.lblcep.Text = "CEP:*";
            // 
            // lblcomplemento
            // 
            this.lblcomplemento.AutoSize = true;
            this.lblcomplemento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcomplemento.Location = new System.Drawing.Point(15, 73);
            this.lblcomplemento.Name = "lblcomplemento";
            this.lblcomplemento.Size = new System.Drawing.Size(100, 15);
            this.lblcomplemento.TabIndex = 1;
            this.lblcomplemento.Text = "Complemento";
            // 
            // lbllogradouro
            // 
            this.lbllogradouro.AutoSize = true;
            this.lbllogradouro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbllogradouro.Location = new System.Drawing.Point(270, 30);
            this.lbllogradouro.Name = "lbllogradouro";
            this.lbllogradouro.Size = new System.Drawing.Size(83, 15);
            this.lbllogradouro.TabIndex = 0;
            this.lbllogradouro.Text = "Logradouro";
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalvar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsalvar.Location = new System.Drawing.Point(689, 87);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(78, 46);
            this.btnsalvar.TabIndex = 2;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maskedcel);
            this.groupBox3.Controls.Add(this.maskedtel);
            this.groupBox3.Controls.Add(this.txtemail);
            this.groupBox3.Controls.Add(this.lblemail);
            this.groupBox3.Controls.Add(this.lblcel);
            this.groupBox3.Controls.Add(this.lbltel);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(28, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(618, 107);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comunicação";
            // 
            // maskedcel
            // 
            this.maskedcel.Location = new System.Drawing.Point(355, 21);
            this.maskedcel.Mask = "00000-9999";
            this.maskedcel.Name = "maskedcel";
            this.maskedcel.Size = new System.Drawing.Size(139, 22);
            this.maskedcel.TabIndex = 7;
            this.maskedcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedcel_KeyPress);
            // 
            // maskedtel
            // 
            this.maskedtel.Location = new System.Drawing.Point(130, 21);
            this.maskedtel.Mask = "0000-9999";
            this.maskedtel.Name = "maskedtel";
            this.maskedtel.Size = new System.Drawing.Size(148, 22);
            this.maskedtel.TabIndex = 6;
            this.maskedtel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedtel_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(130, 65);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(244, 22);
            this.txtemail.TabIndex = 3;
            this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtemail_KeyDown);
            this.txtemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemail_KeyPress);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblemail.Location = new System.Drawing.Point(70, 68);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(45, 15);
            this.lblemail.TabIndex = 2;
            this.lblemail.Text = "Email:";
            // 
            // lblcel
            // 
            this.lblcel.AutoSize = true;
            this.lblcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcel.Location = new System.Drawing.Point(295, 28);
            this.lblcel.Name = "lblcel";
            this.lblcel.Size = new System.Drawing.Size(58, 15);
            this.lblcel.TabIndex = 1;
            this.lblcel.Text = "Celular:";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltel.Location = new System.Drawing.Point(46, 28);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(69, 15);
            this.lbltel.TabIndex = 0;
            this.lbltel.Text = "Telefone:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(689, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 189);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(689, 151);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(78, 46);
            this.btnlimpar.TabIndex = 14;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 535);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtcod_cliente);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldt_nasc;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lbluf;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Label lblnum_resid;
        private System.Windows.Forms.Label lblcomplemento;
        private System.Windows.Forms.Label lbllogradouro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblcel;
        private System.Windows.Forms.Label lbltel;
        public System.Windows.Forms.TextBox txtcod_cliente;
        public System.Windows.Forms.TextBox txtnome;
        public System.Windows.Forms.ComboBox combosexo;
        public System.Windows.Forms.TextBox txtcidade;
        public System.Windows.Forms.TextBox txtn;
        public System.Windows.Forms.TextBox txtlogradouro;
        public System.Windows.Forms.TextBox txtcomplemento;
        public System.Windows.Forms.TextBox txtbairro;
        public System.Windows.Forms.MaskedTextBox maskedcep;
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.MaskedTextBox maskedcpf;
        public System.Windows.Forms.MaskedTextBox maskedrg;
        public System.Windows.Forms.TextBox txtuf;
        public System.Windows.Forms.MaskedTextBox maskedcel;
        public System.Windows.Forms.MaskedTextBox maskedtel;
        public System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnlimpar;
        public System.Windows.Forms.MaskedTextBox maskeddt_nasc;
    }
}