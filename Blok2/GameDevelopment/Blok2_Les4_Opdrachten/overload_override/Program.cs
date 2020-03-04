using System;

namespace overload_override
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Dog dog1 = new Dog();

            dog1.dog(10);
            dog1.dog("Zwei");
            dog1.dog("Zwei", 10);

            Boot boot1 = new Boot();
            boot1.bewegen();
            
        }
    }
}
