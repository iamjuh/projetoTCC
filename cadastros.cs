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
    public partial class cadastros : Form
    {
        public cadastros()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cliente Objcliente = new Cliente();
            Objcliente.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormProdutos Objproduto = new FormProdutos();
            Objproduto.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Fornecedor Objfornecedor = new Fornecedor();
            Objfornecedor.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Categoria Objcategoria = new Categoria();
            Objcategoria.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Marca Objmar = new Marca();
            Objmar.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Funcionario Objfun = new Funcionario();
            Objfun.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CadLogin Objcad = new CadLogin();
            Objcad.ShowDialog();
        }
    }
}
