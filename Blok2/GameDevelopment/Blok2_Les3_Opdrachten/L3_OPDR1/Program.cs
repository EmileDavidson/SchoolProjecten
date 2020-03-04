using System;
using System.Collections;
using System.Collections.Generic;


namespace L3_OPDR1
{
    class Program
    {
        static Boolean controleleeftijd = false;
        static Boolean controlelengte = false;
        static Boolean running = false;
        static string input = "";
        static void Main(string[] args)
        {
            //Maak een lijst aan om de alle people[newPlayerNumber]s in op te slaan
            List<Person> people = new List<Person>();

            // een loop maken zodat het pas stopt wanneer jij wilt
            Console.Clear();

            while (running == false)
            {

                controleleeftijd = false;
                controlelengte = false;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("type 'stop' to stop of type 'add' om nog een persoon toe te voegen aan de lijst \ntype 'count' om het aantal personen te zien en type 'lijst' om alle gegevens te zien");
                Console.ResetColor();
                input = Console.ReadLine();
                Console.Clear();
                if (input == "stop")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("je bent gestopt met mensen toe te voegen aan de lijst");
                    Console.ResetColor();
                    Console.WriteLine("je hebt momenteen " + people.Count + " in de lijst zitten");
                    running = true;
                }
                else if (input == "count")
                {
                    Console.Clear();
                    Console.WriteLine("je hebt momenteen " + people.Count + " in de lijst zitten");
                }
                else if (input == "lijst")
                {
                    Console.Clear();
                    // console.writeline(people[1].GetIets()); zodat het weet wat je wilt krijgen. 
                    for (int i = 0; i < people.Count; i++)
                    {
                        Console.WriteLine(people[i].GetName());
                        Console.WriteLine(people[i].GetLand());
                        Console.WriteLine(people[i].GetOogkleur());
                        Console.WriteLine(people[i].GetLengte());
                        Console.WriteLine(people[i].GetLeeftijd());
                        Console.WriteLine(people[i].GetBSN());
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("-----------------------------------");
                        Console.ResetColor();
                    }
                }
                else if (input == "add")
                {

                    people.Add(new Person());
                    int newPlayerNumber = people.Count - 1;
                    //controle zorgt er voor dat het een echt antwoord is en niet iets randoms
                    //vraag naar de naam en control die in de person class
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("goedemorgen wat is je naam?");
                    Console.ResetColor();
                    string name = Console.ReadLine();
                    people[newPlayerNumber].SetName(name);
                    Console.Clear();

                    //vraag naar het land en controle inde person class
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Dat is een mooie naam! uit welk land kom je?");
                    Console.ResetColor();
                    string land = Console.ReadLine();
                    people[newPlayerNumber].SetLand(land);
                    Console.Clear();

                    // vraag naar de oogkleur en word vervolgens gecontrolleerd in de person class
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("welke kleur ogen heb je?");
                    Console.ResetColor();
                    string oogkleur = Console.ReadLine();
                    people[newPlayerNumber].SetOogkleur(oogkleur);
                    Console.Clear();

                    // vraag naar de lengte in cm en word vervoglens gecontroleerd in de person class
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("hoeveel cm lang ben je? ( 100 cm = 1 meter ) rond af op hele centimers");
                    Console.ResetColor();
                    string lengte = Console.ReadLine();
                    people[newPlayerNumber].SetLengte(lengte);
                    Console.Clear();

                    //vraag naar leeftijd word vervolgens gecontrollerd in de person class
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("hoe jong ben je?");
                    Console.ResetColor();
                    string leeftijd = Console.ReadLine();
                    people[newPlayerNumber].SetLeeftijd(leeftijd);
                    Console.Clear();

                    // vraag naar de BSN nummer en word vervolgens gecontrollerd in de person class
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("wat is je BSN nummer?");
                    Console.ResetColor();
                    string bsn = Console.ReadLine();
                    people[newPlayerNumber].SetBSN(bsn);
                    Console.Clear();



                    //Controleer de de nieuwe person goed is opgeslagen
                    if (people[newPlayerNumber] != null)
                    {
                        Console.Clear();
                        Console.WriteLine("\nGoedemorgen " + people[newPlayerNumber].GetName());
                        Console.WriteLine("jij komt uit " + people[newPlayerNumber].GetLand());
                        Console.WriteLine("jij komt uit " + people[newPlayerNumber].GetOogkleur());
                        Console.WriteLine("jij bent " + people[newPlayerNumber].GetLengte() + " cm lang");
                        Console.WriteLine("je bent " + people[newPlayerNumber].GetLeeftijd() + " jaar jong");
                        Console.WriteLine("je BSN nummer is " + people[newPlayerNumber].GetBSN());
                    }
                    //Controle of de persoon is toegevoegd
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("DIT IS DE " + people.Count + " PERSOON DIE IS TOEGEVOEGD\n");
                    Console.ResetColor();

                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("dit is geen geldig input");
                    Console.ResetColor();
                }
            }
        }
    }
}