using System;

namespace Uppgift_6_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Välkommen");
            Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Största talet av två tal");
            Console.WriteLine("3. Avsluta programmet");

            string inputMeny = Console.ReadLine();

            switch (inputMeny)
            {
                case "1":
                    Console.WriteLine("Vilka tal vill du summera? Skriv på egna rader");
                    int tal1 = int.Parse(Console.ReadLine());
                    int tal2 = int.Parse(Console.ReadLine());
                    int tal3 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Summan blir {Addera(tal1, tal2, tal3)}");
                    break;

                case "2":
                    Console.WriteLine("Vilka tal vill du ange? Skriv på egen rad");
                    int tal4 = int.Parse(Console.ReadLine());
                    int tal5 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Det största talet är {Största(tal4, tal5)}");
                    break;

                case "3":
                    break;
            }
        }

        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }

        static int Största(int tal1, int tal2)
        {
            if (tal1 < tal2) return tal2;
            else if (tal1 > tal2) return tal1;
            else return tal1 + tal2;
        }
    }
}