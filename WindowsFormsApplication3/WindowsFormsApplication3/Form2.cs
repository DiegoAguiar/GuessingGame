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
    public partial class Form2 : Form
    {
        public Arvore arvore { get; set; }
        public Form formPai { get; set; }
        public Form2(Form formPai, Arvore arvore)
        {
            InitializeComponent();
            this.formPai = formPai;
            this.formPai.Hide();
            this.arvore = arvore;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text+ " "+arvore.perguntaResponde(arvore)+ " ?";
        }

        private void sim_Click(object sender, EventArgs e)
        {
            Arvore noArvore = arvore.percorreArvore(arvore, true);
            if (!noArvore.ultimoNo(noArvore))
            {
                Form form2 = new Form2(this, noArvore);
                form2.Show();
            }
            else {
                Form form3 = new Form3(this, noArvore);
                form3.Show();
            }
        }

        private void nao_Click(object sender, EventArgs e)
        {
            Arvore noArvore = arvore.percorreArvore(arvore, false);
            if (!noArvore.ultimoNo(noArvore))
            {
                Form form2 = new Form2(this, noArvore);
                form2.Show();
            }
            else {
                Form form3 = new Form3(this, noArvore);
                form3.Show();
            }
        }
    }
}
