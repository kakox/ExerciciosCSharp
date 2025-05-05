// Arquivo: Exercicio17.cs
using System;
using System.Globalization;
class Exercicio17
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 17 - Cálculo de lucro por produto");

        int n;
        Console.WriteLine("Digite quantos itens quer listar: ");
        n = int.Parse(Console.ReadLine());
        string[] mercadoria = new string[n];
        double[] precoCompra = new double[n];
        double[] precoVenda = new double[n];

        Console.WriteLine("Digite o produto, o preço que comprou o produto e o preço que vendeu, após isso pressione enter. ");
        for (int i = 0; i < n; i++)
        {
            string[] aux = Console.ReadLine().Split(' ');
            mercadoria[i] = aux[0];
            precoCompra[i] = double.Parse(aux[1], CultureInfo.InvariantCulture);
            precoVenda[i] = double.Parse(aux[2], CultureInfo.InvariantCulture);
        }

        int lucroMenor10 = 0;
        int lucroEntre10e20 = 0;
        int lucroMaior20 = 0;
        double totalCompra = 0.0;
        double totalVenda = 0.0;
        double lucroTotal = 0.0;

        for (int i = 0; i < n; i++)
        {
            // Calcula o percentual de lucro da mercadoria
            double lucroPercentual = ((precoVenda[i] - precoCompra[i]) / precoCompra[i]) * 100;

            // Classifica o lucro percentual e atualiza os contadores
            if (lucroPercentual < 10.0)
            {
                lucroMenor10++;
            }
            else if (lucroPercentual <= 20.0)
            {
                lucroEntre10e20++;
            }
            else
            {
                lucroMaior20++;
            }

            // Acumula os totais de compra, venda e lucro
            totalCompra += precoCompra[i];
            totalVenda += precoVenda[i];
            lucroTotal += precoVenda[i] - precoCompra[i];


        }

        // saidas
        Console.WriteLine("Lucro abaixo de 10%: " + lucroMenor10);
        Console.WriteLine("Lucro entre 10% e 20%: " + lucroEntre10e20);
        Console.WriteLine("Lucro acima de 20%: " + lucroMaior20);
        Console.WriteLine("Valor total de compras: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor total de vendas: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));
    }
}