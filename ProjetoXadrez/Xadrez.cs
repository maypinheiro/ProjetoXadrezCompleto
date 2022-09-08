using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoXadrez
{
    public class Xadrez
    {
        public Tabuleiro CalculaTamanhoTabuleiro(int n)
        {
            int total = n * n;
            int pretas = total / 2;
            int brancas = total - pretas;

            Tabuleiro tabuleiro = new Tabuleiro(total, brancas, pretas);

            return tabuleiro;
        }


    }
}
