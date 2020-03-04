using System;

namespace overload_override
{
    class Voertuigen
    {
        private string soort;
        private bool water;
        public virtual void bewegen(){
            Console.WriteLine("is aan het rijden");
        }
    }
}
