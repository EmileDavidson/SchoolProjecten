using System;

namespace L4_OPDR1_remake
{
    class Shell : Powerup
    {
        string follow = "volgt de player tot hij raakt";
        public Shell(string name, string uitleg) : base(name, uitleg)
        {
            Console.WriteLine(name);
            Console.WriteLine(uitleg);
            Console.WriteLine("deze power doet dit:  " + follow + "\n");
        }
    }
}
