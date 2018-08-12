using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace LojaTCC
{
    public partial class Venda : Form
    {
        clnBancodeDados conn = new clnBancodeDados();
        OracleCommand comando = new OracleCommand();
        OracleDataReader dr;


        public Venda()
        {
            InitializeComponent();
        }
        clnFuncoesGerais.Operacao ObjOperacao;//Cria Obj da Operação
        public clnFuncoesGerais.Operacao EnumProperty//Método para receber o valor
        {
            get { return ObjOperacao; }//Retorna o valor
            set { ObjOperacao = value; }//Recebe o valor
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnfechar_venda_Click(object sender, EventArgs e)
        {
            FecharVenda Objfechar = new FecharVenda();
            Objfechar.Propriedade = txtcod_venda.Text;
            Objfechar.propi = lbltotale.Text;
            Objfechar.ShowDialog();
            txtcod_venda.Text = "";
            txtcod_funcionario.Text = "";
            txtnome.Text = "";
            maskedcpf.Text = "";
            txtcod_cliente.Text = "";
            Close(); 
            //dgvitens_venda.CurrentRow.Clear();

        }

        private void btnpesquisar2_Click(object sender, EventArgs e)
        {

        }


        private void maskedcpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Clncpf ObjCPF = new Clncpf();
                OracleDataReader drDados;
                string CPF = maskedcpf.Text.Replace(".", "-");
                ObjCPF.CPF = CPF;
                drDados = ObjCPF.ProcurarCPF();
                if (drDados.Read())
                {
                    maskedcpf.Text = Convert.ToString(drDados["cpf"]);
                    txtnome.Text = Convert.ToString(drDados["nome"]);
                    txtcod_cliente.Text = Convert.ToString(drDados["cod_Cliente"]);

                }
                else
                {
                    MessageBox.Show("CPF não encontrado" + maskedcpf, "CPF",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    maskedcpf.Text = "";


                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            
            DialogResult Resultado = MessageBox.Show("Gostaria de Cancelar Venda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                Clnabrirvenda objAgenda = new Clnabrirvenda();
                objAgenda.CodVenda = Convert.ToInt32(txtcod_venda.Text);
                objAgenda.ExcluirLogicamente();

                Clninserirproduto objAgend = new Clninserirproduto();
                objAgend.CodItem = Convert.ToInt32(dgvitens_venda.Rows[0].Cells[0].Value);
                objAgend.ExcluirLogicamente();
                carregaDataGrid();
                

                MessageBox.Show("Venda Cancelada com Sucesso", " E X C L U S Ã O ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtcod_cliente.Text = "";
                txtcod_funcionario.Text = "";
                txtnome.Text = "";
                txtcod_venda.Text = "";
                maskedcpf.Text = "";
                //dgvitens_venda.Rows.Clear();
                
            }

            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", "CANCELAMENTO E X C L U S Ã O ",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                //this.Close();
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            txtcod_venda.Enabled = false;
            //lbltotale.BackColor = Color.Red;

        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            try
            {
                Clnabrirvenda abrir = new Clnabrirvenda();
                if (txtcod_venda.Text != "")
                {
                    abrir.CodVenda = Convert.ToInt32(txtcod_venda.Text);
                }

                abrir.Data = datevenda.Text;
                abrir.CodFuncionario = Convert.ToInt32(txtcod_funcionario.Text);
                abrir.CPF = maskedcpf.Text.Replace(".", "-");
                abrir.Nome = txtnome.Text;
                abrir.CodCliente = Convert.ToInt32(txtcod_cliente.Text);
                if (ObjOperacao == clnFuncoesGerais.Operacao.Inclusao)
                {
                    abrir.GravarVenda();
                    MessageBox.Show("Venda aberta com sucesso!! ", "VENDA NOVA!! " + txtnome.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ÚLTIMA VENDA ABERTA!! ", "Código da venda!! " + txtcod_venda.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                Clnabrirvenda obj = new Clnabrirvenda();
                OracleDataReader drDados;
                drDados = obj.ProcurarVenda();
                if (drDados.Read())
                {
                    txtcod_venda.Text = Convert.ToString(drDados["cod_Venda"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtquantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
        

        public void carregaDataGrid()
        {
            Clninserirproduto ObjAgenda = new Clninserirproduto();
            dgvitens_venda.DataSource = ObjAgenda.ListarProduto(txtcod_venda.Text).Tables[0];
            dgvitens_venda.Columns[0].Visible = false;
            dgvitens_venda.Columns[1].Visible = false;
            dgvitens_venda.Columns[0].HeaderText = ("CodItem");
            dgvitens_venda.Columns[1].HeaderText = ("CodVenda");
            dgvitens_venda.Columns[2].HeaderText = ("CodProdutos");
            dgvitens_venda.Columns[3].HeaderText = ("Nome");
            dgvitens_venda.Columns[4].HeaderText = ("Quantidade");
            dgvitens_venda.Columns[5].HeaderText = ("Valor");
            dgvitens_venda.Columns[6].HeaderText = ("Total");
            dgvitens_venda.AutoResizeColumns();

        }

        
        private void btnnovo_Click(object sender, EventArgs e)
        {
            Cliente objCadastroAgenda = new Cliente();
            objCadastroAgenda.Text = ">>>>Novo Cadastro<<<<";
            objCadastroAgenda.txtcod_cliente.Enabled = false;
            objCadastroAgenda.txtnome.Focus();
            objCadastroAgenda.EnumProperty = clnFuncoesGerais.Operacao.Inclusao;
            objCadastroAgenda.ShowDialog();
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void lblsubt_Click(object sender, EventArgs e)
        {

        }


        private void lbltlt_Click(object sender, EventArgs e)
        {

        }

     

        private void picpesquisar_Click(object sender, EventArgs e)
        {
            Clnbuscaproduto ObjbuscaProduto = new Clnbuscaproduto();
            OracleDataReader drDados;
            if (txtcod_produto.Text.Length > 0)
            {
                ObjbuscaProduto.BuscaCod = txtcod_produto.Text;

            }
            if (txtcod_barra.Text.Length > 0)
            {
                ObjbuscaProduto.BuscaBarra = txtcod_barra.Text;

            }

            drDados = ObjbuscaProduto.BuscaProduto();
            if (drDados.Read())
            {
                txtcod_produto.Text = Convert.ToString(drDados["cod_Produtos"]);
                txtcod_barra.Text = Convert.ToString(drDados["cod_barra"]);
                txtnome_produto.Text = Convert.ToString(drDados["nome"]);
                txtvalor.Text = Convert.ToString(drDados["valor"]);
            }
            else
            {
                MessageBox.Show("Produto não encontrado" + txtcod_produto, "Produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcod_produto.Text = "";


            }

        }

        private void pictureexcluir_Click(object sender, EventArgs e)
        {
            int msg;
            msg = Convert.ToInt32(MessageBox.Show("DESEJA EXCLUIR O ITEM ? " +
                Convert.ToString(dgvitens_venda.CurrentRow.Cells[1].Value),
                "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));

            if (msg == 6)
            {
                Clninserirproduto objAgenda = new Clninserirproduto();
                objAgenda.CodItem = Convert.ToInt32(dgvitens_venda.CurrentRow.Cells[0].Value);
                objAgenda.ExcluirLogicamente();

                MessageBox.Show("Item Excluído com Sucesso", " E X C L U S Ã O ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", "CANCELAMENTO E X C L U S Ã O ",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            carregaDataGrid();
            double valorTotal = 0;
            string valor = "";

            if (dgvitens_venda.Rows[0].Cells[6].Value.ToString() != null)
            {
                valor = dgvitens_venda.Rows[0].Cells[6].Value.ToString();
                if (!valor.Equals(""))
                {
                    for (int i = 0; i <= dgvitens_venda.RowCount - 1; i++)
                    {
                        if (dgvitens_venda.Rows[i].Cells[6].Value != null)
                            valorTotal += Convert.ToDouble(dgvitens_venda.Rows[i].Cells[6].Value);
                    }
                    if (valorTotal == 0)
                    {
                        MessageBox.Show("Nenhum registro encontrado");
                    }
                    lbltotale.Text = valorTotal.ToString();
                }
            }
        }

        private void picinserir_Click(object sender, EventArgs e)
        {
             Form1 fun = new Form1();
            if ((txtsub_total.Text == "") || (txtsub_total.Text == "1"))
            {
                MessageBox.Show("POR FAVOR, APERTE A TECLA ENTER AO DIGITAR QUANTIDADE !!", "O CAMPO SUB TOTAL ESTÁ INVÁLIDO !! " + fun.txtusuario.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if ((txtquantidade.Text == ""))
            {
                MessageBox.Show("O CAMPO QUANTIDADE É DE PREENCHIMENTO OBRIGATÓRIO !!");
            }
            else
            {
                Clninserirproduto incluir = new Clninserirproduto();
                if (txtquantidade.Text != "" || txtcod_venda.Text != "" || txtcod_produto.Text != "" || txtnome_produto.Text != "" || txtvalor.Text != "")
                {
                    {
                        incluir.CodVenda = Convert.ToInt32(txtcod_venda.Text);
                        incluir.CodProdutos = Convert.ToInt32(txtcod_produto.Text);
                        incluir.Nome = txtnome_produto.Text;
                        incluir.Quantidade = Convert.ToInt32(txtquantidade.Text);
                        incluir.Valor = Convert.ToDouble(txtvalor.Text);
                        incluir.Total = Convert.ToDouble(txtsub_total.Text);

                        if (ObjOperacao == clnFuncoesGerais.Operacao.Inclusao)
                        {
                            incluir.GravarProduto();
                            carregaDataGrid();
                            txtcod_produto.Text = "";
                            txtcod_barra.Text = "";
                            txtnome_produto.Text = "";
                            txtvalor.Text = "";
                            txtquantidade.Text = "";
                            txtsub_total.Text = "1";
                        }
                    }
                    double valorTotal = 0;
                    string valor = "";

                    if (dgvitens_venda.Rows[0].Cells[6].Value.ToString() != null)
                    {
                        valor = dgvitens_venda.Rows[0].Cells[6].Value.ToString();
                        if (!valor.Equals(""))
                        {
                            for (int i = 0; i <= dgvitens_venda.RowCount - 1; i++)
                            {
                                if (dgvitens_venda.Rows[i].Cells[6].Value != null)
                                    valorTotal += Convert.ToDouble(dgvitens_venda.Rows[i].Cells[6].Value);
                            }
                            if (valorTotal == 0)
                            {
                                MessageBox.Show("Nenhum registro encontrado");
                            }
                            lbltotale.Text = valorTotal.ToString();
                        }
                    }
                }
            }
                    
        


        }

        private void txtquantidade_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double n1, resulto;
                int n2;

                n1 = double.Parse(txtvalor.Text);
                n2 = int.Parse(txtquantidade.Text);

                resulto = n1 * n2;
                txtsub_total.Text = resulto.ToString();
            }

        }

        private void txtsub_total_TextChanged(object sender, EventArgs e)
        {
           Moeds(txtsub_total);
        }
        public static void Moeds(TextBox campo)
        {
            campo.Text.Substring(0,campo.Text.IndexOf(".") + 2);
        }

            private void lbltotale_Click(object sender, EventArgs e)
            {
                
            }

            private void dgvitens_venda_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void txtsub_total_KeyPress(object sender, KeyPressEventArgs e)
            {
               
            }
        }
    }

        
    
    


      
        

    
                     
            
     
        
        