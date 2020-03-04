using System;

namespace L5_OPDR1_Namespace2
{
    public class Person
    {
        public static string var4 = "dit is de laaste variable die zich bevind in de class van de andere namespace";

         public static void functie2()
        {
            string var2 = "dit is de twee variable binnen een functie in een andere namespace en andere class";
            Console.WriteLine(var2);
        }
    }
}