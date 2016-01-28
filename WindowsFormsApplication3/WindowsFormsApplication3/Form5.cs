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
    public partial class Form5 : Form
    {
        public Arvore arvore { get; set; }
        public Form formPai { get; set; }
        public String animal { get; set; }
        public Form5(Form formPai, Arvore arvore, String animal)
        {
            InitializeComponent();
            this.formPai = formPai;
            this.formPai.Hide();
            this.arvore = arvore;
            this.animal = animal;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            String carac = caracteristica.Text;
            arvore.adicionaNo(arvore, animal, carac);
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    if (Application.OpenForms[intIndex].Name != "Form1")
                        Application.OpenForms[intIndex].Close();
                    else { 
                        this.Close();
                        Application.OpenForms[intIndex].Show();
                    }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = "A "+animal+"______ but a "+ arvore.perguntaResponde(arvore) + " does not(Fill it with a animal trait, like 'Lives in Water')";
        }
    }
}
