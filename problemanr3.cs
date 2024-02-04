using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Introdu 3 nume de persoane: ");
        string[] nume = Console.ReadLine().Split(' ');

        foreach (string n in nume)
        {
            Console.WriteLine($"Caracterele din numele {n}:");
            AfiseazaCaractere(n);
        }
    }
    static void AfiseazaCaractere(string nume)
    {
        Dictionary<char, int> frecventa = new Dictionary<char, int>();

        foreach (char c in nume.ToLower())
        {
            if (!frecventa.ContainsKey(c))
            {
                frecventa[c] = 0;
            }
            frecventa[c]++;
        }

        foreach (KeyValuePair<char, int> pair in frecventa)
        {
            Console.WriteLine($"Caracterul '{pair.Key}' apare de {pair.Value} ori");
        }
    }
}
