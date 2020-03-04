using System;

public class Powerup
{
    //variablen staan hier
    string powername = "";
    string input = "";

    //constructor om de power name te pakken
    public Powerup(string a)
    {
        powername = a;
    }

    // getter om de powername te krijgen in een andere class
    public string GetName()
    {
        return powername;
    }

    // controle wat je input is en welke vervolg (actie) functie hier moet gebruiken
    public void control(string newinput)
    {
        input = newinput;
        if (input == "star") { StarPower(); }
        else if (input == "rocket") { RocketPower(); }
        else if (input == "coin") { CoinPower(); }
    }


    // alle power functies
    public void StarPower()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("star power gebruikt");
        Console.ResetColor();
        //echte code om iets uit te voeren
    }
    public void RocketPower()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("rocket power gebruikt");
        Console.ResetColor();
        //echte code om iets uit te voeren
    }
    public void CoinPower()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("coin power gebruikt");
        Console.ResetColor();
        //echte code om iets uit te voeren
    }
}