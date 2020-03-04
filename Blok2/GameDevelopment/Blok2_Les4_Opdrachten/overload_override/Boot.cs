using System;

namespace overload_override
{
    class Boot : Voertuigen
    {
        public override void bewegen()
        {
            Console.WriteLine("is aan het varen");
        }
    }
}
