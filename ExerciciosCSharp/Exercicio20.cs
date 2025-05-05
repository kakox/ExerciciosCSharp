// Arquivo: Exercicio20.cs
using System;
class Exercicio20
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 20 - Impressão de números negativos de uma matriz");

        int m, n;

        Console.WriteLine("Digite o numero de linhas e numero de colunas: ");
        string[] aux = Console.ReadLine().Split(' ');

        m = int.Parse(aux[0]);
        n = int.Parse(aux[1]);

        int[,] matriz1 = new int[m, n];

        Console.WriteLine("Digite a matriz: ");
        for (int i = 0; i < m; i++)
        {
            string[] aux2 = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz1[i, j] = int.Parse(aux2[j]);
            }
        }

        Console.WriteLine("NUMEROS NEGATIVOS: ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matriz1[i, j] < 0)
                {
                    Console.WriteLine(matriz1[i, j]);
                }
            }

        }
    }
}