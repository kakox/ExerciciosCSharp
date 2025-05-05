// Arquivo: Exercicio16.cs
using System;
using System.Globalization;
class Exercicio16
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 16 - Altura das mulheres e número de homens");


        int n;
        Console.WriteLine("Quer adicionar quantas vezes?");
        n = int.Parse(Console.ReadLine());

        double[] altura = new double[n];
        char[] sexo = new char[n];

        Console.WriteLine("Digite a altura em seguida o sexo e pressione enter: ");
        for (int i = 0; i < n; i++)
        {
            string[] vetAux = Console.ReadLine().Split(' ');
            altura[i] = double.Parse(vetAux[0], CultureInfo.InvariantCulture);
            sexo[i] = char.Parse(vetAux[1].ToUpper());

        }

        double maiorAltura = altura[0];
        double menorAltura = altura[0];

        for (int i = 0; i < n; i++)
        {

            if (altura[i] < menorAltura)
            {
                menorAltura = altura[i];

            }

            if (altura[i] > maiorAltura)
            {
                maiorAltura = altura[i];

            }

        }
        Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));



        double somaAlturaMulheres = 0;
        double qtdMulheres = 0;

        for (int i = 0; i < n; i++)
        {
            if (sexo[i] == 'F')
            {
                somaAlturaMulheres += altura[i];
                qtdMulheres++;

            }

        }
        if (qtdMulheres > 0)
        {
            double media = somaAlturaMulheres / qtdMulheres;
            Console.WriteLine("Média das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }

        int qtdHomens = 0;
        for (int i = 0; i < n; ++i)
        {
            if (sexo[i] == 'M')
            {
                qtdHomens++;
            }
        }
        Console.WriteLine("Numero de homens = " + qtdHomens);
    }
}