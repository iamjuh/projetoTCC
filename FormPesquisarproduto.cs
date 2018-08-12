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
    public partial class FormPesquisarproduto : Form
    {
        public FormPesquisarproduto()
        {
            InitializeComponent();
        }

        private void FormPesquisarproduto_Load(object sender, EventArgs e)
        {

        }

        

        private void btnconsultar_Click(object sender, EventArgs e)
        {

            FormProdutos objCadastro = new FormProdutos();
            objCadastro.Text = ">>>Consultar<<<";
            objCadastro.btnsalvar.Visible = false;
            objCadastro.comboFornecedor.Enabled = false;
            objCadastro.comboCategoria.Enabled = false;
            objCadastro.comboetaria.Enabled = false; 
            objCadastro.maskedbarra.Enabled = false;
            objCadastro.txtnome.Enabled = false;
            objCadastro.comboMarca.Enabled = false;
            objCadastro.txtvalor.Enabled = false;
            objCadastro.txtcod_produtos.Enabled = false;
            objCadastro.txtcod_produtos.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[0].Value);
            objCadastro.comboFornecedor.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[1].Value);
            objCadastro.comboCategoria.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[2].Value);
            objCadastro.comboetaria.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[3].Value);
            objCadastro.maskedbarra.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[4].Value);
            objCadastro.txtnome.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[5].Value);
            objCadastro.comboMarca.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[6].Value);
            objCadastro.txtvalor.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[7].Value);
            objCadastro.ShowDialog();
            carregarDataGrid();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
                FormProdutos objCadastroAgenda = new FormProdutos();
                objCadastroAgenda.Text = ">>>>Alterar<<<<";
                objCadastroAgenda.txtcod_produtos.Enabled = false;
                objCadastroAgenda.txtcod_produtos.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[0].Value);
                objCadastroAgenda.comboFornecedor.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[1].Value);
                objCadastroAgenda.comboCategoria.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[2].Value);
                objCadastroAgenda.comboetaria.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[3].Value);
                objCadastroAgenda.maskedbarra.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[4].Value);
                objCadastroAgenda.txtnome.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[5].Value);
                objCadastroAgenda.comboMarca.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[6].Value);
                objCadastroAgenda.txtvalor.Text = Convert.ToString(dgvDadosProduto.CurrentRow.Cells[7].Value);
                objCadastroAgenda.EnumProperty = clnFuncoesGerais.Operacao.Alteracao;
                objCadastroAgenda.ShowDialog();
                carregarDataGrid();
            
        }
        
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int msg;
                msg = Convert.ToInt32(MessageBox.Show("DESEJA EXCLUIR O REGISTRO?  " +
                    Convert.ToString(dgvDadosProduto.CurrentRow.Cells[5].Value),
                    "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));

                if (msg == 6)
                {
                    clnProduto objAgenda = new clnProduto();
                    objAgenda.CodProduto = Convert.ToInt32(dgvDadosProduto.CurrentRow.Cells[0].Value);
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
            catch
            {
                MessageBox.Show("Selecione uma linha!",
                  "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                 carregarDataGrid();
        }

        public void carregarDataGrid()
        {
            clnProduto ObjAgenda = new clnProduto();
            dgvDadosProduto.DataSource = ObjAgenda.Listar(txtdescricao.Text).Tables[0];
            dgvDadosProduto.Columns[0].HeaderText = ("CodProduto");
            dgvDadosProduto.Columns[1].HeaderText = ("CodFornecedor");
            dgvDadosProduto.Columns[2].HeaderText = ("CodCategoria");
            dgvDadosProduto.Columns[3].HeaderText = ("Faixa Etária");
            dgvDadosProduto.Columns[4].HeaderText = ("CodBarra");
            dgvDadosProduto.Columns[5].HeaderText = ("nome");
            dgvDadosProduto.Columns[6].HeaderText = ("marca");
            dgvDadosProduto.Columns[7].HeaderText = ("valor");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
            dgvDadosProduto.AutoResizeColumns();

            if (dgvDadosProduto.RowCount == 0)
            {
                btnconsultar.Enabled = false;
                btnalterar.Enabled = false;
                btnpesquisar.Enabled = false;
                btnexcluir.Enabled = false;
                MessageBox.Show("Não foram encontrado daos com a informação" + txtdescricao.Text, "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDadosProduto.DataSource = null;
                txtdescricao.Text = "";
                txtdescricao.Focus();
            }
            else {
                btnconsultar.Enabled = true;
                btnalterar.Enabled = true;
                btnexcluir.Enabled = true;
            }
        }
        }
        }
        
        

