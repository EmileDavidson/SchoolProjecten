using System;
using System.Collections.Generic;

namespace B2L1
{

    class Program
    {
        static Boolean bezig = true;
        static List<int> lijst = new List<int>();
        static void Main(string[] args)
        {

            Console.WriteLine("\nHoe groot mogen de getalen zijn?");
            string max = Console.ReadLine();


            Console.WriteLine("Hoe groot moet de lijst worden?");
            string size = Console.ReadLine();

            maak(Convert.ToInt16(max), Convert.ToInt16(size));
        }

        public static void maak(int max, int size)
        {
            string msg = "";
            Console.Clear();
            for (int i = 0; i != size; i++)
            {
                Random random = new Random();
                int n = random.Next(max);
                Console.ForegroundColor = ConsoleColor.Green;
                msg += n + " ";
                Console.ResetColor();
                lijst.Add(n);
            }
            for (int count = 0; count != lijst.Count; count++)
            {
                Console.Write(lijst[count] + " ");
            }

        }
    }
}
