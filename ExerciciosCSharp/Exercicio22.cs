// Arquivo: Exercicio22.cs
using System;
class Exercicio22
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 22 - Maior elemento por linha de uma matriz");

        int n;
        Console.WriteLine("Digite o numero de linhas e colunas: ");
        n = int.Parse(Console.ReadLine());
        int[,] matriz = new int[n, n];

        Console.WriteLine("Digite os valores da matriz: ");
        for (int i = 0; i < n; i++)
        {
            string[] aux = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(aux[j]);

            }

        }


        for (int i = 0; i < n; i++)
        {
            int maiorElemento = matriz[i, 0];

            for (int j = 1; j < n; j++)
            {
                if (matriz[i, j] > maiorElemento)
                {
                    maiorElemento = matriz[i, j];
                }
            }

            Console.WriteLine("O maior elemento da " + (i + 1) + "° linha é: " + maiorElemento);
        }
    }
}