using System;

namespace L4_OPDR1_remake
{
    class Rocket : Powerup
    {
        int maxdistance = 100;
        public Rocket(string name, string uitleg) : base(name, uitleg)
        {
            Console.WriteLine(name);
            Console.WriteLine(uitleg);
            Console.WriteLine("deze power gaat max " + maxdistance + " meter verder" + "\n");
        }
    }
}
