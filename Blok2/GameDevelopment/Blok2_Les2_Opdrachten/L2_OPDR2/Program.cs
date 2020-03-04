using System;

namespace L2_OPDR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Erwin", "PRO2");
            Teacher t2 = new Teacher("Erik", "PRO2");
            Teacher t3 = new Teacher("Theo", "PRO1");
            Teacher t4 = new Teacher("Carolien", "SLB & NED");

            Student s1 = new Student("Reynando", "MediaDeveloper");
            Student s2 = new Student("Marijn", "GameDeveloper");
            Student s3 = new Student("Emile", "GameDeveloper");

            Parent p1 = new Parent("Marco", "Man");
            Parent p2 = new Parent("Linda", "Vrouw");

        }
    }
}
