using System;

class GreutateIdealaCalculator
{
    public static double CalculeazaGreutateaIdealaBarbati(double inaltimeCm, int varstaAni)
    {
        return inaltimeCm - 100 - ((inaltimeCm - 150) / 4) + ((varstaAni - 20) / 4);
    }

    public static double CalculeazaGreutateaIdealaFemei(double inaltimeCm, int varstaAni)
    {
        return inaltimeCm - 100 - ((inaltimeCm - 150) / 2.5) + ((varstaAni - 20) / 6);
    }

    public static void AfiseazaGreutateaIdeala(double greutateIdealKg)
    {
        Console.WriteLine($"Greutatea ideală este: {greutateIdealKg:F2} kg");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Introduceți înălțimea (cm):");
        double inaltimeCm = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduceți vârsta (ani):");
        int varstaAni = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceți sexul (f pentru femeie, m pentru bărbat):");
        char sex = Convert.ToChar(Console.ReadLine());

        double greutateIdealKg;

        if (sex == 'f')
        {
            greutateIdealKg = CalculeazaGreutateaIdealaFemei(inaltimeCm, varstaAni);
        }
        else if (sex == 'm')
        {
            greutateIdealKg = CalculeazaGreutateaIdealaBarbati(inaltimeCm, varstaAni);
        }
        else
        {
            Console.WriteLine("Sexul introdus nu este valid.");
            return;
        }

        AfiseazaGreutateaIdeala(greutateIdealKg);
    }
}
