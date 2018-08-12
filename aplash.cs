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
    public partial class aplash : Form
    {
        public aplash()
        {
            InitializeComponent();
        }

        private void aplash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbcarrega.Value < 100)
            {
                pbcarrega.Value = pbcarrega.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                Form1 login = new Form1();
                login.ShowDialog();


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
