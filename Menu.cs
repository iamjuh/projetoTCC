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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente Objcliente = new Cliente();
            Objcliente.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarCliente ObjPesquisarCliente = new PesquisarCliente();
            ObjPesquisarCliente.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Gostaria de Sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdutos Objproduto = new FormProdutos();
            Objproduto.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisarproduto  ObjPesquisarproduto = new FormPesquisarproduto();
            ObjPesquisarproduto.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria Objcategoria = new Categoria();
            Objcategoria.ShowDialog();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor Objfornecedor = new Fornecedor();
            Objfornecedor.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venda Objvenda = new Venda();
            Objvenda.ShowDialog();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisarFornecedor ObjPesquisafornecedor = new PesquisarFornecedor();
            ObjPesquisafornecedor.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marca Objmar= new Marca();
            Objmar.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisaFuncionario ObjPesquisafuncionario = new PesquisaFuncionario();
            ObjPesquisafuncionario.ShowDialog();
        }

        private void balcãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario Objfun = new Funcionario();
            Objfun.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadLogin Objcad = new CadLogin();
            Objcad.ShowDialog();
        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Objlogin = new Form1();
            Objlogin.ShowDialog();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Gostaria de Sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Venda Objvenda = new Venda();
            Objvenda.ShowDialog();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 Objlogin = new Form1();
            Objlogin.ShowDialog();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cadastros Objca = new cadastros();
            Objca.ShowDialog();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Pesquisar Objpe = new Pesquisar();
            Objpe.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FormWeb objweb = new FormWeb();
            objweb.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            relatoriodevendas objrela = new  relatoriodevendas();
            objrela.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //Process.Start("Calc.exe");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
      



         
           
        
    } 
}
