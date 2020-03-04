using System;
using System.Collections.Generic;

namespace L4_OPDR2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Parent> parents = new List<Parent>();
            Teacher t1 = new Teacher("Erwin", "PRO2");
            Teacher t2 = new Teacher("Erik", "PRO2");
            Teacher t3 = new Teacher("Theo", "PRO1");
            Teacher t4 = new Teacher("Carolien", "SLB & NED");

            Student s1 = new Student("Reynando", "MediaDeveloper");
            Student s2 = new Student("Marijn", "GameDeveloper");
            Student s3 = new Student("Emile", "GameDeveloper");


            


            // Parent.SetEigenschap("glinsterend hoofd");
            // Parent p1 = new Parent("Marco", "Man");
            // Parent.SetEigenschap("haar hebben");
            // Parent p2 = new Parent("Linda", "Vrouw");

            
            parents.Add(new Parent("Marco", "man"));
            parents[0].SetEigenschap("heeft geen haar op zijn hoofd \n");
            Console.WriteLine(parents[0].GetEigenschap());
            
            parents.Add(new Parent("Linda", "Vrouw"));
            parents[1].SetEigenschap("heeft haar op der hoofd \n");
            Console.WriteLine(parents[1].GetEigenschap());

            

        }
    }
}
