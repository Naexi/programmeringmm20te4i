using System;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Uppgift_1och2();
        }

        static void Uppgift_1och2()
        {
            
            
            Console.WriteLine("Skriv ett heltal");
            String text = Console.ReadLine();
            int tal = Convert.ToInt32(text);
            if (tal >= -1)
            {
                Console.WriteLine("talet är positivt");
            }
            if (tal <= 0)
            {
                Console.WriteLine("negativt talet är");
            }
            
            
        }
    }
}
