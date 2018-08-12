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
    public partial class CadLogin : Form
    {
        public CadLogin()
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsenha_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblfuncionario_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if ((txtusuario.Text == "") || (combofun.Text == "") || (txtsenha.Text == ""))
            {
                MessageBox.Show("Os campos com * são de preenchimento obrigatórios");
            }
            else
            {
                clnLogin log = new clnLogin();
                if (txtcod_login.Text == "")
                {
                    //log.CodLogin = Convert.ToInt32(txtcod_login.Text);
                    log.cod_func = Convert.ToInt32(combofun.SelectedValue);
                    log.usuario = txtusuario.Text;
                    log.senha = txtsenha.Text;
                    log.nivelacesso = combonivel.Text;
                }
               

                 if (ObjOperacao == clnFuncoesGerais.Operacao.Inclusao)
                {
                    log.GravarCadLogin();
                    MessageBox.Show("Dados gravados com sucesso!!", "Item Novo " + txtusuario.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ObjOperacao == clnFuncoesGerais.Operacao.Alteracao)
                {
                    log.Alterar();
                    MessageBox.Show("Registro nº " + txtcod_login.Text + "Alterado com sucesso",
                        "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
        }

        private void CadLogin_Load(object sender, EventArgs e)
        {
            OracleConnection cn = new OracleConnection();
            cn.ConnectionString = "Data Source=(DESCRIPTION="
                + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
                + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));"
              + "User Id=hr;Password=123456";
            cn.Open();
            OracleCommand com = new OracleCommand();
            com.Connection = cn;
            com.CommandText = "select * from funcionario";
            OracleDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            combofun.DisplayMember = "nome";
            combofun.ValueMember = "cod_Funcionario";
            combofun.DataSource = dt;


            txtcod_login.Enabled = false;
        }
        }
    }

