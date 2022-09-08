using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoXadrez


{
    public class Tela
    {
        public int RecebeValor()
        {
            int n = int.Parse(Console.ReadLine());
            return n;
        }

        public void Imprimir(Tabuleiro tabuleiro)
        {

            Console.WriteLine($"{tabuleiro.Branca} casas brancas e {tabuleiro.Preta} casas pretas");
        }
    }
}

