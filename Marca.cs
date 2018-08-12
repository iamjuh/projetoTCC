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
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
        }
        clnFuncoesGerais.Operacao ObjOperacao;//Cria Obj da Operação
        public clnFuncoesGerais.Operacao EnumProperty//Método para receber o valor
        {
            get { return ObjOperacao; }//Retorna o valor
            set { ObjOperacao = value; }//Recebe o valor
        }


        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if ((txtnome.Text == ""))
            {
                MessageBox.Show("Os campos com * são de preenchimento obrigatórios");
            }
            else
            {
                Clnmarca Categoria = new Clnmarca();
                if (txtcod_marca.Text != "")
                {
                    Categoria.CodMarca = Convert.ToInt32(txtcod_marca.Text);
                }

                Categoria.Nome = txtnome.Text;

                if (ObjOperacao == clnFuncoesGerais.Operacao.Inclusao)
                {
                    Categoria.Gravar();
                    MessageBox.Show("Inserido!!", "Item " + txtnome.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtnome.Text = ""; 
                carregaDataGrid();

            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
                         int msg;
           msg=Convert.ToInt32(MessageBox.Show("DESEJA EXCLUIR O REGISTRO? " + 
               Convert.ToString(dgvmarca.CurrentRow.Cells[1].Value),
               "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));

         if( msg == 6){
            Clnmarca objAgenda = new Clnmarca();
                objAgenda.CodMarca = Convert.ToInt32(dgvmarca.CurrentRow.Cells[0].Value);
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

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            carregaDataGrid();
        }

        public void carregaDataGrid()
        {
            Clnmarca ObjAgenda = new Clnmarca();
            dgvmarca.DataSource = ObjAgenda.Listar(txtnome.Text).Tables[0];
            dgvmarca.Columns[0].HeaderText = ("Cod");
            dgvmarca.Columns[1].HeaderText = ("Marca");

            dgvmarca.AutoResizeColumns();

            if (dgvmarca.RowCount == 0)
            {
                btnpesquisar.Enabled = false;
                btnexcluir.Enabled = false;
                MessageBox.Show("Não foram encontrado dados com a informação" + txtnome.Text, "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvmarca.DataSource = null;
                txtnome.Text = "";
                txtnome.Focus();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        }

        }
    

             



        
