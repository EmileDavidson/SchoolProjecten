using System;

namespace Overload_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Character MyBaseCharacter = new Character();
            MyBaseCharacter.Walk();

            Player player1 = new Player();
            player1.Shoot();
            player1.Shoot(10);
            player1.Shoot("target");
            player1.Walk();
            player1.Jump();

        }
    }
}
