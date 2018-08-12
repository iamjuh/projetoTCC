using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace LojaTCC
{
    public partial class FecharVenda : Form
    {
        public FecharVenda()
        {
            InitializeComponent();
        }
           clnFuncoesGerais.Operacao ObjOperacao;//Cria Obj da Operação
        public clnFuncoesGerais.Operacao EnumProperty//Método para receber o valor
        {
            get { return ObjOperacao; }//Retorna o valor
            set { ObjOperacao = value; }//Recebe o valor
        }
        public FecharVenda(string texto)
        {
            InitializeComponent();
            txtcod_fecharvenda.Text = texto;
            txtvalor.Text = texto;
        }
        public string Propriedade { get; set; }
        public string propi { get; set; }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void FecharVenda_Load(object sender, EventArgs e)
        {
            txtcod_fecharvenda.Enabled = false;
            txtvalor.Enabled = false;
            if (!this.Propriedade.Equals(""))
                txtcod_fecharvenda.Text =this.Propriedade;

            if (!this.propi.Equals(""))
                txtvalor.Text = this.propi;
                
        }
        

        private void btnok_Click(object sender, EventArgs e)
        {
            if ((txtvalor.Text == "") || (comboforma.Text == "") || (txtdesconto.Text == ""))
            {
                MessageBox.Show("Campos com preenchimento obrigatório");
            }
            else
            {
                Clnfecharvenda fec = new Clnfecharvenda();
                if (txtcod_fecharvenda.Text != "")
                {
                    fec.CodVenda = Convert.ToInt32(txtcod_fecharvenda.Text);
                    fec.ValorTotal = Convert.ToDouble(txtvalor.Text);
                    fec.Desconto = Convert.ToDouble(txtdesconto.Text);
                    fec.Forma_pag = comboforma.Text;
                    fec.Parcelas = comboparcelas.Text;
                    fec.Valor_pago = Convert.ToDouble(txtvalor_pago.Text);
                    fec.Valor_restante = Convert.ToDouble(txtvalor_restante.Text);
                    fec.Troco = Convert.ToDouble(txttroco.Text);
                    fec.Datadehoje = datafechar.Text;
                }
                if (ObjOperacao == clnFuncoesGerais.Operacao.Inclusao)
                {
                    fec.Gravar();
                    MessageBox.Show("VENDA FECHADA COM SUCESSO!!", " " + txtcod_fecharvenda.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
        }

        private void txtvalor_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbltroco_Click(object sender, EventArgs e)
        {

        }

        private void lblvalorrest_Click(object sender, EventArgs e)
        {

        }


        private void txtdesconto_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void txtdesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double n1, n2, resul;

                n1 = double.Parse(txtvalor.Text);
                n2 = double.Parse(txtdesconto.Text);

                resul = n1 - n2;
                txtvalor.Text = resul.ToString();
            }
        }

        private void comboparcelas_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double n1, n2, resul, res;

                n1 = double.Parse(txtvalor.Text);
                n2 = double.Parse(comboparcelas.Text);

                resul = n1 / n2;
                txtvalor_pago.Text = resul.ToString();

                resul = resul * (n2 - 1);
                txtvalor_restante.Text = resul.ToString();

                res = 0;
                txttroco.Text = res.ToString();
            }
        }

        private void txtvalor_pago_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double n1, n2, resul, res;

                n1 = double.Parse(txtvalor.Text);
                n2 = double.Parse(txtvalor_pago.Text);

                resul = n2 - n1;
                txttroco.Text = resul.ToString();

                res = 0;
                txtvalor_restante.Text = res.ToString();
               
            }
            Moeds(txtvalor_restante);
        }

        private void txtvalor_pago_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }

        }

        private void comboparcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        //private void txtdesconto_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
        //    {
        //        e.Handled = true;
        //    }
        //}

        private void comboforma_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboforma.SelectedItem.Equals("Dinheiro"))
            {
                comboparcelas.Enabled = false;
                txtvalor_restante.Enabled = false;
                comboparcelas.Text = "0";
                txtvalor_restante.Text = "0";
            }
            if (comboforma.SelectedItem.Equals("Cartão Crédito"))
            {
                comboparcelas.Enabled = true;
                txtvalor_restante.Enabled = false;
            }
            if (comboforma.SelectedItem.Equals("Cartão Débito"))
            {
                comboparcelas.Enabled = true;
                txtvalor_restante.Enabled = false;
            }
        }

        private void txttroco_TextChanged(object sender, EventArgs e)
        {
            Moeds(txttroco);
        }
        public static void Moeds(TextBox campo)
        {
            campo.Text.Substring(0,campo.Text.IndexOf(".") + 2);
        }

        private void txtvalor_restante_TextChanged(object sender, EventArgs e)
        {
            Moeds(txtvalor_restante);
        }

        private void txtvalor_pago_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
    }


