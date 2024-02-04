using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Introdu un numar cu minim 3 cifre: ");
            string input = Console.ReadLine();

            if (input.Length < 3)
            {
                Console.WriteLine("Numarul trebuie sa aiba minim 3 cifre. Te rog incearca din nou.");
            }
            else
            {
                int numar;
                if (int.TryParse(input, out numar))
                {
                    int numarInOglinda = CalculeazaInOglinda(numar);
                    Console.WriteLine($"Numarul in oglinda este: {numarInOglinda}");

                    if (EstePatratPerfect(numarInOglinda))
                    {
                        Console.WriteLine($"{numarInOglinda} este patrat perfect.");
                    }
                    else
                    {
                        Console.WriteLine($"{numarInOglinda} nu este patrat perfect.");
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Te rog sa introduci un numar valid.");
                }
            }
        }
    }

    static int CalculeazaInOglinda(int numar)
    {
        int invers = 0;
        while (numar > 0)
        {
            invers = invers * 10 + numar % 10;
            numar /= 10;
        }
        return invers;
    }

    static bool EstePatratPerfect(int numar)
    {
        int radacina = (int)Math.Sqrt(numar);
        return radacina * radacina == numar;
    }
}
