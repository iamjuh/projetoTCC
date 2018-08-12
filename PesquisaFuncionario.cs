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
    public partial class PesquisaFuncionario : Form
    {
        public PesquisaFuncionario()
        {
            InitializeComponent();
        }
        public static clnFuncoesGerais.Operacao ObjOperacao;
        public clnFuncoesGerais.Operacao EnumProperty
        {
            get { return ObjOperacao; }
            set { ObjOperacao = value; }
        }
   
        private void PesquisaFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Funcionario objCadastro = new Funcionario();
            objCadastro.Text = ">>>Consultar<<<";
            objCadastro.btnsalvar.Visible = false;
            objCadastro.txtnome.Enabled = false;
            objCadastro.maskeddt_nasc.Enabled = false;
            objCadastro.combosexo.Enabled = false;
            objCadastro.maskedcpf.Enabled = false;
            objCadastro.maskedrg.Enabled = false;
            objCadastro.txtlogradouro.Enabled = false;
            objCadastro.txtn.Enabled = false;
            objCadastro.txtcomplemento.Enabled = false;
            objCadastro.maskedcep.Enabled = false;
            objCadastro.txtbairro.Enabled = false;
            objCadastro.txtcidade.Enabled = false;
            objCadastro.txtuf.Enabled = false;
            objCadastro.maskedtel.Enabled = false;
            objCadastro.maskedcel.Enabled = false;
            objCadastro.txtemail.Enabled = false;
            objCadastro.txtcargo.Enabled = false;
            objCadastro.txtcod_funcionario.Enabled = false;
            objCadastro.txtcod_funcionario.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[0].Value);
            objCadastro.txtnome.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[1].Value);
            objCadastro.maskeddt_nasc.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[2].Value);
            objCadastro.combosexo.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[3].Value);
            objCadastro.maskedcpf.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[4].Value);
            objCadastro.maskedrg.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[5].Value);
            objCadastro.txtlogradouro.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[6].Value);
            objCadastro.txtn.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[7].Value);
            objCadastro.txtcomplemento.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[8].Value);
            objCadastro.maskedcep.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[9].Value);
            objCadastro.txtbairro.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[10].Value);
            objCadastro.txtcidade.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[11].Value);
            objCadastro.txtuf.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[12].Value);
            objCadastro.maskedtel.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[13].Value);
            objCadastro.maskedcel.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[14].Value);
            objCadastro.txtemail.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[15].Value);
            objCadastro.txtcargo.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[16].Value);
            objCadastro.ShowDialog();
            carregarDataGrid();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
            {
            carregarDataGrid();
             }

        public void carregaDataGrid() {
            Clfuncionario ObjAgenda = new Clfuncionario();
            dgvDadosFuncionario.DataSource = ObjAgenda.Listar(txtdescricao.Text).Tables[0];
            dgvDadosFuncionario.Columns[0].HeaderText = ("Cod");
            dgvDadosFuncionario.Columns[1].HeaderText = ("Funcionario");
            dgvDadosFuncionario.Columns[2].HeaderText = ("Telefone");

            dgvDadosFuncionario.AutoResizeColumns();

            if (dgvDadosFuncionario.RowCount == 0)
            {
                btnconsultar.Enabled = false;
                btnalterar.Enabled = false;
                btnpesquisar.Enabled = false;
                btnexcluir.Enabled = false;
                MessageBox.Show("Não foram encontrado daos com a informação" + txtdescricao.Text, "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDadosFuncionario.DataSource = null;
                txtdescricao.Text = "";
                txtdescricao.Focus();
            }
            else {
                btnconsultar.Enabled = true;
                btnalterar.Enabled = true;
                btnexcluir.Enabled = true;
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            
            Funcionario objCadastroAgenda = new Funcionario();
            objCadastroAgenda.Text = ">>>>Alterar<<<<";
            objCadastroAgenda.txtcod_funcionario.Enabled = false;
            objCadastroAgenda.txtcod_funcionario.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[0].Value);
            objCadastroAgenda.txtnome.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[1].Value);
            objCadastroAgenda.maskeddt_nasc.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[2].Value);
            objCadastroAgenda.combosexo.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[3].Value);
            objCadastroAgenda.maskedcpf.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[4].Value);
            objCadastroAgenda.maskedrg.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[5].Value);
            objCadastroAgenda.txtlogradouro.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[6].Value);
            objCadastroAgenda.txtn.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[7].Value);
            objCadastroAgenda.txtcomplemento.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[8].Value);
            objCadastroAgenda.maskedcep.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[9].Value);
            objCadastroAgenda.txtbairro.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[10].Value);
            objCadastroAgenda.txtcidade.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[11].Value);
            objCadastroAgenda.txtuf.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[12].Value);
            objCadastroAgenda.maskedtel.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[13].Value);
            objCadastroAgenda.maskedcel.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[14].Value);
            objCadastroAgenda.txtemail.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[15].Value);
            objCadastroAgenda.txtcargo.Text = Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[16].Value);
            objCadastroAgenda.EnumProperty = clnFuncoesGerais.Operacao.Alteracao;
            objCadastroAgenda.ShowDialog();
            carregarDataGrid();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            int msg;
            msg = Convert.ToInt32(MessageBox.Show("DESEJA EXCLUIR O REGISTRO?" +
                Convert.ToString(dgvDadosFuncionario.CurrentRow.Cells[1].Value),
                "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));

            if (msg == 6)
            {
                Clfuncionario objAgenda = new Clfuncionario();
                objAgenda.CodFuncionario = Convert.ToInt32(dgvDadosFuncionario.CurrentRow.Cells[0].Value);
                objAgenda.ExcluirLogicamente();

                MessageBox.Show("Registro Excluído com Sucesso", " E X C L U S Ã O ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", "CANCELAMENTO E X C L U S Ã O ",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            carregarDataGrid();
      
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
          {
            carregarDataGrid();
          }

        public void carregarDataGrid() {
            Clfuncionario ObjAgenda = new Clfuncionario();
            dgvDadosFuncionario.DataSource = ObjAgenda.Listar(txtdescricao.Text).Tables[0];
            dgvDadosFuncionario.Columns[0].HeaderText = ("Cod");
            dgvDadosFuncionario.Columns[1].HeaderText = ("Funcionario");
            dgvDadosFuncionario.Columns[2].HeaderText = ("Telefone");

            dgvDadosFuncionario.AutoResizeColumns();

            if (dgvDadosFuncionario.RowCount == 0)
            {
                btnconsultar.Enabled = false;
                btnalterar.Enabled = false;
                btnpesquisar.Enabled = false;
                btnexcluir.Enabled = false;
                MessageBox.Show("Não foram encontrado daos com a informação" + txtdescricao.Text, "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDadosFuncionario.DataSource = null;
                txtdescricao.Text = "";
                txtdescricao.Focus();
            }
            else {
                btnconsultar.Enabled = true;
                btnalterar.Enabled = true;
                btnexcluir.Enabled = true;
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            Funcionario objCadastroAgenda = new Funcionario();
            objCadastroAgenda.Text = ">>>>Novo Cadastro<<<<";
            objCadastroAgenda.txtcod_funcionario.Enabled = false;
            objCadastroAgenda.txtnome.Focus();
            objCadastroAgenda.EnumProperty = clnFuncoesGerais.Operacao.Inclusao;
            objCadastroAgenda.ShowDialog();
            carregaDataGrid();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        }

        }
    

