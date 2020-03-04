using System;

namespace B2L2
{
    class Program
    {

        static Boolean bezig = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Wat wil je doen?");
            while(bezig == true){

            string input = Console.ReadLine();
            
            args = input.Split(" ");

            Console.WriteLine("Het antwoord is: " + calc(Convert.ToInt32(args[0]), args[1], Convert.ToInt32(args[2])));


            int calc(int a, string type, int b) {
                switch(type) {
                    case "x":
                    return a * b;
                    case "/":
                    return a / b;
                    case "-":
                    return a - b;
                    case "+":
                    return a + b;
                    case "%":
                    return a % b;
                    default:
                    Console.WriteLine("ERROR");
                    break;
                }
                return 1000;
            }
        }
    }
}
}
