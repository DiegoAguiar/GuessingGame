using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameHoplon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Arvore arvore = new Arvore();
            arvore.raiz = true;
            arvore.pergunta = "lives in water";
            arvore.filhoDireita = new Arvore();
            arvore.filhoDireita.raiz = false;
            arvore.filhoDireita.resposta = "Shark";
            arvore.filhoEsquerda = new Arvore();
            arvore.filhoEsquerda.raiz = false;
            arvore.filhoEsquerda.resposta = "Monkey";

            Application.Run(new Form1(arvore));
        }
    }
}
