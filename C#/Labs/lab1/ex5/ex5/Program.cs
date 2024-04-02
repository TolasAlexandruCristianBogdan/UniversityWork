using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti numere intregi separate prin spatiu:");
        string input = Console.ReadLine();
        string[] numereString = input.Split(' ');

        // Calcularea mediei aritmetice
        double sumaAritmetica = 0;
        foreach (string numarString in numereString)
        {
            int numar;
            if (int.TryParse(numarString, out numar))
            {
                sumaAritmetica += numar;
            }
        }
        double mediaAritmetica = sumaAritmetica / numereString.Length;
        Console.WriteLine($"Media aritmetica a numerelor este: {mediaAritmetica}");

        // Calcularea mediei geometrice
        double produsGeometric = 1;
        foreach (string numarString in numereString)
        {
            int numar;
            if (int.TryParse(numarString, out numar))
            {
                produsGeometric *= numar;
            }
        }
        double mediaGeometrica = Math.Pow(produsGeometric, 1.0 / numereString.Length);
        Console.WriteLine($"Media geometrica a numerelor este: {mediaGeometrica}");
    }
}
