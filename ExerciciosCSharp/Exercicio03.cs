// Arquivo: Exercicio3.cs
using System;
using System.Globalization;
class Exercicio3
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 3 - Cálculo da área de um retângulo");

        double b, a, area, perimetro, diagonal;
        Console.WriteLine("Digite a base: ");
        b = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite a altura: ");
        a = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

        area = b * a;
        perimetro = 2 * (b + a);
        diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

        Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Perimetro = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Diagonal = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
    }
}