using System;
using System.Collections;
using System.Collections.Generic;

namespace L4_OPDR1
{
    class Program
    {
        //hier maak ik een list met alle powers
        public static List<Powerup> power = new List<Powerup>();

        //hier heb ik al mijn variabelen
        public static string input;
        public static bool bezig = true;
        static void Main(string[] args)
        {
            //add ik powers aan mijn lijst in een nieuwe plek dus eerste add = 0 tweede keer dat ik wat add = 1
            power.Add(new Powerup("star"));
            power.Add(new Powerup("rocket"));
            power.Add(new Powerup("coin"));

            Console.Clear();
            //while zodat ik elke keer een power kan gebruiken
            while (bezig == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("type een van de volgende dingen om de power te gebruiken");
                Console.ResetColor();
                //kijkt hoeveel powers er zijn geadd voor elke power geadd plaatst hij de power name
                for (int i = 0; i < power.Count; i++)
                {
                //pakt i en plaatst de power uit de lijst door getname die returned de name die ik hebben geset met een contructor
                    Console.Write(power[i].GetName() + " -- ");
                }
                // zorgt dat je typed op een nieuwe regel
                Console.WriteLine();
                //vraagt om input (readline)
                input = Console.ReadLine();
                //kijkt hoeveel powers er zijn geadd
                for (int i = 0; i < power.Count; i++)
                {
                    // als de input gelijk staat aan de naam van een geadde power voert hij dit uit
                    // hij pakt de input en die stuur hij door voor controle en hij stopt de loop
                    if (input.Equals(power[i].GetName()))
                    {
                        Console.Clear();
                        power[i].control(input);
                        break;
                    }
                    //als er iets niet goed gaat bijvoorbeeld als de input niet klopt met een naam van een power
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("er is iets niet goed gegaan");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
