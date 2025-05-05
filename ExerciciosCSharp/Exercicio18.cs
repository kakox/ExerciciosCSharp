// Arquivo: Exercicio18.cs
using System;
class Exercicio18
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 18 - Diagonal e números negativos");

        int n;
        int[,] a;
        n = int.Parse(Console.ReadLine());
        a = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                a[i, j] = int.Parse(s[j]);
            }
        }

        Console.WriteLine("DIAGONAL PRINCIPAL: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i, i] + " ");
        }
        Console.WriteLine();

        int cont = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i, j] < 0)
                {
                    cont++;
                }
            }
        }
        Console.WriteLine("QUANTIDADE DE NEGATIVOS: " + cont);
    }
}