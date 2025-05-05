// Arquivo: Exercicio25.cs
using System;
using System.Globalization;
class Exercicio25
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 25 - Soma dos positivos e modificação da matriz");

        // entrada de dados
        int n;

        Console.WriteLine("Essa é uma matriz quadrada, digite um unico " +
            "numero que sera o numero de linhas e colunas:");
        n = int.Parse(Console.ReadLine());

        double[,] matriz = new double[n, n];

        // leitura dos dados da matriz
        Console.WriteLine("Digite os elementos da matriz: ");
        for (int i = 0; i < n; i++)
        {
            string[] aux = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = double.Parse(aux[j], CultureInfo.InvariantCulture);
            }
        }

        // soma dos positivos da matriz
        double somaPositivos = 0.0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matriz[i, j] > 0.0)
                {
                    somaPositivos += matriz[i, j];
                }
            }
        }
        Console.WriteLine("SOMA DOS POSITIVOS: " + somaPositivos.ToString("F1", CultureInfo.InvariantCulture));

        // leitura da linha
        Console.WriteLine("LINHA ESCOLHIDA: ");
        int linha = int.Parse(Console.ReadLine());

        for (int j = 0; j < n; j++)
        {
            Console.Write(matriz[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
        }
        Console.WriteLine();

        // leitura da coluna
        Console.WriteLine("COLUNA ESCOLHIDA: ");
        int coluna = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(matriz[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
        }
        Console.WriteLine();

        // leitura da diagonal principal
        Console.WriteLine("DIAGONAL PRINCIPAL: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(matriz[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
        }
        Console.WriteLine();

        // alteração da matriz, elevando numeros negativos
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matriz[i, j] < 0.0)
                {
                    matriz[i, j] = Math.Pow(matriz[i, j], 2);
                }
            }
        }

        // exibição da matriz alterada
        Console.WriteLine("MATRIZ ALTERADA: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();
        }
    }
}