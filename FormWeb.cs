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
    public partial class FormWeb : Form
    {
        public FormWeb()
        {
            InitializeComponent();
        }

        private void btncarregar_Click(object sender, EventArgs e)
        {
            carregarDataGrid();
        }

        public void carregarDataGrid()
        {
            Clnweb ObjAgenda = new Clnweb();
            dgvweb.DataSource = ObjAgenda.Listar2(txtdescricao.Text).Tables[0];
            dgvweb.Columns[0].HeaderText = ("Codemail");
            dgvweb.Columns[1].HeaderText = ("Nome");
            dgvweb.Columns[2].HeaderText = ("Email");
            dgvweb.Columns[3].HeaderText = ("Mensagem");
            dgvweb.AutoResizeColumns();

            if (dgvweb.RowCount == 0)
            {

                MessageBox.Show("Não foram encontrado daos com a informação" + txtdescricao.Text, "VERIFICAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvweb.DataSource = null;
                txtdescricao.Text = "";
                txtdescricao.Focus();
            }

       
        }

        private void button1_Click(object sender, EventArgs e)
        {
                carregarDataGrid();
            
        }


        private void btnler_Click(object sender, EventArgs e)
        {

            FaleconoscoWeb objCadastro = new FaleconoscoWeb();
            objCadastro.Text = ">>>Fale Conosco<<<";
            objCadastro.txtnome.Enabled = false;
            objCadastro.txtemail.Enabled = false;
            objCadastro.richmensagem.Enabled = false;

            objCadastro.txtcod_mesagem.Text = Convert.ToString(dgvweb.CurrentRow.Cells[0].Value);
            objCadastro.txtnome.Text = Convert.ToString(dgvweb.CurrentRow.Cells[1].Value);
            objCadastro.txtemail.Text = Convert.ToString(dgvweb.CurrentRow.Cells[2].Value);
            objCadastro.richmensagem.Text = Convert.ToString(dgvweb.CurrentRow.Cells[3].Value);
            objCadastro.ShowDialog();
        }

        private void btnexcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                int msg;
                msg = Convert.ToInt32(MessageBox.Show("DESEJA EXCLUIR O REGISTRO?  " +
                    Convert.ToString(dgvweb.CurrentRow.Cells[1].Value),
                    "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));

                if (msg == 6)
                {
                    Clnweb objAgenda = new Clnweb();
                    objAgenda.Codemail = Convert.ToInt32(dgvweb.CurrentRow.Cells[0].Value);
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
