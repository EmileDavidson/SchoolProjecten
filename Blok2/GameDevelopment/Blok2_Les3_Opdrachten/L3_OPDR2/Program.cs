using System;
using System.Collections;
using System.Collections.Generic;

namespace L3_OPDR2
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Monster> monsters = new List<Monster>();
            ArrayList deadmonster = new ArrayList();
            Boolean bezig = true;


            monsters.Add(new Monster(30, "Raynando"));
            monsters.Add(new Monster(30, "Sam"));
            monsters.Add(new Monster(30, "Simon"));
            monsters.Add(new Monster(30, "Marijn"));
            monsters.Add(new Monster(30, "Ruben"));

            while (bezig == true)
            {
                if (deadmonster.Count == monsters.Count)
                {
                    Console.Clear();
                    bezig = false;
                    Console.WriteLine("hey hero! goed gedaan je hebt alle monsters verslagen");
                    Console.WriteLine("Type iets om door te gaan");
                    Console.ReadLine();

                }
                else
                {
                    Console.Clear();
                    showmonsters();
                    monsterdead();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\ntype 'attack name' om aan te vallen");
                    Console.ResetColor();
                    // readline word in de input gezet en die word vervolgens in args gezet met een split
                    string input = Console.ReadLine();
                    args = input.Split(" ");
                    if (args[0] == "Attack")
                    {
                        string inputname = args[1];
                        foreach (Monster monster in monsters)
                        {
                            // als input naam gelijk is aan een monster naam voer uit anders geef door dat er iets niet goed gaat
                            if (inputname.Equals(monster.GetName()))
                            {
                                // set het hp van het monster met de zelfde naam en pak de huidge hp (getter) en dan - 10 en dat set hij weer neer
                                monster.SetHP(monster.GetHP() - 10);
                                Console.Clear();
                                //als de monster 0 hp heeft pakt hij bij begin 0 daar plaatst hij monster name
                                //daarna verhoogd hij met 1 voor als de volgende dood is
                                if (monster.GetHP() == 0)
                                {
                                    deadmonster.Add(monster.GetName());

                                }
                                //als er iets niet goed is gegaan
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("er is iets niet goed gegaan probeer het opnieuw");
                                Console.ResetColor();
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("er is iets niet goed gegaan probeer het opnieuw");
                        Console.ResetColor();
                    }
                }
                // functies: 
                void showmonsters()
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("monsters an there lives:");
                    Console.ResetColor();
                    for (int alive = 0; alive < monsters.Count; alive++)
                    {
                        if (monsters[alive].GetHP() >= 1)
                        {
                            Console.WriteLine(monsters[alive].GetName() + ": " + monsters[alive].GetHP());
                        }
                    }
                    Console.WriteLine();
                }

                void monsterdead()
                {
                    Console.WriteLine("dode monsters:");
                    foreach (string s in deadmonster)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }


    }
}
