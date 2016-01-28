using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameHoplon
{
    public partial class Form3 : Form
    {
        public Arvore arvore { get; set; }
        public Form formPai { get; set; }
        public Form3(Form formPai,Arvore arvore)
        {
            InitializeComponent();
            this.formPai = formPai;
            this.formPai.Hide();
            this.arvore = arvore;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text + " " + arvore.perguntaResponde(arvore) + " ?";
        }

        private void sim_Click(object sender, EventArgs e)
        {
            Form form6 = new Form6(this,arvore);
            form6.Show();
        }

        private void nao_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4(this,arvore);
            form4.Show();

        }
    }
}
