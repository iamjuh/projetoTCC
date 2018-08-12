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
    public partial class PesquisarCliente : Form
    {
        public PesquisarCliente()
        {
            InitializeComponent();
        }
        public static clnFuncoesGerais.Operacao ObjOperacao;
        public clnFuncoesGerais.Operacao EnumProperty
        {
            get { return ObjOperacao; }
            set { ObjOperacao = value; }
        }
        

        private void btnnovo_Click(object sender, EventArgs e)
        {
            
            Cliente objCadastroAgenda = new Cliente();
            objCadastroAgenda.Text = ">>>>Novo Cadastro<<<<";
            objCadastroAgenda.txtcod_cliente.Enabled = false;
            objCadastroAgenda.txtnome.Focus();
            objCadastroAgenda.EnumProperty = clnFuncoesGerais.Operacao.Inclusao;
            objCadastroAgenda.ShowDialog();
            carregaDataGrid();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
             Cliente objCadastro = new Cliente();
            objCadastro.Text = ">>>Consultar<<<";
            objCadastro.btnsalvar.Visible = false;
            objCadastro.btnlimpar.Visible = false;
            objCadastro.txtnome.Enabled = false;
            objCadastro.maskeddt_nasc.Enabled=false;
            objCadastro.combosexo.Enabled=false;
            objCadastro.maskedcpf.Enabled=false;
            objCadastro.maskedrg.Enabled=false;
            objCadastro.txtlogradouro.Enabled = false; 
            objCadastro.txtn.Enabled=false;
            objCadastro.txtcomplemento.Enabled=false; 
            objCadastro.maskedcep.Enabled = false;
            objCadastro.txtbairro.Enabled = false;
            objCadastro.txtcidade.Enabled = false;
            objCadastro.txtuf.Enabled=false;
            objCadastro.maskedtel.Enabled = false;
            objCadastro.maskedcel.Enabled=false;
            objCadastro.txtemail.Enabled=false;
            objCadastro.txtcod_cliente.Enabled = false;
            objCadastro.txtcod_cliente.Text = Convert.ToString(dgvDados.CurrentRow.Cells[0].Value);
            objCadastro.txtnome.Text = Convert.ToString(dgvDados.CurrentRow.Cells[1].Value);
            objCadastro.maskeddt_nasc.Text = Convert.ToString(dgvDados.CurrentRow.Cells[2].Value);
            objCadastro.combosexo.Text = Convert.ToString(dgvDados.CurrentRow.Cells[3].Value);   
            objCadastro.maskedcpf.Text = Convert.ToString(dgvDados.CurrentRow.Cells[4].Value);
            objCadastro.maskedrg.Text = Convert.ToString(dgvDados.CurrentRow.Cells[5].Value);
            objCadastro.txtlogradouro.Text = Convert.ToString(dgvDados.CurrentRow.Cells[6].Value);
            objCadastro.txtn.Text = Convert.ToString(dgvDados.CurrentRow.Cells[7].Value);
            objCadastro.txtcomplemento.Text = Convert.ToString(dgvDados.CurrentRow.Cells[8].Value); 
            objCadastro.maskedcep.Text = Convert.ToString(dgvDados.CurrentRow.Cells[9].Value);
            objCadastro.txtbairro.Text = Convert.ToString(dgvDados.CurrentRow.Cells[10].Value);
            objCadastro.txtcidade.Text = Convert.ToString(dgvDados.CurrentRow.Cells[11].Value);
            objCadastro.txtuf.Text = Convert.ToString(dgvDados.CurrentRow.Cells[12].Value);
            objCadastro.maskedtel.Text = Convert.ToString(dgvDados.CurrentRow.Cells[13].Value);
            objCadastro.maskedcel.Text = Convert.ToString(dgvDados.CurrentRow.Cells[14].Value);
            objCadastro.txtemail.Text = Convert.ToString(dgvDados.CurrentRow.Cells[15].Value);   
            objCadastro.ShowDialog();
            carregaDataGrid();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            Cliente objCadastroAgenda = new Cliente();
            objCadastroAgenda.Text = ">>>>Alterar<<<<";
            objCadastroAgenda.txtcod_cliente.Enabled = false;
            objCadastroAgenda.btnlimpar.Enabled = false;
            objCadastroAgenda.txtcod_cliente.Text = Convert.ToString(dgvDados.CurrentRow.Cells[0].Value);
            objCadastroAgenda.txtnome.Text = Convert.ToString(dgvDados.CurrentRow.Cells[1].Value);
            objCadastroAgenda.maskeddt_nasc.Text = Convert.ToString(dgvDados.CurrentRow.Cells[2].Value);
            objCadastroAgenda.combosexo.Text = Convert.ToString(dgvDados.CurrentRow.Cells[3].Value);
            objCadastroAgenda.maskedcpf.Text = Convert.ToString(dgvDados.CurrentRow.Cells[4].Value);
            objCadastroAgenda.maskedrg.Text = Convert.ToString(dgvDados.CurrentRow.Cells[5].Value);
            objCadastroAgenda.txtlogradouro.Text = Convert.ToString(dgvDados.CurrentRow.Cells[6].Value);
            objCadastroAgenda.txtn.Text = Convert.ToString(dgvDados.CurrentRow.Cells[7].Value);
            objCadastroAgenda.txtcomplemento.Text = Convert.ToString(dgvDados.CurrentRow.Cells[8].Value);
            objCadastroAgenda.maskedcep.Text = Convert.ToString(dgvDados.CurrentRow.Cells[9].Value);
            objCadastroAgenda.txtbairro.Text = Convert.ToString(dgvDados.CurrentRow.Cells[10].Value);
            objCadastroAgenda.txtcidade.Text = Convert.ToString(dgvDados.CurrentRow.Cells[11].Value);
            objCadastroAgenda.txtuf.Text = Convert.ToString(dgvDados.CurrentRow.Cells[12].Value);
            objCadastroAgenda.maskedtel.Text = Convert.ToString(dgvDados.CurrentRow.Cells[13].Value);
            objCadastroAgenda.maskedcel.Text = Convert.ToString(dgvDados.CurrentRow.Cells[14].Value);
            objCadastroAgenda.txtemail.Text = Convert.ToString(dgvDados.CurrentRow.Cells[15].Value);
            objCadastroAgenda.EnumProperty = clnFuncoesGerais.Operacao.Alteracao;
            objCadastroAgenda.ShowDialog();
            carregaDataGrid();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            int msg;
           msg=Convert.ToInt32(MessageBox.Show("DESEJA EXCLUIR O REGISTRO?" + 
               Convert.ToString(dgvDados.CurrentRow.Cells[1].Value),
               "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));

         if( msg == 6){
            Clncliente objAgenda = new Clncliente();
                objAgenda.CodCliente = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value);
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

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarCliente_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregaDataGrid();
        }

        public void carregaDataGrid()
        {
            Clncliente ObjAgenda = new Clncliente();
            dgvDados.DataSource = ObjAgenda.Listar(txtdescricao.Text).Tables[0];
            dgvDados.Columns[0].HeaderText = ("Cod");
            dgvDados.Columns[1].HeaderText = ("Cliente");
            dgvDados.Columns[2].HeaderText = ("Telefone");

            dgvDados.AutoResizeColumns();

            if (dgvDados.RowCount == 0)
            {
                btnconsultar.Enabled = false;
                btnalterar.Enabled = false;
                btnpesquisar.Enabled = false;
                btnexcluir.Enabled = false;
                MessageBox.Show("Não foram encontrado daos com a informação" + txtdescricao.Text, "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDados.DataSource = null;
                txtdescricao.Text = "";
                txtdescricao.Focus();
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
    

