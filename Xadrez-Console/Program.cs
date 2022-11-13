using System;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tad = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tad);

            Console.ReadLine();

        }
    }
}
