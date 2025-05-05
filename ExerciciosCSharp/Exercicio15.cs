// Arquivo: Exercicio15.cs
using System;
using System.Globalization;
class Exercicio15
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 15 - Média de notas e aprovação");

        int n;
        Console.WriteLine("Quer fazer a leitura de quantos alunos?");
        n = int.Parse(Console.ReadLine());

        string[] nome = new string[n];
        double[] nota1 = new double[n];
        double[] nota2 = new double[n];

        Console.WriteLine("Digite o nome, n1 e n2 do aluno: ");

        for (int i = 0; i < n; i++)
        {
            string[] vetAux = Console.ReadLine().Split(' ');
            nome[i] = vetAux[0];
            nota1[i] = double.Parse(vetAux[1], CultureInfo.InvariantCulture);
            nota2[i] = double.Parse(vetAux[2], CultureInfo.InvariantCulture);

        }

        double media;

        Console.WriteLine("Esses são nossos alunos aprovados: ");
        for (int i = 0; i < n; i++)
        {
            media = (nota1[i] + nota2[i]) / 2;
            if (media >= 6)
            {
                Console.WriteLine(nome[i]);
            }
        }
    }
}