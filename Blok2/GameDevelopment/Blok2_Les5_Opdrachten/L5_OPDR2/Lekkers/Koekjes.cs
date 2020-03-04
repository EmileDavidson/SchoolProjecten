    using System;
    class Koekjes : Consturctor{
        public Koekjes(string name, string soort): base(name, soort){
            Console.WriteLine("name: " + name);
            Console.WriteLine("soort: " + soort);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------");
            Console.ResetColor();
        }
    }
