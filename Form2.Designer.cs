namespace LojaTCC
{
    partial class Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
            this.lblcod_funcionario = new System.Windows.Forms.Label();
            this.txtcod_funcionario = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.lblcargo = new System.Windows.Forms.Label();
            this.maskedcel = new System.Windows.Forms.MaskedTextBox();
            this.maskedtel = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcel = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcod_funcionario
            // 
            this.lblcod_funcionario.AutoSize = true;
            this.lblcod_funcionario.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_funcionario.Location = new System.Drawing.Point(83, 34);
            this.lblcod_funcionario.Name = "lblcod_funcionario";
            this.lblcod_funcionario.Size = new System.Drawing.Size(136, 15);
            this.lblcod_funcionario.TabIndex = 1;
            this.lblcod_funcionario.Text = "Código Funcionário";
            // 
            // txtcod_funcionario
            // 
            this.txtcod_funcionario.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod_funcionario.Location = new System.Drawing.Point(246, 30);
            this.txtcod_funcionario.Name = "txtcod_funcionario";
            this.txtcod_funcionario.Size = new System.Drawing.Size(100, 22);
            this.txtcod_funcionario.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskeddt_nasc);
            this.groupBox2.Controls.Add(this.maskedcpf);
            this.groupBox2.Controls.Add(this.maskedrg);
            this.groupBox2.Controls.Add(this.combosexo);
            this.groupBox2.Controls.Add(this.txtnome);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblsexo);
            this.groupBox2.Controls.Add(this.lbldt_nasc);
            this.groupBox2.Controls.Add(this.lblnome);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(54, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // maskeddt_nasc
            // 
            this.maskeddt_nasc.Location = new System.Drawing.Point(171, 72);
            this.maskeddt_nasc.Mask = "00/00/0000";
            this.maskeddt_nasc.Name = "maskeddt_nasc";
            this.maskeddt_nasc.Size = new System.Drawing.Size(122, 22);
            this.maskeddt_nasc.TabIndex = 14;
            this.maskeddt_nasc.ValidatingType = typeof(System.DateTime);
            // 
            // maskedcpf
            // 
            this.maskedcpf.Location = new System.Drawing.Point(407, 110);
            this.maskedcpf.Name = "maskedcpf";
            this.maskedcpf.Size = new System.Drawing.Size(144, 22);
            this.maskedcpf.TabIndex = 13;
            // 
            // maskedrg
            // 
            this.maskedrg.Location = new System.Drawing.Point(407, 72);
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
            this.combosexo.Location = new System.Drawing.Point(171, 110);
            this.combosexo.Name = "combosexo";
            this.combosexo.Size = new System.Drawing.Size(132, 23);
            this.combosexo.TabIndex = 11;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(171, 32);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(384, 22);
            this.txtnome.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(346, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "CPF:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(351, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "RG:*";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblsexo.Location = new System.Drawing.Point(127, 110);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(38, 15);
            this.lblsexo.TabIndex = 3;
            this.lblsexo.Text = "Sexo";
            this.lblsexo.Click += new System.EventHandler(this.lblsexo_Click);
            // 
            // lbldt_nasc
            // 
            this.lbldt_nasc.AutoSize = true;
            this.lbldt_nasc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbldt_nasc.Location = new System.Drawing.Point(19, 79);
            this.lbldt_nasc.Name = "lbldt_nasc";
            this.lbldt_nasc.Size = new System.Drawing.Size(146, 15);
            this.lbldt_nasc.TabIndex = 1;
            this.lbldt_nasc.Text = "Data de Nascimento:*";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblnome.Location = new System.Drawing.Point(111, 39);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(54, 15);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtuf);
            this.groupBox1.Controls.Add(this.txtcidade);
            this.groupBox1.Controls.Add(this.txtn);
            this.groupBox1.Controls.Add(this.txtlogradouro);
            this.groupBox1.Controls.Add(this.txtcomplemento);
            this.groupBox1.Controls.Add(this.txtbairro);
            this.groupBox1.Controls.Add(this.maskedcep);
            this.groupBox1.Controls.Add(this.lbluf);
            this.groupBox1.Controls.Add(this.lblnum_resid);
            this.groupBox1.Controls.Add(this.lblcidade);
            this.groupBox1.Controls.Add(this.lblbairro);
            this.groupBox1.Controls.Add(this.lblcep);
            this.groupBox1.Controls.Add(this.lblcomplemento);
            this.groupBox1.Controls.Add(this.lbllogradouro);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(54, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // txtuf
            // 
            this.txtuf.Location = new System.Drawing.Point(555, 66);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(100, 22);
            this.txtuf.TabIndex = 14;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(407, 110);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(131, 22);
            this.txtcidade.TabIndex = 13;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(407, 66);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 22);
            this.txtn.TabIndex = 12;
            // 
            // txtlogradouro
            // 
            this.txtlogradouro.Location = new System.Drawing.Point(407, 28);
            this.txtlogradouro.Name = "txtlogradouro";
            this.txtlogradouro.Size = new System.Drawing.Size(215, 22);
            this.txtlogradouro.TabIndex = 11;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(132, 70);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(98, 22);
            this.txtcomplemento.TabIndex = 10;
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(132, 110);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(160, 22);
            this.txtbairro.TabIndex = 9;
            // 
            // maskedcep
            // 
            this.maskedcep.Location = new System.Drawing.Point(130, 28);
            this.maskedcep.Name = "maskedcep";
            this.maskedcep.Size = new System.Drawing.Size(162, 22);
            this.maskedcep.TabIndex = 8;
            this.maskedcep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedcep_KeyDown);
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbluf.Location = new System.Drawing.Point(526, 73);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(23, 15);
            this.lbluf.TabIndex = 6;
            this.lbluf.Text = "UF";
            // 
            // lblnum_resid
            // 
            this.lblnum_resid.AutoSize = true;
            this.lblnum_resid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblnum_resid.Location = new System.Drawing.Point(366, 73);
            this.lblnum_resid.Name = "lblnum_resid";
            this.lblnum_resid.Size = new System.Drawing.Size(20, 15);
            this.lblnum_resid.TabIndex = 2;
            this.lblnum_resid.Text = "N°";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcidade.Location = new System.Drawing.Point(334, 113);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(52, 15);
            this.lblcidade.TabIndex = 5;
            this.lblcidade.Text = "Cidade";
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblbairro.Location = new System.Drawing.Point(72, 113);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(47, 15);
            this.lblbairro.TabIndex = 4;
            this.lblbairro.Text = "Bairro";
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcep.Location = new System.Drawing.Point(79, 31);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(40, 15);
            this.lblcep.TabIndex = 3;
            this.lblcep.Text = "CEP:*";
            // 
            // lblcomplemento
            // 
            this.lblcomplemento.AutoSize = true;
            this.lblcomplemento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcomplemento.Location = new System.Drawing.Point(19, 73);
            this.lblcomplemento.Name = "lblcomplemento";
            this.lblcomplemento.Size = new System.Drawing.Size(100, 15);
            this.lblcomplemento.TabIndex = 1;
            this.lblcomplemento.Text = "Complemento";
            // 
            // lbllogradouro
            // 
            this.lbllogradouro.AutoSize = true;
            this.lbllogradouro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbllogradouro.Location = new System.Drawing.Point(303, 31);
            this.lbllogradouro.Name = "lbllogradouro";
            this.lbllogradouro.Size = new System.Drawing.Size(83, 15);
            this.lbllogradouro.TabIndex = 0;
            this.lbllogradouro.Text = "Logradouro";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtcargo);
            this.groupBox3.Controls.Add(this.lblcargo);
            this.groupBox3.Controls.Add(this.maskedcel);
            this.groupBox3.Controls.Add(this.maskedtel);
            this.groupBox3.Controls.Add(this.txtemail);
            this.groupBox3.Controls.Add(this.lblemail);
            this.groupBox3.Controls.Add(this.lblcel);
            this.groupBox3.Controls.Add(this.lbltel);
            this.groupBox3.Controls.Add(this.shapeContainer1);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(54, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 170);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comunicação";
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(132, 30);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(185, 22);
            this.txtcargo.TabIndex = 8;
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcargo.Location = new System.Drawing.Point(69, 37);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(50, 15);
            this.lblcargo.TabIndex = 7;
            this.lblcargo.Text = "Cargo:";
            // 
            // maskedcel
            // 
            this.maskedcel.Location = new System.Drawing.Point(407, 71);
            this.maskedcel.Mask = "00000-9999";
            this.maskedcel.Name = "maskedcel";
            this.maskedcel.Size = new System.Drawing.Size(139, 22);
            this.maskedcel.TabIndex = 7;
            // 
            // maskedtel
            // 
            this.maskedtel.Location = new System.Drawing.Point(130, 71);
            this.maskedtel.Mask = "0000-9999";
            this.maskedtel.Name = "maskedtel";
            this.maskedtel.Size = new System.Drawing.Size(148, 22);
            this.maskedtel.TabIndex = 6;
            this.maskedtel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedtel_MaskInputRejected);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(130, 110);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(419, 22);
            this.txtemail.TabIndex = 3;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblemail.Location = new System.Drawing.Point(69, 113);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(45, 15);
            this.lblemail.TabIndex = 2;
            this.lblemail.Text = "Email:";
            // 
            // lblcel
            // 
            this.lblcel.AutoSize = true;
            this.lblcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcel.Location = new System.Drawing.Point(328, 74);
            this.lblcel.Name = "lblcel";
            this.lblcel.Size = new System.Drawing.Size(58, 15);
            this.lblcel.TabIndex = 1;
            this.lblcel.Text = "Celular:";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltel.Location = new System.Drawing.Point(50, 74);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(69, 15);
            this.lbltel.TabIndex = 0;
            this.lbltel.Text = "Telefone:";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(766, 104);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(94, 42);
            this.btnsalvar.TabIndex = 5;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(738, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 168);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(766, 182);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(94, 42);
            this.btnlimpar.TabIndex = 16;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 18);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(655, 149);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -4;
            this.lineShape1.X2 = -4;
            this.lineShape1.Y1 = -11;
            this.lineShape1.Y2 = 144;
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 606);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtcod_funcionario);
            this.Controls.Add(this.lblcod_funcionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionário";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcod_funcionario;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.MaskedTextBox maskedcpf;
        public System.Windows.Forms.MaskedTextBox maskedrg;
        public System.Windows.Forms.ComboBox combosexo;
        public System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lbldt_nasc;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtuf;
        public System.Windows.Forms.TextBox txtcidade;
        public System.Windows.Forms.TextBox txtn;
        public System.Windows.Forms.TextBox txtlogradouro;
        public System.Windows.Forms.TextBox txtcomplemento;
        public System.Windows.Forms.TextBox txtbairro;
        public System.Windows.Forms.MaskedTextBox maskedcep;
        private System.Windows.Forms.Label lbluf;
        private System.Windows.Forms.Label lblnum_resid;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Label lblcomplemento;
        private System.Windows.Forms.Label lbllogradouro;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.MaskedTextBox maskedcel;
        public System.Windows.Forms.MaskedTextBox maskedtel;
        public System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblcel;
        private System.Windows.Forms.Label lbltel;
        public System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Label lblcargo;
        public System.Windows.Forms.TextBox txtcod_funcionario;
        public System.Windows.Forms.TextBox txtcargo;
        public System.Windows.Forms.MaskedTextBox maskeddt_nasc;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnlimpar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}