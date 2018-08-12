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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }
        clnFuncoesGerais.Operacao ObjOperacao;//Cria Obj da Operação
        public clnFuncoesGerais.Operacao EnumProperty//Método para receber o valor
        {
            get { return ObjOperacao; }//Retorna o valor
            set { ObjOperacao = value; }//Recebe o valor
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtlogradouro.Enabled = false;
            txtuf.Enabled = false;
            txtbairro.Enabled = false;
            txtcidade.Enabled = false;
            txtcod_funcionario.Enabled = false;
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
                            Clfuncionario funcionario = new Clfuncionario();
                            if (txtcod_funcionario.Text != "")
                            {
                                funcionario.CodFuncionario = Convert.ToInt32(txtcod_funcionario.Text);
                            }

                            funcionario.Nome = txtnome.Text;
                            funcionario.DtNasc = maskeddt_nasc.Text;
                            funcionario.Sexo = combosexo.Text;
                            funcionario.CPF = maskedcpf.Text.Replace(",", "-");
                            funcionario.RG = maskedrg.Text;
                            funcionario.Logradouro = txtlogradouro.Text;
                            funcionario.NumResid = txtn.Text;
                            funcionario.Complemento = txtcomplemento.Text;
                            funcionario.CEP = maskedcep.Text.Replace("-", "");
                            funcionario.Bairro = txtbairro.Text;
                            funcionario.Cidade = txtcidade.Text;
                            funcionario.UF = txtuf.Text;
                            funcionario.Telefone = maskedtel.Text.Replace("()", "-");
                            funcionario.Celular = maskedcel.Text.Replace("()", "-");
                            funcionario.Email = txtemail.Text;
                            funcionario.Cargo = txtcargo.Text;

                            if (ObjOperacao == clnFuncoesGerais.Operacao.Inclusao)
                            {
                                funcionario.Gravar();
                                MessageBox.Show("Dados gravados com sucesso!!", "Item Novo " + txtnome.Text,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (ObjOperacao == clnFuncoesGerais.Operacao.Alteracao)
                            {
                                funcionario.Alterar();
                                MessageBox.Show("Registro nº " + txtcod_funcionario.Text + "Alterado com sucesso",
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void maskedtel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblsexo_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

            txtcod_funcionario.Text = "";
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
            txtcargo.Text = "";
        }
        }
    }

