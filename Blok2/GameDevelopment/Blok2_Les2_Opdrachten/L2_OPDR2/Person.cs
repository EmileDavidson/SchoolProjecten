using System;

namespace L2_OPDR2
{
    public class Person
    {
        private string name = "no_name";
        public Person(string name){
            //constructor
            this.name = name;

            Console.WriteLine("Hey!! "+name);
        }
        
    }
}