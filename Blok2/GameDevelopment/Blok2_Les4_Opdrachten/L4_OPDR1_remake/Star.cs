using System;

namespace L4_OPDR1_remake
{
    class Star : Powerup
    {
        string color = "heeft meerdere colors als player color";
        public Star(string name, string uitleg) : base(name, uitleg)
        {
            Console.WriteLine(name);
            Console.WriteLine(uitleg);
            Console.WriteLine("deze power doet dit: " + color);
        }
    }
}
