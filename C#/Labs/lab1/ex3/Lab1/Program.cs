using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Alegeți tipul de conversie:");
        Console.WriteLine("1. Celsius în Fahrenheit");
        Console.WriteLine("2. Fahrenheit în Celsius");

        int optiune = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceți temperatura: ");
        double temperaturaInput = Convert.ToDouble(Console.ReadLine());

        double temperaturaOutput = 0;

        switch (optiune)
        {
            case 1:
                temperaturaOutput = CelsiusToFahrenheit(temperaturaInput);
                Console.WriteLine($"Temperatura convertită: {temperaturaOutput:F2} °F");
                Console.ReadKey();
                break;
            case 2:
                temperaturaOutput = FahrenheitToCelsius(temperaturaInput);
                Console.WriteLine($"Temperatura convertită: {temperaturaOutput:F2} °C");
                Console.ReadKey();
                break;
        }
    }

    static double CelsiusToFahrenheit(double temperaturaCelsius)
    {
        return temperaturaCelsius * 9 / 5 + 32;
    }

    static double FahrenheitToCelsius(double temperaturaFahrenheit)
    {
        return (temperaturaFahrenheit - 32) * 5 / 9;
    }
}
