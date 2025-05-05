// Arquivo: Exercicio14.cs
using System;
using System.Globalization;
class Exercicio14
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 14 - Nome e idade do mais velho");

        int n;
        n = int.Parse(Console.ReadLine());

        string[] nomes = new string[n];
        int[] idades = new int[n];

        for (int i = 0; i < n; i++)
        {
            string[] aux = Console.ReadLine().Split(' ');

            nomes[i] = aux[0];
            idades[i] = int.Parse(aux[1]);

        }

        string maisVelho = nomes[0];
        int maiorIdade = idades[0];

        for (int i = 0; i < n; i++)
        {
            if (idades[i] > maiorIdade)
            {
                maiorIdade = idades[i];
                maisVelho = nomes[i];

            }
        }
        Console.WriteLine("Pessoa mais velha: " + maisVelho);
        Console.WriteLine(maiorIdade.ToString("F0", CultureInfo.InvariantCulture) + " anos");

    }
}