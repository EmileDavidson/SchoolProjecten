using System;

namespace L5_OPDR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //fruit namespace / tropische sub namespace
            Fruit.Appel appel = new Fruit.Appel("appel", "fruit");
            Fruit.Bananen banaan = new Fruit.Bananen("banaan", "fruit");
            Fruit.Tropische.Ananas Ananas = new Fruit.Tropische.Ananas("Ananas", "TropischeFruit");
            Fruit.Tropische.Avocado avocado = new Fruit.Tropische.Avocado("avocado", "TropischeFruit");
            //groenten namespace
            Groenten.Bloemkool bloemkool = new Groenten.Bloemkool("bloemkool", "groenten");
            Groenten.Broccoli broccoli = new Groenten.Broccoli("broccoli", "groenten");

            //vlees namespace
            Vlees.Gehaktbal gehaktbal = new Vlees.Gehaktbal("gehaktbal", "vlees");
            Vlees.Hamburger hamburger = new Vlees.Hamburger("hamburger", "vlees");

            //zoetigheid
            Zoetigheid.Chips chips = new Zoetigheid.Chips("chips", "zoetigheid");
            Zoetigheid.Snoep snoep = new Zoetigheid.Snoep("snoep", "zoetigheid");
            
            Console.WriteLine(appel.GetName() + "  " + appel.GetSoort() + "\n");
            Console.WriteLine(banaan.GetName() + "  " + banaan.GetSoort() + "\n");
            Console.WriteLine(Ananas.GetName() + "  " + Ananas.GetSoort() + "\n");
            Console.WriteLine(avocado.GetName() + "  " + avocado.GetSoort() + "\n");

            Console.WriteLine(bloemkool.GetName() + "  " + bloemkool.GetSoort() + "\n");
            Console.WriteLine(broccoli.GetName() + "  " + broccoli.GetSoort() + "\n");
            Console.WriteLine(gehaktbal.GetName() + "  " + gehaktbal.GetSoort() + "\n");
            Console.WriteLine(hamburger.GetName() + "  " + hamburger.GetSoort() + "\n");
            Console.WriteLine(chips.GetName() + "  " + chips.GetSoort() + "\n");
            Console.WriteLine(snoep.GetName() + "  " + snoep.GetSoort() + "\n");

            Console.ReadKey();

        }
    }
}
