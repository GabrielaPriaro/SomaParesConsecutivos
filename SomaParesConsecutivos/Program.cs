﻿//obs: Utilizar estrutura condicional While:
//Problema "pares_consecutivos" (adaptado de URI 1159)
//O programa deve ler um valor inteiro X indefinidas vezes. (O programa irá parar quando o valor de X
//for igual a 0). Para cada X lido, imprima a soma dos 5 pares consecutivos a partir de X, inclusive o X
//, se for par. Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação:
//4 + 6 + 8 + 10 + 12, enquanto que se o valor de entrada for 11, por exempo, a saída deve ser 80, que é a
//soma de 12+14+16+18+20. 

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SomaParesConsecutivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, soma;

            Console.Write("Digite um numero inteiro: ");
            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 != 0)
                {
                    x++;
                }
                soma = 5 * x + 20;

                Console.WriteLine($"SOMA = {soma}");

                Console.Write("Digite um numero inteiro: ");
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}