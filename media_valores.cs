using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];
            int soma = 0;
            int contador = 0;
            double media;

            Console.WriteLine("Média aritmética de 10 valores inteiros\n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}º valor: ", i + 1);
                valores[i] = int.Parse(Console.ReadLine());
                soma += valores[i];
            }

            media = (double)soma / 10;

            for (int i = 0; i < 10; i++)
            {
                if (valores[i] > media)
                {
                    contador++;
                }
            }

            Console.WriteLine("\nMédia: {0}", media);
            Console.WriteLine("\nQuantidade de valores maiores que a média: {0}\n", contador);
        }
    }
}
