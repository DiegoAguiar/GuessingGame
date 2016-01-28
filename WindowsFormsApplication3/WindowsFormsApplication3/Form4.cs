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
    public partial class Form4 : Form
    {
        public Arvore arvore { get; set; }
        public Form formPai { get; set; }
        public Form4(Form formPai, Arvore arvore)
        {
            InitializeComponent();
            this.formPai = formPai;
            this.formPai.Hide();
            this.arvore = arvore;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            String animal = animalName.Text;
            Form form5 = new Form5(this,arvore,animal);
            form5.Show();
        }
    }
}
