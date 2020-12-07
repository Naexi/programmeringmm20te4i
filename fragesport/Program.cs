using System;

namespace fragesport
{
    class Program
    {
        static void Main(string[] args)
        {
            int fråga = 0;
            int korrekt = 0;
            int fel = 0;
            string svar;
            string svar1 = "Oslo";
            string svar2 = "Köpenhamn";
            string svar3 = "Helsingfors";
            Console.WriteLine("SVARA MED STOR BOKSTAV!");
            if (fråga == 0)
            {
                Console.WriteLine("vad heter norges huvudstad?");
                svar = Console.ReadLine();
                if (svar.Equals(svar1))
                {
                    Console.WriteLine("Korrekt!");
                    korrekt += 1;
                }
                if (!svar.Equals(svar1))
                {
                    Console.WriteLine("Fel");
                    fel += 1;
                }
                fråga += 1;
            }
            if (fråga == 1)
            {
                Console.WriteLine("vad heter Danmarks huvudstad?");
                svar = Console.ReadLine();
                if (svar.Equals(svar2))
                {
                    Console.WriteLine("Korrekt!");
                    korrekt += 1;
                }
                if (!svar.Equals(svar2))
                {
                    Console.WriteLine("Fel");
                    fel += 1;
                }
                fråga += 1;
            }
            if (fråga == 2)
            {
                Console.WriteLine("vad heter Finlands huvudstad?");
                svar = Console.ReadLine();
                if (svar.Equals(svar3))
                {
                    Console.WriteLine("Korrekt!");
                    korrekt += 1;
                }
                if (!svar.Equals(svar3))
                {
                    Console.WriteLine("Fel");
                    fel += 1;
                }
            }
            Console.WriteLine($"antal korrekta svar:{korrekt}");
            Console.WriteLine($"antal fel svar:{fel}");
            if (korrekt == 3)
            {
                Console.WriteLine("antigen fuskar du eller så kan du dina städer");
            }
        }
    }
}
