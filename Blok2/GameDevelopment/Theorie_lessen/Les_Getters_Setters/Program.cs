using System;

namespace Les_Getters_Setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Player MyMario = new Player();

            ShowPlayer();

            MyMario.points += 150;

            ShowPlayer();

            MyMario.lives -= 200;
            MyMario.points += 1;

            ShowPlayer();

            void ShowPlayer()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-----------------");
                Console.ResetColor();
                Console.WriteLine("NAME: " + MyMario.name);
                Console.WriteLine("LIVES: " + MyMario.lives);
                Console.WriteLine("POINTS: " + MyMario.points);
                Console.WriteLine("ISDEAD: " + MyMario.isDead);
            }
        }
    }
}
