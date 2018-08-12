namespace LojaTCC
{
    partial class FecharVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FecharVenda));
            this.lblcod_fechar = new System.Windows.Forms.Label();
            this.txtcod_fecharvenda = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.datafechar = new System.Windows.Forms.DateTimePicker();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.comboparcelas = new System.Windows.Forms.ComboBox();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.lblvalor_pago = new System.Windows.Forms.Label();
            this.comboforma = new System.Windows.Forms.ComboBox();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.txtvalor_pago = new System.Windows.Forms.TextBox();
            this.txtvalor_restante = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lbltroco = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblparcelas = new System.Windows.Forms.Label();
            this.lbldesconto = new System.Windows.Forms.Label();
            this.lblforma = new System.Windows.Forms.Label();
            this.lblvalortotal = new System.Windows.Forms.Label();
            this.lblvalorrest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcod_fechar
            // 
            this.lblcod_fechar.AutoSize = true;
            this.lblcod_fechar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_fechar.Location = new System.Drawing.Point(94, 23);
            this.lblcod_fechar.Name = "lblcod_fechar";
            this.lblcod_fechar.Size = new System.Drawing.Size(58, 15);
            this.lblcod_fechar.TabIndex = 0;
            this.lblcod_fechar.Text = "Código:";
            // 
            // txtcod_fecharvenda
            // 
            this.txtcod_fecharvenda.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod_fecharvenda.Location = new System.Drawing.Point(165, 20);
            this.txtcod_fecharvenda.Name = "txtcod_fecharvenda";
            this.txtcod_fecharvenda.Size = new System.Drawing.Size(109, 22);
            this.txtcod_fecharvenda.TabIndex = 1;
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(348, 319);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(85, 47);
            this.btnok.TabIndex = 7;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // datafechar
            // 
            this.datafechar.CalendarFont = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datafechar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datafechar.Location = new System.Drawing.Point(329, 20);
            this.datafechar.Name = "datafechar";
            this.datafechar.Size = new System.Drawing.Size(313, 22);
            this.datafechar.TabIndex = 8;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(684, 397);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(40, 74);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(604, 217);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "fechar Venda";
            // 
            // comboparcelas
            // 
            this.comboparcelas.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboparcelas.FormattingEnabled = true;
            this.comboparcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboparcelas.Location = new System.Drawing.Point(439, 150);
            this.comboparcelas.Name = "comboparcelas";
            this.comboparcelas.Size = new System.Drawing.Size(121, 23);
            this.comboparcelas.TabIndex = 32;
            this.comboparcelas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboparcelas_KeyDown_1);
            this.comboparcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboparcelas_KeyPress);
            // 
            // txtdesconto
            // 
            this.txtdesconto.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesconto.Location = new System.Drawing.Point(155, 150);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(121, 22);
            this.txtdesconto.TabIndex = 31;
            this.txtdesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdesconto_KeyDown);
            // 
            // lblvalor_pago
            // 
            this.lblvalor_pago.AutoSize = true;
            this.lblvalor_pago.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor_pago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblvalor_pago.Location = new System.Drawing.Point(68, 199);
            this.lblvalor_pago.Name = "lblvalor_pago";
            this.lblvalor_pago.Size = new System.Drawing.Size(80, 15);
            this.lblvalor_pago.TabIndex = 30;
            this.lblvalor_pago.Text = "Valor Pago:";
            // 
            // comboforma
            // 
            this.comboforma.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboforma.FormattingEnabled = true;
            this.comboforma.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão Crédito",
            "Cartão Débito "});
            this.comboforma.Location = new System.Drawing.Point(439, 106);
            this.comboforma.Name = "comboforma";
            this.comboforma.Size = new System.Drawing.Size(180, 23);
            this.comboforma.TabIndex = 29;
            this.comboforma.SelectedIndexChanged += new System.EventHandler(this.comboforma_SelectedIndexChanged_1);
            // 
            // txttroco
            // 
            this.txttroco.Enabled = false;
            this.txttroco.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroco.Location = new System.Drawing.Point(155, 242);
            this.txttroco.Name = "txttroco";
            this.txttroco.Size = new System.Drawing.Size(121, 22);
            this.txttroco.TabIndex = 28;
            this.txttroco.TextChanged += new System.EventHandler(this.txttroco_TextChanged);
            // 
            // txtvalor_pago
            // 
            this.txtvalor_pago.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor_pago.Location = new System.Drawing.Point(155, 196);
            this.txtvalor_pago.Name = "txtvalor_pago";
            this.txtvalor_pago.Size = new System.Drawing.Size(121, 22);
            this.txtvalor_pago.TabIndex = 27;
            this.txtvalor_pago.TextChanged += new System.EventHandler(this.txtvalor_pago_TextChanged);
            this.txtvalor_pago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtvalor_pago_KeyDown_1);
            this.txtvalor_pago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_pago_KeyPress_1);
            // 
            // txtvalor_restante
            // 
            this.txtvalor_restante.Enabled = false;
            this.txtvalor_restante.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor_restante.Location = new System.Drawing.Point(441, 196);
            this.txtvalor_restante.Name = "txtvalor_restante";
            this.txtvalor_restante.Size = new System.Drawing.Size(119, 22);
            this.txtvalor_restante.TabIndex = 26;
            this.txtvalor_restante.TextChanged += new System.EventHandler(this.txtvalor_restante_TextChanged);
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(155, 105);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(119, 22);
            this.txtvalor.TabIndex = 25;
            // 
            // lbltroco
            // 
            this.lbltroco.AutoSize = true;
            this.lbltroco.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltroco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltroco.Location = new System.Drawing.Point(94, 245);
            this.lbltroco.Name = "lbltroco";
            this.lbltroco.Size = new System.Drawing.Size(51, 15);
            this.lbltroco.TabIndex = 24;
            this.lbltroco.Text = "Troco:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 23;
            // 
            // lblparcelas
            // 
            this.lblparcelas.AutoSize = true;
            this.lblparcelas.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblparcelas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblparcelas.Location = new System.Drawing.Point(368, 153);
            this.lblparcelas.Name = "lblparcelas";
            this.lblparcelas.Size = new System.Drawing.Size(65, 15);
            this.lblparcelas.TabIndex = 22;
            this.lblparcelas.Text = "Parcelas:";
            // 
            // lbldesconto
            // 
            this.lbldesconto.AutoSize = true;
            this.lbldesconto.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesconto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbldesconto.Location = new System.Drawing.Point(73, 153);
            this.lbldesconto.Name = "lbldesconto";
            this.lbldesconto.Size = new System.Drawing.Size(75, 15);
            this.lbldesconto.TabIndex = 21;
            this.lbldesconto.Text = "Desconto:";
            // 
            // lblforma
            // 
            this.lblforma.AutoSize = true;
            this.lblforma.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblforma.Location = new System.Drawing.Point(307, 109);
            this.lblforma.Name = "lblforma";
            this.lblforma.Size = new System.Drawing.Size(126, 15);
            this.lblforma.TabIndex = 20;
            this.lblforma.Text = "Forma Pagamento:";
            // 
            // lblvalortotal
            // 
            this.lblvalortotal.AutoSize = true;
            this.lblvalortotal.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalortotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblvalortotal.Location = new System.Drawing.Point(66, 108);
            this.lblvalortotal.Name = "lblvalortotal";
            this.lblvalortotal.Size = new System.Drawing.Size(83, 15);
            this.lblvalortotal.TabIndex = 19;
            this.lblvalortotal.Text = "Valor Total:";
            // 
            // lblvalorrest
            // 
            this.lblvalorrest.AutoSize = true;
            this.lblvalorrest.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorrest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblvalorrest.Location = new System.Drawing.Point(326, 199);
            this.lblvalorrest.Name = "lblvalorrest";
            this.lblvalorrest.Size = new System.Drawing.Size(107, 15);
            this.lblvalorrest.TabIndex = 18;
            this.lblvalorrest.Text = "Valor Restante:";
            // 
            // FecharVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 397);
            this.Controls.Add(this.comboparcelas);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.lblvalor_pago);
            this.Controls.Add(this.comboforma);
            this.Controls.Add(this.txttroco);
            this.Controls.Add(this.txtvalor_pago);
            this.Controls.Add(this.txtvalor_restante);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lbltroco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblparcelas);
            this.Controls.Add(this.lbldesconto);
            this.Controls.Add(this.lblforma);
            this.Controls.Add(this.lblvalortotal);
            this.Controls.Add(this.lblvalorrest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datafechar);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtcod_fecharvenda);
            this.Controls.Add(this.lblcod_fechar);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FecharVenda";
            this.Text = "Fechar Venda";
            this.Load += new System.EventHandler(this.FecharVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcod_fechar;
        private System.Windows.Forms.TextBox txtcod_fecharvenda;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.DateTimePicker datafechar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboparcelas;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Label lblvalor_pago;
        private System.Windows.Forms.ComboBox comboforma;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.TextBox txtvalor_pago;
        private System.Windows.Forms.TextBox txtvalor_restante;
        public System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lbltroco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblparcelas;
        private System.Windows.Forms.Label lbldesconto;
        private System.Windows.Forms.Label lblforma;
        private System.Windows.Forms.Label lblvalortotal;
        private System.Windows.Forms.Label lblvalorrest;
    }
}