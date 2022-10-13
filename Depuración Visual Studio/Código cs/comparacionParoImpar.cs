using System;

namespace PAR_O_IMPAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime un número");
            int n;
            string b;
            b = Console.ReadLine();
            n = int.Parse(b);
            if (n % 2 == 0)
            {
                Console.WriteLine("Número par");
            }

        }
    }
}