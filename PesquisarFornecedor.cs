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
    public partial class PesquisarFornecedor : Form
    {
        public PesquisarFornecedor()
        {
            InitializeComponent();
        }
        
        public static clnFuncoesGerais.Operacao ObjOperacao;
        public clnFuncoesGerais.Operacao EnumProperty
        {
            get { return ObjOperacao; }
            set { ObjOperacao = value; }
        }
        private void button4_Click(object sender, EventArgs e)
        {
             int msg;
           msg=Convert.ToInt32(MessageBox.Show("DESEJA EXCLUIR O REGISTRO?" + 
               Convert.ToString(dgvDadosFornecedor.CurrentRow.Cells[1].Value),
               "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));

         if( msg == 6){
            ClnFornecedor objAgenda = new ClnFornecedor();
                objAgenda.CodFornecedor = Convert.ToInt32(dgvDadosFornecedor.CurrentRow.Cells[0].Value);
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
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Fornecedor objCadastro = new Fornecedor();
            objCadastro.Text = ">>>Consultar<<<";
            objCadastro.btnsalvar.Visible = false;
            objCadastro.txtnome.Enabled = false;
            objCadastro.maskedcnpj.Enabled=false;
            objCadastro.txtie.Enabled=false;
            objCadastro.txtrepresentante.Enabled=false;
            objCadastro.maskedtel.Enabled = false; 
            objCadastro.txtcod_fornecedor.Enabled = false;
            objCadastro.txtcod_fornecedor.Text = Convert.ToString(dgvDadosFornecedor.CurrentRow.Cells[0].Value);
            objCadastro.txtnome.Text = Convert.ToString(dgvDadosFornecedor.CurrentRow.Cells[1].Value);
            objCadastro.maskedcnpj.Text = Convert.ToString(dgvDadosFornecedor.CurrentRow.Cells[2].Value);
            objCadastro.txtie.Text = Convert.ToString(dgvDadosFornecedor.CurrentRow.Cells[3].Value);   
            objCadastro.txtrepresentante.Text = Convert.ToString(dgvDadosFornecedor.CurrentRow.Cells[4].Value);
            objCadastro.maskedtel.Text = Convert.ToString(dgvDadosFornecedor.CurrentRow.Cells[5].Value);   
            objCadastro.ShowDialog();
            carregaDataGrid();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {

            Fornecedor objCadastroAgenda = new Fornecedor();
            objCadastroAgenda.Text = ">>>>Alterar<<<<";
            objCadastroAgenda.txtcod_fornecedor.Enabled = false;
            objCadastroAgenda.txtcod_fornecedor.Text = Convert.ToString(dgvDadosFornecedor.CurrentRow.Cells[0].Value);
            objCadastroAgenda.txtnome.Text = Convert.ToString(dgvDadosFornecedor.CurrentRow.Cells[1].Value);
            objCadastroAgenda.maskedcnpj.Text = Convert.ToString(dgvDadosFornecedor.CurrentRow.Cells[2].Value);
            objCadastroAgenda.txtie.Text = Convert.ToString(dgvDadosFornecedor.CurrentRow.Cells[3].Value);
            objCadastroAgenda.txtrepresentante.Text = Convert.ToString(dgvDadosFornecedor.CurrentRow.Cells[4].Value);
            objCadastroAgenda.maskedtel.Text = Convert.ToString(dgvDadosFornecedor.CurrentRow.Cells[5].Value);
            objCadastroAgenda.EnumProperty = clnFuncoesGerais.Operacao.Alteracao;
            objCadastroAgenda.ShowDialog();
            carregaDataGrid();
        }

        private void PesquisarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregaDataGrid();
        }

        public void carregaDataGrid()
        {
            ClnFornecedor ObjAgenda = new ClnFornecedor();
            dgvDadosFornecedor.DataSource = ObjAgenda.Listar(txtDescricao.Text).Tables[0];
            dgvDadosFornecedor.Columns[0].HeaderText = ("cod_fornecedor");
            dgvDadosFornecedor.Columns[1].HeaderText = ("nome_fan");
            dgvDadosFornecedor.Columns[2].HeaderText = ("tel");

            dgvDadosFornecedor.AutoResizeColumns();

            if (dgvDadosFornecedor.RowCount == 0)
            {
                btnconsultar.Enabled = false;
                btnalterar.Enabled = false;
                btnpesquisar.Enabled = false;
                btnexcluir.Enabled = false;
                MessageBox.Show("Não foram encontrado daos com a informação" + txtDescricao.Text, "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDadosFornecedor.DataSource = null;
                txtDescricao.Text = "";
                txtDescricao.Focus();
            }
            else
            {
                btnconsultar.Enabled = true;
                btnalterar.Enabled = true;
                btnexcluir.Enabled = true;
            }

        }
        }
        }
    

