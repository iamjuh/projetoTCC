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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }
        clnFuncoesGerais.Operacao ObjOperacao;//Cria Obj da Operação
        public clnFuncoesGerais.Operacao EnumProperty//Método para receber o valor
        {
            get { return ObjOperacao; }//Retorna o valor
            set { ObjOperacao = value; }//Recebe o valor
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnsalvar_Click(object sender, EventArgs e)
        {

            if ((txtnome.Text == "") || (comboMarca.Text == "") || (comboFornecedor.Text == "")
               || (txtvalor.Text == ""))
            {
                MessageBox.Show("Os campos com * são de preenchimento obrigatórios");
            }
            else
            {
                clnProduto produtos = new clnProduto();
                if (txtcod_produtos.Text == "")
                {
                    //produtos.CodProduto = Convert.ToInt32(txtcod_produtos.Text);
                    produtos.CodFornecedor = Convert.ToInt32(comboFornecedor.SelectedValue);
                    produtos.CodCategoria = Convert.ToInt32(comboCategoria.SelectedValue);
                    produtos.Faixa = comboetaria.Text;
                    produtos.CodBarra = maskedbarra.Text;
                    produtos.Nome = txtnome.Text;
                    produtos.Marca = comboMarca.Text;
                    produtos.Valor = Convert.ToDouble(txtvalor.Text);
                }

               

                 if (ObjOperacao == clnFuncoesGerais.Operacao.Inclusao)
                {
                    produtos.Gravar();
                    MessageBox.Show("Dados gravados com sucesso!!", "Item Novo " + txtnome.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ObjOperacao == clnFuncoesGerais.Operacao.Alteracao)
                {
                    produtos.Alterar();
                    MessageBox.Show("Registro nº" + txtcod_produtos.Text + "Alterado com sucesso",
                        "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
        }
            

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            ClnFornecedor objProduto = new ClnFornecedor();
            comboFornecedor.DataSource = objProduto.Listar(String.Empty).Tables[0];
            comboFornecedor.DisplayMember = "nome_fan";
            comboFornecedor.ValueMember = "cod_Fornecedor";

            Clncategoria objcat = new Clncategoria();
            comboCategoria.DataSource = objcat.Listar(String.Empty).Tables[0];
            comboCategoria.DisplayMember = "nome";
            comboCategoria.ValueMember = "cod_categoria";

            Clnmarca objmar = new Clnmarca();
            comboMarca.DataSource = objmar.Listar(String.Empty).Tables[0];
            comboMarca.DisplayMember = "nome";

            txtcod_produtos.Enabled = false;

            

            //OracleConnection ma = new OracleConnection();
            //ma.ConnectionString = "Data Source=(DESCRIPTION="
            //    + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
            //    + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));"
            //  + "User Id=hr;Password=123456";
            //ma.Open();
            //OracleCommand comf = new OracleCommand();
            //comf.Connection = ma;
            //comf.CommandText = "select * from marca";
            //OracleDataReader der = comf.ExecuteReader();
            //DataTable dat = new DataTable();
            //dat.Load(der);
            //comboMarca.DisplayMember = "nome";
            //comboMarca.DataSource = dat;


            txtcod_produtos.Enabled = false;

        }

        private void txtcod_fornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblcod_barra_Click(object sender, EventArgs e)
        {

        }

        private void txtcod_barra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void lblvalor_Click(object sender, EventArgs e)
        {

        }

        private void lblcod_categoria_Click(object sender, EventArgs e)
        {

        }

        private void maskedbarra_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (maskedbarra.TextLength < 13)
                {
                    MessageBox.Show("Código de barras incorreto", "Possui 13 digitos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Código de barras correto");
            }

        }
      
    }
}
