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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            logar();
        }
        public void logar()
        {

            if (txtusuario.Text == "" || txtsenha.Text == "")
            {
                MessageBox.Show
                    ("Digite o usuário e a senha para entrar no sistema");
                txtusuario.BackColor = Color.Red;
                txtusuario.ForeColor = Color.White;
                txtsenha.BackColor = Color.Red;
                txtsenha.ForeColor = Color.White;
            }
            else
            {
                clnLogin Agenda = new clnLogin();
                OracleDataReader objDRDados;
                objDRDados = Agenda.ListarLogin
                    (txtusuario.Text);
                if (objDRDados.Read())
                {
                    Agenda.usuario =
                        objDRDados["USUARIO"].ToString();
                    Agenda.senha =
                        objDRDados["SENHA"].ToString();
                    Agenda.cod_func = Convert.ToInt16
                       (objDRDados["Cod_Login"].ToString());

                    if ((txtsenha.Text != Agenda.senha))
                    {
                        MessageBox.Show
                            ("senha incorreta");
                        txtsenha.Clear();
                        txtsenha.BackColor = Color.Red;
                        txtsenha.ForeColor = Color.White;

                    }



                    else
                    {

                        Agenda.nivelacesso =
                        objDRDados["NIVEL_ACESSO"].ToString();

                        if (Agenda.nivelacesso == "Administrador")
                        {
                            Menu x = new Menu();
                            this.Visible = false;
                            x.label1.Text = Convert.ToString
                           (Agenda.usuario);
                            x.ShowDialog();

                        }
                       
                        if (Agenda.nivelacesso == "Atendente")
                        {
                            Menu2 x = new Menu2();
                            this.Visible = false;
                            x.llbnome.Text = Convert.ToString
                           (Agenda.usuario);
                            //x.lblcod.Text = Convert.ToString(
                            x.ShowDialog();
                        }

                        if (Agenda.nivelacesso == "Caixa")
                        {
                            Menu2 x = new Menu2();
                            this.Visible = false;
                            x.llbnome.Text = Convert.ToString
                           (Agenda.usuario);
                            x.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Erro em nível de acesso! contate seu administrador.");


                        }
                    }
                }


                else
                {

                    MessageBox.Show
                        ("usuário incorreto");
                    txtusuario.Clear();
                    txtusuario.BackColor = Color.Red;
                }


            }
        }
           

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Gostaria de Sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
