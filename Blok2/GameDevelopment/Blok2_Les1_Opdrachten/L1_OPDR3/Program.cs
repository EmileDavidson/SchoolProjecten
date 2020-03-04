using System;

namespace B2L3
{
    class Program
    {

        static void Main(string[] args)
        {
       while(true){
           Console.ForegroundColor = ConsoleColor.White;
       Console.WriteLine("type iets om het naar het bestand te sturen.");

       string input = Console.ReadLine();

                if(add(input)){
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Succesvol");
                Console.ResetColor();
                } else {
                    Console.Clear();
                    Console.WriteLine("er is iets mis gegaan");
                }
               
        }
    }
        private static bool add(string input) 
        {
                //maakt een file aan als die er nog niet is. 
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("bin/tekstbestand.txt", true))
                {
                    //als er een file is dan write hij de message 
                    if (file != null) {
                	file.WriteLine(input);
                    return true;
                    } 
                    //anders returned hij het als "false"
                    else
                    {
                        return false;
                    }
                }
            }

    }
}

