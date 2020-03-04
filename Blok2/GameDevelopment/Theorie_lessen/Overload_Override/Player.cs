using System;

namespace Overload_Override
{
    //Mario class overerft veriabelen en fucnties van character
    public class Player : Character
    {
        //variable
        public int lives = 3;
        public string item = "";

        //player constructor
        public Player()
        {
            Console.WriteLine("Player constructor");
        }

        //player jump functie
        public void Jump()
        {
            Console.WriteLine("jump");
        }

        //player sprint functie
        public void Shoot()
        {
            Console.WriteLine("shoot");
        }

        public override void Walk()
        {
            base.Walk();

            Console.WriteLine("mario walks a bit weirder");
        }

        public void Shoot(int amount)
        {
            Console.WriteLine("shoot: " + amount);
        }

        public void Shoot(string target)
        {
            Console.WriteLine("shoot: " + target);
        }

    }
}
