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
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
                    }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente Objcliente = new Cliente();
            Objcliente.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venda Objvenda = new Venda();
            Objvenda.ShowDialog();
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

        private void llbnome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cliente Objcliente = new Cliente();
            Objcliente.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PesquisarCliente ObjPesquisarCliente = new PesquisarCliente();
            ObjPesquisarCliente.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Venda Objvenda = new Venda();
            Objvenda.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Gostaria de Sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 Objlogin = new Form1();
            Objlogin.ShowDialog();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Menu2_Load(object sender, EventArgs e)
        {

        }
    }
}
