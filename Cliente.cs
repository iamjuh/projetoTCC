using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace LojaTCC
{
    public partial class Cliente : Form
    {


        public Cliente()
        {
            InitializeComponent();
        }
        clnFuncoesGerais.Operacao ObjOperacao;//Cria Obj da Operação
        public clnFuncoesGerais.Operacao EnumProperty//Método para receber o valor
        {
            get { return ObjOperacao; }//Retorna o valor
            set { ObjOperacao = value; }//Recebe o valor
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
                maskedcpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if (maskedcpf.Text == "")
                        MessageBox.Show("Informe um CPF!", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (Validacoes.validarCPF(maskedcpf.Text))
                        {
                            maskedcpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                            try
                            {
                                if ((txtnome.Text == "") || (maskedtel.Text == "") || (txtn.Text == "")
                        || (maskedcpf.Text == ""))
                                {
                                    MessageBox.Show("Os campos com * são de preenchimento obrigatórios");
                                }
                                else
                                {
                                    Clncliente Cliente = new Clncliente();
                                    if (txtcod_cliente.Text != "")
                                    {
                                        Cliente.CodCliente = Convert.ToInt32(txtcod_cliente.Text);
                                    }

                                    Cliente.Nome = txtnome.Text;
                                    Cliente.DtNasc = maskeddt_nasc.Text;
                                    Cliente.Sexo = combosexo.Text;
                                    Cliente.CPF = maskedcpf.Text.Replace(".", "-");
                                    Cliente.RG = maskedrg.Text;
                                    Cliente.Logradouro = txtlogradouro.Text;
                                    Cliente.NumResid = txtn.Text;
                                    Cliente.Complemento = txtcomplemento.Text;
                                    Cliente.CEP = maskedcep.Text.Replace("-", "");
                                    Cliente.Bairro = txtbairro.Text;
                                    Cliente.Cidade = txtcidade.Text;
                                    Cliente.UF = txtuf.Text;
                                    Cliente.Telefone = maskedtel.Text.Replace("()", "-");
                                    Cliente.Celular = maskedcel.Text.Replace("()", "-");
                                    Cliente.Email = txtemail.Text;

                                    if (ObjOperacao == clnFuncoesGerais.Operacao.Inclusao)
                                    {
                                        Cliente.Gravar();
                                        MessageBox.Show("Dados gravados com sucesso!!", "Item Novo " + txtnome.Text,
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else if (ObjOperacao == clnFuncoesGerais.Operacao.Alteracao)
                                    {
                                        Cliente.Alterar();
                                        MessageBox.Show("Registro nº " + txtcod_cliente.Text + "Alterado com sucesso ",
                                            "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    Close();
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao inserir Cliente\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                            MessageBox.Show("Informe um CPF válido!", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        
            
            //===========================================================================
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Cliente_Load(object sender, EventArgs e)
        {
            txtlogradouro.Enabled = false;
            txtuf.Enabled = false;
            txtbairro.Enabled = false;
            txtcidade.Enabled = false;
            txtcod_cliente.Enabled = false;
          

            if (txtcod_cliente.Text != "")
            {
                Clncliente ObjClnAgenda = new Clncliente();
                OracleDataReader ObjDrDados;
                ObjDrDados = ObjClnAgenda.ListarUsuario (txtcod_cliente.Text);

                if (ObjDrDados.Read())
                {
                    txtnome.Text = ObjDrDados["Nome"].ToString();
                    maskedtel.Text = ObjDrDados["Telefone"].ToString();
                    maskedcel.Text = ObjDrDados["Celular"].ToString();
                    maskedcep.Text = ObjDrDados["CEP"].ToString();
                    txtlogradouro.Text = ObjDrDados["Logradouro"].ToString();
                    txtuf.Text = ObjDrDados["UF"].ToString();
                    txtn.Text = ObjDrDados["Nº"].ToString();
                    txtbairro.Text = ObjDrDados["Bairro"].ToString();
                    txtcidade.Text = ObjDrDados["Cidade"].ToString();
                }

                txtnome.Focus();
            }
        }

        private void maskedcep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clnCEP ObjCEP = new clnCEP();
                OracleDataReader drDados;
                string CEP = maskedcep.Text.Replace("-", "");//retira -
                ObjCEP.CEP = CEP;
                drDados = ObjCEP.ProcurarCEP();
                if (drDados.Read())
                {
                    txtlogradouro.Text = Convert.ToString(drDados["descricao"]);
                    txtuf.Text = Convert.ToString(drDados["UF"]);
                    txtbairro.Text = Convert.ToString(drDados["Bairro"]);
                    txtcidade.Text = Convert.ToString(drDados["Cidade"]);
                    txtn.Focus();
                }
                else
                {
                    MessageBox.Show("CEP não encontrado" + maskedcep, "CEP",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtlogradouro.Text = "";
                    txtuf.Text = "";
                    txtn.Text = "";
                    txtbairro.Text = "";
                    txtcidade.Text = "";

                }
            }
        }
            private bool ValidaCep(string cep)
         {
	
          if (cep.Length == 8)
         {	
           cep = cep.Substring(0, 5) + "-" + cep.Substring(5, 3);
           maskedcep.Text = cep;
         }

          return System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));

}
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcod_cliente.Text = "";
            maskeddt_nasc.Text = "";
            txtnome.Text = "";
            maskedrg.Text = "";
            maskedcpf.Text = "";
            txtuf.Text = "";
            txtlogradouro.Text = "";
            txtn.Text = "";
            txtcomplemento.Text = "";
            maskedcep.Text = "";
            txtbairro.Text = "";
            txtcidade.Text = "";
            maskedtel.Text = "";
            maskedcel.Text = "";
            txtemail.Text = "";
        }

        private void maskedtel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void maskedcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validacoes vpermissao = new Validacoes();
            //vpermissao.email(sender, e);
        }

        private void txtcomplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Validacoes.validarEmail(txtemail.Text))
                {
                    MessageBox.Show("E-MAIL INFORMADO É VÁLIDO! POR FAVOR, CONTINUE O CADASTRO!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("E-MAIL INFORMADO É INVÁLIDO! POR FAVOR, VERIFIQUE SE DIGITOU CORRETAMENTE E TENTE NOVAMENTE!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

  

     


    }
}
