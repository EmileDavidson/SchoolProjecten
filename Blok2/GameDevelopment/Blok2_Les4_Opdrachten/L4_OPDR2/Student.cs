using System;

namespace L4_OPDR2
{
    public class Student : Person
    {
        public Student(string name, string education) : base(name)
        {
            //constructor
            Console.WriteLine("You're studying " + education + "\n");
        }
    }
}