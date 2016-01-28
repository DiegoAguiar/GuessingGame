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
    public partial class Form6 : Form
    {
        public Arvore arvore { get; set; }
        public Form formPai { get; set; }
        public Form6(Form formPai, Arvore arvore)
        {
            InitializeComponent();
            this.formPai = formPai;
            this.formPai.Hide();
            this.arvore = arvore;
        }

        private void ok_Click(object sender, EventArgs e)
        {
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
    }
}
