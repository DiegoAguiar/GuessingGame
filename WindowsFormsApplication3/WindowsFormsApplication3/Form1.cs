using System;
using System.Windows.Forms;

namespace GuessingGameHoplon
{
    public partial class Form1 : Form
    {
        public Arvore arvore { get; set; }
        public Form1(Arvore arvore)
        {
            InitializeComponent();
            this.arvore = arvore;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(this,arvore);
            form2.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
