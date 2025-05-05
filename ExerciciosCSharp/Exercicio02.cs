// Arquivo: Exercicio2.cs
using System;
using System.Globalization;
class Exercicio2
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 2 - Cálculo da área de um terreno");
        // variaveis
        double largura, comprimento, precoMetroQuadrado, area, preco;

        // entrada de dados
        Console.WriteLine("Digite a largura do terreno: ");
        largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o comprimento do terreno: ");
        comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o preço por m²: ");
        precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // calculo
        area = largura * comprimento;
        preco = area * precoMetroQuadrado;

        // saida de dados
        Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("PRECO =" + preco.ToString("F2", CultureInfo.InvariantCulture));
    }
}