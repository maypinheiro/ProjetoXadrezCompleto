using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoXadrez
{

        public class Tabuleiro
        {

            public int Tamanho { get; private set; }
            public int Branca { get; private set; }
            public int Preta { get; private set; }

            public Tabuleiro(int tamanho, int branca, int preta)
            {
                Tamanho = tamanho;
                Branca = branca;
                Preta = preta;
            }



        }
    
}

 