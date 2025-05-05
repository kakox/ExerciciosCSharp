// Arquivo: Exercicio9.cs
using System;
using System.Globalization;
class Exercicio9
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 9 - Identificação do maior número e sua posição");

        int n;
        n = int.Parse(Console.ReadLine());
        double[] num = new double[n];
        string[] s = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            num[i] = double.Parse(s[i], CultureInfo.InvariantCulture);

        }
        double maior = num[0];
        int posicaoMaior = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] > maior)
            {
                maior = num[i];
                posicaoMaior = i;
            }
        }
        Console.WriteLine("O maior numero encontrado foi: " + maior.ToString("F1", CultureInfo.InvariantCulture) + " na posição: " + posicaoMaior);
    }
}