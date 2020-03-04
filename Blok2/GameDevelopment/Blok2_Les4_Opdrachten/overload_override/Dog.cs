using System;

namespace overload_override
{
    class Dog
    {
        public void dog(string a, int b)
        {
            Console.WriteLine($"de honds naam is: {a}");
            Console.WriteLine($"en blaft {b}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------");
            Console.ResetColor();
        }
        public void dog(int b)
        {
            Console.WriteLine("alle honden moeten blafen en");
            Console.WriteLine($"en ze blaffen {b} keer");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------");
            Console.ResetColor();
        }
        public void dog(string a)
        {
            Console.WriteLine($"de honds naam is: {a}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------");
            Console.ResetColor();
        }
    }
}
