using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campo_minado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limiteinicial;
            int limitefinal;
            int numoculto;
            int jogada;
            int qtdplayers;
            int player = 0;

            Console.WriteLine("Jogo: Acertou, perdeu!");
            Console.Write("\nDigite a quantidade de jogadores: ");
            qtdplayers = int.Parse(Console.ReadLine());
            string[] players = new string[qtdplayers];

            for (int i = 0; i < qtdplayers; i++)
            {
                Console.Write("\nDigite o nome do {0}º jogador: ", i + 1);
                players[i] = Console.ReadLine();
            }

            Random random = new Random();
            numoculto = random.Next(1, 101);

            Console.Clear();
            Console.WriteLine("Jogo: Acertou, perdeu!");
            limiteinicial = 1;
            limitefinal = 100;

            do
            {
                do
                {
                    do
                    {
                        Console.Write("\n{0}, digite um número entre {1} e {2}: ", players[player], limiteinicial, limitefinal);
                        jogada = int.Parse(Console.ReadLine());
                    } while (jogada < limiteinicial || jogada > limitefinal);
                    player = (player + 1) % qtdplayers;
                } while (jogada <= limiteinicial || jogada >= limitefinal);

                if (jogada == numoculto)
                {
                    Console.WriteLine("\n{0} acertou o número e perdeu, parabéns!\n", players[player - 1]);
                }
                else
                {
                    if (jogada < numoculto)
                        limiteinicial = jogada;
                    else
                        limitefinal = jogada;
                }
            } while (jogada != numoculto);
        }
    }
}
