using System;

namespace L5_OPDR1
{
    class Program
    {
        static string var3 = "dit is de variable in de class die ik aanroep in de main functie";
        static void Main(string[] args)
        {
            string var1 = "dit is de eerste variable binnen de program class in de main functie";
            Console.WriteLine(var1);
            L5_OPDR1_Namespace2.Person.functie2();
            Console.WriteLine(var3);
            Console.WriteLine(L5_OPDR1_Namespace2.Person.var4);
        }
       
    }
}