// Sa se verifice daca un nr citit de la tastatura este pozitiv sau negativ
class Program
{
    static void Main(string[] args)
    {
        // Sa se verifice daca un nr citit de la tastatura este pozitiv sau negativ

        int a;
        string rez;
        Console.WriteLine(" Introduce un numar: ");
        a = int.Parse(Console.ReadLine());
        Console.Write(a);
        rez = (a > 0) ? " este pozitiv ." : " este negativ .";
        Console.Write(rez);
        Console.ReadLine();

        // Sa se verifice daca nr este par sau impar

        int b;
        Console.WriteLine(" Introduce un alt numar: ");
        b = Convert.ToInt32(Console.ReadLine());
        if (b % 2 == 0)Console.WriteLine("{0} este par.", b);
        else Console.WriteLine("{0} este impar.", b);
        Console.ReadLine();

        // Conversie implicita si ecplicita 

        int c = 5;
        float d = 0;
        d = c; //conversie implicita. Datele nu vor fi pierdute.
        d = 0.9F;
        c = (int)d;//converise explicita. Datele vor fi pierdute

        // Conversie intre nr intregi si siruri de caractere

        int m = Convert.ToInt32(123.23); //pt nr
        string myText = "50";
        int myNumber = int.Parse(myText);//conversie din string in int

        // Concatenare

        string name = "< Cristi >";
        string date = DateTime.Today.ToShortDateString();
        string str = "Hello " + name + " astazi este " + date + ".";
        //folosim operatorul + pentru concatenare 
        System.Console.WriteLine(str);
        Console.ReadKey();

        // Sa se citeasca un caracter introdus de la tastatura 

        char chr;
        Console.WriteLine(" Apasa o tasta: ");
        chr = (char)Console.Read();
        Console.Read();
        Console.WriteLine(" Ai tastat : " + chr);
        Console.ReadKey();
    }  
}
