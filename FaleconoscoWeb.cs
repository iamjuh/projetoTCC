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
    public partial class FaleconoscoWeb : Form
    {
        public FaleconoscoWeb()
        {
            InitializeComponent();
        }

        private void btnresponder_Click(object sender, EventArgs e)
        {
            EnviarEmail Obj = new EnviarEmail();
            Obj.Propriedade = txtemail.Text;
            Obj.assun = txtassunto.Text;
            Obj.ShowDialog();
            Close();
        }

        private void FaleconoscoWeb_Load(object sender, EventArgs e)
        {

        }
    }
}
