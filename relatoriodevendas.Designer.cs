namespace LojaTCC
{
    partial class relatoriodevendas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(relatoriodevendas));
            this.dgvrelatorio = new System.Windows.Forms.DataGridView();
            this.lbltotale = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrelatorio = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.datarela = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.chkVisualizaImpressao = new System.Windows.Forms.CheckBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label2 = new System.Windows.Forms.Label();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnValor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvrelatorio
            // 
            this.dgvrelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrelatorio.Location = new System.Drawing.Point(63, 180);
            this.dgvrelatorio.Name = "dgvrelatorio";
            this.dgvrelatorio.Size = new System.Drawing.Size(758, 408);
            this.dgvrelatorio.TabIndex = 1;
            // 
            // lbltotale
            // 
            this.lbltotale.AutoSize = true;
            this.lbltotale.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotale.Location = new System.Drawing.Point(561, 94);
            this.lbltotale.Name = "lbltotale";
            this.lbltotale.Size = new System.Drawing.Size(89, 31);
            this.lbltotale.TabIndex = 1;
            this.lbltotale.Text = "00,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "R$ : ";
            // 
            // btnrelatorio
            // 
            this.btnrelatorio.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrelatorio.Location = new System.Drawing.Point(192, 94);
            this.btnrelatorio.Name = "btnrelatorio";
            this.btnrelatorio.Size = new System.Drawing.Size(220, 40);
            this.btnrelatorio.TabIndex = 3;
            this.btnrelatorio.Text = "Gerar Relatório";
            this.btnrelatorio.UseVisualStyleBackColor = true;
            this.btnrelatorio.Click += new System.EventHandler(this.btnrelatorio_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.Location = new System.Drawing.Point(845, 298);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(108, 62);
            this.btnimprimir.TabIndex = 4;
            this.btnimprimir.Text = "Imprimir Relatório";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // datarela
            // 
            this.datarela.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datarela.Location = new System.Drawing.Point(192, 40);
            this.datarela.Name = "datarela";
            this.datarela.Size = new System.Drawing.Size(301, 22);
            this.datarela.TabIndex = 5;
            this.datarela.ValueChanged += new System.EventHandler(this.datarela_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data do Relatório:";
            // 
            // chkVisualizaImpressao
            // 
            this.chkVisualizaImpressao.AutoSize = true;
            this.chkVisualizaImpressao.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVisualizaImpressao.Location = new System.Drawing.Point(839, 378);
            this.chkVisualizaImpressao.Name = "chkVisualizaImpressao";
            this.chkVisualizaImpressao.Size = new System.Drawing.Size(161, 19);
            this.chkVisualizaImpressao.TabIndex = 7;
            this.chkVisualizaImpressao.Text = "Visualizar Impressão";
            this.chkVisualizaImpressao.UseVisualStyleBackColor = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1003, 639);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(522, 36);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(298, 127);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor Vendido";
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnValor
            // 
            this.btnValor.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValor.Location = new System.Drawing.Point(845, 87);
            this.btnValor.Name = "btnValor";
            this.btnValor.Size = new System.Drawing.Size(114, 55);
            this.btnValor.TabIndex = 10;
            this.btnValor.Text = "Gerar ValorVendido";
            this.btnValor.UseVisualStyleBackColor = true;
            this.btnValor.Click += new System.EventHandler(this.btnValor_Click);
            // 
            // relatoriodevendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1003, 639);
            this.Controls.Add(this.btnValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotale);
            this.Controls.Add(this.chkVisualizaImpressao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datarela);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnrelatorio);
            this.Controls.Add(this.dgvrelatorio);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "relatoriodevendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.relatoriodevendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvrelatorio;
        private System.Windows.Forms.Label lbltotale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrelatorio;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.DateTimePicker datarela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkVisualizaImpressao;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnValor;

    }
}