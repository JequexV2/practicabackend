using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Introdu o lista de numere separate prin spatii: ");
        string[] input = Console.ReadLine().Split(' ');

        double[] numere = new double[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numere[i] = double.Parse(input[i], CultureInfo.InvariantCulture);
        }

        AfiseazaNumereNeintregi(numere);
        AfiseazaCelMaiMicNumar(numere);
    }

    static void AfiseazaNumereNeintregi(double[] numere)
    {
        Console.WriteLine("Numerele care nu sunt intregi:");
        foreach (double numar in numere)
        {
            if (numar % 1 != 0)
            {
                Console.WriteLine(numar);
            }
        }
    }

    static void AfiseazaCelMaiMicNumar(double[] numere)
    {
        if (numere.Length == 0)
        {
            Console.WriteLine("Nu exista numere in lista.");
            return;
        }

        double celMaiMic = numere[0];
        for (int i = 1; i < numere.Length; i++)
        {
            if (numere[i] < celMaiMic)
            {
                celMaiMic = numere[i];
            }
        }

        Console.WriteLine($"Cel mai mic numar este: {celMaiMic}");
    }
}
