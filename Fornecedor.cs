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
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }
        clnFuncoesGerais.Operacao ObjOperacao;//Cria Obj da Operação
        public clnFuncoesGerais.Operacao EnumProperty//Método para receber o valor
        {
            get { return ObjOperacao; }//Retorna o valor
            set { ObjOperacao = value; }//Recebe o valor
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnsalvar_Click(object sender, EventArgs e)
        {
             if ((txtnome.Text == "") || (maskedtel.Text == "") || (txtrepresentante.Text == "")
                || (maskedcnpj.Text == ""))
            {
                MessageBox.Show("Os campos com * são de preenchimento obrigatórios");
            }
            else
            {
                ClnFornecedor fornecedor = new ClnFornecedor();
                if (txtcod_fornecedor.Text != "")
                {
                    fornecedor.CodFornecedor = Convert.ToInt32(txtcod_fornecedor.Text);
                }

                fornecedor.Nome = txtnome.Text;
                fornecedor.CNPJ = maskedcnpj.Text;
                fornecedor.IE = txtie.Text;
                fornecedor.Representante = txtrepresentante.Text;
                fornecedor.Telefone = maskedtel.Text.Replace("()", "-");

                if (ObjOperacao == clnFuncoesGerais.Operacao.Inclusao)
                {
                    fornecedor.Gravar();
                    MessageBox.Show("Dados gravados com sucesso!!", "Item Novo " + txtnome.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ObjOperacao == clnFuncoesGerais.Operacao.Alteracao)
                {
                    fornecedor.Alterar();
                    MessageBox.Show("Registro nº" + txtcod_fornecedor.Text + "Alterado com sucesso",
                        "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
        }

        private void maskedFoneComercial_MaskInputRejected(object sender, System.Windows.Forms.MaskInputRejectedEventArgs e)
        {

        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            txtcod_fornecedor.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedcnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Validacoes.isCNPJ(maskedcnpj.Text))
                {
                    MessageBox.Show("SEU CNPJ É VÁLIDO! POR FAVOR, CONTINUE O CADASTRO!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("SEU CNPJ É INVÁLIDO! POR FAVOR, VERIFIQUE SE DIGITOU CORRETAMENTE E TENTE NOVAMENTE!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        }
    }

