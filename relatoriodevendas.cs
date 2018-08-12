using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace LojaTCC
{
    public partial class relatoriodevendas : Form
    {

        private string _textoParaImpressao;
        private string documentContents;

        private string textoParaImpressao
        {
            get { return _textoParaImpressao; }
            set { _textoParaImpressao = value; }
        }

        public relatoriodevendas()
        {
            InitializeComponent();
        }
        

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void relatoriodevendas_Load(object sender, EventArgs e)
        {

        }

        private void btnrelatorio_Click(object sender, EventArgs e)
        {
            carregarDataGrid();
            if (dgvrelatorio.RowCount == 0)
            {
                MessageBox.Show("Não foram encontrado dados com a informação " + datarela.Text, "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dgvrelatorio.DataSource = null;
            }
            lbltotale.Text = "";
            
}
        
        
             
        
        public void carregarDataGrid()
        {
            Clnfecharvenda ObjAgenda = new Clnfecharvenda();
            dgvrelatorio.DataSource = ObjAgenda.Listar(datarela.Text).Tables[0];
            dgvrelatorio.Columns[8].Visible = false;
            dgvrelatorio.Columns[0].HeaderText = ("ValorTotal");
            dgvrelatorio.Columns[1].HeaderText = ("CodVenda");
            dgvrelatorio.Columns[2].HeaderText = ("Desconto");
            dgvrelatorio.Columns[3].HeaderText = ("Forma_pag");
            dgvrelatorio.Columns[4].HeaderText = ("Parcelas");
            dgvrelatorio.Columns[5].HeaderText = ("Valor_pago");
            dgvrelatorio.Columns[6].HeaderText = ("Valor_restante");
            dgvrelatorio.Columns[7].HeaderText = ("Troco");
            dgvrelatorio.Columns[8].HeaderText = ("Datadehoje");
            dgvrelatorio.AutoResizeColumns();

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            //Criar um documento com 150 linhas
            string[] textoParaImpressao = new string[151];
            for (int i = 0; i < 151; i++)
            {
                textoParaImpressao[i] = i.ToString();
                textoParaImpressao[i] +=
                    "http://www.macoratti.net - Quase tudo para Visual Basic.";
            }
            PrintDocument doc = new ClnImprimirDocumento(textoParaImpressao);
            doc.PrintPage += this.printDocument1_PrintPage;

            PrintDialog dialogo = new  PrintDialog();
            dialogo.Document = doc;

            //se o usuario clicar ok imprimi o documento
            if(dialogo.ShowDialog() == DialogResult.OK)
            {
                //verifica se o usuario deseja visualizar a impressao
                if(chkVisualizaImpressao.Checked)
                {
                    PrintPreviewDialog ppdlg = new PrintPreviewDialog();
                    ppdlg.Document = doc;
                    ppdlg.ShowDialog();
                }
                else 
                {
                    doc.Print();
                }
                }

        }
       


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            //e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 90, 750, 90);
            //e.Graphics.DrawLine(new Pen(Color.Black, 1), 80, 93, 750, 93);

            //e.Graphics.DrawLine(new Pen(Color.Black, 1), 80, 187, 750, 187);
            //e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 190, 750, 190);

            string strDisplay = "LPK - Sistema Let´s play kids";
            System.Drawing.Font fntString = new Font("Times New Roman", 28,
                                FontStyle.Bold);
            e.Graphics.DrawString(strDisplay, fntString,
                                Brushes.Black, 120, 80);

            strDisplay = "Relatório de Vendas";
            fntString = new System.Drawing.Font("Times New Roman", 22,
                                FontStyle.Regular);
            e.Graphics.DrawString(strDisplay, fntString,
                                Brushes.Black, 240, 220);

            //e.Graphics.DrawLine(new Pen(Color.Black, 1), 80, 187, 750, 187);
            //e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 190, 750, 190);

            fntString = new System.Drawing.Font("Times New Roman", 12,
                        FontStyle.Bold);
            e.Graphics.DrawString("Data:  ", fntString,
                        Brushes.Black, 100, 180);
            fntString = new System.Drawing.Font("Times New Roman", 12,
                        FontStyle.Regular);
            e.Graphics.DrawString(datarela.Text, fntString,
                                          Brushes.Black, 170, 180);
            //e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 240, 380, 240);

            fntString = new System.Drawing.Font("Times New Roman", 12,
                        FontStyle.Bold);
            e.Graphics.DrawString("Valor Vendido :  ", fntString,
                        Brushes.Black, 420, 180);
            fntString = new System.Drawing.Font("Times New Roman", 12,
                        FontStyle.Regular);
            e.Graphics.DrawString(lbltotale.Text, fntString,
                                         Brushes.Black, 550, 180);
            //e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 240, 720, 240);

            fntString = new Font("Times New Roman", 20, FontStyle.Bold);

            e.Graphics.FillRectangle(Brushes.Gray, new Rectangle(100, 260, 620, 20));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(100, 260, 620, 20));


            int LinhaAtual = 0;
            int currentPage = 0;
            int currentLine = 0;

            Single leftMargin = e.MarginBounds.Left;
            Single topMargin = e.MarginBounds.Top + 100;
            Single rightMargin = e.MarginBounds.Right;
            Single bottonMargin = e.MarginBounds.Bottom;

            Pen penPrint = new Pen(Color.Black, 2);
            Pen penPrintRed = new Pen(Color.Red, 3);

            Font boldFont;
            Font titleFont;
            Font subTitleFont;
            Font footerFont;
            Font normalFont;

            boldFont = new Font("Arial", 9, FontStyle.Bold);
            titleFont = new Font("Arial", 15, FontStyle.Bold);
            subTitleFont = new Font("Arial", 12, FontStyle.Bold);
            footerFont = new Font("Arial", 8);
            normalFont = new Font("Arial", 9);

            currentLine = 0;

            //e.Graphics.DrawLine(penPrintRed, leftMargin, 300, rightMargin, 300);

            //e.Graphics.DrawLine(penPrintRed, leftMargin, 280, rightMargin, 280);


            e.Graphics.DrawString("ValorTotal", boldFont, Brushes.Black, leftMargin + 5, 320, new StringFormat());
            e.Graphics.DrawString("CodVenda", boldFont, Brushes.Black, leftMargin + 80, 320, new StringFormat());
            e.Graphics.DrawString("Desconto", boldFont, Brushes.Black, leftMargin + 150, 320, new StringFormat());
            e.Graphics.DrawString("Forma_pag", boldFont, Brushes.Black, leftMargin + 220, 320, new StringFormat());
            e.Graphics.DrawString("Parcelas", boldFont, Brushes.Black, leftMargin + 310, 320, new StringFormat());
            e.Graphics.DrawString("Valor_pago", boldFont, Brushes.Black, leftMargin + 390, 320, new StringFormat());
            e.Graphics.DrawString("Valor_restante", boldFont, Brushes.Black, leftMargin + 470, 320, new StringFormat());
            e.Graphics.DrawString("Troco", boldFont, Brushes.Black, leftMargin + 570, 320, new StringFormat());


            e.Graphics.DrawLine(penPrint, leftMargin, bottonMargin, rightMargin, bottonMargin);
            e.Graphics.DrawString(System.DateTime.Now.ToString(), footerFont, Brushes.Black, leftMargin, bottonMargin, new StringFormat());
            currentLine += Convert.ToInt32(normalFont.GetHeight(e.Graphics));
            string ValorTotal, CodVenda, Desconto, Forma_pag, Parcelas, Valor_pago, Valor_restante, Troco;
            int LinhaImpressaoAtual = 380;


                        //for (int cont = 1; cont <= dgv.RowCount; cont++){//Pega linha por linha no DGV                 Cod = (dgv.Rows[LinhaAtual].Cells[0].Value.ToString());                 Nome = (dgv.Rows[LinhaAtual].Cells[1].Value.ToString());                 Tel = (dgv.Rows[LinhaAtual].Cells[2].Value.ToString()); 

            for (int cont = 1; cont <= dgvrelatorio.RowCount; cont++)
            {


                ValorTotal = (dgvrelatorio.CurrentRow.Cells[0].Value.ToString());
                CodVenda = (dgvrelatorio.CurrentRow.Cells[1].Value.ToString());
                Desconto = (dgvrelatorio.CurrentRow.Cells[2].Value.ToString());
                Forma_pag = (dgvrelatorio.CurrentRow.Cells[3].Value.ToString());
                Parcelas = (dgvrelatorio.CurrentRow.Cells[4].Value.ToString());
                Valor_pago = (dgvrelatorio.CurrentRow.Cells[5].Value.ToString());
                Valor_restante = (dgvrelatorio.CurrentRow.Cells[6].Value.ToString());
                Troco = (dgvrelatorio.CurrentRow.Cells[7].Value.ToString());


                e.Graphics.DrawString(ValorTotal, new Font("Arial", 9), Brushes.Black, leftMargin + 15, LinhaImpressaoAtual);
                e.Graphics.DrawString(CodVenda, new Font("Arial", 9), Brushes.Black, leftMargin + 100, LinhaImpressaoAtual);
                e.Graphics.DrawString(Desconto, new Font("Arial", 9), Brushes.Black, leftMargin + 180, LinhaImpressaoAtual);
                e.Graphics.DrawString(Forma_pag, new Font("Arial", 9), Brushes.Black, leftMargin + 220, LinhaImpressaoAtual);
                e.Graphics.DrawString(Parcelas, new Font("Arial", 9), Brushes.Black, leftMargin + 300, LinhaImpressaoAtual);
                e.Graphics.DrawString(Valor_pago, new Font("Arial", 9), Brushes.Black, leftMargin + 400, LinhaImpressaoAtual);
                e.Graphics.DrawString(Valor_restante, new Font("Arial", 9), Brushes.Black, leftMargin + 500, LinhaImpressaoAtual);
                e.Graphics.DrawString(Troco, new Font("Arial", 9), Brushes.Black, leftMargin + 580, LinhaImpressaoAtual);
                LinhaImpressaoAtual += 15;

                if (cont == 60)
                {
                    LinhaAtual++;
                    currentPage = 1 + currentPage;
                    e.Graphics.DrawString("Página : " + currentPage, footerFont, Brushes.Black, rightMargin - 50, bottonMargin + 70, new StringFormat());

                    e.Graphics.DrawLine(penPrint, leftMargin + 500, bottonMargin - 30, rightMargin, bottonMargin - 30);
                    e.Graphics.DrawString("Qtde de Itens: " + cont + " / " + dgvrelatorio.RowCount, normalFont, Brushes.Black, leftMargin + 500, bottonMargin - 20);

                    e.HasMorePages = true;
                    break;
                }
                else
                {
                    LinhaAtual++;
                }

                if (dgvrelatorio.RowCount == LinhaAtual)
                {
                    currentPage = 1 + currentPage;
                    e.Graphics.DrawString("Página : " + currentPage, footerFont, Brushes.Black, rightMargin - 50, bottonMargin + 70, new StringFormat());
                    LinhaAtual = 0;
                    currentPage = 0;

                    e.Graphics.DrawLine(penPrint, leftMargin + 500, bottonMargin - 30, rightMargin, bottonMargin - 30);
                    e.Graphics.DrawString("Qtde de Itens: " + cont + " / " + dgvrelatorio.RowCount, normalFont, Brushes.Black, leftMargin + 500, bottonMargin - 20);

                    break;
                }
            }
        }

        private void datarela_ValueChanged(object sender, EventArgs e)
        {
            
        }

        public void Soma()
        {
            double valorTotal = 0;
            string valor = "";

            if (dgvrelatorio.Rows[0].Cells[0].Value.ToString() != null)
            {
                valor = dgvrelatorio.Rows[0].Cells[0].Value.ToString();
                if (!valor.Equals(""))
                {
                    for (int i = 0; i <= dgvrelatorio.RowCount - 1; i++)
                    {
                        if (dgvrelatorio.Rows[i].Cells[0].Value != null)
                            valorTotal += Convert.ToDouble(dgvrelatorio.Rows[i].Cells[0].Value);
                    }
                    if (valorTotal == 0)
                    {
                        MessageBox.Show("Nenhum registro encontrado");
                    }
                    lbltotale.Text = valorTotal.ToString();
                }
            }
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            Soma();
        }

        
       
    }
}
