using System;

namespace Overload_Override
{
    public class Character
    {
        public int points = 0;
        public float speed = 30.0f;
        public string name = "base character";
        public string sprite = "default";
        
        public Character()
        {
            Console.WriteLine("Character Constructor");
        }

        public virtual void Walk()
        {
            Console.WriteLine("Walk");
        }
        public void Die()
        {
            Console.WriteLine("Die");
        }
    }
}
