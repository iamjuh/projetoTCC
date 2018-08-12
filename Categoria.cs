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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }
        clnFuncoesGerais.Operacao ObjOperacao;//Cria Obj da Operação
        public clnFuncoesGerais.Operacao EnumProperty//Método para receber o valor
        {
            get { return ObjOperacao; }//Retorna o valor
            set { ObjOperacao = value; }//Recebe o valor
        }
    

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            ////strQuery += ("Seq_categoria.NEXTVAL, ");
            //clnBancodeDados ja = new clnBancodeDados();
            //if (ja.ExecutaComando(strQuery).ErroCode == 00001)
            //{
            //    MessageBox.Show("Categoria Já Existente !!");
            //}

            //clnBancodeDados nom = new  clnBancodeDados();
            //if((nom.Nome == ("UQ_categoria.UNIQUE")))
            //{
            //    MessageBox.Show("Categoria Já Existente !!");
            //}

            if ((txtnome.Text == ""))
            {
                MessageBox.Show("Os campos com * são de preenchimento obrigatórios");
            }
            else
            {
                Clncategoria Categoria = new Clncategoria();
                if (txtcod_categoria.Text != "")
                {
                    Categoria.CodCategoria = Convert.ToInt32(txtcod_categoria.Text);
                }

                Categoria.Nome = txtnome.Text;
                
                if (ObjOperacao == clnFuncoesGerais.Operacao.Inclusao)
                {
                   Categoria.Gravar();
                    MessageBox.Show("Inserido!!", "Item " + txtnome.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                   
                else if (ObjOperacao == clnFuncoesGerais.Operacao.Alteracao)
                {
                    Categoria.Alterar();
                    MessageBox.Show("Registro nº" + txtcod_categoria.Text + "Alterado com sucesso",
                        "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                carregaDataGrid();
                txtnome.Text = "";
            }
        }



        private void Categoria_Load(object sender, EventArgs e)
        {
            txtcod_categoria.Enabled = false;
            }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblfaixa_Click(object sender, EventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
       {

            carregaDataGrid();
        }

        public void carregaDataGrid()
        {
            Clncategoria ObjAgenda = new Clncategoria();
            dgvCategoria.DataSource = ObjAgenda.Listar(txtnome.Text).Tables[0];
            dgvCategoria.Columns[0].HeaderText = ("Cod");
            dgvCategoria.Columns[1].HeaderText = ("Categoria");

            dgvCategoria.AutoResizeColumns();

            if (dgvCategoria.RowCount == 0)
            {
                btnpesquisar.Enabled = false;
                btnexcluir.Enabled = false;
                MessageBox.Show("Não foram encontrado daos com a informação" + txtnome.Text, "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCategoria.DataSource = null;
                txtnome.Text = "";
                txtnome.Focus();
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            
             int msg;
           msg=Convert.ToInt32(MessageBox.Show("DESEJA EXCLUIR O REGISTRO? " + 
               Convert.ToString(dgvCategoria.CurrentRow.Cells[1].Value),
               "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));

         if( msg == 6){
            Clncategoria objAgenda = new Clncategoria();
                objAgenda.CodCategoria = Convert.ToInt32(dgvCategoria.CurrentRow.Cells[0].Value);
                objAgenda.ExcluirLogicamente();

                MessageBox.Show("Registro Excluído com Sucesso"," E X C L U S Ã O ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    
            else
            {
            MessageBox.Show("OPERAÇÃO CANCELADA", "CANCELAMENTO E X C L U S Ã O ",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            carregaDataGrid();
        }
        }
        }
        



        
    

