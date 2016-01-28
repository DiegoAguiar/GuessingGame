using System;
using System.Collections.Generic;

namespace GuessingGameHoplon
{
    public class Arvore
    {
        public Boolean raiz { get; set; }
        public String pergunta { get; set; }
        public String resposta { get; set; }
        public Arvore filhoEsquerda { get; set; }
        public Arvore filhoDireita { get; set; }

        public Arvore()
        {
            

        }
        public Arvore percorreArvore(Arvore arvore, Boolean resposta)
        {
            if (arvore.raiz && resposta)
                return arvore.filhoDireita;
            else if (!resposta)
                return arvore.filhoEsquerda;
            else
                return arvore;

        }

        public String perguntaResponde(Arvore arvore)
        {
            if (arvore.raiz)
                return arvore.pergunta;
            else
                return arvore.resposta;

        }

        public Boolean ultimoNo(Arvore arvore)
        {
            if (arvore.raiz)
                return false;
            else
                return true;
        }

        public Arvore adicionaNo(Arvore arvore, String animal, String caracteristica)
        {
            Arvore arvoreNova = new Arvore();
            arvoreNova = arvore;

            arvore.raiz = true;
            arvore.pergunta = caracteristica;
            arvore.filhoEsquerda = new Arvore();
            arvore.filhoEsquerda = new Arvore();
            arvore.filhoEsquerda.raiz = false;
            arvore.filhoEsquerda.resposta = arvoreNova.resposta;
            arvore.resposta = "";
            arvore.filhoEsquerda.filhoDireita = null;
            arvore.filhoEsquerda.filhoEsquerda = null;

            arvore.filhoDireita = new Arvore();
            arvore.filhoDireita.raiz = false;
            arvore.filhoDireita.resposta = animal;
            arvore.filhoDireita.filhoDireita = null;
            arvore.filhoDireita.filhoEsquerda = null;

            return arvore;

        }
    }
}
