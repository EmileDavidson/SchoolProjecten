using System;

namespace L4_OPDR2
{
    public class Person
    {
        private string name = "no_name";
        public static string personeigenschap = "geen_eigenschap";
        public Person(string name){
            //constructor
            this.name = name;
            personeigenschap = "is een mens";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hey!! "+name);
            Console.ResetColor();
            Console.WriteLine(name + " " + Person.personeigenschap);
        }
        
    }
}