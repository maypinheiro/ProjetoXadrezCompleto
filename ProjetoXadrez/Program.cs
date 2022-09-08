using System;

namespace ProjetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tela tela = new Tela();
            Xadrez xadrez = new Xadrez();
            var tabuleiro = xadrez.CalculaTamanhoTabuleiro(tela.RecebeValor());
            tela.Imprimir(tabuleiro);
        }
    }
}
