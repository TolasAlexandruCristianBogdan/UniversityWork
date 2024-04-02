using System;
class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti un numar real: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introduceti un alt numar real: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nRezultatele operațiilor matematice:");

        // Adunare
        double suma = Adunare(num1, num2);
        AfisareOperatie(num1, num2, "+", suma);

        // Scădere
        double diferenta = Scadere(num1, num2);
        AfisareOperatie(num1, num2, "-", diferenta);

        // Înmulțire
        double produs = Inmultire(num1, num2);
        AfisareOperatie(num1, num2, "*", produs);

        // Împărțire
        double impartireRezultat = Impartire(num1, num2);
        AfisareOperatie(num1, num2, "/", impartireRezultat);
    }

    // Metoda pentru adunare
    public static double Adunare(double a, double b)
    {
        return a + b;
    }

    // Metoda pentru scădere
    public static double Scadere(double a, double b)
    {
        return a - b;
    }

    // Metoda pentru înmulțire
    public static double Inmultire(double a, double b)
    {
        return a * b;
    }

    // Metoda pentru împărțire
    public static double Impartire(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Nu se poate împarti la zero.");
            return double.NaN; // Returnează NaN (Not a Number) în cazul unei împărțiri la zero
        }
    }

    // Metoda pentru afișarea operației
    public static void AfisareOperatie(double a, double b, string operatie, double rezultat)
    {
        Console.WriteLine($"{a} {operatie} {b} = {rezultat}");
    }
}
