using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LojaTCC
{
    public partial class PesquisarLogin : Form
    {
        public PesquisarLogin()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            carregarDataGrid();
        }

        public void carregarDataGrid()
        {
            clnLogin ObjAgenda = new clnLogin();
            dgvlogin.DataSource = ObjAgenda.Listar(txtdescricao.Text).Tables[0];
            dgvlogin.Columns[0].HeaderText = ("CodLogin");
            dgvlogin.Columns[1].HeaderText = ("cod_fun");
            dgvlogin.Columns[2].HeaderText = ("usuario");
            dgvlogin.Columns[3].HeaderText = ("senha");
            dgvlogin.Columns[4].HeaderText = ("nivelacesso");

            dgvlogin.AutoResizeColumns();

            if (dgvlogin.RowCount == 0)
            {
                btnconsultar.Enabled = false;
                btnalterar.Enabled = false;
                btnpesquisar.Enabled = false;
                btnexcluir.Enabled = false;
                MessageBox.Show("Não foram encontrado daos com a informação" + txtdescricao.Text, "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvlogin.DataSource = null;
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

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            CadLogin objCadastro = new CadLogin();
            objCadastro.Text = ">>>Consultar<<<";
            objCadastro.btnsalvar.Visible = false;
            objCadastro.combofun.Enabled = false;
            objCadastro.txtusuario.Enabled = false;
            objCadastro.txtsenha.Enabled = false;
            objCadastro.combonivel.Enabled = false;
            objCadastro.txtcod_login.Text = Convert.ToString(dgvlogin.CurrentRow.Cells[0].Value);
            objCadastro.combofun.Text = Convert.ToString(dgvlogin.CurrentRow.Cells[1].Value);
            objCadastro.txtusuario.Text = Convert.ToString(dgvlogin.CurrentRow.Cells[2].Value);
            objCadastro.txtsenha.Text = Convert.ToString(dgvlogin.CurrentRow.Cells[3].Value);
            objCadastro.combonivel.Text = Convert.ToString(dgvlogin.CurrentRow.Cells[4].Value);
            objCadastro.ShowDialog();
            carregarDataGrid();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            CadLogin objCadastroAgenda = new CadLogin();
            objCadastroAgenda.Text = ">>>>Alterar<<<<";
            objCadastroAgenda.txtcod_login.Enabled = false;
            objCadastroAgenda.txtcod_login.Text = Convert.ToString(dgvlogin.CurrentRow.Cells[0].Value);
            objCadastroAgenda.combofun.Text = Convert.ToString(dgvlogin.CurrentRow.Cells[1].Value);
            objCadastroAgenda.txtusuario.Text = Convert.ToString(dgvlogin.CurrentRow.Cells[2].Value);
            objCadastroAgenda.txtsenha.Text = Convert.ToString(dgvlogin.CurrentRow.Cells[3].Value);
            objCadastroAgenda.combonivel.Text = Convert.ToString(dgvlogin.CurrentRow.Cells[4].Value);
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
                    Convert.ToString(dgvlogin.CurrentRow.Cells[2].Value),
                    "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                
                if (msg == 6)
                {
                    clnLogin objAgenda = new clnLogin();
                    objAgenda.CodLogin = Convert.ToInt32(dgvlogin.CurrentRow.Cells[0].Value);
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

        }
    }

