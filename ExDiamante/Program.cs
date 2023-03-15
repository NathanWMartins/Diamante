﻿namespace ExDiamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero impar para imprimir o tamanho do diamante: ");
            int n = int.Parse(Console.ReadLine());
            while (n % 2 == 0)
            {
                Console.WriteLine("Digite um numero IMPAR para imprimir o tamanho do diamante: ");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i += 2)
            {
                for (int j = 1; j <= (n - i) / 2; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("x");
                }

                Console.WriteLine();
            }
            for (int i = n - 2; i >= 1; i -= 2)
            {
                for (int j = 1; j <= (n - i) / 2; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("x");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}