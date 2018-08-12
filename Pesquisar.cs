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
    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PesquisarCliente ObjPesquisarCliente = new PesquisarCliente();
            ObjPesquisarCliente.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormPesquisarproduto ObjPesquisarproduto = new FormPesquisarproduto();
            ObjPesquisarproduto.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PesquisarFornecedor ObjPesquisafornecedor = new PesquisarFornecedor();
            ObjPesquisafornecedor.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PesquisaFuncionario ObjPesquisafuncionario = new PesquisaFuncionario();
            ObjPesquisafuncionario.ShowDialog();
        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PesquisarLogin ObjPesquisalogin = new PesquisarLogin();
            ObjPesquisalogin.ShowDialog();
        }
    }
}
