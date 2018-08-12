using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Net.Mail;

namespace LojaTCC
{
    public partial class EnviarEmail : Form
    {
        public EnviarEmail()
        {
            InitializeComponent();
        }
        public string Propriedade { get; set; }
        public string assun { get; set; }

        private void EnviarEmail_Load(object sender, EventArgs e)
        {
            if (!this.Propriedade.Equals(""))
                txtpara.Text = this.Propriedade;
            if (!this.assun.Equals(""))
                txtassunto.Text = this.assun;
        }
        public void SendEmail()
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();

            //aqui add o para 
            //message.To.Add("nomedodestinatario@email.com");//destinatario
            if (!string.IsNullOrWhiteSpace(txtpara.Text))
            {
                message.To.Add(txtpara.Text);//utilizar o email escritona textbox.
            }
            else
            {
                MessageBox.Show("campo 'para' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ////aqui add o CC
            //message.CC.Add(txtcc.Text);

            //permite add um anexo
            //System.Net.Mail.Attachment anexo = new System.Net.Mail.Attachment(txtanexo.Text);
            //message.Attachments.Add(anexo);

            //message.Subject = "Mensagem de teste"; // assunto do email
            message.Subject = txtassunto.Text;

            message.From = new System.Net.Mail.MailAddress("juju.souza983@gmail.com");

            //message.Body = "Esta mensagem serve para testar o programa" ; //corpo do email
            message.Body = richmensagem.Text;

            //Volamos a utilizar a namespace, mas para o Smtpclient, que nos permitiránenviar o email
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();

            //smtp.Host = "smtp.gmail.com"; // servidor de smtp (este é do gmail)
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
           

            ///--------- AQUI ESCOLHEMOS SE O NOSSO EMAIL TEM SSL

            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            //para finalizar criamos as credenciais 
            smtp.Credentials = new System.Net.NetworkCredential("juju.souza983@gmail.com", "gianeelara");
            smtp.Send(message); // envia a mensagem (este método poderá lançar uma excepção
            MessageBox.Show("Email enviado com sucesso!", "Informção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();


        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtanexo.Text = openFileDialog1.FileName;
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            SendEmail();
        }
    }
}
